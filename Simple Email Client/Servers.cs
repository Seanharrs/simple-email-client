namespace SimpleEmailClient
{
	public static class Servers
	{
		//Gmail servers for reading/writing
		public static readonly ServerReadDetails GMAIL_POP3 = new ServerReadDetails("pop.gmail.com", 995, true);
		public static readonly ServerReadDetails GMAIL_IMAP4 = new ServerReadDetails("imap.gmail.com", 993, true);
		public static readonly ServerWriteDetails GMAIL_SMTP = new ServerWriteDetails("smtp.gmail.com", 465, true, true);

		//Hotmail servers for reading/writing
		public static readonly ServerReadDetails HOTMAIL_POP3 = new ServerReadDetails("pop-mail.outlook.com", 995, true);
		public static readonly ServerReadDetails HOTMAIL_IMAP4 = new ServerReadDetails("imap-mail.outlook.com", 993, true);
		public static readonly ServerWriteDetails HOTMAIL_SMTP = new ServerWriteDetails("smtp-mail.outlook.com", 587, true, true);

		//Yahoo servers for reading/writing
		public static readonly ServerReadDetails YAHOO_POP3 = new ServerReadDetails("pop.mail.yahoo.com", 995, true);
		public static readonly ServerReadDetails YAHOO_IMAP4 = new ServerReadDetails("imap.mail.yahoo.com", 993, true);
		public static readonly ServerWriteDetails YAHOO_SMTP = new ServerWriteDetails("smtp.mail.yahoo.com", 465, true, true);
	}
}
