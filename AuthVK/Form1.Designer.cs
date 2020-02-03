namespace AuthVK
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.log_textBox = new System.Windows.Forms.TextBox();
            this.pass_textBox = new System.Windows.Forms.TextBox();
            this.auth_button = new System.Windows.Forms.Button();
            this.info_button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stastus_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // log_textBox
            // 
            this.log_textBox.Location = new System.Drawing.Point(23, 23);
            this.log_textBox.Name = "log_textBox";
            this.log_textBox.Size = new System.Drawing.Size(155, 20);
            this.log_textBox.TabIndex = 0;
            // 
            // pass_textBox
            // 
            this.pass_textBox.Location = new System.Drawing.Point(23, 65);
            this.pass_textBox.Name = "pass_textBox";
            this.pass_textBox.PasswordChar = '*';
            this.pass_textBox.Size = new System.Drawing.Size(155, 20);
            this.pass_textBox.TabIndex = 1;
            // 
            // auth_button
            // 
            this.auth_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auth_button.Location = new System.Drawing.Point(23, 131);
            this.auth_button.Name = "auth_button";
            this.auth_button.Size = new System.Drawing.Size(94, 23);
            this.auth_button.TabIndex = 3;
            this.auth_button.Text = "Authorization";
            this.auth_button.UseVisualStyleBackColor = true;
            this.auth_button.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // info_button
            // 
            this.info_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info_button.Location = new System.Drawing.Point(133, 131);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(94, 23);
            this.info_button.TabIndex = 4;
            this.info_button.Text = "Friends List";
            this.info_button.UseVisualStyleBackColor = true;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(250, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 316);
            this.listBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // stastus_label
            // 
            this.stastus_label.AutoSize = true;
            this.stastus_label.Location = new System.Drawing.Point(20, 101);
            this.stastus_label.Name = "stastus_label";
            this.stastus_label.Size = new System.Drawing.Size(67, 13);
            this.stastus_label.TabIndex = 8;
            this.stastus_label.Text = "Login status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Friends List:";
            // 
            // exitbutton
            // 
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.ForeColor = System.Drawing.Color.Firebrick;
            this.exitbutton.Location = new System.Drawing.Point(23, 302);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(94, 23);
            this.exitbutton.TabIndex = 10;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 362);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stastus_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.info_button);
            this.Controls.Add(this.auth_button);
            this.Controls.Add(this.pass_textBox);
            this.Controls.Add(this.log_textBox);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox log_textBox;
        private System.Windows.Forms.TextBox pass_textBox;
        private System.Windows.Forms.Button auth_button;
        private System.Windows.Forms.Button info_button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label stastus_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exitbutton;
    }
}

