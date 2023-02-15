namespace 模拟银行卡ATM机系统
{
    partial class Menu
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
            this.btn_seach = new System.Windows.Forms.Button();
            this.btn_fetch = new System.Windows.Forms.Button();
            this.btn_shift = new System.Windows.Forms.Button();
            this.btn_goback = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lab_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_seach
            // 
            this.btn_seach.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_seach.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_seach.Location = new System.Drawing.Point(40, 120);
            this.btn_seach.Name = "btn_seach";
            this.btn_seach.Size = new System.Drawing.Size(120, 40);
            this.btn_seach.TabIndex = 0;
            this.btn_seach.Text = "查询";
            this.btn_seach.UseVisualStyleBackColor = false;
            this.btn_seach.Click += new System.EventHandler(this.btn_seach_Click);
            // 
            // btn_fetch
            // 
            this.btn_fetch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_fetch.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fetch.Location = new System.Drawing.Point(400, 120);
            this.btn_fetch.Name = "btn_fetch";
            this.btn_fetch.Size = new System.Drawing.Size(120, 40);
            this.btn_fetch.TabIndex = 1;
            this.btn_fetch.Text = "取款";
            this.btn_fetch.UseVisualStyleBackColor = false;
            this.btn_fetch.Click += new System.EventHandler(this.btn_fetch_Click);
            // 
            // btn_shift
            // 
            this.btn_shift.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_shift.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_shift.Location = new System.Drawing.Point(40, 220);
            this.btn_shift.Name = "btn_shift";
            this.btn_shift.Size = new System.Drawing.Size(120, 40);
            this.btn_shift.TabIndex = 2;
            this.btn_shift.Text = "转账";
            this.btn_shift.UseVisualStyleBackColor = false;
            this.btn_shift.Click += new System.EventHandler(this.btn_shift_Click);
            // 
            // btn_goback
            // 
            this.btn_goback.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_goback.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_goback.Location = new System.Drawing.Point(400, 320);
            this.btn_goback.Name = "btn_goback";
            this.btn_goback.Size = new System.Drawing.Size(120, 40);
            this.btn_goback.TabIndex = 3;
            this.btn_goback.Text = "退卡";
            this.btn_goback.UseVisualStyleBackColor = false;
            this.btn_goback.Click += new System.EventHandler(this.btn_goback_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_add.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_add.Location = new System.Drawing.Point(400, 220);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(120, 40);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "存款";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_modify.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_modify.Location = new System.Drawing.Point(40, 320);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(120, 40);
            this.btn_modify.TabIndex = 5;
            this.btn_modify.Text = "改密";
            this.btn_modify.UseVisualStyleBackColor = false;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(209, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "请您选择服务";
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
            this.lab_time.TabIndex = 7;
            this.lab_time.Text = "倒计时";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::模拟银行卡ATM机系统.Properties.Resources.底图;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.lab_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_goback);
            this.Controls.Add(this.btn_shift);
            this.Controls.Add(this.btn_fetch);
            this.Controls.Add(this.btn_seach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主菜单";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_seach;
        private System.Windows.Forms.Button btn_fetch;
        private System.Windows.Forms.Button btn_shift;
        private System.Windows.Forms.Button btn_goback;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lab_time;
    }
}