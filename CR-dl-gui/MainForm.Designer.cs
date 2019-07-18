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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AccountGroupBox = new System.Windows.Forms.GroupBox();
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
            this.Season = new System.Windows.Forms.NumericUpDown();
            this.Episode = new System.Windows.Forms.NumericUpDown();
            this.UseSeason = new System.Windows.Forms.CheckBox();
            this.UseEpisode = new System.Windows.Forms.CheckBox();
            this.AccountGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.TypeControl.SuspendLayout();
            this.Softsub.SuspendLayout();
            this.Hardsub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attempts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Season)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Episode)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountGroupBox
            // 
            resources.ApplyResources(this.AccountGroupBox, "AccountGroupBox");
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
            // 
            // ChangeLanguage
            // 
            resources.ApplyResources(this.ChangeLanguage, "ChangeLanguage");
            this.ChangeLanguage.Name = "ChangeLanguage";
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
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // DeleteLoginFile
            // 
            resources.ApplyResources(this.DeleteLoginFile, "DeleteLoginFile");
            this.DeleteLoginFile.ForeColor = System.Drawing.Color.Red;
            this.DeleteLoginFile.Name = "DeleteLoginFile";
            this.DeleteLoginFile.UseVisualStyleBackColor = true;
            this.DeleteLoginFile.Click += new System.EventHandler(this.DeleteLoginFile_Click);
            // 
            // CookiesFileNotFound
            // 
            resources.ApplyResources(this.CookiesFileNotFound, "CookiesFileNotFound");
            this.CookiesFileNotFound.ForeColor = System.Drawing.Color.Red;
            this.CookiesFileNotFound.Name = "CookiesFileNotFound";
            // 
            // CookiesFileFound
            // 
            resources.ApplyResources(this.CookiesFileFound, "CookiesFileFound");
            this.CookiesFileFound.ForeColor = System.Drawing.Color.Green;
            this.CookiesFileFound.Name = "CookiesFileFound";
            // 
            // ShowPassword
            // 
            resources.ApplyResources(this.ShowPassword, "ShowPassword");
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // Login
            // 
            resources.ApplyResources(this.Login, "Login");
            this.Login.Name = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Password
            // 
            resources.ApplyResources(this.Password, "Password");
            this.Password.Name = "Password";
            this.Password.UseSystemPasswordChar = true;
            // 
            // EmailOrUserName
            // 
            resources.ApplyResources(this.EmailOrUserName, "EmailOrUserName");
            this.EmailOrUserName.Name = "EmailOrUserName";
            // 
            // PasswordLabel
            // 
            resources.ApplyResources(this.PasswordLabel, "PasswordLabel");
            this.PasswordLabel.Name = "PasswordLabel";
            // 
            // EmailOrUserNameLabel
            // 
            resources.ApplyResources(this.EmailOrUserNameLabel, "EmailOrUserNameLabel");
            this.EmailOrUserNameLabel.Name = "EmailOrUserNameLabel";
            // 
            // CookiesFileLabel
            // 
            resources.ApplyResources(this.CookiesFileLabel, "CookiesFileLabel");
            this.CookiesFileLabel.Name = "CookiesFileLabel";
            // 
            // Save
            // 
            resources.ApplyResources(this.Save, "Save");
            this.Save.Name = "Save";
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
            // 
            // Softsub
            // 
            resources.ApplyResources(this.Softsub, "Softsub");
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
            this.Softsub.UseVisualStyleBackColor = true;
            // 
            // ExecuteSoftsubCommand
            // 
            resources.ApplyResources(this.ExecuteSoftsubCommand, "ExecuteSoftsubCommand");
            this.ExecuteSoftsubCommand.Name = "ExecuteSoftsubCommand";
            this.ExecuteSoftsubCommand.UseVisualStyleBackColor = true;
            this.ExecuteSoftsubCommand.Click += new System.EventHandler(this.ExecuteSoftsubCommand_Click);
            // 
            // SoftsubCommand
            // 
            resources.ApplyResources(this.SoftsubCommand, "SoftsubCommand");
            this.SoftsubCommand.Name = "SoftsubCommand";
            this.SoftsubCommand.ReadOnly = true;
            // 
            // ListSubtitles
            // 
            resources.ApplyResources(this.ListSubtitles, "ListSubtitles");
            this.ListSubtitles.Name = "ListSubtitles";
            this.ListSubtitles.UseVisualStyleBackColor = true;
            this.ListSubtitles.CheckedChanged += new System.EventHandler(this.ListSubtitles_CheckedChanged);
            // 
            // SubtitltesOnly
            // 
            resources.ApplyResources(this.SubtitltesOnly, "SubtitltesOnly");
            this.SubtitltesOnly.Name = "SubtitltesOnly";
            this.SubtitltesOnly.UseVisualStyleBackColor = true;
            this.SubtitltesOnly.CheckedChanged += new System.EventHandler(this.SubtitltesOnly_CheckedChanged);
            // 
            // SoftsubSaveDirectory
            // 
            resources.ApplyResources(this.SoftsubSaveDirectory, "SoftsubSaveDirectory");
            this.SoftsubSaveDirectory.Name = "SoftsubSaveDirectory";
            this.SoftsubSaveDirectory.TextChanged += new System.EventHandler(this.SoftsubSaveDirectory_TextChanged);
            // 
            // SoftsubSaveDirectoryLabel
            // 
            resources.ApplyResources(this.SoftsubSaveDirectoryLabel, "SoftsubSaveDirectoryLabel");
            this.SoftsubSaveDirectoryLabel.Name = "SoftsubSaveDirectoryLabel";
            // 
            // LegacyPlayer
            // 
            resources.ApplyResources(this.LegacyPlayer, "LegacyPlayer");
            this.LegacyPlayer.Checked = true;
            this.LegacyPlayer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LegacyPlayer.Name = "LegacyPlayer";
            this.LegacyPlayer.UseVisualStyleBackColor = true;
            this.LegacyPlayer.CheckedChanged += new System.EventHandler(this.LegacyPlayer_CheckedChanged);
            // 
            // AttachFonts
            // 
            resources.ApplyResources(this.AttachFonts, "AttachFonts");
            this.AttachFonts.Checked = true;
            this.AttachFonts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AttachFonts.Name = "AttachFonts";
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
            this.SubtitleLanguages.SelectedIndexChanged += new System.EventHandler(this.SubtitleLanguages_SelectedIndexChanged);
            // 
            // SpecifySubtitleLanguages
            // 
            resources.ApplyResources(this.SpecifySubtitleLanguages, "SpecifySubtitleLanguages");
            this.SpecifySubtitleLanguages.Name = "SpecifySubtitleLanguages";
            this.SpecifySubtitleLanguages.UseVisualStyleBackColor = true;
            this.SpecifySubtitleLanguages.CheckedChanged += new System.EventHandler(this.SpecifySubtitleLanguages_CheckedChanged);
            // 
            // Hardsub
            // 
            resources.ApplyResources(this.Hardsub, "Hardsub");
            this.Hardsub.Controls.Add(this.ExecuteHardsubCommand);
            this.Hardsub.Controls.Add(this.HardsubCommand);
            this.Hardsub.Controls.Add(this.HardsubSaveDirectory);
            this.Hardsub.Controls.Add(this.HardsubSaveDirectoryLabel);
            this.Hardsub.Name = "Hardsub";
            this.Hardsub.UseVisualStyleBackColor = true;
            // 
            // ExecuteHardsubCommand
            // 
            resources.ApplyResources(this.ExecuteHardsubCommand, "ExecuteHardsubCommand");
            this.ExecuteHardsubCommand.Name = "ExecuteHardsubCommand";
            this.ExecuteHardsubCommand.UseVisualStyleBackColor = true;
            this.ExecuteHardsubCommand.Click += new System.EventHandler(this.ExecuteHardsubCommand_Click);
            // 
            // HardsubCommand
            // 
            resources.ApplyResources(this.HardsubCommand, "HardsubCommand");
            this.HardsubCommand.Name = "HardsubCommand";
            this.HardsubCommand.ReadOnly = true;
            // 
            // HardsubSaveDirectory
            // 
            resources.ApplyResources(this.HardsubSaveDirectory, "HardsubSaveDirectory");
            this.HardsubSaveDirectory.Name = "HardsubSaveDirectory";
            this.HardsubSaveDirectory.TextChanged += new System.EventHandler(this.HardsubSaveDirectory_TextChanged);
            // 
            // HardsubSaveDirectoryLabel
            // 
            resources.ApplyResources(this.HardsubSaveDirectoryLabel, "HardsubSaveDirectoryLabel");
            this.HardsubSaveDirectoryLabel.Name = "HardsubSaveDirectoryLabel";
            // 
            // URL
            // 
            resources.ApplyResources(this.URL, "URL");
            this.URL.Name = "URL";
            this.URL.TextChanged += new System.EventHandler(this.URL_TextChanged);
            // 
            // URLLabel
            // 
            resources.ApplyResources(this.URLLabel, "URLLabel");
            this.URLLabel.Name = "URLLabel";
            // 
            // Proxy
            // 
            resources.ApplyResources(this.Proxy, "Proxy");
            this.Proxy.Name = "Proxy";
            this.Proxy.TextChanged += new System.EventHandler(this.Proxy_TextChanged);
            // 
            // ProxyLabel
            // 
            resources.ApplyResources(this.ProxyLabel, "ProxyLabel");
            this.ProxyLabel.Name = "ProxyLabel";
            // 
            // UseProxy
            // 
            resources.ApplyResources(this.UseProxy, "UseProxy");
            this.UseProxy.Name = "UseProxy";
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
            this.Resolution.SelectedIndexChanged += new System.EventHandler(this.Resolution_SelectedIndexChanged);
            // 
            // DefaultSubtitleLabel
            // 
            resources.ApplyResources(this.DefaultSubtitleLabel, "DefaultSubtitleLabel");
            this.DefaultSubtitleLabel.Name = "DefaultSubtitleLabel";
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
            this.DefaultSubtitle.SelectedIndexChanged += new System.EventHandler(this.DefaultSubtitle_SelectedIndexChanged);
            // 
            // ConnectionsNumberLabel
            // 
            resources.ApplyResources(this.ConnectionsNumberLabel, "ConnectionsNumberLabel");
            this.ConnectionsNumberLabel.Name = "ConnectionsNumberLabel";
            // 
            // ConnectionsNumber
            // 
            resources.ApplyResources(this.ConnectionsNumber, "ConnectionsNumber");
            this.ConnectionsNumber.Name = "ConnectionsNumber";
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
            this.Seasons.TextChanged += new System.EventHandler(this.Seasons_TextChanged);
            // 
            // Episodes
            // 
            resources.ApplyResources(this.Episodes, "Episodes");
            this.Episodes.Name = "Episodes";
            this.Episodes.TextChanged += new System.EventHandler(this.Episodes_TextChanged);
            // 
            // Attempts
            // 
            resources.ApplyResources(this.Attempts, "Attempts");
            this.Attempts.Name = "Attempts";
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
            // 
            // ProxyForVideo
            // 
            resources.ApplyResources(this.ProxyForVideo, "ProxyForVideo");
            this.ProxyForVideo.Name = "ProxyForVideo";
            this.ProxyForVideo.UseVisualStyleBackColor = true;
            this.ProxyForVideo.CheckedChanged += new System.EventHandler(this.ProxyForVideo_CheckedChanged);
            // 
            // UseSeasons
            // 
            resources.ApplyResources(this.UseSeasons, "UseSeasons");
            this.UseSeasons.Name = "UseSeasons";
            this.UseSeasons.UseVisualStyleBackColor = true;
            this.UseSeasons.CheckedChanged += new System.EventHandler(this.UseSeasons_CheckedChanged);
            // 
            // UseEpisodes
            // 
            resources.ApplyResources(this.UseEpisodes, "UseEpisodes");
            this.UseEpisodes.Name = "UseEpisodes";
            this.UseEpisodes.UseVisualStyleBackColor = true;
            this.UseEpisodes.CheckedChanged += new System.EventHandler(this.UseEpisodes_CheckedChanged);
            // 
            // UseResolution
            // 
            resources.ApplyResources(this.UseResolution, "UseResolution");
            this.UseResolution.Name = "UseResolution";
            this.UseResolution.UseVisualStyleBackColor = true;
            this.UseResolution.CheckedChanged += new System.EventHandler(this.UseResolution_CheckedChanged);
            // 
            // Season
            // 
            resources.ApplyResources(this.Season, "Season");
            this.Season.Name = "Season";
            this.Season.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Season.ValueChanged += new System.EventHandler(this.Season_ValueChanged);
            // 
            // Episode
            // 
            resources.ApplyResources(this.Episode, "Episode");
            this.Episode.Name = "Episode";
            this.Episode.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Episode.ValueChanged += new System.EventHandler(this.Episode_ValueChanged);
            // 
            // UseSeason
            // 
            resources.ApplyResources(this.UseSeason, "UseSeason");
            this.UseSeason.Name = "UseSeason";
            this.UseSeason.UseVisualStyleBackColor = true;
            this.UseSeason.CheckedChanged += new System.EventHandler(this.UseSeason_CheckedChanged);
            // 
            // UseEpisode
            // 
            resources.ApplyResources(this.UseEpisode, "UseEpisode");
            this.UseEpisode.Name = "UseEpisode";
            this.UseEpisode.UseVisualStyleBackColor = true;
            this.UseEpisode.CheckedChanged += new System.EventHandler(this.UseEpisode_CheckedChanged);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UseEpisode);
            this.Controls.Add(this.UseSeason);
            this.Controls.Add(this.Episode);
            this.Controls.Add(this.Season);
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
            ((System.ComponentModel.ISupportInitialize)(this.Season)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Episode)).EndInit();
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
        private System.Windows.Forms.NumericUpDown Season;
        private System.Windows.Forms.NumericUpDown Episode;
        private System.Windows.Forms.CheckBox UseSeason;
        private System.Windows.Forms.CheckBox UseEpisode;
    }
}

