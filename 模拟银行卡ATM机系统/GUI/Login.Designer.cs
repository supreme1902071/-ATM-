namespace 模拟银行卡ATM机系统
{
    partial class form_login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.card = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.passwd = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // card
            // 
            this.card.AutoSize = true;
            this.card.BackColor = System.Drawing.Color.Transparent;
            this.card.Font = new System.Drawing.Font("宋体", 15F);
            this.card.Location = new System.Drawing.Point(78, 153);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(112, 25);
            this.card.TabIndex = 0;
            this.card.Text = "银行卡号";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // passwd
            // 
            this.passwd.AutoSize = true;
            this.passwd.BackColor = System.Drawing.Color.Transparent;
            this.passwd.Font = new System.Drawing.Font("宋体", 15F);
            this.passwd.Location = new System.Drawing.Point(128, 222);
            this.passwd.Name = "passwd";
            this.passwd.Size = new System.Drawing.Size(62, 25);
            this.passwd.TabIndex = 2;
            this.passwd.Text = "密码";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(208, 25);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.MintCream;
            this.login.Font = new System.Drawing.Font("宋体", 15F);
            this.login.Location = new System.Drawing.Point(154, 294);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(87, 50);
            this.login.TabIndex = 4;
            this.login.Text = "登录";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.Font = new System.Drawing.Font("宋体", 15F);
            this.welcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.welcome.Location = new System.Drawing.Point(140, 59);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(276, 25);
            this.welcome.TabIndex = 5;
            this.welcome.Text = "欢迎使用兰氏银行ATM机";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.MintCream;
            this.back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.back.Font = new System.Drawing.Font("宋体", 15F);
            this.back.Location = new System.Drawing.Point(316, 294);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(87, 50);
            this.back.TabIndex = 6;
            this.back.Text = "退出";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // form_login
            // 
            this.AcceptButton = this.login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::模拟银行卡ATM机系统.Properties.Resources.底图;
            this.CancelButton = this.back;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.back);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.card);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label card;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label passwd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button back;
    }
}

