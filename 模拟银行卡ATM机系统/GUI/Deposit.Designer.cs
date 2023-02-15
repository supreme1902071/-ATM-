namespace 模拟银行卡ATM机系统
{
    partial class Deposit
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
            this.lab_dmoney = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lab_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lab_dmoney
            // 
            this.lab_dmoney.AutoSize = true;
            this.lab_dmoney.BackColor = System.Drawing.Color.Transparent;
            this.lab_dmoney.Font = new System.Drawing.Font("宋体", 15F);
            this.lab_dmoney.Location = new System.Drawing.Point(119, 166);
            this.lab_dmoney.Name = "lab_dmoney";
            this.lab_dmoney.Size = new System.Drawing.Size(112, 25);
            this.lab_dmoney.TabIndex = 0;
            this.lab_dmoney.Text = "存款金额";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_confirm.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_confirm.Location = new System.Drawing.Point(173, 308);
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
            this.btn_back.Location = new System.Drawing.Point(304, 308);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 40);
            this.btn_back.TabIndex = 3;
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
            this.lab_time.TabIndex = 4;
            this.lab_time.Text = "倒计时";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Deposit
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
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lab_dmoney);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_dmoney;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lab_time;
        private System.Windows.Forms.Timer timer1;
    }
}