namespace 模拟银行卡ATM机系统
{
    partial class Passwd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lab_passwd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lab_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_passwd
            // 
            this.lab_passwd.AutoSize = true;
            this.lab_passwd.BackColor = System.Drawing.Color.Transparent;
            this.lab_passwd.Font = new System.Drawing.Font("宋体", 15F);
            this.lab_passwd.Location = new System.Drawing.Point(134, 183);
            this.lab_passwd.Name = "lab_passwd";
            this.lab_passwd.Size = new System.Drawing.Size(112, 25);
            this.lab_passwd.TabIndex = 0;
            this.lab_passwd.Text = "输入密码";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(139, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_confirm.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_confirm.Location = new System.Drawing.Point(171, 300);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(100, 40);
            this.btn_confirm.TabIndex = 2;
            this.btn_confirm.Text = "确认";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_back.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_back.Location = new System.Drawing.Point(313, 300);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 40);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "返回";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lab_time
            // 
            this.lab_time.AutoSize = true;
            this.lab_time.BackColor = System.Drawing.Color.Transparent;
            this.lab_time.Font = new System.Drawing.Font("宋体", 15F);
            this.lab_time.ForeColor = System.Drawing.Color.White;
            this.lab_time.Location = new System.Drawing.Point(480, 40);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(87, 25);
            this.lab_time.TabIndex = 4;
            this.lab_time.Text = "倒计时";
            // 
            // Passwd
            // 
            this.AcceptButton = this.btn_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::模拟银行卡ATM机系统.Properties.Resources.底图;
            this.CancelButton = this.btn_back;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.lab_time);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lab_passwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Passwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_passwd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lab_time;
    }
}