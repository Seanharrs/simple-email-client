using ActiveUp.Net.Mail;

namespace Simple_Email_Client
{
	class WriteMailWrapper
	{
		private SmtpClient writeClient = new SmtpClient();

		public WriteMailWrapper(string server, int port, bool sslConnection,
		                        bool authRequired, string username, 
								string password)
		{
			if(sslConnection)
				writeClient.ConnectSsl(server, port);
			else
				writeClient.Connect(server, port);

			if(authRequired)
				writeClient.Authenticate(username, password,
				                         SaslMechanism.Login);
		}

		public void SendEmail(string whoFrom, string[] whoTo,
		                      string subject, string message)
		{
			SmtpMessage email = new SmtpMessage
			{
				From = new Address(whoFrom),
				Subject = subject,
				BodyText = { Text = message }
			};
			foreach(string recipient in whoTo)
				email.To.Add(recipient);

			email.DirectSend();
		}
	}
}
