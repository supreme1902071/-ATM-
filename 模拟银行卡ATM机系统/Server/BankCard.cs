using System;
using System.Collections.Generic;
using System.Text;

namespace 模拟银行卡ATM机系统
{
    public class BankCard
    {
        private string card_id; // 卡号
        private string card_passwd;  // 卡密码
        private decimal card_money;  // 卡中金额
        private decimal one_day_fetchmoney; // 当日取钱总额（每日跟新）
        private DateTime last_time;  // 上次取钱时间
        private TimeSpan differ_time; // 本次登录与上次登录相差天数
        private User user;           // 卡所属人
        private string user_id;      //  卡所属ID
        private const decimal Day_Max_out = 40000; // 每日最大取款数
        private const decimal Once_Max_out = 5000; // 一次最大取款数
        private Sqlconnect sqlconnect = new Sqlconnect();

        public string Card_id { get => card_id; set => card_id = value; }
        public string Card_passwd { get => card_passwd; set => card_passwd = value; }
        public decimal Money { get => card_money; set => card_money = value; }
        public decimal One_day_fetchmoney { get => one_day_fetchmoney; set => one_day_fetchmoney = value; }
        public DateTime Last_time { get => last_time; set => last_time = value; }
        internal User User { get => user; set => user = value; }
        public string User_id { get => user_id; set => user_id = value; }

        public BankCard(string card_id,string card_password,decimal card_money, decimal one_day_fetchmoney, DateTime last_time,string user_id)
        {
            this.card_id = card_id;
            this.card_passwd = card_password;
            this.card_money = card_money;
            this.one_day_fetchmoney = one_day_fetchmoney;
            this.last_time = last_time;
            this.user_id = user_id;
            //Update();
        }
        public BankCard()  
        {
            //Update();
        }

        /*
         * 定义一个数据库操作类SqlUtils,在BankCard中实例化其对象，并调用其方法，需要以下功能 
         * 1: public BankCard init(string card_id);  初始化当前BankCard对象，传入卡号，返回一个BankCard对象
         * 2: public bool login(string card_id,string passwd ); 判断登录是否成功 传入卡号和密码，判断是否存在
         * 3: public bool Isexsit(string card_id);  判断是否有该卡号 传入卡号，判断是否存在该用户
         * 4: pubilc bool updatamoney(string card_id,decimal money, int opt); 修改当前银行卡金额,传入卡号，修改金额，和操作,opt=1就存款money元,opt=2就取出money元
         * 5  pubilc bool updata_last_time(string card_id,DateTime last_time); 更新上次取钱时间，传入卡号，将数据库中last_time修改成last_time
         * 6: public bool modifypasswd(string card_id,string newpasswd); 更新当前银行卡密码，传入卡号，新密码，将数据库中的passwd修改成newpassed;
         * 7: public bool updata_one_day_fetchmoney(string card_id,decimal one_day_fetchmoney); 更新单日取款金额，传入卡号，金额，将数据库中的one_day_fetchmoney修改成one_day_fetchmoney;
         * 8: public bool updat_one_day_fetchmoney(string card_id, decimal one_day_fetchmoney); 更新当日已取款额度
         */

        public bool login(string card_id, string passwd)
        {
            if(sqlconnect.login(card_id, passwd))
            {
                BankCard card = sqlconnect.init(card_id);
                this.card_id = card.Card_id;
                this.card_passwd = card.Card_passwd;
                this.card_money = card.Money;
                this.one_day_fetchmoney = card.One_day_fetchmoney;
                this.last_time = card.Last_time;
                this.user_id = card.User_id;
                return true;
            }
            return false;
        }
        public void Update() // 本次登录与上次取钱(转账)时间，天数上的差距 difer_time.Days即是相差天数,跟新one_day_fetchmoney
        {
            differ_time = DateTime.Now.Date - last_time;
            /*Console.WriteLine(last_time);
            Console.WriteLine(111);
            Console.WriteLine(differ_time.Days);*/
            if(differ_time.Days >= 1)
            {
                one_day_fetchmoney = 0;
                //sqlconnect.// 存入数据库
                sqlconnect.updat_one_day_fetchmoney(this.card_id, 0);
            }
        }
        public bool Add(decimal money)   // 存钱
        {
            this.card_money += money;
            // 存入数据库
            sqlconnect.updatamoney(this.card_id, money,1);
            return true; 
        }

        public int Fetch(decimal money)  // 取钱  如果钱不够返回1,如果超过单日最大取款数返回2,如果一次性取款超过5000返回3，取钱成功返回0
        {
            Update();
            if (card_money < money) // 钱不够
            {
                return 1;
            }

            if(Day_Max_out - one_day_fetchmoney < money) // 单日最大取款-单日已经取款 < 取款数；
            {
                return 2;
            }
            
            if (money > Once_Max_out)// 一次性取款不超过5000
            {
                return 3;
            }

            last_time = DateTime.Now;  // 存钱最新取款时间
            string time = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
            sqlconnect.updata_last_time(this.card_id, time);  // 存入数据库

            // 该卡-money
            card_money -= money;
            sqlconnect.updatamoney(this.card_id, money, 2);  
            
            // 单日上限+money
            one_day_fetchmoney += money;
            sqlconnect.updat_one_day_fetchmoney(this.card_id,one_day_fetchmoney); 
            
            return 0;  // 0表示成功
        }

        public int Shift(decimal money,string othercard)  // 转账 如果待转账账号不对，返回-1，如果取钱的问题返回Fetch的对应数字
        {

            if (!sqlconnect.Isexsit(othercard) || othercard.Equals(this.Card_id)) return -1;

            if (Fetch(money) != 0) return Fetch(money);

            sqlconnect.updatamoney(othercard, money, 1);     // 转账卡+money

            return 0;
        }

        public int Modifypasswd(string old_pswd, string pswd1, string pswd2)   // 修改密码 返回1旧密码错误，返回2新密码不为6为，返回3新密码两次输入不同
        {
            // 验证旧密码
            if (!old_pswd.Equals(card_passwd))
            {
                return 1;
            }

            // 密码为6位
            if (pswd1.Length != 6 || pswd2.Length != 6) return 2;

            // 输入两次相同
            if (!pswd1.Equals(pswd2))
            {
                return 3;
            }
           
            card_passwd = pswd1;

            // 存入数据库
            sqlconnect.modifypasswd(this.card_id, card_passwd);
            return 0; ;
        }

    }
}
