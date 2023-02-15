namespace 模拟银行卡ATM机系统
{
    partial class Modify
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
            this.lab_old = new System.Windows.Forms.Label();
            this.lab_new = new System.Windows.Forms.Label();
            this.lab_new2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lab_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_old
            // 
            this.lab_old.AutoSize = true;
            this.lab_old.BackColor = System.Drawing.Color.Transparent;
            this.lab_old.Font = new System.Drawing.Font("宋体", 15F);
            this.lab_old.Location = new System.Drawing.Point(150, 95);
            this.lab_old.Name = "lab_old";
            this.lab_old.Size = new System.Drawing.Size(87, 25);
            this.lab_old.TabIndex = 0;
            this.lab_old.Text = "原密码";
            // 
            // lab_new
            // 
            this.lab_new.AutoSize = true;
            this.lab_new.BackColor = System.Drawing.Color.Transparent;
            this.lab_new.Font = new System.Drawing.Font("宋体", 15F);
            this.lab_new.Location = new System.Drawing.Point(150, 185);
            this.lab_new.Name = "lab_new";
            this.lab_new.Size = new System.Drawing.Size(87, 25);
            this.lab_new.TabIndex = 1;
            this.lab_new.Text = "新密码";
            // 
            // lab_new2
            // 
            this.lab_new2.AutoSize = true;
            this.lab_new2.BackColor = System.Drawing.Color.Transparent;
            this.lab_new2.Font = new System.Drawing.Font("宋体", 15F);
            this.lab_new2.Location = new System.Drawing.Point(122, 270);
            this.lab_new2.Name = "lab_new2";
            this.lab_new2.Size = new System.Drawing.Size(112, 25);
            this.lab_new2.TabIndex = 2;
            this.lab_new2.Text = "确认密码";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(150, 25);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(240, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(150, 25);
            this.textBox2.TabIndex = 4;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(240, 270);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(150, 25);
            this.textBox3.TabIndex = 5;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_confirm.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_confirm.Location = new System.Drawing.Point(166, 362);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(100, 40);
            this.btn_confirm.TabIndex = 6;
            this.btn_confirm.Text = "确认";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_back.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_back.Location = new System.Drawing.Point(324, 362);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 40);
            this.btn_back.TabIndex = 7;
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
            this.lab_time.Size = new System.Drawing.Size(90, 25);
            this.lab_time.TabIndex = 8;
            this.lab_time.Text = "label1";
            // 
            // Modify
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
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lab_new2);
            this.Controls.Add(this.lab_new);
            this.Controls.Add(this.lab_old);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_old;
        private System.Windows.Forms.Label lab_new;
        private System.Windows.Forms.Label lab_new2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lab_time;
    }
}