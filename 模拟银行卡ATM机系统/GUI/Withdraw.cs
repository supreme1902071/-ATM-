using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 模拟银行卡ATM机系统
{
    public partial class Withdraw : Form
    {
        private BankCard bankcard;
        private int number;
        public Withdraw(BankCard bankCard)
        {
            this.bankcard = bankCard;
            InitializeComponent();
            lab_time.Text = "30";
        }

        //返回功能
        private void btn_conti_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Menu menu = new Menu(bankcard);
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        //退卡功能
        private void btn_back_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            form_login login = new form_login(bankcard);
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        //取款100
        private void btn_100_Click(object sender, EventArgs e)
        {
            this.Hide();
            number = 100;
            if (jude(number))
            {
                timer1.Stop();
                Passwd passwd = new Passwd(bankcard);
                passwd.ShowDialog();
                if (passwd.b)
                {
                    MessageBox.Show("取款成功");
                } 
            }
            lab_time.Text = "30";
            this.Show();
            timer1.Start();
        }

        //取款500
        private void btn_500_Click(object sender, EventArgs e)
        {
            this.Hide();
            number = 500;
            if (jude(number))
            {
                timer1.Stop();
                Passwd passwd = new Passwd(bankcard);
                passwd.ShowDialog();
                if (passwd.b)
                {
                    MessageBox.Show("取款成功");
                }
                lab_time.Text = "30";
            }
            this.Show();
            timer1.Start();
        }

        //取款1000
        private void btn_1000_Click(object sender, EventArgs e)
        {
            this.Hide();
            number = 1000;
            if (jude(number))
            {
                timer1.Stop();
                Passwd passwd = new Passwd(bankcard);
                passwd.ShowDialog();
                if (passwd.b)
                {
                    MessageBox.Show("取款成功");
                }
                lab_time.Text = "30";
            }
            this.Show();
            timer1.Start();
        }

        //取款2000
        private void btn_2000_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            number = 2000;
            if (jude(number))
            {
                Passwd passwd = new Passwd(bankcard);
                passwd.ShowDialog();
                if (passwd.b)
                {
                    MessageBox.Show("取款成功");
                }
                lab_time.Text = "30";
            }
            this.Show();
            timer1.Start();
        }

        //取款5000
        private void btn_5000_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            number = 5000;
            if (jude(number))
            {
                Passwd passwd = new Passwd(bankcard);
                passwd.ShowDialog();
                if (passwd.b)
                {
                    MessageBox.Show("取款成功");
                }
                lab_time.Text = "30";
            }
            this.Show();
            timer1.Start();
        }

        //其他金额
        private void btn_cust_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Other_money other_Money = new Other_money(bankcard);
            other_Money.ShowDialog();
            lab_time.Text = "30";
            this.Show();
            timer1.Start();
        }

        private bool jude(int number)
        {
            int ans = this.bankcard.Fetch(number);
            if (ans == 1)
            {
                MessageBox.Show("金额不够！");
                return false;
            }
            else if (ans == 2)
            {
                MessageBox.Show("今日已达取款上限！");
                return false;
            }
            else if (ans == 3)
            {
                MessageBox.Show("今日已达取款上限！");
                return false;
            }
            else return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var number = int.Parse(lab_time.Text);
            number -= 1;
            lab_time.Text = number.ToString();
            if (number == 0)
            {
                Menu menu = new Menu(bankcard);
                this.Hide();
                menu.ShowDialog();
                this.Close();
            }
        }
    }
}
