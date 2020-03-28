namespace EmailClientSMTP
{
    partial class SendForm
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
			this.ReceiverEmailTextBox = new System.Windows.Forms.TextBox();
			this.MessageSubjectTextBox = new System.Windows.Forms.TextBox();
			this.sendBtn = new System.Windows.Forms.Button();
			this.pathFileBox = new System.Windows.Forms.TextBox();
			this.attachBtn = new System.Windows.Forms.Button();
			this.btnsendemail = new System.Windows.Forms.Label();
			this.body = new System.Windows.Forms.Label();
			this.MessageBodyTextBox = new System.Windows.Forms.TextBox();
			this.titletexbox = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SenderEmailTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SenderPasswordTextBox = new System.Windows.Forms.TextBox();
			this.SmtpServerTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.PortNumberTextBox = new System.Windows.Forms.TextBox();
			this.EnableSslCheckBox = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ReceiverEmailTextBox
			// 
			this.ReceiverEmailTextBox.Location = new System.Drawing.Point(170, 279);
			this.ReceiverEmailTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.ReceiverEmailTextBox.Name = "ReceiverEmailTextBox";
			this.ReceiverEmailTextBox.Size = new System.Drawing.Size(239, 22);
			this.ReceiverEmailTextBox.TabIndex = 0;
			this.ReceiverEmailTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// MessageSubjectTextBox
			// 
			this.MessageSubjectTextBox.Location = new System.Drawing.Point(170, 381);
			this.MessageSubjectTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.MessageSubjectTextBox.Multiline = true;
			this.MessageSubjectTextBox.Name = "MessageSubjectTextBox";
			this.MessageSubjectTextBox.Size = new System.Drawing.Size(239, 26);
			this.MessageSubjectTextBox.TabIndex = 1;
			this.MessageSubjectTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// sendBtn
			// 
			this.sendBtn.Location = new System.Drawing.Point(879, 475);
			this.sendBtn.Margin = new System.Windows.Forms.Padding(4);
			this.sendBtn.Name = "sendBtn";
			this.sendBtn.Size = new System.Drawing.Size(100, 28);
			this.sendBtn.TabIndex = 2;
			this.sendBtn.Text = "SEND";
			this.sendBtn.UseVisualStyleBackColor = true;
			this.sendBtn.Click += new System.EventHandler(this.SendBtn_Click);
			// 
			// pathFileBox
			// 
			this.pathFileBox.Location = new System.Drawing.Point(22, 481);
			this.pathFileBox.Margin = new System.Windows.Forms.Padding(4);
			this.pathFileBox.Name = "pathFileBox";
			this.pathFileBox.Size = new System.Drawing.Size(387, 22);
			this.pathFileBox.TabIndex = 3;
			// 
			// attachBtn
			// 
			this.attachBtn.Location = new System.Drawing.Point(286, 513);
			this.attachBtn.Margin = new System.Windows.Forms.Padding(4);
			this.attachBtn.Name = "attachBtn";
			this.attachBtn.Size = new System.Drawing.Size(123, 28);
			this.attachBtn.TabIndex = 4;
			this.attachBtn.Text = "Attach ...";
			this.attachBtn.UseVisualStyleBackColor = true;
			this.attachBtn.Click += new System.EventHandler(this.AttachBtn_Click);
			// 
			// btnsendemail
			// 
			this.btnsendemail.AutoSize = true;
			this.btnsendemail.Location = new System.Drawing.Point(19, 284);
			this.btnsendemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.btnsendemail.Name = "btnsendemail";
			this.btnsendemail.Size = new System.Drawing.Size(101, 17);
			this.btnsendemail.TabIndex = 5;
			this.btnsendemail.Text = "Receiver email";
			// 
			// body
			// 
			this.body.AutoSize = true;
			this.body.Location = new System.Drawing.Point(488, 13);
			this.body.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.body.Name = "body";
			this.body.Size = new System.Drawing.Size(100, 17);
			this.body.TabIndex = 6;
			this.body.Text = "Message body";
			// 
			// MessageBodyTextBox
			// 
			this.MessageBodyTextBox.Location = new System.Drawing.Point(491, 46);
			this.MessageBodyTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.MessageBodyTextBox.Multiline = true;
			this.MessageBodyTextBox.Name = "MessageBodyTextBox";
			this.MessageBodyTextBox.Size = new System.Drawing.Size(488, 361);
			this.MessageBodyTextBox.TabIndex = 7;
			this.MessageBodyTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// titletexbox
			// 
			this.titletexbox.AutoSize = true;
			this.titletexbox.Location = new System.Drawing.Point(31, 390);
			this.titletexbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.titletexbox.Name = "titletexbox";
			this.titletexbox.Size = new System.Drawing.Size(55, 17);
			this.titletexbox.TabIndex = 8;
			this.titletexbox.Text = "Subject";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 17);
			this.label1.TabIndex = 9;
			this.label1.Text = "Sender Details";
			// 
			// SenderEmailTextBox
			// 
			this.SenderEmailTextBox.Location = new System.Drawing.Point(170, 43);
			this.SenderEmailTextBox.Name = "SenderEmailTextBox";
			this.SenderEmailTextBox.Size = new System.Drawing.Size(239, 22);
			this.SenderEmailTextBox.TabIndex = 10;
			this.SenderEmailTextBox.TextChanged += new System.EventHandler(this.SenderEmailTextBox_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(46, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 17);
			this.label2.TabIndex = 11;
			this.label2.Text = "Sender email";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 17);
			this.label3.TabIndex = 12;
			this.label3.Text = "Sender password";
			// 
			// SenderPasswordTextBox
			// 
			this.SenderPasswordTextBox.Location = new System.Drawing.Point(170, 81);
			this.SenderPasswordTextBox.Name = "SenderPasswordTextBox";
			this.SenderPasswordTextBox.PasswordChar = '*';
			this.SenderPasswordTextBox.Size = new System.Drawing.Size(239, 22);
			this.SenderPasswordTextBox.TabIndex = 13;
			this.SenderPasswordTextBox.TextChanged += new System.EventHandler(this.SenderPasswordTextBox_TextChanged);
			// 
			// SmtpServerTextBox
			// 
			this.SmtpServerTextBox.Location = new System.Drawing.Point(170, 125);
			this.SmtpServerTextBox.Name = "SmtpServerTextBox";
			this.SmtpServerTextBox.Size = new System.Drawing.Size(239, 22);
			this.SmtpServerTextBox.TabIndex = 14;
			this.SmtpServerTextBox.TextChanged += new System.EventHandler(this.SmtpServerTextBox_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(53, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 17);
			this.label4.TabIndex = 15;
			this.label4.Text = "Smtp server";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(103, 166);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 17);
			this.label5.TabIndex = 16;
			this.label5.Text = "Port";
			// 
			// PortNumberTextBox
			// 
			this.PortNumberTextBox.Location = new System.Drawing.Point(170, 160);
			this.PortNumberTextBox.Name = "PortNumberTextBox";
			this.PortNumberTextBox.Size = new System.Drawing.Size(239, 22);
			this.PortNumberTextBox.TabIndex = 17;
			this.PortNumberTextBox.TextChanged += new System.EventHandler(this.PortNumberTextBox_TextChanged);
			// 
			// EnableSslCheckBox
			// 
			this.EnableSslCheckBox.AutoSize = true;
			this.EnableSslCheckBox.Location = new System.Drawing.Point(170, 204);
			this.EnableSslCheckBox.Name = "EnableSslCheckBox";
			this.EnableSslCheckBox.Size = new System.Drawing.Size(104, 21);
			this.EnableSslCheckBox.TabIndex = 18;
			this.EnableSslCheckBox.Text = "Enable SSL";
			this.EnableSslCheckBox.UseVisualStyleBackColor = true;
			this.EnableSslCheckBox.CheckedChanged += new System.EventHandler(this.EnableSslCheckBox_CheckedChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(16, 244);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(109, 17);
			this.label6.TabIndex = 19;
			this.label6.Text = "Receiver details";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(19, 338);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(87, 17);
			this.label7.TabIndex = 20;
			this.label7.Text = "Email details";
			// 
			// SendForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1055, 554);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.EnableSslCheckBox);
			this.Controls.Add(this.PortNumberTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.SmtpServerTextBox);
			this.Controls.Add(this.SenderPasswordTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.SenderEmailTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.titletexbox);
			this.Controls.Add(this.MessageBodyTextBox);
			this.Controls.Add(this.body);
			this.Controls.Add(this.btnsendemail);
			this.Controls.Add(this.attachBtn);
			this.Controls.Add(this.pathFileBox);
			this.Controls.Add(this.sendBtn);
			this.Controls.Add(this.MessageSubjectTextBox);
			this.Controls.Add(this.ReceiverEmailTextBox);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "SendForm";
			this.Text = "SendForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReceiverEmailTextBox;
        private System.Windows.Forms.TextBox MessageSubjectTextBox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox pathFileBox;
        private System.Windows.Forms.Button attachBtn;
        private System.Windows.Forms.Label btnsendemail;
        private System.Windows.Forms.Label body;
        private System.Windows.Forms.TextBox MessageBodyTextBox;
        private System.Windows.Forms.Label titletexbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox SenderEmailTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox SenderPasswordTextBox;
		private System.Windows.Forms.TextBox SmtpServerTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox PortNumberTextBox;
		private System.Windows.Forms.CheckBox EnableSslCheckBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}