namespace SimpleEmailClient
{
	public struct ServerReadDetails
	{
		public string Server { get; }
		public int Port { get; }
		public bool SslConnection { get; }

		public ServerReadDetails(string server, int port, bool sslConnection)
		{
			Server = server;
			Port = port;
			SslConnection = sslConnection;
		}
	}

	public struct ServerWriteDetails
	{
		public string Server { get; }
		public int Port { get; }
		public bool SslConnection { get; }
		public bool AuthRequired { get; }

		public ServerWriteDetails(string server, int port, bool sslConnection, bool authRequired)
		{
			Server = server;
			Port = port;
			SslConnection = sslConnection;
			AuthRequired = authRequired;
		}
	}

	public enum Protocol { Pop3, Imap4 }
	public enum EmailProvider { Gmail, Hotmail, Yahoo, Other }
}
