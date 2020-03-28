namespace EmailClientSMTP
{
    partial class Form1
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.EmailTextLabel = new System.Windows.Forms.Label();
			this.PassTextLabel = new System.Windows.Forms.Label();
			this.LoginBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(36, 79);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(353, 22);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(36, 137);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.Size = new System.Drawing.Size(353, 22);
			this.textBox2.TabIndex = 1;
			// 
			// EmailTextLabel
			// 
			this.EmailTextLabel.AutoSize = true;
			this.EmailTextLabel.Location = new System.Drawing.Point(36, 55);
			this.EmailTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.EmailTextLabel.Name = "EmailTextLabel";
			this.EmailTextLabel.Size = new System.Drawing.Size(48, 17);
			this.EmailTextLabel.TabIndex = 2;
			this.EmailTextLabel.Text = "EMAIL";
			// 
			// PassTextLabel
			// 
			this.PassTextLabel.AutoSize = true;
			this.PassTextLabel.Location = new System.Drawing.Point(36, 112);
			this.PassTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.PassTextLabel.Name = "PassTextLabel";
			this.PassTextLabel.Size = new System.Drawing.Size(88, 17);
			this.PassTextLabel.TabIndex = 3;
			this.PassTextLabel.Text = "PASSWORD";
			// 
			// LoginBtn
			// 
			this.LoginBtn.Location = new System.Drawing.Point(36, 185);
			this.LoginBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.LoginBtn.Name = "LoginBtn";
			this.LoginBtn.Size = new System.Drawing.Size(100, 28);
			this.LoginBtn.TabIndex = 4;
			this.LoginBtn.Text = "LOG IN";
			this.LoginBtn.UseVisualStyleBackColor = true;
			this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 231);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(186, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "ONLY FOR GMAIL CLIENTS";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 395);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LoginBtn);
			this.Controls.Add(this.PassTextLabel);
			this.Controls.Add(this.EmailTextLabel);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label EmailTextLabel;
        private System.Windows.Forms.Label PassTextLabel;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label1;
    }
}

