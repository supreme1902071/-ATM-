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
    
    public partial class Menu : Form
    {
        private BankCard bankcard;
       
        public Menu(BankCard bankCard)
        {
            this.bankcard = bankCard;
            InitializeComponent();
            lab_time.Text = "30";

        }


        //查询功能OVER
        private void btn_seach_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Query queryFrom = new Query(bankcard);
            this.Hide();
            this.Close();
            queryFrom.ShowDialog();
            lab_time.Text = "30";
        }

        //取款功能
        private void btn_fetch_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Withdraw withdraw = new Withdraw(bankcard);
            withdraw.ShowDialog();
            this.Close();
            lab_time.Text = "30";
        }

        //转账功能
        private void btn_shift_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Transfer transfer = new Transfer(bankcard);
            transfer.ShowDialog();
            this.Close();
            lab_time.Text = "30";
        }

        //存款功能
        private void btn_add_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Deposit deposit = new Deposit(bankcard);
            this.Hide();
            deposit.ShowDialog();
            this.Close();
            lab_time.Text = "30";
        }

        //改密功能
        private void btn_modify_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Modify modify = new Modify(bankcard);
            this.Hide();
            modify.ShowDialog();
            this.Close();
            lab_time.Text = "30";
        }

        //退卡功能
        private void btn_goback_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            form_login login = new form_login(bankcard);
            login.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var number = int.Parse(lab_time.Text);
            number -= 1;
            lab_time.Text = number.ToString();
            if(number == 0)
            {
                this.Hide();
                form_login login = new form_login(bankcard);
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
