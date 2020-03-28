using Limilabs.Client.IMAP;
using Limilabs.Client.POP3;
using Limilabs.Mail;
using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MailKit.Search;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailClientSMTP
{
	public partial class RetriveMail : Form
	{
		List<MimeMessage> retrievedMessages = null;
		DateTime _yearWhenSent;
		string _emailSender = string.Empty;
		public RetriveMail()
		{
			InitializeComponent();
		}

		//login btn
		private async void Button1_Click(object sender, EventArgs e)
		{
			var emailYear = SearchYearTextBox.Text.Trim();
			_yearWhenSent = DateTime.Parse(emailYear, CultureInfo.InvariantCulture);
			await DownloadWithImap();
		}

		private async Task DownloadWithImap()
		{
			using (var imapClient = new ImapClient())
			{
				using(var cancelToken = new CancellationTokenSource())
				{
					//await imapClient.ConnectAsync("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
					await imapClient.ConnectAsync("imap.gmail.com", 993, true, cancelToken.Token);
					try
					{
						await imapClient.AuthenticateAsync(TextBoxEmail.Text.Trim(), TextBoxPass.Text.Trim());
						var inbox = imapClient.Inbox;
						await inbox.OpenAsync(MailKit.FolderAccess.ReadOnly, cancelToken.Token);

						var totalMessages = inbox.Count;

						var query = SearchQuery.DeliveredOn(_yearWhenSent);
						var searchedMail = await inbox.SearchAsync(query, cancelToken.Token);

						totalMessages = searchedMail.Count;

						retrievedMessages = new List<MimeMessage>(totalMessages);
						foreach (var uid in searchedMail)
						{
							try
							{
								var msg = await inbox.GetMessageAsync(uid, cancelToken.Token);
								retrievedMessages.Add(msg);
								var itemList = new ListViewItem($"{msg.Subject}");
								TitleListView.Items.Add(itemList);
							}
							catch (Exception ex)
							{
								MessageBox.Show($"An error happened.{ex.Message}");
								Close();
							}
							
						}

						MessageBox.Show($"Total {totalMessages} messages.");
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Connection failure. {ex.Message}");
						Close();
						new RetriveMail().Show();
					}
				}
			}
		}

		private async void email_BTN_Click(object sender, EventArgs e)
		{
			string selectedTitle = TitleListView.SelectedItems[0].SubItems[0].Text.Trim();
			var attach = false;

			foreach (MimeMessage mimeMessage in retrievedMessages)
			{
				if (mimeMessage.Subject.Trim() == selectedTitle)
				{
					if (mimeMessage.Attachments.Count() > 0)
					{
						attach = true;
						foreach (var attachment in mimeMessage.Attachments)
						{
							var part = attachment as MimePart;
							var fileName = Path.Combine(@"D:\Универ\3 курс\семестр 2\PR\smtpFiles", part.FileName);
							if (File.Exists(fileName))
							{
								File.Delete(fileName);
							}

							using (var stream = File.Create(fileName))
							{ 
								await part.Content.DecodeToAsync(stream);
							}
						}
					}

					string[] row = { 
						mimeMessage.From.ToString(), 
						mimeMessage.To.ToString(), 
						mimeMessage.Subject.ToString(), 
						mimeMessage.Date.ToString("MM/dd/yyyy hh:mm tt"), 
						attach.ToString() };
					ListViewItem itemlist = new ListViewItem(row);
					MailInfo.Items.Add(itemlist);
					try
					{
						emailbody.Text = mimeMessage.HtmlBody.ToString();
					}
					catch
					{
						emailbody.Text = " ";
					}

					break;
				}
			}
		}

		private void PortNumberTextBox_TextChanged(object sender, EventArgs e){}
		private void SentFromTextBox_TextChanged(object sender, EventArgs e){}
		private void TextBoxEmail_TextChanged(object sender, EventArgs e) { }
		private void TextBoxPass_TextChanged(object sender, EventArgs e) { }
		private void SmtpServerTextBox_TextChanged(object sender, EventArgs e) { }
		private void TitleListView_SelectedIndexChanged(object sender, EventArgs e) { }
		private void RetriveMail_Load(object sender, EventArgs e) { }
		private void MailInfo_SelectedIndexChanged(object sender, EventArgs e){}
	}
}

