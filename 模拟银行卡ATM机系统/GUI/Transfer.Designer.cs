namespace 模拟银行卡ATM机系统
{
    partial class Transfer
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
            this.lab_cardID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lab_money = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lab_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lab_cardID
            // 
            this.lab_cardID.AutoSize = true;
            this.lab_cardID.BackColor = System.Drawing.Color.Transparent;
            this.lab_cardID.Font = new System.Drawing.Font("宋体", 15F);
            this.lab_cardID.Location = new System.Drawing.Point(125, 96);
            this.lab_cardID.Name = "lab_cardID";
            this.lab_cardID.Size = new System.Drawing.Size(112, 25);
            this.lab_cardID.TabIndex = 0;
            this.lab_cardID.Text = "汇入账户";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(243, 206);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 25);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lab_money
            // 
            this.lab_money.AutoSize = true;
            this.lab_money.BackColor = System.Drawing.Color.Transparent;
            this.lab_money.Font = new System.Drawing.Font("宋体", 15F);
            this.lab_money.Location = new System.Drawing.Point(125, 206);
            this.lab_money.Name = "lab_money";
            this.lab_money.Size = new System.Drawing.Size(112, 25);
            this.lab_money.TabIndex = 3;
            this.lab_money.Text = "汇款金额";
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.SystemColors.Window;
            this.btn_confirm.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_confirm.Location = new System.Drawing.Point(117, 310);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(120, 40);
            this.btn_confirm.TabIndex = 4;
            this.btn_confirm.Text = "确认";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.Window;
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_back.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_back.Location = new System.Drawing.Point(305, 310);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(120, 40);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "返回";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
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
            this.lab_time.TabIndex = 6;
            this.lab_time.Text = "倒计时";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Transfer
            // 
            this.AcceptButton = this.btn_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::模拟银行卡ATM机系统.Properties.Resources.底图;
            this.CancelButton = this.btn_back;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.lab_time);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.lab_money);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lab_cardID);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "转账";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_cardID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lab_money;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lab_time;
        private System.Windows.Forms.Timer timer1;
    }
}