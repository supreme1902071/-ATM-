namespace 模拟银行卡ATM机系统
{
    partial class Query
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
            this.label_standard = new System.Windows.Forms.Label();
            this.label_card = new System.Windows.Forms.Label();
            this.label_money = new System.Windows.Forms.Label();
            this.btn_continue = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label_other = new System.Windows.Forms.Label();
            this.lab_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_standard
            // 
            this.label_standard.AutoSize = true;
            this.label_standard.BackColor = System.Drawing.Color.Transparent;
            this.label_standard.Font = new System.Drawing.Font("宋体", 15F);
            this.label_standard.Location = new System.Drawing.Point(35, 51);
            this.label_standard.Name = "label_standard";
            this.label_standard.Size = new System.Drawing.Size(87, 25);
            this.label_standard.TabIndex = 0;
            this.label_standard.Text = "欢迎语";
            // 
            // label_card
            // 
            this.label_card.AutoSize = true;
            this.label_card.BackColor = System.Drawing.Color.Transparent;
            this.label_card.Font = new System.Drawing.Font("宋体", 15F);
            this.label_card.Location = new System.Drawing.Point(145, 126);
            this.label_card.Name = "label_card";
            this.label_card.Size = new System.Drawing.Size(62, 25);
            this.label_card.TabIndex = 1;
            this.label_card.Text = "卡号";
            this.label_card.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.BackColor = System.Drawing.Color.Transparent;
            this.label_money.Font = new System.Drawing.Font("宋体", 15F);
            this.label_money.Location = new System.Drawing.Point(145, 200);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(62, 25);
            this.label_money.TabIndex = 2;
            this.label_money.Text = "余额";
            this.label_money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_continue.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_continue.Location = new System.Drawing.Point(150, 345);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(90, 40);
            this.btn_continue.TabIndex = 3;
            this.btn_continue.Text = "返回";
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continu_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_back.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_back.Location = new System.Drawing.Point(350, 345);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(90, 40);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "取卡";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // label_other
            // 
            this.label_other.AutoSize = true;
            this.label_other.BackColor = System.Drawing.Color.Transparent;
            this.label_other.Font = new System.Drawing.Font("宋体", 15F);
            this.label_other.Location = new System.Drawing.Point(145, 276);
            this.label_other.Name = "label_other";
            this.label_other.Size = new System.Drawing.Size(187, 25);
            this.label_other.TabIndex = 5;
            this.label_other.Text = "剩余可取款金额";
            this.label_other.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::模拟银行卡ATM机系统.Properties.Resources.底图;
            this.CancelButton = this.btn_back;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.lab_time);
            this.Controls.Add(this.label_other);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.label_money);
            this.Controls.Add(this.label_card);
            this.Controls.Add(this.label_standard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Query";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "余额查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_standard;
        private System.Windows.Forms.Label label_card;
        private System.Windows.Forms.Label label_money;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label_other;
        private System.Windows.Forms.Label lab_time;
        private System.Windows.Forms.Timer timer1;
    }
}