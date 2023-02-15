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
    public partial class form_login : Form
    {
        private BankCard bankcard;
        public form_login(BankCard bankCard)
        {
            this.bankcard = bankCard;
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是退格和数字，则屏蔽输入
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是退格和数字，则屏蔽输入
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }
        //登录功能
        private void login_Click(object sender, EventArgs e)
        {
            //判断用户输入是否与数据库中相符合
            //if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            //{
            //    MessageBox.Show("银行卡号或密码输入有误！");
            //    return;
            //}
            if (!(textBox1.Text.Equals("") || textBox2.Text.Equals("")) 
                &&bankcard.login(textBox1.Text, textBox2.Text))
            {
                this.Hide();
                Menu menu = new Menu(bankcard);
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("银行卡号或密码输入有误！");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        //退卡功能
        private void back_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
