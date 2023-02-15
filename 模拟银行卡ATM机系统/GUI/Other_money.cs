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
    public partial class Other_money : Form
    {
        private BankCard bankcard;
        public Other_money(BankCard bankCard)
        {
            this.bankcard = bankCard;
            InitializeComponent();
            lab_time.Text = "30";
        }

        //限制文本框只能输入退格和数字
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是退格和数字，则屏蔽输入
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

        //确认取款金额
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            //用户输入取款金额
            if (textBox1.Text.Equals("")) {
                MessageBox.Show("请输入正确金额");
                return;
            }
            var number = int.Parse(textBox1.Text);
            if (number % 100 == 0) //取款金额为一百倍数
            {
                int getreturn = this.bankcard.Fetch(number);
                this.Hide();
                if (getreturn == 1)//判断是否超额
                {
                    MessageBox.Show("超出卡中余额");
                }
                else if (getreturn == 2)
                {
                    MessageBox.Show("超出今日上限金额数");
                }
                else if (getreturn == 3)
                {
                    MessageBox.Show("单笔交易不能超过5000");
                }
                else
                {
                    Passwd passwd = new Passwd(bankcard);
                    passwd.ShowDialog();
                    if (passwd.b == true)
                    {
                        MessageBox.Show("取款成功！");
                    }
                } 
            }
            else
            {
                MessageBox.Show("输入金额需为100倍数！");
                lab_time.Text = "30";
            }
            textBox1.Text = "";
            timer1.Start();
        }


        //返回功能
        private void btn_back_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var number = int.Parse(lab_time.Text);
            number -= 1;
            lab_time.Text = number.ToString();
            if (number == 0)
            {
                this.Close();
            }
        }
    }
}
