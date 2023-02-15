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
    public partial class Deposit : Form
    {
        private BankCard bankcard;
        public Deposit(BankCard bankCard)
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
            timer1.Stop();
            Menu menu = new Menu(bankcard);
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        //存款功能
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            //用户输入存款金额
           
            string number = textBox1.Text;

            if ("".Equals(number))
            {
                MessageBox.Show("请输入取款金额！");
            }
            else
            {
                decimal money = Convert.ToDecimal(number);
                if (money % 100 != 0) //非一百倍数无效
                {
                    MessageBox.Show("输入存款金额无效！");
                }
                else
                {
                    bankcard.Add(money);
                    MessageBox.Show("存款成功！");
                    textBox1.Text = "";
                }
            }
            lab_time.Text = "30";
            timer1.Start();
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
