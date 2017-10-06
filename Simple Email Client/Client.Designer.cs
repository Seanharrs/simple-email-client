namespace SimpleEmailClient
{
	partial class Client
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sendEmailBodyText = new System.Windows.Forms.RichTextBox();
			this.getMailButton = new System.Windows.Forms.Button();
			this.senderLabel = new System.Windows.Forms.Label();
			this.subjectLabel = new System.Windows.Forms.Label();
			this.recipientsLabel = new System.Windows.Forms.Label();
			this.emailDetailsGroupbox = new System.Windows.Forms.GroupBox();
			this._carbonCopiesLabel = new System.Windows.Forms.Label();
			this.carbonCopiesLabel = new System.Windows.Forms.Label();
			this._subjectLabel = new System.Windows.Forms.Label();
			this._recipientsLabel = new System.Windows.Forms.Label();
			this._senderLabel = new System.Windows.Forms.Label();
			this.sendMailButton = new System.Windows.Forms.Button();
			this.nextEmailButton = new System.Windows.Forms.Button();
			this.previousEmailButton = new System.Windows.Forms.Button();
			this.sendSubjectText = new System.Windows.Forms.TextBox();
			this._sendRecipients = new System.Windows.Forms.Label();
			this._sendSubject = new System.Windows.Forms.Label();
			this.sendRecipientsText = new System.Windows.Forms.TextBox();
			this.applicationTabControl = new System.Windows.Forms.TabControl();
			this.accountsTab = new System.Windows.Forms.TabPage();
			this.accountDetailsContainer = new System.Windows.Forms.SplitContainer();
			this._protocolLabel = new System.Windows.Forms.Label();
			this.showPasswordCheckbox = new System.Windows.Forms.CheckBox();
			this.serverDetailsPanel = new System.Windows.Forms.Panel();
			this.outboundAuthCheckBox = new System.Windows.Forms.CheckBox();
			this.outboundSslCheckBox = new System.Windows.Forms.CheckBox();
			this._inboundServerLabel = new System.Windows.Forms.Label();
			this.inboundSslCheckBox = new System.Windows.Forms.CheckBox();
			this.inboundServerText = new System.Windows.Forms.TextBox();
			this.outboundServerText = new System.Windows.Forms.TextBox();
			this._inboundPortLabel = new System.Windows.Forms.Label();
			this._outboundServerLabel = new System.Windows.Forms.Label();
			this.inboundPortText = new System.Windows.Forms.TextBox();
			this.outboundPortText = new System.Windows.Forms.TextBox();
			this._outboundPort = new System.Windows.Forms.Label();
			this.linkAccountButton = new System.Windows.Forms.Button();
			this.providerComboBox = new System.Windows.Forms.ComboBox();
			this.protocolComboBox = new System.Windows.Forms.ComboBox();
			this._providerLabel = new System.Windows.Forms.Label();
			this._passwordLabel = new System.Windows.Forms.Label();
			this._linkWarning = new System.Windows.Forms.Label();
			this._addressLabel = new System.Windows.Forms.Label();
			this.emailPasswordText = new System.Windows.Forms.TextBox();
			this.emailAddressText = new System.Windows.Forms.TextBox();
			this._linkAccountLabel = new System.Windows.Forms.Label();
			this.currentAccountComboBox = new System.Windows.Forms.ComboBox();
			this._switchAccountLabel = new System.Windows.Forms.Label();
			this.viewEmailsTab = new System.Windows.Forms.TabPage();
			this._readStatusLabel = new System.Windows.Forms.Label();
			this.readStatusText = new System.Windows.Forms.TextBox();
			this.readEmailBodyText = new System.Windows.Forms.RichTextBox();
			this.sendEmailsTab = new System.Windows.Forms.TabPage();
			this.sendCarbonCopiesText = new System.Windows.Forms.TextBox();
			this._sendCarbonCopy = new System.Windows.Forms.Label();
			this._sendStatusLabel = new System.Windows.Forms.Label();
			this.sendStatusTextBox = new System.Windows.Forms.TextBox();
			this.emailDetailsGroupbox.SuspendLayout();
			this.applicationTabControl.SuspendLayout();
			this.accountsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.accountDetailsContainer)).BeginInit();
			this.accountDetailsContainer.Panel1.SuspendLayout();
			this.accountDetailsContainer.Panel2.SuspendLayout();
			this.accountDetailsContainer.SuspendLayout();
			this.serverDetailsPanel.SuspendLayout();
			this.viewEmailsTab.SuspendLayout();
			this.sendEmailsTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// sendEmailBodyText
			// 
			this.sendEmailBodyText.Location = new System.Drawing.Point(6, 141);
			this.sendEmailBodyText.Name = "sendEmailBodyText";
			this.sendEmailBodyText.Size = new System.Drawing.Size(917, 280);
			this.sendEmailBodyText.TabIndex = 5;
			this.sendEmailBodyText.Text = "";
			// 
			// getMailButton
			// 
			this.getMailButton.Location = new System.Drawing.Point(565, 64);
			this.getMailButton.Name = "getMailButton";
			this.getMailButton.Size = new System.Drawing.Size(134, 74);
			this.getMailButton.TabIndex = 2;
			this.getMailButton.Text = "Get Emails";
			this.getMailButton.UseVisualStyleBackColor = true;
			this.getMailButton.Click += new System.EventHandler(this.GetMailButton_Click);
			// 
			// senderLabel
			// 
			this.senderLabel.AutoEllipsis = true;
			this.senderLabel.Location = new System.Drawing.Point(56, 21);
			this.senderLabel.Name = "senderLabel";
			this.senderLabel.Size = new System.Drawing.Size(470, 13);
			this.senderLabel.TabIndex = 3;
			// 
			// subjectLabel
			// 
			this.subjectLabel.AutoEllipsis = true;
			this.subjectLabel.Location = new System.Drawing.Point(58, 112);
			this.subjectLabel.Name = "subjectLabel";
			this.subjectLabel.Size = new System.Drawing.Size(468, 13);
			this.subjectLabel.TabIndex = 4;
			// 
			// recipientsLabel
			// 
			this.recipientsLabel.AutoEllipsis = true;
			this.recipientsLabel.Location = new System.Drawing.Point(35, 52);
			this.recipientsLabel.Name = "recipientsLabel";
			this.recipientsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.recipientsLabel.Size = new System.Drawing.Size(491, 13);
			this.recipientsLabel.TabIndex = 5;
			// 
			// emailDetailsGroupbox
			// 
			this.emailDetailsGroupbox.Controls.Add(this._carbonCopiesLabel);
			this.emailDetailsGroupbox.Controls.Add(this.carbonCopiesLabel);
			this.emailDetailsGroupbox.Controls.Add(this._subjectLabel);
			this.emailDetailsGroupbox.Controls.Add(this._recipientsLabel);
			this.emailDetailsGroupbox.Controls.Add(this._senderLabel);
			this.emailDetailsGroupbox.Controls.Add(this.senderLabel);
			this.emailDetailsGroupbox.Controls.Add(this.recipientsLabel);
			this.emailDetailsGroupbox.Controls.Add(this.subjectLabel);
			this.emailDetailsGroupbox.Location = new System.Drawing.Point(6, 9);
			this.emailDetailsGroupbox.Name = "emailDetailsGroupbox";
			this.emailDetailsGroupbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.emailDetailsGroupbox.Size = new System.Drawing.Size(532, 155);
			this.emailDetailsGroupbox.TabIndex = 6;
			this.emailDetailsGroupbox.TabStop = false;
			// 
			// _carbonCopiesLabel
			// 
			this._carbonCopiesLabel.AutoSize = true;
			this._carbonCopiesLabel.Location = new System.Drawing.Point(6, 81);
			this._carbonCopiesLabel.Name = "_carbonCopiesLabel";
			this._carbonCopiesLabel.Size = new System.Drawing.Size(23, 13);
			this._carbonCopiesLabel.TabIndex = 10;
			this._carbonCopiesLabel.Text = "Cc:";
			// 
			// carbonCopiesLabel
			// 
			this.carbonCopiesLabel.AutoEllipsis = true;
			this.carbonCopiesLabel.Location = new System.Drawing.Point(35, 81);
			this.carbonCopiesLabel.Name = "carbonCopiesLabel";
			this.carbonCopiesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.carbonCopiesLabel.Size = new System.Drawing.Size(491, 13);
			this.carbonCopiesLabel.TabIndex = 9;
			// 
			// _subjectLabel
			// 
			this._subjectLabel.AutoSize = true;
			this._subjectLabel.Location = new System.Drawing.Point(6, 112);
			this._subjectLabel.Name = "_subjectLabel";
			this._subjectLabel.Size = new System.Drawing.Size(46, 13);
			this._subjectLabel.TabIndex = 8;
			this._subjectLabel.Text = "Subject:";
			// 
			// _recipientsLabel
			// 
			this._recipientsLabel.AutoSize = true;
			this._recipientsLabel.Location = new System.Drawing.Point(6, 52);
			this._recipientsLabel.Name = "_recipientsLabel";
			this._recipientsLabel.Size = new System.Drawing.Size(23, 13);
			this._recipientsLabel.TabIndex = 7;
			this._recipientsLabel.Text = "To:";
			// 
			// _senderLabel
			// 
			this._senderLabel.AutoSize = true;
			this._senderLabel.Location = new System.Drawing.Point(6, 21);
			this._senderLabel.Name = "_senderLabel";
			this._senderLabel.Size = new System.Drawing.Size(44, 13);
			this._senderLabel.TabIndex = 6;
			this._senderLabel.Text = "Sender:";
			// 
			// sendMailButton
			// 
			this.sendMailButton.Location = new System.Drawing.Point(442, 427);
			this.sendMailButton.Name = "sendMailButton";
			this.sendMailButton.Size = new System.Drawing.Size(75, 23);
			this.sendMailButton.TabIndex = 6;
			this.sendMailButton.Text = "Send Email";
			this.sendMailButton.UseVisualStyleBackColor = true;
			this.sendMailButton.Click += new System.EventHandler(this.SendMailButton_Click);
			// 
			// nextEmailButton
			// 
			this.nextEmailButton.Location = new System.Drawing.Point(746, 64);
			this.nextEmailButton.Name = "nextEmailButton";
			this.nextEmailButton.Size = new System.Drawing.Size(85, 23);
			this.nextEmailButton.TabIndex = 3;
			this.nextEmailButton.Text = "Next Email";
			this.nextEmailButton.UseVisualStyleBackColor = true;
			this.nextEmailButton.Click += new System.EventHandler(this.NextEmailButton_Click);
			// 
			// previousEmailButton
			// 
			this.previousEmailButton.Location = new System.Drawing.Point(746, 115);
			this.previousEmailButton.Name = "previousEmailButton";
			this.previousEmailButton.Size = new System.Drawing.Size(85, 23);
			this.previousEmailButton.TabIndex = 4;
			this.previousEmailButton.Text = "Previous Email";
			this.previousEmailButton.UseVisualStyleBackColor = true;
			this.previousEmailButton.Click += new System.EventHandler(this.PreviousEmailButton_Click);
			// 
			// sendSubjectText
			// 
			this.sendSubjectText.Location = new System.Drawing.Point(6, 76);
			this.sendSubjectText.Name = "sendSubjectText";
			this.sendSubjectText.Size = new System.Drawing.Size(333, 20);
			this.sendSubjectText.TabIndex = 2;
			// 
			// _sendRecipients
			// 
			this._sendRecipients.AutoSize = true;
			this._sendRecipients.Location = new System.Drawing.Point(3, 99);
			this._sendRecipients.Name = "_sendRecipients";
			this._sendRecipients.Size = new System.Drawing.Size(23, 13);
			this._sendRecipients.TabIndex = 12;
			this._sendRecipients.Text = "To:";
			// 
			// _sendSubject
			// 
			this._sendSubject.AutoSize = true;
			this._sendSubject.Location = new System.Drawing.Point(6, 59);
			this._sendSubject.Name = "_sendSubject";
			this._sendSubject.Size = new System.Drawing.Size(46, 13);
			this._sendSubject.TabIndex = 14;
			this._sendSubject.Text = "Subject:";
			// 
			// sendRecipientsText
			// 
			this.sendRecipientsText.Location = new System.Drawing.Point(6, 115);
			this.sendRecipientsText.Name = "sendRecipientsText";
			this.sendRecipientsText.Size = new System.Drawing.Size(333, 20);
			this.sendRecipientsText.TabIndex = 3;
			// 
			// applicationTabControl
			// 
			this.applicationTabControl.Controls.Add(this.accountsTab);
			this.applicationTabControl.Controls.Add(this.viewEmailsTab);
			this.applicationTabControl.Controls.Add(this.sendEmailsTab);
			this.applicationTabControl.Location = new System.Drawing.Point(12, 12);
			this.applicationTabControl.Name = "applicationTabControl";
			this.applicationTabControl.SelectedIndex = 0;
			this.applicationTabControl.Size = new System.Drawing.Size(937, 482);
			this.applicationTabControl.TabIndex = 1;
			// 
			// accountsTab
			// 
			this.accountsTab.Controls.Add(this.accountDetailsContainer);
			this.accountsTab.Location = new System.Drawing.Point(4, 22);
			this.accountsTab.Name = "accountsTab";
			this.accountsTab.Padding = new System.Windows.Forms.Padding(3);
			this.accountsTab.Size = new System.Drawing.Size(929, 456);
			this.accountsTab.TabIndex = 0;
			this.accountsTab.Text = "Link/Change Accounts";
			this.accountsTab.UseVisualStyleBackColor = true;
			// 
			// accountDetailsContainer
			// 
			this.accountDetailsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.accountDetailsContainer.Location = new System.Drawing.Point(3, 3);
			this.accountDetailsContainer.Name = "accountDetailsContainer";
			// 
			// accountDetailsContainer.Panel1
			// 
			this.accountDetailsContainer.Panel1.Controls.Add(this._protocolLabel);
			this.accountDetailsContainer.Panel1.Controls.Add(this.showPasswordCheckbox);
			this.accountDetailsContainer.Panel1.Controls.Add(this.serverDetailsPanel);
			this.accountDetailsContainer.Panel1.Controls.Add(this.linkAccountButton);
			this.accountDetailsContainer.Panel1.Controls.Add(this.providerComboBox);
			this.accountDetailsContainer.Panel1.Controls.Add(this.protocolComboBox);
			this.accountDetailsContainer.Panel1.Controls.Add(this._providerLabel);
			this.accountDetailsContainer.Panel1.Controls.Add(this._passwordLabel);
			this.accountDetailsContainer.Panel1.Controls.Add(this._linkWarning);
			this.accountDetailsContainer.Panel1.Controls.Add(this._addressLabel);
			this.accountDetailsContainer.Panel1.Controls.Add(this.emailPasswordText);
			this.accountDetailsContainer.Panel1.Controls.Add(this.emailAddressText);
			this.accountDetailsContainer.Panel1.Controls.Add(this._linkAccountLabel);
			// 
			// accountDetailsContainer.Panel2
			// 
			this.accountDetailsContainer.Panel2.Controls.Add(this.currentAccountComboBox);
			this.accountDetailsContainer.Panel2.Controls.Add(this._switchAccountLabel);
			this.accountDetailsContainer.Size = new System.Drawing.Size(923, 450);
			this.accountDetailsContainer.SplitterDistance = 307;
			this.accountDetailsContainer.TabIndex = 0;
			this.accountDetailsContainer.TabStop = false;
			// 
			// _protocolLabel
			// 
			this._protocolLabel.AutoSize = true;
			this._protocolLabel.Location = new System.Drawing.Point(10, 157);
			this._protocolLabel.Name = "_protocolLabel";
			this._protocolLabel.Size = new System.Drawing.Size(49, 13);
			this._protocolLabel.TabIndex = 18;
			this._protocolLabel.Text = "Protocol:";
			// 
			// showPasswordCheckbox
			// 
			this.showPasswordCheckbox.AutoSize = true;
			this.showPasswordCheckbox.Location = new System.Drawing.Point(192, 104);
			this.showPasswordCheckbox.Name = "showPasswordCheckbox";
			this.showPasswordCheckbox.Size = new System.Drawing.Size(102, 17);
			this.showPasswordCheckbox.TabIndex = 11;
			this.showPasswordCheckbox.Text = "Show Password";
			this.showPasswordCheckbox.UseVisualStyleBackColor = true;
			this.showPasswordCheckbox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckbox_CheckedChanged);
			// 
			// serverDetailsPanel
			// 
			this.serverDetailsPanel.Controls.Add(this.outboundAuthCheckBox);
			this.serverDetailsPanel.Controls.Add(this.outboundSslCheckBox);
			this.serverDetailsPanel.Controls.Add(this._inboundServerLabel);
			this.serverDetailsPanel.Controls.Add(this.inboundSslCheckBox);
			this.serverDetailsPanel.Controls.Add(this.inboundServerText);
			this.serverDetailsPanel.Controls.Add(this.outboundServerText);
			this.serverDetailsPanel.Controls.Add(this._inboundPortLabel);
			this.serverDetailsPanel.Controls.Add(this._outboundServerLabel);
			this.serverDetailsPanel.Controls.Add(this.inboundPortText);
			this.serverDetailsPanel.Controls.Add(this.outboundPortText);
			this.serverDetailsPanel.Controls.Add(this._outboundPort);
			this.serverDetailsPanel.Location = new System.Drawing.Point(12, 195);
			this.serverDetailsPanel.Name = "serverDetailsPanel";
			this.serverDetailsPanel.Size = new System.Drawing.Size(282, 160);
			this.serverDetailsPanel.TabIndex = 6;
			// 
			// outboundAuthCheckBox
			// 
			this.outboundAuthCheckBox.AutoSize = true;
			this.outboundAuthCheckBox.Location = new System.Drawing.Point(162, 133);
			this.outboundAuthCheckBox.Name = "outboundAuthCheckBox";
			this.outboundAuthCheckBox.Size = new System.Drawing.Size(94, 17);
			this.outboundAuthCheckBox.TabIndex = 12;
			this.outboundAuthCheckBox.Text = "Auth Required";
			this.outboundAuthCheckBox.UseVisualStyleBackColor = true;
			// 
			// outboundSslCheckBox
			// 
			this.outboundSslCheckBox.AutoSize = true;
			this.outboundSslCheckBox.Location = new System.Drawing.Point(162, 110);
			this.outboundSslCheckBox.Name = "outboundSslCheckBox";
			this.outboundSslCheckBox.Size = new System.Drawing.Size(71, 17);
			this.outboundSslCheckBox.TabIndex = 11;
			this.outboundSslCheckBox.Text = "SSL/TLS";
			this.outboundSslCheckBox.UseVisualStyleBackColor = true;
			// 
			// _inboundServerLabel
			// 
			this._inboundServerLabel.AutoSize = true;
			this._inboundServerLabel.Location = new System.Drawing.Point(3, 10);
			this._inboundServerLabel.Name = "_inboundServerLabel";
			this._inboundServerLabel.Size = new System.Drawing.Size(83, 13);
			this._inboundServerLabel.TabIndex = 23;
			this._inboundServerLabel.Text = "Inbound Server:";
			// 
			// inboundSslCheckBox
			// 
			this.inboundSslCheckBox.AutoSize = true;
			this.inboundSslCheckBox.Location = new System.Drawing.Point(154, 35);
			this.inboundSslCheckBox.Name = "inboundSslCheckBox";
			this.inboundSslCheckBox.Size = new System.Drawing.Size(71, 17);
			this.inboundSslCheckBox.TabIndex = 8;
			this.inboundSslCheckBox.Text = "SSL/TLS";
			this.inboundSslCheckBox.UseVisualStyleBackColor = true;
			// 
			// inboundServerText
			// 
			this.inboundServerText.Location = new System.Drawing.Point(92, 7);
			this.inboundServerText.Name = "inboundServerText";
			this.inboundServerText.Size = new System.Drawing.Size(184, 20);
			this.inboundServerText.TabIndex = 6;
			// 
			// outboundServerText
			// 
			this.outboundServerText.Location = new System.Drawing.Point(100, 82);
			this.outboundServerText.Name = "outboundServerText";
			this.outboundServerText.Size = new System.Drawing.Size(176, 20);
			this.outboundServerText.TabIndex = 9;
			// 
			// _inboundPortLabel
			// 
			this._inboundPortLabel.AutoSize = true;
			this._inboundPortLabel.Location = new System.Drawing.Point(54, 36);
			this._inboundPortLabel.Name = "_inboundPortLabel";
			this._inboundPortLabel.Size = new System.Drawing.Size(29, 13);
			this._inboundPortLabel.TabIndex = 22;
			this._inboundPortLabel.Text = "Port:";
			// 
			// _outboundServerLabel
			// 
			this._outboundServerLabel.AutoSize = true;
			this._outboundServerLabel.Location = new System.Drawing.Point(3, 85);
			this._outboundServerLabel.Name = "_outboundServerLabel";
			this._outboundServerLabel.Size = new System.Drawing.Size(91, 13);
			this._outboundServerLabel.TabIndex = 27;
			this._outboundServerLabel.Text = "Outbound Server:";
			// 
			// inboundPortText
			// 
			this.inboundPortText.Location = new System.Drawing.Point(92, 33);
			this.inboundPortText.Name = "inboundPortText";
			this.inboundPortText.Size = new System.Drawing.Size(48, 20);
			this.inboundPortText.TabIndex = 7;
			// 
			// outboundPortText
			// 
			this.outboundPortText.Location = new System.Drawing.Point(100, 108);
			this.outboundPortText.Name = "outboundPortText";
			this.outboundPortText.Size = new System.Drawing.Size(48, 20);
			this.outboundPortText.TabIndex = 10;
			// 
			// _outboundPort
			// 
			this._outboundPort.AutoSize = true;
			this._outboundPort.Location = new System.Drawing.Point(62, 111);
			this._outboundPort.Name = "_outboundPort";
			this._outboundPort.Size = new System.Drawing.Size(29, 13);
			this._outboundPort.TabIndex = 21;
			this._outboundPort.Text = "Port:";
			// 
			// linkAccountButton
			// 
			this.linkAccountButton.Location = new System.Drawing.Point(93, 399);
			this.linkAccountButton.Name = "linkAccountButton";
			this.linkAccountButton.Size = new System.Drawing.Size(115, 37);
			this.linkAccountButton.TabIndex = 13;
			this.linkAccountButton.Text = "Link Account";
			this.linkAccountButton.UseVisualStyleBackColor = true;
			this.linkAccountButton.Click += new System.EventHandler(this.LinkAccountButton_Click);
			// 
			// providerComboBox
			// 
			this.providerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.providerComboBox.FormattingEnabled = true;
			this.providerComboBox.Items.AddRange(new object[] {
            "Hotmail",
            "Yahoo",
            "Gmail",
            "Other"});
			this.providerComboBox.Location = new System.Drawing.Point(64, 126);
			this.providerComboBox.Name = "providerComboBox";
			this.providerComboBox.Size = new System.Drawing.Size(91, 21);
			this.providerComboBox.TabIndex = 4;
			this.providerComboBox.SelectedIndexChanged += new System.EventHandler(this.ProviderComboBox_SelectedIndexChanged);
			// 
			// protocolComboBox
			// 
			this.protocolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.protocolComboBox.FormattingEnabled = true;
			this.protocolComboBox.Items.AddRange(new object[] {
            "IMAP4",
            "POP3"});
			this.protocolComboBox.Location = new System.Drawing.Point(65, 154);
			this.protocolComboBox.Name = "protocolComboBox";
			this.protocolComboBox.Size = new System.Drawing.Size(69, 21);
			this.protocolComboBox.TabIndex = 5;
			// 
			// _providerLabel
			// 
			this._providerLabel.AutoSize = true;
			this._providerLabel.Location = new System.Drawing.Point(9, 129);
			this._providerLabel.Name = "_providerLabel";
			this._providerLabel.Size = new System.Drawing.Size(49, 13);
			this._providerLabel.TabIndex = 37;
			this._providerLabel.Text = "Provider:";
			// 
			// _passwordLabel
			// 
			this._passwordLabel.AutoSize = true;
			this._passwordLabel.Location = new System.Drawing.Point(10, 104);
			this._passwordLabel.Name = "_passwordLabel";
			this._passwordLabel.Size = new System.Drawing.Size(56, 13);
			this._passwordLabel.TabIndex = 35;
			this._passwordLabel.Text = "Password:";
			// 
			// _linkWarning
			// 
			this._linkWarning.Location = new System.Drawing.Point(15, 368);
			this._linkWarning.Name = "_linkWarning";
			this._linkWarning.Size = new System.Drawing.Size(279, 28);
			this._linkWarning.TabIndex = 35;
			this._linkWarning.Text = "Linking your account will clear all controls in order to protect your information" +
    "";
			this._linkWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _addressLabel
			// 
			this._addressLabel.AutoSize = true;
			this._addressLabel.Location = new System.Drawing.Point(10, 78);
			this._addressLabel.Name = "_addressLabel";
			this._addressLabel.Size = new System.Drawing.Size(35, 13);
			this._addressLabel.TabIndex = 35;
			this._addressLabel.Text = "Email:";
			// 
			// emailPasswordText
			// 
			this.emailPasswordText.Location = new System.Drawing.Point(72, 101);
			this.emailPasswordText.Name = "emailPasswordText";
			this.emailPasswordText.PasswordChar = '*';
			this.emailPasswordText.Size = new System.Drawing.Size(114, 20);
			this.emailPasswordText.TabIndex = 3;
			// 
			// emailAddressText
			// 
			this.emailAddressText.Location = new System.Drawing.Point(51, 75);
			this.emailAddressText.Name = "emailAddressText";
			this.emailAddressText.Size = new System.Drawing.Size(243, 20);
			this.emailAddressText.TabIndex = 2;
			// 
			// _linkAccountLabel
			// 
			this._linkAccountLabel.AutoSize = true;
			this._linkAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._linkAccountLabel.Location = new System.Drawing.Point(59, 23);
			this._linkAccountLabel.Name = "_linkAccountLabel";
			this._linkAccountLabel.Size = new System.Drawing.Size(170, 31);
			this._linkAccountLabel.TabIndex = 34;
			this._linkAccountLabel.Text = "Link Account";
			// 
			// currentAccountComboBox
			// 
			this.currentAccountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.currentAccountComboBox.FormattingEnabled = true;
			this.currentAccountComboBox.Location = new System.Drawing.Point(189, 96);
			this.currentAccountComboBox.Name = "currentAccountComboBox";
			this.currentAccountComboBox.Size = new System.Drawing.Size(259, 21);
			this.currentAccountComboBox.TabIndex = 14;
			this.currentAccountComboBox.SelectedIndexChanged += new System.EventHandler(this.CurrentAccountComboBox_SelectedIndexChanged);
			// 
			// _switchAccountLabel
			// 
			this._switchAccountLabel.AutoSize = true;
			this._switchAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._switchAccountLabel.Location = new System.Drawing.Point(219, 23);
			this._switchAccountLabel.Name = "_switchAccountLabel";
			this._switchAccountLabel.Size = new System.Drawing.Size(201, 31);
			this._switchAccountLabel.TabIndex = 32;
			this._switchAccountLabel.Text = "Switch Account";
			// 
			// viewEmailsTab
			// 
			this.viewEmailsTab.Controls.Add(this._readStatusLabel);
			this.viewEmailsTab.Controls.Add(this.readStatusText);
			this.viewEmailsTab.Controls.Add(this.readEmailBodyText);
			this.viewEmailsTab.Controls.Add(this.getMailButton);
			this.viewEmailsTab.Controls.Add(this.emailDetailsGroupbox);
			this.viewEmailsTab.Controls.Add(this.nextEmailButton);
			this.viewEmailsTab.Controls.Add(this.previousEmailButton);
			this.viewEmailsTab.Location = new System.Drawing.Point(4, 22);
			this.viewEmailsTab.Name = "viewEmailsTab";
			this.viewEmailsTab.Padding = new System.Windows.Forms.Padding(3);
			this.viewEmailsTab.Size = new System.Drawing.Size(929, 456);
			this.viewEmailsTab.TabIndex = 1;
			this.viewEmailsTab.Text = "View Emails";
			this.viewEmailsTab.UseVisualStyleBackColor = true;
			// 
			// _readStatusLabel
			// 
			this._readStatusLabel.AutoSize = true;
			this._readStatusLabel.Location = new System.Drawing.Point(544, 9);
			this._readStatusLabel.Name = "_readStatusLabel";
			this._readStatusLabel.Size = new System.Drawing.Size(40, 13);
			this._readStatusLabel.TabIndex = 18;
			this._readStatusLabel.Text = "Status:";
			// 
			// readStatusText
			// 
			this.readStatusText.Location = new System.Drawing.Point(590, 6);
			this.readStatusText.Name = "readStatusText";
			this.readStatusText.ReadOnly = true;
			this.readStatusText.Size = new System.Drawing.Size(333, 20);
			this.readStatusText.TabIndex = 17;
			this.readStatusText.TabStop = false;
			// 
			// readEmailBodyText
			// 
			this.readEmailBodyText.Location = new System.Drawing.Point(6, 170);
			this.readEmailBodyText.Name = "readEmailBodyText";
			this.readEmailBodyText.ReadOnly = true;
			this.readEmailBodyText.Size = new System.Drawing.Size(917, 280);
			this.readEmailBodyText.TabIndex = 11;
			this.readEmailBodyText.TabStop = false;
			this.readEmailBodyText.Text = "";
			// 
			// sendEmailsTab
			// 
			this.sendEmailsTab.Controls.Add(this.sendCarbonCopiesText);
			this.sendEmailsTab.Controls.Add(this._sendCarbonCopy);
			this.sendEmailsTab.Controls.Add(this.sendMailButton);
			this.sendEmailsTab.Controls.Add(this.sendEmailBodyText);
			this.sendEmailsTab.Controls.Add(this._sendStatusLabel);
			this.sendEmailsTab.Controls.Add(this.sendStatusTextBox);
			this.sendEmailsTab.Controls.Add(this.sendSubjectText);
			this.sendEmailsTab.Controls.Add(this._sendRecipients);
			this.sendEmailsTab.Controls.Add(this.sendRecipientsText);
			this.sendEmailsTab.Controls.Add(this._sendSubject);
			this.sendEmailsTab.Location = new System.Drawing.Point(4, 22);
			this.sendEmailsTab.Name = "sendEmailsTab";
			this.sendEmailsTab.Padding = new System.Windows.Forms.Padding(3);
			this.sendEmailsTab.Size = new System.Drawing.Size(929, 456);
			this.sendEmailsTab.TabIndex = 2;
			this.sendEmailsTab.Text = "Send Email";
			this.sendEmailsTab.UseVisualStyleBackColor = true;
			// 
			// sendCarbonCopiesText
			// 
			this.sendCarbonCopiesText.Location = new System.Drawing.Point(345, 115);
			this.sendCarbonCopiesText.Name = "sendCarbonCopiesText";
			this.sendCarbonCopiesText.Size = new System.Drawing.Size(333, 20);
			this.sendCarbonCopiesText.TabIndex = 4;
			// 
			// _sendCarbonCopy
			// 
			this._sendCarbonCopy.AutoSize = true;
			this._sendCarbonCopy.Location = new System.Drawing.Point(342, 99);
			this._sendCarbonCopy.Name = "_sendCarbonCopy";
			this._sendCarbonCopy.Size = new System.Drawing.Size(23, 13);
			this._sendCarbonCopy.TabIndex = 17;
			this._sendCarbonCopy.Text = "Cc:";
			// 
			// _sendStatusLabel
			// 
			this._sendStatusLabel.AutoSize = true;
			this._sendStatusLabel.Location = new System.Drawing.Point(544, 9);
			this._sendStatusLabel.Name = "_sendStatusLabel";
			this._sendStatusLabel.Size = new System.Drawing.Size(40, 13);
			this._sendStatusLabel.TabIndex = 16;
			this._sendStatusLabel.Text = "Status:";
			// 
			// sendStatusTextBox
			// 
			this.sendStatusTextBox.Location = new System.Drawing.Point(590, 6);
			this.sendStatusTextBox.Name = "sendStatusTextBox";
			this.sendStatusTextBox.ReadOnly = true;
			this.sendStatusTextBox.Size = new System.Drawing.Size(333, 20);
			this.sendStatusTextBox.TabIndex = 15;
			this.sendStatusTextBox.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(961, 506);
			this.Controls.Add(this.applicationTabControl);
			this.Name = "Form1";
			this.Text = "Form1";
			this.emailDetailsGroupbox.ResumeLayout(false);
			this.emailDetailsGroupbox.PerformLayout();
			this.applicationTabControl.ResumeLayout(false);
			this.accountsTab.ResumeLayout(false);
			this.accountDetailsContainer.Panel1.ResumeLayout(false);
			this.accountDetailsContainer.Panel1.PerformLayout();
			this.accountDetailsContainer.Panel2.ResumeLayout(false);
			this.accountDetailsContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.accountDetailsContainer)).EndInit();
			this.accountDetailsContainer.ResumeLayout(false);
			this.serverDetailsPanel.ResumeLayout(false);
			this.serverDetailsPanel.PerformLayout();
			this.viewEmailsTab.ResumeLayout(false);
			this.viewEmailsTab.PerformLayout();
			this.sendEmailsTab.ResumeLayout(false);
			this.sendEmailsTab.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.RichTextBox sendEmailBodyText;
		private System.Windows.Forms.Button getMailButton;
		private System.Windows.Forms.Label senderLabel;
		private System.Windows.Forms.Label subjectLabel;
		private System.Windows.Forms.Label recipientsLabel;
		private System.Windows.Forms.GroupBox emailDetailsGroupbox;
		private System.Windows.Forms.Button sendMailButton;
		private System.Windows.Forms.Label _subjectLabel;
		private System.Windows.Forms.Label _recipientsLabel;
		private System.Windows.Forms.Label _senderLabel;
		private System.Windows.Forms.Button nextEmailButton;
		private System.Windows.Forms.Button previousEmailButton;
		private System.Windows.Forms.TextBox sendSubjectText;
		private System.Windows.Forms.Label _sendRecipients;
		private System.Windows.Forms.Label _sendSubject;
		private System.Windows.Forms.TextBox sendRecipientsText;
		private System.Windows.Forms.TabControl applicationTabControl;
		private System.Windows.Forms.TabPage accountsTab;
		private System.Windows.Forms.Label _sendStatusLabel;
		private System.Windows.Forms.TextBox sendStatusTextBox;
		private System.Windows.Forms.TabPage viewEmailsTab;
		private System.Windows.Forms.TabPage sendEmailsTab;
		private System.Windows.Forms.Label _sendCarbonCopy;
		private System.Windows.Forms.TextBox sendCarbonCopiesText;
		private System.Windows.Forms.RichTextBox readEmailBodyText;
		private System.Windows.Forms.Label _carbonCopiesLabel;
		private System.Windows.Forms.Label carbonCopiesLabel;
		private System.Windows.Forms.Label _readStatusLabel;
		private System.Windows.Forms.TextBox readStatusText;
		private System.Windows.Forms.SplitContainer accountDetailsContainer;
		private System.Windows.Forms.Button linkAccountButton;
		private System.Windows.Forms.ComboBox providerComboBox;
		private System.Windows.Forms.Label _providerLabel;
		private System.Windows.Forms.Label _addressLabel;
		private System.Windows.Forms.Panel serverDetailsPanel;
		private System.Windows.Forms.Label _protocolLabel;
		private System.Windows.Forms.CheckBox outboundAuthCheckBox;
		private System.Windows.Forms.ComboBox protocolComboBox;
		private System.Windows.Forms.CheckBox outboundSslCheckBox;
		private System.Windows.Forms.Label _inboundServerLabel;
		private System.Windows.Forms.CheckBox inboundSslCheckBox;
		private System.Windows.Forms.TextBox inboundServerText;
		private System.Windows.Forms.TextBox outboundServerText;
		private System.Windows.Forms.Label _inboundPortLabel;
		private System.Windows.Forms.Label _outboundServerLabel;
		private System.Windows.Forms.TextBox inboundPortText;
		private System.Windows.Forms.TextBox outboundPortText;
		private System.Windows.Forms.Label _outboundPort;
		private System.Windows.Forms.TextBox emailAddressText;
		private System.Windows.Forms.Label _linkAccountLabel;
		private System.Windows.Forms.Label _switchAccountLabel;
		private System.Windows.Forms.ComboBox currentAccountComboBox;
		private System.Windows.Forms.Label _passwordLabel;
		private System.Windows.Forms.TextBox emailPasswordText;
		private System.Windows.Forms.CheckBox showPasswordCheckbox;
		private System.Windows.Forms.Label _linkWarning;
	}
}

