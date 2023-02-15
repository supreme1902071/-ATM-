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
    public partial class Query : Form
    {
        private BankCard bankcard;
        static private int ONE_DAY_MAX_NUMBER = 40000;
        //查询功能输出
        public Query(BankCard bankCard)
        {

            this.bankcard = bankCard;
            this.bankcard.Update();
            InitializeComponent();
            lab_time.Text = "30";
            label_standard.Text = "尊敬的兰氏银行用户：";
            label_card.Text = "银行卡号：" + this.bankcard.Card_id.ToString();
            label_money.Text = "账户余额为 " + this.bankcard.Money.ToString() + " 元";
            Decimal UnOne_day_fetchmoney = ONE_DAY_MAX_NUMBER - this.bankcard.One_day_fetchmoney;
            if (UnOne_day_fetchmoney < 0) UnOne_day_fetchmoney = 0;
            label_other.Text = "今日剩余可取金额为 " + (UnOne_day_fetchmoney).ToString() + " 元";

        }

        //返回功能
        private void btn_continu_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Menu menuForm = new Menu(bankcard);
            this.Hide();
            menuForm.ShowDialog();
            Application.ExitThread();
        }

        //退卡功能
        private void btn_back_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            form_login login = new form_login(bankcard);
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var number = int.Parse(lab_time.Text);
            number -= 1;
            lab_time.Text = number.ToString();
            if (number == 0)
            {
                Menu menuForm = new Menu(bankcard);
                this.Hide();
                menuForm.ShowDialog();
                this.Close();
            }
        }
    }
}
