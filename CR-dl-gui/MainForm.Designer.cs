namespace CR_dl_gui
{
    partial class MainForm
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
            if (disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AccountGroupBox = new System.Windows.Forms.GroupBox();
            this.MakeLoginBatchFile = new System.Windows.Forms.Button();
            this.ChangeLanguage = new System.Windows.Forms.Button();
            this.SiteLanguage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteLoginFile = new System.Windows.Forms.Button();
            this.CookiesFileNotFound = new System.Windows.Forms.Label();
            this.CookiesFileFound = new System.Windows.Forms.Label();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.Login = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.EmailOrUserName = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailOrUserNameLabel = new System.Windows.Forms.Label();
            this.CookiesFileLabel = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.LanguageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnglishLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.ArabicLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRdlGithubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRdlguiGithubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TypeControl = new System.Windows.Forms.TabControl();
            this.Softsub = new System.Windows.Forms.TabPage();
            this.SoftsubSaveButton = new System.Windows.Forms.Button();
            this.ExecuteSoftsubCommand = new System.Windows.Forms.Button();
            this.SoftsubCommand = new System.Windows.Forms.TextBox();
            this.ListSubtitles = new System.Windows.Forms.CheckBox();
            this.SubtitltesOnly = new System.Windows.Forms.CheckBox();
            this.SoftsubSaveDirectory = new System.Windows.Forms.TextBox();
            this.SoftsubSaveDirectoryLabel = new System.Windows.Forms.Label();
            this.LegacyPlayer = new System.Windows.Forms.CheckBox();
            this.AttachFonts = new System.Windows.Forms.CheckBox();
            this.SubtitleLanguages = new System.Windows.Forms.ListBox();
            this.SpecifySubtitleLanguages = new System.Windows.Forms.CheckBox();
            this.Hardsub = new System.Windows.Forms.TabPage();
            this.HardsubSaveButton = new System.Windows.Forms.Button();
            this.ExecuteHardsubCommand = new System.Windows.Forms.Button();
            this.HardsubCommand = new System.Windows.Forms.TextBox();
            this.HardsubSaveDirectory = new System.Windows.Forms.TextBox();
            this.HardsubSaveDirectoryLabel = new System.Windows.Forms.Label();
            this.URL = new System.Windows.Forms.TextBox();
            this.URLLabel = new System.Windows.Forms.Label();
            this.Proxy = new System.Windows.Forms.TextBox();
            this.ProxyLabel = new System.Windows.Forms.Label();
            this.UseProxy = new System.Windows.Forms.CheckBox();
            this.Resolution = new System.Windows.Forms.ComboBox();
            this.DefaultSubtitleLabel = new System.Windows.Forms.Label();
            this.DefaultSubtitle = new System.Windows.Forms.ComboBox();
            this.ConnectionsNumberLabel = new System.Windows.Forms.Label();
            this.ConnectionsNumber = new System.Windows.Forms.NumericUpDown();
            this.Seasons = new System.Windows.Forms.TextBox();
            this.Episodes = new System.Windows.Forms.TextBox();
            this.Attempts = new System.Windows.Forms.NumericUpDown();
            this.AttemptsLabel = new System.Windows.Forms.Label();
            this.ProxyForVideo = new System.Windows.Forms.CheckBox();
            this.UseSeasons = new System.Windows.Forms.CheckBox();
            this.UseEpisodes = new System.Windows.Forms.CheckBox();
            this.UseResolution = new System.Windows.Forms.CheckBox();
            this.TheToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.NoProgressBar = new System.Windows.Forms.CheckBox();
            this.CookiesFile = new System.Windows.Forms.CheckBox();
            this.CookiesFilePath = new System.Windows.Forms.TextBox();
            this.AccountGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.TypeControl.SuspendLayout();
            this.Softsub.SuspendLayout();
            this.Hardsub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attempts)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountGroupBox
            // 
            resources.ApplyResources(this.AccountGroupBox, "AccountGroupBox");
            this.AccountGroupBox.Controls.Add(this.MakeLoginBatchFile);
            this.AccountGroupBox.Controls.Add(this.ChangeLanguage);
            this.AccountGroupBox.Controls.Add(this.SiteLanguage);
            this.AccountGroupBox.Controls.Add(this.label1);
            this.AccountGroupBox.Controls.Add(this.DeleteLoginFile);
            this.AccountGroupBox.Controls.Add(this.CookiesFileNotFound);
            this.AccountGroupBox.Controls.Add(this.CookiesFileFound);
            this.AccountGroupBox.Controls.Add(this.ShowPassword);
            this.AccountGroupBox.Controls.Add(this.Login);
            this.AccountGroupBox.Controls.Add(this.Password);
            this.AccountGroupBox.Controls.Add(this.EmailOrUserName);
            this.AccountGroupBox.Controls.Add(this.PasswordLabel);
            this.AccountGroupBox.Controls.Add(this.EmailOrUserNameLabel);
            this.AccountGroupBox.Controls.Add(this.CookiesFileLabel);
            this.AccountGroupBox.Name = "AccountGroupBox";
            this.AccountGroupBox.TabStop = false;
            this.TheToolTip.SetToolTip(this.AccountGroupBox, resources.GetString("AccountGroupBox.ToolTip"));
            // 
            // MakeLoginBatchFile
            // 
            resources.ApplyResources(this.MakeLoginBatchFile, "MakeLoginBatchFile");
            this.MakeLoginBatchFile.Name = "MakeLoginBatchFile";
            this.TheToolTip.SetToolTip(this.MakeLoginBatchFile, resources.GetString("MakeLoginBatchFile.ToolTip"));
            this.MakeLoginBatchFile.UseVisualStyleBackColor = true;
            this.MakeLoginBatchFile.Click += new System.EventHandler(this.MakeLoginBatchFile_Click);
            // 
            // ChangeLanguage
            // 
            resources.ApplyResources(this.ChangeLanguage, "ChangeLanguage");
            this.ChangeLanguage.Name = "ChangeLanguage";
            this.TheToolTip.SetToolTip(this.ChangeLanguage, resources.GetString("ChangeLanguage.ToolTip"));
            this.ChangeLanguage.UseVisualStyleBackColor = true;
            this.ChangeLanguage.Click += new System.EventHandler(this.ChangeLanguage_Click);
            // 
            // SiteLanguage
            // 
            resources.ApplyResources(this.SiteLanguage, "SiteLanguage");
            this.SiteLanguage.FormattingEnabled = true;
            this.SiteLanguage.Items.AddRange(new object[] {
            resources.GetString("SiteLanguage.Items"),
            resources.GetString("SiteLanguage.Items1"),
            resources.GetString("SiteLanguage.Items2"),
            resources.GetString("SiteLanguage.Items3"),
            resources.GetString("SiteLanguage.Items4"),
            resources.GetString("SiteLanguage.Items5"),
            resources.GetString("SiteLanguage.Items6"),
            resources.GetString("SiteLanguage.Items7"),
            resources.GetString("SiteLanguage.Items8"),
            resources.GetString("SiteLanguage.Items9"),
            resources.GetString("SiteLanguage.Items10")});
            this.SiteLanguage.Name = "SiteLanguage";
            this.TheToolTip.SetToolTip(this.SiteLanguage, resources.GetString("SiteLanguage.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.TheToolTip.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // DeleteLoginFile
            // 
            resources.ApplyResources(this.DeleteLoginFile, "DeleteLoginFile");
            this.DeleteLoginFile.ForeColor = System.Drawing.Color.Red;
            this.DeleteLoginFile.Name = "DeleteLoginFile";
            this.TheToolTip.SetToolTip(this.DeleteLoginFile, resources.GetString("DeleteLoginFile.ToolTip"));
            this.DeleteLoginFile.UseVisualStyleBackColor = true;
            this.DeleteLoginFile.Click += new System.EventHandler(this.DeleteLoginFile_Click);
            // 
            // CookiesFileNotFound
            // 
            resources.ApplyResources(this.CookiesFileNotFound, "CookiesFileNotFound");
            this.CookiesFileNotFound.ForeColor = System.Drawing.Color.Red;
            this.CookiesFileNotFound.Name = "CookiesFileNotFound";
            this.TheToolTip.SetToolTip(this.CookiesFileNotFound, resources.GetString("CookiesFileNotFound.ToolTip"));
            // 
            // CookiesFileFound
            // 
            resources.ApplyResources(this.CookiesFileFound, "CookiesFileFound");
            this.CookiesFileFound.ForeColor = System.Drawing.Color.Green;
            this.CookiesFileFound.Name = "CookiesFileFound";
            this.TheToolTip.SetToolTip(this.CookiesFileFound, resources.GetString("CookiesFileFound.ToolTip"));
            // 
            // ShowPassword
            // 
            resources.ApplyResources(this.ShowPassword, "ShowPassword");
            this.ShowPassword.Name = "ShowPassword";
            this.TheToolTip.SetToolTip(this.ShowPassword, resources.GetString("ShowPassword.ToolTip"));
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // Login
            // 
            resources.ApplyResources(this.Login, "Login");
            this.Login.Name = "Login";
            this.TheToolTip.SetToolTip(this.Login, resources.GetString("Login.ToolTip"));
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Password
            // 
            resources.ApplyResources(this.Password, "Password");
            this.Password.Name = "Password";
            this.TheToolTip.SetToolTip(this.Password, resources.GetString("Password.ToolTip"));
            this.Password.UseSystemPasswordChar = true;
            // 
            // EmailOrUserName
            // 
            resources.ApplyResources(this.EmailOrUserName, "EmailOrUserName");
            this.EmailOrUserName.Name = "EmailOrUserName";
            this.TheToolTip.SetToolTip(this.EmailOrUserName, resources.GetString("EmailOrUserName.ToolTip"));
            // 
            // PasswordLabel
            // 
            resources.ApplyResources(this.PasswordLabel, "PasswordLabel");
            this.PasswordLabel.Name = "PasswordLabel";
            this.TheToolTip.SetToolTip(this.PasswordLabel, resources.GetString("PasswordLabel.ToolTip"));
            // 
            // EmailOrUserNameLabel
            // 
            resources.ApplyResources(this.EmailOrUserNameLabel, "EmailOrUserNameLabel");
            this.EmailOrUserNameLabel.Name = "EmailOrUserNameLabel";
            this.TheToolTip.SetToolTip(this.EmailOrUserNameLabel, resources.GetString("EmailOrUserNameLabel.ToolTip"));
            // 
            // CookiesFileLabel
            // 
            resources.ApplyResources(this.CookiesFileLabel, "CookiesFileLabel");
            this.CookiesFileLabel.Name = "CookiesFileLabel";
            this.TheToolTip.SetToolTip(this.CookiesFileLabel, resources.GetString("CookiesFileLabel.ToolTip"));
            // 
            // Save
            // 
            resources.ApplyResources(this.Save, "Save");
            this.Save.Name = "Save";
            this.TheToolTip.SetToolTip(this.Save, resources.GetString("Save.ToolTip"));
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LanguageMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.TheToolTip.SetToolTip(this.menuStrip1, resources.GetString("menuStrip1.ToolTip"));
            // 
            // LanguageMenuItem
            // 
            resources.ApplyResources(this.LanguageMenuItem, "LanguageMenuItem");
            this.LanguageMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EnglishLanguage,
            this.ArabicLanguage});
            this.LanguageMenuItem.Name = "LanguageMenuItem";
            // 
            // EnglishLanguage
            // 
            resources.ApplyResources(this.EnglishLanguage, "EnglishLanguage");
            this.EnglishLanguage.Name = "EnglishLanguage";
            this.EnglishLanguage.Click += new System.EventHandler(this.EnglishLanguage_Click);
            // 
            // ArabicLanguage
            // 
            resources.ApplyResources(this.ArabicLanguage, "ArabicLanguage");
            this.ArabicLanguage.Name = "ArabicLanguage";
            this.ArabicLanguage.Click += new System.EventHandler(this.ArabicLanguage_Click);
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRdlGithubToolStripMenuItem,
            this.cRdlguiGithubToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            // 
            // cRdlGithubToolStripMenuItem
            // 
            resources.ApplyResources(this.cRdlGithubToolStripMenuItem, "cRdlGithubToolStripMenuItem");
            this.cRdlGithubToolStripMenuItem.Name = "cRdlGithubToolStripMenuItem";
            this.cRdlGithubToolStripMenuItem.Click += new System.EventHandler(this.CRdlGithubToolStripMenuItem_Click);
            // 
            // cRdlguiGithubToolStripMenuItem
            // 
            resources.ApplyResources(this.cRdlguiGithubToolStripMenuItem, "cRdlguiGithubToolStripMenuItem");
            this.cRdlguiGithubToolStripMenuItem.Name = "cRdlguiGithubToolStripMenuItem";
            this.cRdlguiGithubToolStripMenuItem.Click += new System.EventHandler(this.CRdlguiGithubToolStripMenuItem_Click);
            // 
            // TypeControl
            // 
            resources.ApplyResources(this.TypeControl, "TypeControl");
            this.TypeControl.Controls.Add(this.Softsub);
            this.TypeControl.Controls.Add(this.Hardsub);
            this.TypeControl.Name = "TypeControl";
            this.TypeControl.SelectedIndex = 0;
            this.TheToolTip.SetToolTip(this.TypeControl, resources.GetString("TypeControl.ToolTip"));
            // 
            // Softsub
            // 
            resources.ApplyResources(this.Softsub, "Softsub");
            this.Softsub.Controls.Add(this.SoftsubSaveButton);
            this.Softsub.Controls.Add(this.ExecuteSoftsubCommand);
            this.Softsub.Controls.Add(this.SoftsubCommand);
            this.Softsub.Controls.Add(this.ListSubtitles);
            this.Softsub.Controls.Add(this.SubtitltesOnly);
            this.Softsub.Controls.Add(this.SoftsubSaveDirectory);
            this.Softsub.Controls.Add(this.SoftsubSaveDirectoryLabel);
            this.Softsub.Controls.Add(this.LegacyPlayer);
            this.Softsub.Controls.Add(this.AttachFonts);
            this.Softsub.Controls.Add(this.SubtitleLanguages);
            this.Softsub.Controls.Add(this.SpecifySubtitleLanguages);
            this.Softsub.Name = "Softsub";
            this.TheToolTip.SetToolTip(this.Softsub, resources.GetString("Softsub.ToolTip"));
            this.Softsub.UseVisualStyleBackColor = true;
            // 
            // SoftsubSaveButton
            // 
            resources.ApplyResources(this.SoftsubSaveButton, "SoftsubSaveButton");
            this.SoftsubSaveButton.Name = "SoftsubSaveButton";
            this.TheToolTip.SetToolTip(this.SoftsubSaveButton, resources.GetString("SoftsubSaveButton.ToolTip"));
            this.SoftsubSaveButton.UseVisualStyleBackColor = true;
            this.SoftsubSaveButton.Click += new System.EventHandler(this.SoftsubSaveButton_Click);
            // 
            // ExecuteSoftsubCommand
            // 
            resources.ApplyResources(this.ExecuteSoftsubCommand, "ExecuteSoftsubCommand");
            this.ExecuteSoftsubCommand.Name = "ExecuteSoftsubCommand";
            this.TheToolTip.SetToolTip(this.ExecuteSoftsubCommand, resources.GetString("ExecuteSoftsubCommand.ToolTip"));
            this.ExecuteSoftsubCommand.UseVisualStyleBackColor = true;
            this.ExecuteSoftsubCommand.Click += new System.EventHandler(this.ExecuteSoftsubCommand_Click);
            // 
            // SoftsubCommand
            // 
            resources.ApplyResources(this.SoftsubCommand, "SoftsubCommand");
            this.SoftsubCommand.Name = "SoftsubCommand";
            this.SoftsubCommand.ReadOnly = true;
            this.TheToolTip.SetToolTip(this.SoftsubCommand, resources.GetString("SoftsubCommand.ToolTip"));
            // 
            // ListSubtitles
            // 
            resources.ApplyResources(this.ListSubtitles, "ListSubtitles");
            this.ListSubtitles.Name = "ListSubtitles";
            this.TheToolTip.SetToolTip(this.ListSubtitles, resources.GetString("ListSubtitles.ToolTip"));
            this.ListSubtitles.UseVisualStyleBackColor = true;
            this.ListSubtitles.CheckedChanged += new System.EventHandler(this.ListSubtitles_CheckedChanged);
            // 
            // SubtitltesOnly
            // 
            resources.ApplyResources(this.SubtitltesOnly, "SubtitltesOnly");
            this.SubtitltesOnly.Name = "SubtitltesOnly";
            this.TheToolTip.SetToolTip(this.SubtitltesOnly, resources.GetString("SubtitltesOnly.ToolTip"));
            this.SubtitltesOnly.UseVisualStyleBackColor = true;
            this.SubtitltesOnly.CheckedChanged += new System.EventHandler(this.SubtitltesOnly_CheckedChanged);
            // 
            // SoftsubSaveDirectory
            // 
            resources.ApplyResources(this.SoftsubSaveDirectory, "SoftsubSaveDirectory");
            this.SoftsubSaveDirectory.Name = "SoftsubSaveDirectory";
            this.TheToolTip.SetToolTip(this.SoftsubSaveDirectory, resources.GetString("SoftsubSaveDirectory.ToolTip"));
            this.SoftsubSaveDirectory.TextChanged += new System.EventHandler(this.SoftsubSaveDirectory_TextChanged);
            // 
            // SoftsubSaveDirectoryLabel
            // 
            resources.ApplyResources(this.SoftsubSaveDirectoryLabel, "SoftsubSaveDirectoryLabel");
            this.SoftsubSaveDirectoryLabel.Name = "SoftsubSaveDirectoryLabel";
            this.TheToolTip.SetToolTip(this.SoftsubSaveDirectoryLabel, resources.GetString("SoftsubSaveDirectoryLabel.ToolTip"));
            // 
            // LegacyPlayer
            // 
            resources.ApplyResources(this.LegacyPlayer, "LegacyPlayer");
            this.LegacyPlayer.Name = "LegacyPlayer";
            this.TheToolTip.SetToolTip(this.LegacyPlayer, resources.GetString("LegacyPlayer.ToolTip"));
            this.LegacyPlayer.UseVisualStyleBackColor = true;
            this.LegacyPlayer.CheckedChanged += new System.EventHandler(this.LegacyPlayer_CheckedChanged);
            // 
            // AttachFonts
            // 
            resources.ApplyResources(this.AttachFonts, "AttachFonts");
            this.AttachFonts.Checked = true;
            this.AttachFonts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AttachFonts.Name = "AttachFonts";
            this.TheToolTip.SetToolTip(this.AttachFonts, resources.GetString("AttachFonts.ToolTip"));
            this.AttachFonts.UseVisualStyleBackColor = true;
            this.AttachFonts.CheckedChanged += new System.EventHandler(this.AttachFonts_CheckedChanged);
            // 
            // SubtitleLanguages
            // 
            resources.ApplyResources(this.SubtitleLanguages, "SubtitleLanguages");
            this.SubtitleLanguages.FormattingEnabled = true;
            this.SubtitleLanguages.Items.AddRange(new object[] {
            resources.GetString("SubtitleLanguages.Items"),
            resources.GetString("SubtitleLanguages.Items1"),
            resources.GetString("SubtitleLanguages.Items2"),
            resources.GetString("SubtitleLanguages.Items3"),
            resources.GetString("SubtitleLanguages.Items4"),
            resources.GetString("SubtitleLanguages.Items5"),
            resources.GetString("SubtitleLanguages.Items6"),
            resources.GetString("SubtitleLanguages.Items7"),
            resources.GetString("SubtitleLanguages.Items8"),
            resources.GetString("SubtitleLanguages.Items9"),
            resources.GetString("SubtitleLanguages.Items10")});
            this.SubtitleLanguages.Name = "SubtitleLanguages";
            this.SubtitleLanguages.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.TheToolTip.SetToolTip(this.SubtitleLanguages, resources.GetString("SubtitleLanguages.ToolTip"));
            this.SubtitleLanguages.SelectedIndexChanged += new System.EventHandler(this.SubtitleLanguages_SelectedIndexChanged);
            // 
            // SpecifySubtitleLanguages
            // 
            resources.ApplyResources(this.SpecifySubtitleLanguages, "SpecifySubtitleLanguages");
            this.SpecifySubtitleLanguages.Name = "SpecifySubtitleLanguages";
            this.TheToolTip.SetToolTip(this.SpecifySubtitleLanguages, resources.GetString("SpecifySubtitleLanguages.ToolTip"));
            this.SpecifySubtitleLanguages.UseVisualStyleBackColor = true;
            this.SpecifySubtitleLanguages.CheckedChanged += new System.EventHandler(this.SpecifySubtitleLanguages_CheckedChanged);
            // 
            // Hardsub
            // 
            resources.ApplyResources(this.Hardsub, "Hardsub");
            this.Hardsub.Controls.Add(this.HardsubSaveButton);
            this.Hardsub.Controls.Add(this.ExecuteHardsubCommand);
            this.Hardsub.Controls.Add(this.HardsubCommand);
            this.Hardsub.Controls.Add(this.HardsubSaveDirectory);
            this.Hardsub.Controls.Add(this.HardsubSaveDirectoryLabel);
            this.Hardsub.Name = "Hardsub";
            this.TheToolTip.SetToolTip(this.Hardsub, resources.GetString("Hardsub.ToolTip"));
            this.Hardsub.UseVisualStyleBackColor = true;
            // 
            // HardsubSaveButton
            // 
            resources.ApplyResources(this.HardsubSaveButton, "HardsubSaveButton");
            this.HardsubSaveButton.Name = "HardsubSaveButton";
            this.TheToolTip.SetToolTip(this.HardsubSaveButton, resources.GetString("HardsubSaveButton.ToolTip"));
            this.HardsubSaveButton.UseVisualStyleBackColor = true;
            this.HardsubSaveButton.Click += new System.EventHandler(this.HardsubSaveButton_Click);
            // 
            // ExecuteHardsubCommand
            // 
            resources.ApplyResources(this.ExecuteHardsubCommand, "ExecuteHardsubCommand");
            this.ExecuteHardsubCommand.Name = "ExecuteHardsubCommand";
            this.TheToolTip.SetToolTip(this.ExecuteHardsubCommand, resources.GetString("ExecuteHardsubCommand.ToolTip"));
            this.ExecuteHardsubCommand.UseVisualStyleBackColor = true;
            this.ExecuteHardsubCommand.Click += new System.EventHandler(this.ExecuteHardsubCommand_Click);
            // 
            // HardsubCommand
            // 
            resources.ApplyResources(this.HardsubCommand, "HardsubCommand");
            this.HardsubCommand.Name = "HardsubCommand";
            this.HardsubCommand.ReadOnly = true;
            this.TheToolTip.SetToolTip(this.HardsubCommand, resources.GetString("HardsubCommand.ToolTip"));
            // 
            // HardsubSaveDirectory
            // 
            resources.ApplyResources(this.HardsubSaveDirectory, "HardsubSaveDirectory");
            this.HardsubSaveDirectory.Name = "HardsubSaveDirectory";
            this.TheToolTip.SetToolTip(this.HardsubSaveDirectory, resources.GetString("HardsubSaveDirectory.ToolTip"));
            this.HardsubSaveDirectory.TextChanged += new System.EventHandler(this.HardsubSaveDirectory_TextChanged);
            // 
            // HardsubSaveDirectoryLabel
            // 
            resources.ApplyResources(this.HardsubSaveDirectoryLabel, "HardsubSaveDirectoryLabel");
            this.HardsubSaveDirectoryLabel.Name = "HardsubSaveDirectoryLabel";
            this.TheToolTip.SetToolTip(this.HardsubSaveDirectoryLabel, resources.GetString("HardsubSaveDirectoryLabel.ToolTip"));
            // 
            // URL
            // 
            resources.ApplyResources(this.URL, "URL");
            this.URL.Name = "URL";
            this.TheToolTip.SetToolTip(this.URL, resources.GetString("URL.ToolTip"));
            this.URL.TextChanged += new System.EventHandler(this.URL_TextChanged);
            // 
            // URLLabel
            // 
            resources.ApplyResources(this.URLLabel, "URLLabel");
            this.URLLabel.Name = "URLLabel";
            this.TheToolTip.SetToolTip(this.URLLabel, resources.GetString("URLLabel.ToolTip"));
            // 
            // Proxy
            // 
            resources.ApplyResources(this.Proxy, "Proxy");
            this.Proxy.Name = "Proxy";
            this.TheToolTip.SetToolTip(this.Proxy, resources.GetString("Proxy.ToolTip"));
            this.Proxy.TextChanged += new System.EventHandler(this.Proxy_TextChanged);
            // 
            // ProxyLabel
            // 
            resources.ApplyResources(this.ProxyLabel, "ProxyLabel");
            this.ProxyLabel.Name = "ProxyLabel";
            this.TheToolTip.SetToolTip(this.ProxyLabel, resources.GetString("ProxyLabel.ToolTip"));
            // 
            // UseProxy
            // 
            resources.ApplyResources(this.UseProxy, "UseProxy");
            this.UseProxy.Name = "UseProxy";
            this.TheToolTip.SetToolTip(this.UseProxy, resources.GetString("UseProxy.ToolTip"));
            this.UseProxy.UseVisualStyleBackColor = true;
            this.UseProxy.CheckedChanged += new System.EventHandler(this.UseProxy_CheckedChanged);
            // 
            // Resolution
            // 
            resources.ApplyResources(this.Resolution, "Resolution");
            this.Resolution.FormattingEnabled = true;
            this.Resolution.Items.AddRange(new object[] {
            resources.GetString("Resolution.Items"),
            resources.GetString("Resolution.Items1"),
            resources.GetString("Resolution.Items2"),
            resources.GetString("Resolution.Items3"),
            resources.GetString("Resolution.Items4")});
            this.Resolution.Name = "Resolution";
            this.TheToolTip.SetToolTip(this.Resolution, resources.GetString("Resolution.ToolTip"));
            this.Resolution.SelectedIndexChanged += new System.EventHandler(this.Resolution_SelectedIndexChanged);
            // 
            // DefaultSubtitleLabel
            // 
            resources.ApplyResources(this.DefaultSubtitleLabel, "DefaultSubtitleLabel");
            this.DefaultSubtitleLabel.Name = "DefaultSubtitleLabel";
            this.TheToolTip.SetToolTip(this.DefaultSubtitleLabel, resources.GetString("DefaultSubtitleLabel.ToolTip"));
            // 
            // DefaultSubtitle
            // 
            resources.ApplyResources(this.DefaultSubtitle, "DefaultSubtitle");
            this.DefaultSubtitle.FormattingEnabled = true;
            this.DefaultSubtitle.Items.AddRange(new object[] {
            resources.GetString("DefaultSubtitle.Items"),
            resources.GetString("DefaultSubtitle.Items1"),
            resources.GetString("DefaultSubtitle.Items2"),
            resources.GetString("DefaultSubtitle.Items3"),
            resources.GetString("DefaultSubtitle.Items4"),
            resources.GetString("DefaultSubtitle.Items5"),
            resources.GetString("DefaultSubtitle.Items6"),
            resources.GetString("DefaultSubtitle.Items7"),
            resources.GetString("DefaultSubtitle.Items8"),
            resources.GetString("DefaultSubtitle.Items9"),
            resources.GetString("DefaultSubtitle.Items10")});
            this.DefaultSubtitle.Name = "DefaultSubtitle";
            this.TheToolTip.SetToolTip(this.DefaultSubtitle, resources.GetString("DefaultSubtitle.ToolTip"));
            this.DefaultSubtitle.SelectedIndexChanged += new System.EventHandler(this.DefaultSubtitle_SelectedIndexChanged);
            // 
            // ConnectionsNumberLabel
            // 
            resources.ApplyResources(this.ConnectionsNumberLabel, "ConnectionsNumberLabel");
            this.ConnectionsNumberLabel.Name = "ConnectionsNumberLabel";
            this.TheToolTip.SetToolTip(this.ConnectionsNumberLabel, resources.GetString("ConnectionsNumberLabel.ToolTip"));
            // 
            // ConnectionsNumber
            // 
            resources.ApplyResources(this.ConnectionsNumber, "ConnectionsNumber");
            this.ConnectionsNumber.Name = "ConnectionsNumber";
            this.TheToolTip.SetToolTip(this.ConnectionsNumber, resources.GetString("ConnectionsNumber.ToolTip"));
            this.ConnectionsNumber.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ConnectionsNumber.ValueChanged += new System.EventHandler(this.ConnectionsNumber_ValueChanged);
            // 
            // Seasons
            // 
            resources.ApplyResources(this.Seasons, "Seasons");
            this.Seasons.Name = "Seasons";
            this.TheToolTip.SetToolTip(this.Seasons, resources.GetString("Seasons.ToolTip"));
            this.Seasons.TextChanged += new System.EventHandler(this.Seasons_TextChanged);
            // 
            // Episodes
            // 
            resources.ApplyResources(this.Episodes, "Episodes");
            this.Episodes.Name = "Episodes";
            this.TheToolTip.SetToolTip(this.Episodes, resources.GetString("Episodes.ToolTip"));
            this.Episodes.TextChanged += new System.EventHandler(this.Episodes_TextChanged);
            // 
            // Attempts
            // 
            resources.ApplyResources(this.Attempts, "Attempts");
            this.Attempts.Name = "Attempts";
            this.TheToolTip.SetToolTip(this.Attempts, resources.GetString("Attempts.ToolTip"));
            this.Attempts.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Attempts.ValueChanged += new System.EventHandler(this.Attempts_ValueChanged);
            // 
            // AttemptsLabel
            // 
            resources.ApplyResources(this.AttemptsLabel, "AttemptsLabel");
            this.AttemptsLabel.Name = "AttemptsLabel";
            this.TheToolTip.SetToolTip(this.AttemptsLabel, resources.GetString("AttemptsLabel.ToolTip"));
            // 
            // ProxyForVideo
            // 
            resources.ApplyResources(this.ProxyForVideo, "ProxyForVideo");
            this.ProxyForVideo.Name = "ProxyForVideo";
            this.TheToolTip.SetToolTip(this.ProxyForVideo, resources.GetString("ProxyForVideo.ToolTip"));
            this.ProxyForVideo.UseVisualStyleBackColor = true;
            this.ProxyForVideo.CheckedChanged += new System.EventHandler(this.ProxyForVideo_CheckedChanged);
            // 
            // UseSeasons
            // 
            resources.ApplyResources(this.UseSeasons, "UseSeasons");
            this.UseSeasons.Name = "UseSeasons";
            this.TheToolTip.SetToolTip(this.UseSeasons, resources.GetString("UseSeasons.ToolTip"));
            this.UseSeasons.UseVisualStyleBackColor = true;
            this.UseSeasons.CheckedChanged += new System.EventHandler(this.UseSeasons_CheckedChanged);
            // 
            // UseEpisodes
            // 
            resources.ApplyResources(this.UseEpisodes, "UseEpisodes");
            this.UseEpisodes.Name = "UseEpisodes";
            this.TheToolTip.SetToolTip(this.UseEpisodes, resources.GetString("UseEpisodes.ToolTip"));
            this.UseEpisodes.UseVisualStyleBackColor = true;
            this.UseEpisodes.CheckedChanged += new System.EventHandler(this.UseEpisodes_CheckedChanged);
            // 
            // UseResolution
            // 
            resources.ApplyResources(this.UseResolution, "UseResolution");
            this.UseResolution.Name = "UseResolution";
            this.TheToolTip.SetToolTip(this.UseResolution, resources.GetString("UseResolution.ToolTip"));
            this.UseResolution.UseVisualStyleBackColor = true;
            this.UseResolution.CheckedChanged += new System.EventHandler(this.UseResolution_CheckedChanged);
            // 
            // TheToolTip
            // 
            this.TheToolTip.AutomaticDelay = 60000;
            this.TheToolTip.AutoPopDelay = 60000;
            this.TheToolTip.InitialDelay = 500;
            this.TheToolTip.IsBalloon = true;
            this.TheToolTip.ReshowDelay = 500;
            this.TheToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TheToolTip.ToolTipTitle = "Information";
            // 
            // NoProgressBar
            // 
            resources.ApplyResources(this.NoProgressBar, "NoProgressBar");
            this.NoProgressBar.Name = "NoProgressBar";
            this.TheToolTip.SetToolTip(this.NoProgressBar, resources.GetString("NoProgressBar.ToolTip"));
            this.NoProgressBar.UseVisualStyleBackColor = true;
            this.NoProgressBar.CheckedChanged += new System.EventHandler(this.NoProgressBar_CheckedChanged);
            // 
            // CookiesFile
            // 
            resources.ApplyResources(this.CookiesFile, "CookiesFile");
            this.CookiesFile.Name = "CookiesFile";
            this.TheToolTip.SetToolTip(this.CookiesFile, resources.GetString("CookiesFile.ToolTip"));
            this.CookiesFile.UseVisualStyleBackColor = true;
            this.CookiesFile.CheckedChanged += new System.EventHandler(this.CookiesFile_CheckedChanged);
            // 
            // CookiesFilePath
            // 
            resources.ApplyResources(this.CookiesFilePath, "CookiesFilePath");
            this.CookiesFilePath.Name = "CookiesFilePath";
            this.TheToolTip.SetToolTip(this.CookiesFilePath, resources.GetString("CookiesFilePath.ToolTip"));
            this.CookiesFilePath.TextChanged += new System.EventHandler(this.CookiesFilePath_TextChanged);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CookiesFilePath);
            this.Controls.Add(this.CookiesFile);
            this.Controls.Add(this.NoProgressBar);
            this.Controls.Add(this.UseResolution);
            this.Controls.Add(this.UseEpisodes);
            this.Controls.Add(this.UseSeasons);
            this.Controls.Add(this.ProxyForVideo);
            this.Controls.Add(this.Attempts);
            this.Controls.Add(this.AttemptsLabel);
            this.Controls.Add(this.Episodes);
            this.Controls.Add(this.Seasons);
            this.Controls.Add(this.ConnectionsNumber);
            this.Controls.Add(this.ConnectionsNumberLabel);
            this.Controls.Add(this.DefaultSubtitle);
            this.Controls.Add(this.DefaultSubtitleLabel);
            this.Controls.Add(this.Resolution);
            this.Controls.Add(this.UseProxy);
            this.Controls.Add(this.Proxy);
            this.Controls.Add(this.ProxyLabel);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.URLLabel);
            this.Controls.Add(this.TypeControl);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.AccountGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.TheToolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.AccountGroupBox.ResumeLayout(false);
            this.AccountGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TypeControl.ResumeLayout(false);
            this.Softsub.ResumeLayout(false);
            this.Softsub.PerformLayout();
            this.Hardsub.ResumeLayout(false);
            this.Hardsub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attempts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AccountGroupBox;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox EmailOrUserName;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label EmailOrUserNameLabel;
        private System.Windows.Forms.Label CookiesFileLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem LanguageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EnglishLanguage;
        private System.Windows.Forms.ToolStripMenuItem ArabicLanguage;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label CookiesFileNotFound;
        private System.Windows.Forms.Label CookiesFileFound;
        private System.Windows.Forms.TabControl TypeControl;
        private System.Windows.Forms.TabPage Softsub;
        private System.Windows.Forms.TabPage Hardsub;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Label URLLabel;
        private System.Windows.Forms.Button DeleteLoginFile;
        private System.Windows.Forms.TextBox Proxy;
        private System.Windows.Forms.Label ProxyLabel;
        private System.Windows.Forms.CheckBox UseProxy;
        private System.Windows.Forms.ComboBox SiteLanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangeLanguage;
        private System.Windows.Forms.ToolStripMenuItem cRdlGithubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRdlguiGithubToolStripMenuItem;
        private System.Windows.Forms.ComboBox Resolution;
        private System.Windows.Forms.Label DefaultSubtitleLabel;
        private System.Windows.Forms.ComboBox DefaultSubtitle;
        private System.Windows.Forms.CheckBox SpecifySubtitleLanguages;
        private System.Windows.Forms.ListBox SubtitleLanguages;
        private System.Windows.Forms.Label ConnectionsNumberLabel;
        private System.Windows.Forms.NumericUpDown ConnectionsNumber;
        private System.Windows.Forms.CheckBox AttachFonts;
        private System.Windows.Forms.TextBox Seasons;
        private System.Windows.Forms.TextBox Episodes;
        private System.Windows.Forms.NumericUpDown Attempts;
        private System.Windows.Forms.Label AttemptsLabel;
        private System.Windows.Forms.CheckBox LegacyPlayer;
        private System.Windows.Forms.CheckBox ProxyForVideo;
        private System.Windows.Forms.TextBox SoftsubSaveDirectory;
        private System.Windows.Forms.Label SoftsubSaveDirectoryLabel;
        private System.Windows.Forms.TextBox HardsubSaveDirectory;
        private System.Windows.Forms.Label HardsubSaveDirectoryLabel;
        private System.Windows.Forms.CheckBox SubtitltesOnly;
        private System.Windows.Forms.CheckBox ListSubtitles;
        private System.Windows.Forms.Button ExecuteSoftsubCommand;
        private System.Windows.Forms.TextBox SoftsubCommand;
        private System.Windows.Forms.Button ExecuteHardsubCommand;
        private System.Windows.Forms.TextBox HardsubCommand;
        private System.Windows.Forms.CheckBox UseSeasons;
        private System.Windows.Forms.CheckBox UseEpisodes;
        private System.Windows.Forms.CheckBox UseResolution;
        private System.Windows.Forms.ToolTip TheToolTip;
        private System.Windows.Forms.CheckBox NoProgressBar;
        private System.Windows.Forms.CheckBox CookiesFile;
        private System.Windows.Forms.TextBox CookiesFilePath;
        private System.Windows.Forms.Button SoftsubSaveButton;
        private System.Windows.Forms.Button HardsubSaveButton;
        private System.Windows.Forms.Button MakeLoginBatchFile;
    }
}

