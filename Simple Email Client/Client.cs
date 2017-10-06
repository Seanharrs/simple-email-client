using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Windows.Forms;
using ActiveUp.Net.Mail;
using User_Accounts;
using Message = ActiveUp.Net.Mail.Message;

namespace SimpleEmailClient
{
	public partial class Client : Form
	{
        #region Private fields
        //The first email in a collection
        private const int FIRST_EMAIL = 0;
        //The collection index of the current email being read
        private int currentEmailIndex;

		//Variables to read/write to the servers
		private SmtpMailWrapper smtp;
		private PopMailWrapper pop;
		private ImapMailWrapper imap;

        //Container to hold emails
        private MessageCollection messages = new MessageCollection();

		//Variables to split time consuming/intensive tasks into seperate threads
		private BackgroundWorker popWorker = new BackgroundWorker();
		private BackgroundWorker imapWorker = new BackgroundWorker();
		private BackgroundWorker smtpWorker = new BackgroundWorker();
		
		private Account currentAccount;

		private bool successfulSend;
		#endregion

		public Client()
		{
			InitializeComponent();

			if(!EncryptionKeySet(UserAccounts.CspContainerName))
				SecureCrypt.AssignCspKey(UserAccounts.CspContainerName);

			foreach(Account account in UserAccounts.Accounts)
				currentAccountComboBox.Items.Add(account.EmailAddress);

			//Set a default account
			if(UserAccounts.Accounts.Count > 0)
			{
				currentAccount = UserAccounts.Accounts[0];
				currentAccountComboBox.SelectedIndex = 0;
			}

			EnableDetailsPanel(false);
		}

		~Client()
		{
			smtp.Close();
			pop.Close();
			imap.Close();
		}

		private bool EncryptionKeySet(string cspContainerName)
		{
			var csp = new CspParameters
			{
				Flags = CspProviderFlags.UseExistingKey,
				KeyContainerName = cspContainerName
			};
			try { using(new RSACryptoServiceProvider(csp)) {} }
			catch { return false; }

			return true;
		}

		private void EnableDetailsPanel(bool b)
		{
			serverDetailsPanel.Enabled = b;
			serverDetailsPanel.Visible = b;
		}

		#region Email reading
		private void GetMailButton_Click(object sender, EventArgs e)
		{
			if(currentAccount == null)
			{
				MessageBox.Show("Please set up an account first.");
				return;
			}

			if(currentAccount.Protocol == Protocol.Pop3)
				SetupWorker(popWorker, PopWorker_DoWork, ReadWorker_WorkCompleted, null);
			else
				SetupWorker(imapWorker, ImapWorker_DoWork, ReadWorker_WorkCompleted, null);
		}
		
		private void PopWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			if(pop == null)
				pop = new PopMailWrapper(currentAccount.InboundServer.Server, currentAccount.InboundServer.Port, 
										 currentAccount.InboundServer.SslConnection, currentAccount.EmailAddress,
										 currentAccount.Password);

			messages = pop.GetMail("inbox");
		}
		
		private void ImapWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			if(imap == null)
				imap = new ImapMailWrapper(currentAccount.InboundServer.Server, currentAccount.InboundServer.Port,
										   currentAccount.InboundServer.SslConnection, currentAccount.EmailAddress, 
										   currentAccount.Password);
			
			messages = imap.GetMail("inbox");
		}
		
		private void ReadWorker_WorkCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if(messages.Count < 1)
				readStatusText.Text = "No emails to display.";
			else
			{
				DisplayEmail(FIRST_EMAIL);
				readStatusText.Text = "Loaded emails successfully.";
			}
		}
		#endregion

		#region Email sending
		private void SendMailButton_Click(object sender, EventArgs e)
		{
			if(currentAccount == null)
			{
				MessageBox.Show("Please set up an account first.");
				return;
			}

			SmtpMessage email = new SmtpMessage
			{
				From = new Address(currentAccount.EmailAddress),
				Subject = sendSubjectText.Text,
				BodyText = { Text = sendEmailBodyText.Text },
				IsHtml = false,
			};
			email.To.AddRange(StringToAddress(sendRecipientsText.Text));
			email.Cc.AddRange(StringToAddress(sendCarbonCopiesText.Text));
			
			SetupWorker(smtpWorker, SmtpWorker_DoWork, SmtpWorker_WorkCompleted, email);
		}

		private IEnumerable<Address> StringToAddress(string text)
			=> text.Split(',').Select(addr => addr.Trim(' ', '\t', '\r', '\n'))
							  .Where(addr => addr != string.Empty)
							  .Select(addr => new Address(addr));

		private void SmtpWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			if(smtp == null)
				smtp = new SmtpMailWrapper(currentAccount.OutboundServer.Server, currentAccount.OutboundServer.Port, 
										   currentAccount.OutboundServer.SslConnection, currentAccount.OutboundServer.AuthRequired, 
										   currentAccount.EmailAddress, currentAccount.Password);

			successfulSend = smtp.SendEmail((SmtpMessage)e.Argument);
		}

		private void SmtpWorker_WorkCompleted(object sender, RunWorkerCompletedEventArgs e) 
			=> sendStatusTextBox.Text = successfulSend ? "Email sent successfully." : "Failed to send email.";
		#endregion

		private void SetupWorker(BackgroundWorker worker, DoWorkEventHandler doWork, RunWorkerCompletedEventHandler workCompleted, object args)
		{
			if(worker == null)
				throw new ArgumentNullException(nameof(worker), "Argument cannot be null");
			if(doWork == null)
				throw new ArgumentNullException(nameof(doWork), "Argument cannot be null");

			worker.WorkerSupportsCancellation = false;
			worker.WorkerReportsProgress = false;
			worker.DoWork += doWork;
			if(workCompleted != null)
				worker.RunWorkerCompleted += workCompleted;

			if(args == null)
			{
				readStatusText.Text = "Loading emails...";
				worker.RunWorkerAsync();
			}
			else
			{
				sendStatusTextBox.Text = "Sending email...";
				worker.RunWorkerAsync(args);
			}
		}

		#region Display emails
		private void DisplayEmail(int index)
		{
			Message msg = messages[index];
			currentEmailIndex = index;

			string body = Parser.ParseMessage(msg.OriginalData).BodyText.Text.Trim('\r', '\n');

			subjectLabel.Text = msg.Subject;
			readEmailBodyText.Text = body;
			senderLabel.Text = msg.From.ToString();
			carbonCopiesLabel.Text = msg.Cc.Merged;
			recipientsLabel.Text = msg.To.Merged;
		}

		private void PreviousEmailButton_Click(object sender, EventArgs e) => DisplayEmail(currentEmailIndex - 1);

		private void NextEmailButton_Click(object sender, EventArgs e) => DisplayEmail(currentEmailIndex + 1);
		#endregion

		private void ProviderComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(providerComboBox.SelectedIndex != -1)
				EnableDetailsPanel(providerComboBox.SelectedItem.ToString() == "Other");
		}

		#region Link new account
		private void LinkAccountButton_Click(object sender, EventArgs e)
		{
			if(providerComboBox.SelectedItem == null || protocolComboBox.SelectedItem == null || emailAddressText.Text == string.Empty)
			{
				MessageBox.Show("Please specify a provider, an email address, and a protocol");
				return;
			}

			Account acc;
			if(providerComboBox.SelectedItem.ToString() == "Other")
			{
				if(inboundServerText.Text == string.Empty || outboundServerText.Text == string.Empty)
				{
					MessageBox.Show("Please specify inbound and outbound servers");
					return;
				}

				acc = NewAccountUnknownProvider();
			}
			else
				acc = NewAccount();

			currentAccount = acc;
			UserAccounts.AddAccount(acc);
			currentAccountComboBox.Items.Add(acc.EmailAddress);
			currentAccountComboBox.SelectedIndex = currentAccountComboBox.Items.Count - 1;
			ClearControls();
		}
		
		private Account NewAccountUnknownProvider()
		{
			Protocol protocol = protocolComboBox.SelectedItem.ToString() == "IMAP4" ? Protocol.Imap4 : Protocol.Pop3;

			inboundPortText.Text = CleanText(inboundPortText);
			outboundPortText.Text = CleanText(outboundPortText);

			if(inboundPortText.Text == string.Empty)
				inboundPortText.Text = protocol == Protocol.Imap4 ? "993" : "995";

			if(outboundPortText.Text == string.Empty)
				outboundPortText.Text = "465";

			ServerReadDetails inboundServer = 
                new ServerReadDetails(inboundServerText.Text, int.Parse(inboundPortText.Text), inboundSslCheckBox.Checked);

			ServerWriteDetails outboundServer = 
                new ServerWriteDetails(inboundServerText.Text, int.Parse(inboundPortText.Text), inboundSslCheckBox.Checked, outboundAuthCheckBox.Checked);

			SecureString email = SecureCrypt.ToSecure(emailAddressText.Text.ToCharArray());
			SecureString password = SecureCrypt.ToSecure(emailPasswordText.Text.ToCharArray());
			return new Account(email, password, protocol, inboundServer, outboundServer);
		}

		private string CleanText(TextBox box) => box.Text.Where(char.IsDigit).Aggregate("", (current, c) => current + c);

		private Account NewAccount()
		{
			EmailProvider provider = EmailProvider.Hotmail;
			switch(providerComboBox.SelectedItem.ToString())
			{
				case "Gmail":
					provider = EmailProvider.Gmail;
					break;
				case "Yahoo":
					provider = EmailProvider.Yahoo;
					break;
			}

			Protocol protocol = protocolComboBox.SelectedItem.ToString() == "IMAP4" ? Protocol.Imap4 : Protocol.Pop3;

			SecureString email = SecureCrypt.ToSecure(emailAddressText.Text.ToCharArray());
			SecureString password = SecureCrypt.ToSecure(emailPasswordText.Text.ToCharArray());
			return new Account(email, password, provider, protocol);
		}

		private void ClearControls()
		{
			emailAddressText.Text = string.Empty;
			emailPasswordText.Text = string.Empty;
			showPasswordCheckbox.Checked = false;
			providerComboBox.SelectedIndex = -1;
			protocolComboBox.SelectedIndex = -1;

			inboundServerText.Text = string.Empty;
			inboundPortText.Text = string.Empty;
			inboundSslCheckBox.Checked = false;

			outboundServerText.Text = string.Empty;
			outboundPortText.Text = string.Empty;
			outboundSslCheckBox.Checked = false;
			outboundAuthCheckBox.Checked = false;

			EnableDetailsPanel(false);
		}
		#endregion

		private void CurrentAccountComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Current account changed, make sure we reset the mail wrapper classes
			if(pop != null)
			{
				pop.Close();
				pop = null;
			}
			if(imap != null)
			{
				imap.Close();
				imap = null;
			}
			if(smtp != null)
			{
				smtp.Close();
				smtp = null;
			}
			currentAccount = UserAccounts.Accounts[currentAccountComboBox.SelectedIndex];
		}

		private void ShowPasswordCheckbox_CheckedChanged(object sender, EventArgs e) 
			=> emailPasswordText.PasswordChar = showPasswordCheckbox.Checked ? '\0' : '*';
	}
}
