namespace UdpClient
{
	partial class ClientFrom
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
			this.StartSharingButton = new System.Windows.Forms.Button();
			this.StopSharingButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// StartSharingButton
			// 
			this.StartSharingButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.StartSharingButton.Location = new System.Drawing.Point(110, 178);
			this.StartSharingButton.Name = "StartSharingButton";
			this.StartSharingButton.Size = new System.Drawing.Size(200, 100);
			this.StartSharingButton.TabIndex = 0;
			this.StartSharingButton.Text = "START SHARING";
			this.StartSharingButton.UseVisualStyleBackColor = false;
			this.StartSharingButton.Click += new System.EventHandler(this.StartSharingButton_Click);
			// 
			// StopSharingButton
			// 
			this.StopSharingButton.BackColor = System.Drawing.Color.Red;
			this.StopSharingButton.Location = new System.Drawing.Point(490, 178);
			this.StopSharingButton.Name = "StopSharingButton";
			this.StopSharingButton.Size = new System.Drawing.Size(200, 100);
			this.StopSharingButton.TabIndex = 1;
			this.StopSharingButton.Text = "STOP SHARING";
			this.StopSharingButton.UseVisualStyleBackColor = false;
			this.StopSharingButton.Click += new System.EventHandler(this.StopSharingButton_Click);
			// 
			// ClientFrom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.StopSharingButton);
			this.Controls.Add(this.StartSharingButton);
			this.Name = "ClientFrom";
			this.Text = "Client";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button StartSharingButton;
		private System.Windows.Forms.Button StopSharingButton;
	}
}

