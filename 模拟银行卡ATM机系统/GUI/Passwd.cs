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
    public partial class Passwd : Form
    {
        private BankCard bankcard;
        public Boolean b = true; //判断是否正确输入密码
        public Passwd(BankCard bankCard)
        {
            this.bankcard = bankCard;
            InitializeComponent();
            lab_time.Text = "30";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是退格和数字，则屏蔽输入
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

        //返回功能
        private void btn_back_Click(object sender, EventArgs e)
        {
            b = false;
            this.Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            //待修改用户密码
            string passwd =this.bankcard.Card_passwd;
            //判断密码是否与数据库中符合
            if (passwd.Equals(textBox1.Text))
            {
                timer1.Stop();
                this.Close();
            }
            else
            {
                MessageBox.Show("输入密码有误请重新输入！");
                textBox1.Text = "";
                lab_time.Text = "30";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var number = int.Parse(lab_time.Text);
            number -= 1;
            lab_time.Text = number.ToString();
            if (number == 0)
            {
                b = false;
                this.Close();
            }
        }
    }
}
