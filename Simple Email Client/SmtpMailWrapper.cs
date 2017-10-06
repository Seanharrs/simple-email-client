using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using ActiveUp.Net.Mail;

namespace SimpleEmailClient
{
	class SmtpMailWrapper
	{
		private readonly SmtpClient smtpClient = new SmtpClient();

		public SmtpMailWrapper(string server, int port, bool sslConnection, bool authRequired, string username, string password)
		{
			try
			{
				if(sslConnection)
					smtpClient.ConnectSsl(server, port);
				else
					smtpClient.Connect(server, port);

				smtpClient.Command("ehlo " + server, 250);

				if(authRequired)
					smtpClient.Authenticate(username, password, SaslMechanism.Login);
			}
			catch(IOException)
			{
				MessageBox.Show("Failed to connect - please ensure you have entered the correct server address and port, and try again.");
			}
			catch(Exception e) when (e is SocketException || e is ArgumentNullException || e is ArgumentOutOfRangeException || e is SmtpException)
			{
				MessageBox.Show(e.Message);
				//TODO visual error handling for the user
			}
		}

		public void Close()
		{
			if(smtpClient.IsConnected)
				smtpClient.Disconnect();
			smtpClient.Close();
		}

		public bool SendEmail(SmtpMessage email)
		{
			//TODO email signatures to verify email so not treated as spam

			try { email.DirectSend(); }
			catch(Exception e) when (e is SocketException || e is ArgumentNullException || e is ArgumentOutOfRangeException || e is SmtpException)
			{
				MessageBox.Show(e.Message);
				//TODO visual error handling for the user
				return false;
			}
			return true;
		}
	}
}
