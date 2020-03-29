namespace EmailClientSMTP
{
    partial class RetriveMail
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
			this.TextBoxEmail = new System.Windows.Forms.TextBox();
			this.TextBoxPass = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.LoginButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.TitleListView = new System.Windows.Forms.ListView();
			this.email_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label4 = new System.Windows.Forms.Label();
			this.email_BTN = new System.Windows.Forms.Button();
			this.MailInfo = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.emailbody = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SmtpServerTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SearchYearTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TextBoxEmail
			// 
			this.TextBoxEmail.Location = new System.Drawing.Point(16, 60);
			this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(4);
			this.TextBoxEmail.Multiline = true;
			this.TextBoxEmail.Name = "TextBoxEmail";
			this.TextBoxEmail.Size = new System.Drawing.Size(247, 24);
			this.TextBoxEmail.TabIndex = 0;
			this.TextBoxEmail.TextChanged += new System.EventHandler(this.TextBoxEmail_TextChanged);
			// 
			// TextBoxPass
			// 
			this.TextBoxPass.Location = new System.Drawing.Point(16, 128);
			this.TextBoxPass.Margin = new System.Windows.Forms.Padding(4);
			this.TextBoxPass.Multiline = true;
			this.TextBoxPass.Name = "TextBoxPass";
			this.TextBoxPass.PasswordChar = '*';
			this.TextBoxPass.Size = new System.Drawing.Size(247, 24);
			this.TextBoxPass.TabIndex = 1;
			this.TextBoxPass.TextChanged += new System.EventHandler(this.TextBoxPass_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 39);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 107);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Password";
			// 
			// LoginButton
			// 
			this.LoginButton.Location = new System.Drawing.Point(61, 477);
			this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(156, 28);
			this.LoginButton.TabIndex = 4;
			this.LoginButton.Text = "Show inbox";
			this.LoginButton.UseVisualStyleBackColor = true;
			this.LoginButton.Click += new System.EventHandler(this.Button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(109, 39);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 17);
			this.label3.TabIndex = 5;
			// 
			// TitleListView
			// 
			this.TitleListView.BackColor = System.Drawing.SystemColors.Menu;
			this.TitleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.email_title});
			this.TitleListView.FullRowSelect = true;
			this.TitleListView.GridLines = true;
			this.TitleListView.HideSelection = false;
			this.TitleListView.HoverSelection = true;
			this.TitleListView.Location = new System.Drawing.Point(286, 59);
			this.TitleListView.Margin = new System.Windows.Forms.Padding(4);
			this.TitleListView.MultiSelect = false;
			this.TitleListView.Name = "TitleListView";
			this.TitleListView.Size = new System.Drawing.Size(401, 446);
			this.TitleListView.TabIndex = 6;
			this.TitleListView.TabStop = false;
			this.TitleListView.UseCompatibleStateImageBehavior = false;
			this.TitleListView.View = System.Windows.Forms.View.Details;
			this.TitleListView.SelectedIndexChanged += new System.EventHandler(this.TitleListView_SelectedIndexChanged);
			// 
			// email_title
			// 
			this.email_title.Text = "Subject";
			this.email_title.Width = 269;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(283, 38);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Retrieved email";
			// 
			// email_BTN
			// 
			this.email_BTN.Location = new System.Drawing.Point(535, 513);
			this.email_BTN.Margin = new System.Windows.Forms.Padding(4);
			this.email_BTN.Name = "email_BTN";
			this.email_BTN.Size = new System.Drawing.Size(100, 28);
			this.email_BTN.TabIndex = 8;
			this.email_BTN.Text = "Email Details";
			this.email_BTN.UseVisualStyleBackColor = true;
			this.email_BTN.Click += new System.EventHandler(this.email_BTN_Click);
			// 
			// MailInfo
			// 
			this.MailInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.MailInfo.HideSelection = false;
			this.MailInfo.Location = new System.Drawing.Point(707, 59);
			this.MailInfo.Margin = new System.Windows.Forms.Padding(4);
			this.MailInfo.Name = "MailInfo";
			this.MailInfo.Size = new System.Drawing.Size(880, 107);
			this.MailInfo.TabIndex = 9;
			this.MailInfo.UseCompatibleStateImageBehavior = false;
			this.MailInfo.View = System.Windows.Forms.View.Details;
			this.MailInfo.SelectedIndexChanged += new System.EventHandler(this.MailInfo_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "From";
			this.columnHeader1.Width = 291;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "To";
			this.columnHeader2.Width = 179;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Subject";
			this.columnHeader3.Width = 233;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "DeliveryDate";
			this.columnHeader4.Width = 152;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "HasAttachment";
			this.columnHeader5.Width = 138;
			// 
			// emailbody
			// 
			this.emailbody.Location = new System.Drawing.Point(707, 175);
			this.emailbody.Margin = new System.Windows.Forms.Padding(4);
			this.emailbody.Multiline = true;
			this.emailbody.Name = "emailbody";
			this.emailbody.Size = new System.Drawing.Size(880, 330);
			this.emailbody.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 176);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 17);
			this.label5.TabIndex = 11;
			this.label5.Text = "Smtp server";
			// 
			// SmtpServerTextBox
			// 
			this.SmtpServerTextBox.Location = new System.Drawing.Point(16, 196);
			this.SmtpServerTextBox.Name = "SmtpServerTextBox";
			this.SmtpServerTextBox.Size = new System.Drawing.Size(247, 22);
			this.SmtpServerTextBox.TabIndex = 12;
			this.SmtpServerTextBox.TextChanged += new System.EventHandler(this.SmtpServerTextBox_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 234);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 17);
			this.label6.TabIndex = 13;
			this.label6.Text = "Delivered on date";
			// 
			// SearchYearTextBox
			// 
			this.SearchYearTextBox.Location = new System.Drawing.Point(17, 254);
			this.SearchYearTextBox.Name = "SearchYearTextBox";
			this.SearchYearTextBox.Size = new System.Drawing.Size(246, 22);
			this.SearchYearTextBox.TabIndex = 14;
			this.SearchYearTextBox.TextChanged += new System.EventHandler(this.PortNumberTextBox_TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(325, 513);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 28);
			this.button1.TabIndex = 15;
			this.button1.Text = "Back";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// RetriveMail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1600, 554);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.SearchYearTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.SmtpServerTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.emailbody);
			this.Controls.Add(this.MailInfo);
			this.Controls.Add(this.email_BTN);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.TitleListView);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TextBoxPass);
			this.Controls.Add(this.TextBoxEmail);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "RetriveMail";
			this.Text = "RetriveMail";
			this.Load += new System.EventHandler(this.RetriveMail_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView TitleListView;
        private System.Windows.Forms.ColumnHeader email_title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button email_BTN;
        private System.Windows.Forms.ListView MailInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox emailbody;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox SmtpServerTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox SearchYearTextBox;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Button button1;
	}
}