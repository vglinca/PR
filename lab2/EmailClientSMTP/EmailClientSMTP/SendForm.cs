using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailClientSMTP
{
	public partial class SendForm : Form
	{
		private string _senderEmail = string.Empty;
		private string _receiverEmail = string.Empty;
		private string _senderPassword = string.Empty;
		private string _smtpServer = string.Empty;
		private int _portNumber = default;
		private bool _isSSL = false;
		private MailMessage _mailMessage = new MailMessage();
		private readonly Regex _regex =
			new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

		public SendForm()
		{
			InitializeComponent();
		}
		//public SendForm(string emailaddress, string password)
		//{
		//	_senderEmail = emailaddress;
		//	_senderPassword = password;

		//	InitializeComponent();
		//}

		private void SendBtn_Click(object sender, EventArgs e)
		{
			new Thread(async() => await  SendAsync()).Start();
			//Close();
		}

		private async Task SendAsync()
		{
			if (_regex.IsMatch(_senderEmail) && _regex.IsMatch(_receiverEmail))
			{
				try
				{
					try
					{
						using (var client = new SmtpClient(_smtpServer, _portNumber))
						{
							_mailMessage.From = new MailAddress(_senderEmail);
							_mailMessage.To.Add(new MailAddress(_receiverEmail));
							_mailMessage.Subject = MessageSubjectTextBox.Text;
							_mailMessage.IsBodyHtml = true;
							_mailMessage.Body = MessageBodyTextBox.Text;
							client.EnableSsl = _isSSL;
							client.UseDefaultCredentials = false;
							client.Credentials = new NetworkCredential(_senderEmail, _senderPassword);
							client.DeliveryMethod = SmtpDeliveryMethod.Network;
							await client.SendMailAsync(_mailMessage);
							_mailMessage.Dispose();
							MessageBox.Show("Email sent.");
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show($"{ex.Message}");
						Close();
						Hide();
						new SendForm().Show();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"{ex.Message}");
					Close();
					Hide();
					new SendForm().Show();
				}
			}
			else
			{
				MessageBox.Show($"One or more email addresses are invalid.");
				Close();
				Hide();
				new SendForm().Show();
			}
		}

		//receiver email
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			_receiverEmail = ReceiverEmailTextBox.Text.Trim();
		}

		private void AttachBtn_Click(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog();
			openFileDialog.ShowDialog();
			var path = openFileDialog.FileName.ToString();
			pathFileBox.Text = path;
			var attachment = new Attachment(path);
			if (attachment != null)
			{
				_mailMessage.Attachments.Add(attachment);
			}
		}

		private void SenderEmailTextBox_TextChanged(object sender, EventArgs e)
		{
			_senderEmail = SenderEmailTextBox.Text.Trim();
		}

		private void SenderPasswordTextBox_TextChanged(object sender, EventArgs e)
		{
			_senderPassword = SenderPasswordTextBox.Text.Trim();
		}

		private void SmtpServerTextBox_TextChanged(object sender, EventArgs e)
		{
			_smtpServer = SmtpServerTextBox.Text.Trim();

		}

		private void PortNumberTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				_portNumber = int.Parse(PortNumberTextBox.Text.Trim());
			}
			catch (Exception ex)
			{
				MessageBox.Show($"{ex.Message}");
			}
		}

		private void EnableSslCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			_isSSL = EnableSslCheckBox.Checked;
		}

		//subject
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
		}
		//body
		private void textBox3_TextChanged(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			new StartForm().Show();
			Close();
		}
	}
}
