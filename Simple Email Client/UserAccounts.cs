using System.Collections.Generic;
using System.Windows.Forms;
using SimpleEmailClient;
using System.IO;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using LitJson;

namespace User_Accounts
{
	public static class UserAccounts
	{
		public static string CspContainerName => "EncryptedAccounts";
		private const int KEY_SIZE = 4096;

		private static readonly string PATH = Application.StartupPath + "/accounts.json";

		private static List<Account> accounts;
		public static List<Account> Accounts => accounts ?? (accounts = Load());

		private static List<Account> Load()
		{
			if(!File.Exists(PATH))
				return new List<Account>();

			byte[] encryptedData = File.ReadAllBytes(PATH);
			byte[] decryptedData = SecureCrypt.DecryptCsp(CspContainerName, KEY_SIZE, encryptedData);
			JsonData jsonData = JsonMapper.ToObject(Encoding.UTF8.GetString(decryptedData));
			
			List<Account> existingAccounts = new List<Account>();
			for(int i = 0; i < jsonData.Count; ++i)
			{
				string json = jsonData[i].ToJson();
				Match matchData = Regex.Match(json, "\"InboundServer\":{(.*?)}," +
				                                    "\"OutboundServer\":{(.*?)}," +
				                                    "\"EmailAddress\":\"(.*?)\"," +
				                                    "\"Password\":\"(.*?)\"," +
				                                    "\"Provider\":([0-9])," +
				                                    "\"Protocol\":([0-9])");

				string inbound = matchData.Groups[1].Value;
				string outbound = matchData.Groups[2].Value;
				SecureString email =  SecureCrypt.ToSecure(matchData.Groups[3].Value.ToCharArray());
				SecureString password = SecureCrypt.ToSecure(matchData.Groups[4].Value.ToCharArray());
				string providerString = matchData.Groups[5].Value;
				string protocolString = matchData.Groups[6].Value;

				EmailProvider provider = (EmailProvider)int.Parse(providerString);
				Protocol protocol = (Protocol)int.Parse(protocolString);

				if(provider != EmailProvider.Other)
				{
					existingAccounts.Add(new Account(email, password, provider, protocol));
					continue;
				}

				string inServer, inPort, inSsl;
				GetServerDetails(inbound, out inServer, out inPort, out inSsl);
				string outServer, outPort, outSsl;
				GetServerDetails(outbound, out outServer, out outPort, out outSsl);

				string outAuth = Regex.Match(outbound, "\"AuthRequired\":(true|false)").Groups[0].Value;

				ServerReadDetails inboundServer = new ServerReadDetails(inServer, int.Parse(inPort), inSsl == "true");
				ServerWriteDetails outboundServer = new ServerWriteDetails(outServer, int.Parse(outPort), outSsl == "true", outAuth == "true");

				existingAccounts.Add(new Account(email, password, protocol, inboundServer, outboundServer));
			}
			return existingAccounts;
		}

		private static void GetServerDetails(string json, out string server, out string port, out string ssl)
		{
			Match data = Regex.Match(json, "\"Server\":\"(.*?)\"," +
			                               "\"Port\":([0-9]+)," +
			                               "\"SslConnection\":(true|false)");
			server = data.Groups[1].Value;
			port = data.Groups[2].Value;
			ssl = data.Groups[3].Value;
		}

		public static void AddAccount(Account account)
		{
			accounts.Add(account);
			Save();
		}

		private static void Save()
		{
			string json = JsonMapper.ToJson(accounts);
			byte[] jsonData = Encoding.UTF8.GetBytes(json);
			byte[] encryptedData = SecureCrypt.EncryptCsp(CspContainerName, KEY_SIZE, jsonData);
			File.WriteAllBytes(PATH, encryptedData);
		}

		public static void DeleteAccount(Account account)
		{
            for(int i = 0; i < accounts.Count; ++i)
            {
                if(account.Equals(accounts[i]))
                {
                    accounts.RemoveAt(i);
                    break;
                }
            }
            Save();
		}
	}

	public class Account
	{
		public ServerReadDetails InboundServer { get; }
		public ServerWriteDetails OutboundServer { get; }

		private readonly SecureString emailAddress;
		private readonly SecureString password;
		public string EmailAddress => new string(SecureCrypt.FromSecure(emailAddress));
		public string Password => new string(SecureCrypt.FromSecure(password));

		public EmailProvider Provider { get; }
		public Protocol Protocol { get; }

		public Account(SecureString address, SecureString pass, EmailProvider provider, Protocol protocol)
		{
			emailAddress = address;
			password = pass;
			Provider = provider;
			Protocol = protocol;
			switch(provider)
			{
				case EmailProvider.Gmail:
					OutboundServer = Servers.GMAIL_SMTP;
					InboundServer = protocol == Protocol.Imap4 ? Servers.GMAIL_IMAP4 : Servers.GMAIL_POP3;
					break;
				case EmailProvider.Hotmail:
					OutboundServer = Servers.HOTMAIL_SMTP;
					InboundServer = protocol == Protocol.Imap4 ? Servers.HOTMAIL_IMAP4 : Servers.HOTMAIL_POP3;
					break;
				case EmailProvider.Yahoo:
					OutboundServer = Servers.YAHOO_SMTP;
					InboundServer = protocol == Protocol.Imap4 ? Servers.YAHOO_IMAP4 : Servers.YAHOO_POP3;
					break;
			}
		}

		public Account(SecureString address, SecureString pass, Protocol protocol, ServerReadDetails inboundServer, ServerWriteDetails outboundServer)
		{
			emailAddress = address;
			password = pass;
			Protocol = protocol;
			InboundServer = inboundServer;
			OutboundServer = outboundServer;
		}
	}
}
