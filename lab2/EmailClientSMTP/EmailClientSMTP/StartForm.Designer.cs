namespace EmailClientSMTP
{
    partial class StartForm
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
			this.SendButton = new System.Windows.Forms.Button();
			this.ReceiveButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// SendButton
			// 
			this.SendButton.Location = new System.Drawing.Point(61, 126);
			this.SendButton.Margin = new System.Windows.Forms.Padding(4);
			this.SendButton.Name = "SendButton";
			this.SendButton.Size = new System.Drawing.Size(207, 92);
			this.SendButton.TabIndex = 0;
			this.SendButton.Text = "SEND EMAIL";
			this.SendButton.UseVisualStyleBackColor = true;
			this.SendButton.Click += new System.EventHandler(this.Button1_Click);
			// 
			// ReceiveButton
			// 
			this.ReceiveButton.Location = new System.Drawing.Point(61, 244);
			this.ReceiveButton.Margin = new System.Windows.Forms.Padding(4);
			this.ReceiveButton.Name = "ReceiveButton";
			this.ReceiveButton.Size = new System.Drawing.Size(207, 95);
			this.ReceiveButton.TabIndex = 1;
			this.ReceiveButton.Text = "RECEIVE EMAIL";
			this.ReceiveButton.UseVisualStyleBackColor = true;
			this.ReceiveButton.Click += new System.EventHandler(this.Button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(113, 427);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 33);
			this.button1.TabIndex = 2;
			this.button1.Text = "CLOSE";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// StartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 554);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ReceiveButton);
			this.Controls.Add(this.SendButton);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "StartForm";
			this.Text = "START";
			this.Load += new System.EventHandler(this.StartForm_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ReceiveButton;
		private System.Windows.Forms.Button button1;
	}
}