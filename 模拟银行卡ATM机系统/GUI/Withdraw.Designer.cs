namespace 模拟银行卡ATM机系统
{
    partial class Withdraw
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
            this.btn_100 = new System.Windows.Forms.Button();
            this.btn_2000 = new System.Windows.Forms.Button();
            this.btn_500 = new System.Windows.Forms.Button();
            this.btn_5000 = new System.Windows.Forms.Button();
            this.btn_1000 = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_cust = new System.Windows.Forms.Button();
            this.btn_conti = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lab_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_100
            // 
            this.btn_100.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_100.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_100.Location = new System.Drawing.Point(80, 100);
            this.btn_100.Name = "btn_100";
            this.btn_100.Size = new System.Drawing.Size(140, 40);
            this.btn_100.TabIndex = 0;
            this.btn_100.Text = "100";
            this.btn_100.UseVisualStyleBackColor = false;
            this.btn_100.Click += new System.EventHandler(this.btn_100_Click);
            // 
            // btn_2000
            // 
            this.btn_2000.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_2000.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_2000.Location = new System.Drawing.Point(376, 100);
            this.btn_2000.Name = "btn_2000";
            this.btn_2000.Size = new System.Drawing.Size(140, 40);
            this.btn_2000.TabIndex = 1;
            this.btn_2000.Text = "2000";
            this.btn_2000.UseVisualStyleBackColor = false;
            this.btn_2000.Click += new System.EventHandler(this.btn_2000_Click);
            // 
            // btn_500
            // 
            this.btn_500.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_500.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_500.Location = new System.Drawing.Point(80, 190);
            this.btn_500.Name = "btn_500";
            this.btn_500.Size = new System.Drawing.Size(140, 40);
            this.btn_500.TabIndex = 2;
            this.btn_500.Text = "500";
            this.btn_500.UseVisualStyleBackColor = false;
            this.btn_500.Click += new System.EventHandler(this.btn_500_Click);
            // 
            // btn_5000
            // 
            this.btn_5000.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_5000.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_5000.Location = new System.Drawing.Point(376, 190);
            this.btn_5000.Name = "btn_5000";
            this.btn_5000.Size = new System.Drawing.Size(140, 40);
            this.btn_5000.TabIndex = 3;
            this.btn_5000.Text = "5000";
            this.btn_5000.UseVisualStyleBackColor = false;
            this.btn_5000.Click += new System.EventHandler(this.btn_5000_Click);
            // 
            // btn_1000
            // 
            this.btn_1000.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_1000.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_1000.Location = new System.Drawing.Point(80, 280);
            this.btn_1000.Name = "btn_1000";
            this.btn_1000.Size = new System.Drawing.Size(140, 40);
            this.btn_1000.TabIndex = 4;
            this.btn_1000.Text = "1000";
            this.btn_1000.UseVisualStyleBackColor = false;
            this.btn_1000.Click += new System.EventHandler(this.btn_1000_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_back.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_back.Location = new System.Drawing.Point(80, 370);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(140, 40);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "退卡";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_cust
            // 
            this.btn_cust.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_cust.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_cust.Location = new System.Drawing.Point(376, 280);
            this.btn_cust.Name = "btn_cust";
            this.btn_cust.Size = new System.Drawing.Size(140, 40);
            this.btn_cust.TabIndex = 6;
            this.btn_cust.Text = "其他金额";
            this.btn_cust.UseVisualStyleBackColor = false;
            this.btn_cust.Click += new System.EventHandler(this.btn_cust_Click);
            // 
            // btn_conti
            // 
            this.btn_conti.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_conti.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_conti.Location = new System.Drawing.Point(376, 370);
            this.btn_conti.Name = "btn_conti";
            this.btn_conti.Size = new System.Drawing.Size(140, 40);
            this.btn_conti.TabIndex = 7;
            this.btn_conti.Text = "返回";
            this.btn_conti.UseVisualStyleBackColor = false;
            this.btn_conti.Click += new System.EventHandler(this.btn_conti_Click);
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
            this.lab_time.TabIndex = 8;
            this.lab_time.Text = "倒计时";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::模拟银行卡ATM机系统.Properties.Resources.底图;
            this.CancelButton = this.btn_back;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.lab_time);
            this.Controls.Add(this.btn_conti);
            this.Controls.Add(this.btn_cust);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_1000);
            this.Controls.Add(this.btn_5000);
            this.Controls.Add(this.btn_500);
            this.Controls.Add(this.btn_2000);
            this.Controls.Add(this.btn_100);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "取款";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_100;
        private System.Windows.Forms.Button btn_2000;
        private System.Windows.Forms.Button btn_500;
        private System.Windows.Forms.Button btn_5000;
        private System.Windows.Forms.Button btn_1000;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_cust;
        private System.Windows.Forms.Button btn_conti;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lab_time;
    }
}