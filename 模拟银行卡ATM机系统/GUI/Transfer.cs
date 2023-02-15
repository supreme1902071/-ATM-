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
    public partial class Transfer : Form
    {
        private BankCard bankcard;
        public Transfer(BankCard bankCard)
        {
            this.bankcard = bankCard;
            InitializeComponent();
            lab_time.Text = "30";
        }

        //返回功能
        private void btn_back_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Menu menu = new Menu(bankcard);
            menu.ShowDialog();
            this.Close();
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
        //确认转账
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string other_ID = textBox1.Text; //用户输入汇款账户
            string number = textBox2.Text; //用户输入转账金额
            
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("")) //用户文本框输入是否为空
            {
                MessageBox.Show("请输入相关信息！");
                lab_time.Text = "30";
            }
            else
            {
                int getreturn = this.bankcard.Shift(Convert.ToDecimal(number),other_ID);
                if (getreturn == -1) //判断用户输入转账卡号是否存在
                {
                    MessageBox.Show("输入汇款账户有误！请重新输入");
                    lab_time.Text = "30";
                }
                else
                {
                    this.Hide();
                    if (getreturn == 1)//判断是否超额
                    {
                        MessageBox.Show("超出卡中余额，无法转账！");
                        lab_time.Text = "30";
                    }
                    else if (getreturn == 2)
                    {
                        MessageBox.Show("超出今日上限金额数");
                        lab_time.Text = "30";
                    }
                    else if (getreturn == 3)
                    {
                        MessageBox.Show("单笔交易不能超过5000");
                        lab_time.Text = "30";
                    }
                    else
                    {
                        timer1.Stop();
                        Passwd passwd = new Passwd(bankcard);
                        passwd.ShowDialog();
                        if (passwd.b == true) //输入密码
                        {
                            MessageBox.Show("转账成功！");
                        }
                        lab_time.Text = "30";
                    }
                    this.Show();
                }
            }
            
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var number = int.Parse(lab_time.Text);
            number -= 1;
            lab_time.Text = number.ToString();
            if (number == 0)
            {
                this.Hide();
                Menu menu = new Menu(bankcard);
                menu.ShowDialog();
                this.Close();
            }
        }
    }
}
