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
    public partial class Modify : Form
    {
        private BankCard bankcard;
        public Modify(BankCard bankCard)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是退格和数字，则屏蔽输入
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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
            timer1.Stop();
            Menu menu = new Menu(bankcard);
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        //确认改密
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            //待修改用户密码
            string passwd1 = textBox1.Text;
            string passwd2 = textBox2.Text;
            string passwd3 = textBox3.Text;
            //文本框清空
            int flag = bankcard.Modifypasswd(passwd1,passwd2,passwd3);
            if (flag == 1) {
                MessageBox.Show("旧密码错误");
                lab_time.Text = "30";
            }
            else if (flag == 2)
            {
                MessageBox.Show("新密码不合法(要为6位)");
                lab_time.Text = "30";
            }
            else if (flag == 3)
            {
                MessageBox.Show("两次新密码输入不同");
                lab_time.Text = "30";
            }
            else
            {
                MessageBox.Show("密码修改成功");
                lab_time.Text = "30";
            }
            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
