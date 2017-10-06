using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using ActiveUp.Net.Mail;
using Message = ActiveUp.Net.Mail.Message;

namespace SimpleEmailClient
{
	class PopMailWrapper
	{
		private readonly Pop3Client popClient = new Pop3Client();

		public PopMailWrapper(string server, int port, bool sslConnection, string username, string password)
		{
			try
			{
				if(sslConnection)
					popClient.ConnectSsl(server, port, username, password);
				else
					popClient.Connect(server, port, username, password);
			}
			catch(IOException)
			{
				MessageBox.Show("Failed to connect - please ensure you have entered the correct server address and port, and try again.");
			}
			catch(Exception e) when(e is SocketException || e is ArgumentNullException || e is ArgumentOutOfRangeException || e is Pop3Exception)
			{
				MessageBox.Show(e.Message);
				//TODO visual error handling for the user
			}
		}

		public void Close()
		{
			if(popClient.IsConnected)
				popClient.Disconnect();
			popClient.Close();
		}

		public MessageCollection GetMail(string mailBox)
		{
			MessageCollection messages = new MessageCollection();

			if(!popClient.IsConnected)
				return messages;

			//RetrieveMessageObject() starts at 1, ends at MessageCount
			for(int i = 1; i <= popClient.MessageCount; i++)
			{
				try { messages.Add(popClient.RetrieveMessageObject(i)); }
				catch(Pop3Exception e)
				{
					MessageBox.Show(e.Message);
					messages.Add(new Message());
				}
			}
			return messages;
		}
	}
}
