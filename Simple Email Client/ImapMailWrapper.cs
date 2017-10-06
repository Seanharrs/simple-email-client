using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using ActiveUp.Net.Mail;

namespace SimpleEmailClient
{
	class ImapMailWrapper
	{
		private readonly Imap4Client imapClient = new Imap4Client();

		public ImapMailWrapper(string server, int port, bool sslConnection, string username, string password)
		{
			try
			{
				if(sslConnection)
					imapClient.ConnectSsl(server, port);
				else
					imapClient.Connect(server, port);

				imapClient.Login(username, password);
			}
			catch(IOException)
			{
				MessageBox.Show("Failed to connect - please ensure you have entered the correct server address and port, and try again.");
			}
			catch(Exception e) when (e is SocketException || e is ArgumentNullException || e is ArgumentOutOfRangeException || e is Imap4Exception)
			{
				MessageBox.Show(e.Message);
				//TODO visual error handling for the user
			}
		}

		public void Close()
		{
			if(imapClient.IsConnected)
				imapClient.Disconnect();
			imapClient.Close();
		}

		public MessageCollection GetMail(string mailBox)
		{
			try
			{
				if(!imapClient.IsConnected)
					return new MessageCollection();

				Mailbox mail = imapClient.SelectMailbox(mailBox);
				MessageCollection messages = mail.SearchParse("ALL");
				return messages;
			}
			catch(Imap4Exception e)
			{
				MessageBox.Show(e.Message);
				return new MessageCollection();
			}
		}
	}
}
