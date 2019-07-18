using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace CR_dl_gui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateEverything()
        {
            CheckAvailableLanguages();
            UpdateUIElementsStatus();
            CheckCookiesFile();
            this.ActiveControl = URL;
        }

        private void CheckAvailableLanguages()
        {
            //Checks Arabic Languages
            if (File.Exists("ar/CR-dl-gui.resources.dll"))
            {
                LanguageMenuItem.Visible = true;
                ArabicLanguage.Visible = true;
                EnglishLanguage.Visible = true;
            }
        }

        private void UpdateUIElementsStatus()
        {

            // Account settings
            EmailOrUserName.Text = Properties.Settings.Default.EmailOrUserName;
            Password.Text = Properties.Settings.Default.Password;
            SiteLanguage.Text = Properties.Settings.Default.SiteLanguage;

            // Main settings

            Proxy.Text = Properties.Settings.Default.Proxy;
            UseProxy.Checked = Properties.Settings.Default.UseProxy;
            ProxyForVideo.Checked = Properties.Settings.Default.ProxyForVideo;
            Resolution.Text = Properties.Settings.Default.Resolution;
            UseResolution.Checked = Properties.Settings.Default.UseResolution;
            DefaultSubtitle.Text = Properties.Settings.Default.DefaultSubtitle;
            ConnectionsNumber.Value = Properties.Settings.Default.ConnectionsNumber;
            Attempts.Value = Properties.Settings.Default.Attempts;

            UseSeasons.Checked = Properties.Settings.Default.UseSeasons;
            Seasons.Text = Properties.Settings.Default.Seasons;

            UseEpisodes.Checked = Properties.Settings.Default.UseEpisodes;
            Episodes.Text = Properties.Settings.Default.Episodes;


            // Softsub settings
            AttachFonts.Checked = Properties.Settings.Default.AttacheFonts;
            LegacyPlayer.Checked = Properties.Settings.Default.LegacyPlayer;
            SubtitltesOnly.Checked = Properties.Settings.Default.SubtitltesOnly;
            ListSubtitles.Checked = Properties.Settings.Default.ListSubtitles;
            SoftsubSaveDirectory.Text = Properties.Settings.Default.SoftsubSaveDirectory;
            SpecifySubtitleLanguages.Checked = Properties.Settings.Default.SpecifySubtitleLanguages;
            
            // Load selected subtitle languages
            if(Properties.Settings.Default.SubtitleLanguages != "")
            {
                var selected = Properties.Settings.Default.SubtitleLanguages.Split(',').Select(Int32.Parse).ToList();
                foreach (int index in selected)
                {
                    SubtitleLanguages.SetSelected(index, true);
                }
            }
           

            // Hardsub settings
            HardsubSaveDirectory.Text = Properties.Settings.Default.HardsubSaveDirectory;

        }

        public void CheckCookiesFile()
        {
            if (File.Exists("cookies.data"))
            {
                CookiesFileFound.Visible = true;
                CookiesFileNotFound.Visible = false;
            }
            else
            {
                CookiesFileNotFound.Visible = true;
                CookiesFileFound.Visible = false;
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

            //Load Saved language
            if(Properties.Settings.Default.language != "")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(Properties.Settings.Default.language);
                Controls.Clear();
                InitializeComponent();
                this.RightToLeft = (Properties.Settings.Default.RightToLeft) ? RightToLeft.Yes : RightToLeft.No;
                this.RightToLeftLayout = Properties.Settings.Default.RightToLeftLayout;
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            }

            //Load settings
            UpdateEverything();

        }

        private void EnglishLanguage_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.language = "en";
            Properties.Settings.Default.RightToLeft = false;
            Properties.Settings.Default.RightToLeftLayout = false;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            Controls.Clear();
            InitializeComponent();
            this.RightToLeft = RightToLeft.No;
            this.RightToLeftLayout = false;

            //Load settings
            UpdateEverything();
        }

        private void ArabicLanguage_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.language = "ar";
            Properties.Settings.Default.RightToLeft = true;
            Properties.Settings.Default.RightToLeftLayout = true;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar");
            Controls.Clear();
            InitializeComponent();
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;

            //Load settings
            UpdateEverything();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }

        private void DefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.language = "";
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
            Controls.Clear();
            InitializeComponent();

            //Load settings
            UpdateEverything();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string command = "login ";
            command += "\"" + EmailOrUserName.Text + "\" ";
            command += "\"" + Password.Text + "\" ";
            //command += "\"" + SiteLanguage.Text + "\" ";
            if (UseProxy.Checked)
            {
                command += "--httpProxy \"" + Proxy.Text + "\"";
            }
            System.Diagnostics.Process login = new System.Diagnostics.Process();
            login.StartInfo.FileName = "cr-dl.exe";
            login.StartInfo.Arguments = command;
            login.EnableRaisingEvents = true;
            login.Start();
            login.WaitForExit();
            CheckCookiesFile();
        }

        private void Save_Click(object sender, EventArgs e)
        {

            // Account settings
            Properties.Settings.Default.EmailOrUserName = EmailOrUserName.Text;
            Properties.Settings.Default.Password = Password.Text;
            Properties.Settings.Default.SiteLanguage = SiteLanguage.Text;

            // Main settings
            Properties.Settings.Default.Proxy = Proxy.Text;
            Properties.Settings.Default.UseProxy = UseProxy.Checked;
            Properties.Settings.Default.ProxyForVideo = ProxyForVideo.Checked;

            Properties.Settings.Default.UseResolution = UseResolution.Checked;
            Properties.Settings.Default.Resolution = Resolution.Text;

            Properties.Settings.Default.DefaultSubtitle = DefaultSubtitle.Text;
            Properties.Settings.Default.ConnectionsNumber = (int) ConnectionsNumber.Value;
            Properties.Settings.Default.Attempts = (int) Attempts.Value;

            Properties.Settings.Default.UseSeasons = UseSeasons.Checked;
            Properties.Settings.Default.Seasons = Seasons.Text;

            Properties.Settings.Default.UseEpisodes = UseEpisodes.Checked;
            Properties.Settings.Default.Episodes = Episodes.Text;


            // Softsub settings
            Properties.Settings.Default.SpecifySubtitleLanguages = SpecifySubtitleLanguages.Checked;
            // Save selected subtitle languages
            var SL = "";
            foreach (var item in SubtitleLanguages.SelectedIndices)
            {
                SL += item + ",";
            }
            SL = SL.TrimEnd(',');
            Properties.Settings.Default.SubtitleLanguages = SL;
            Properties.Settings.Default.AttacheFonts = AttachFonts.Checked;
            Properties.Settings.Default.LegacyPlayer = LegacyPlayer.Checked;
            Properties.Settings.Default.SubtitltesOnly = SubtitltesOnly.Checked;
            Properties.Settings.Default.ListSubtitles = ListSubtitles.Checked;
            Properties.Settings.Default.SoftsubSaveDirectory = SoftsubSaveDirectory.Text;

            // Hardsub settings
            Properties.Settings.Default.HardsubSaveDirectory = HardsubSaveDirectory.Text;



           
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            MessageBox.Show(Properties.Strings.SaveMessageBody, Properties.Strings.SaveMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteLoginFile_Click(object sender, EventArgs e)
        {
            File.Delete("cookies.data");
            CheckCookiesFile();
        }

        private void ChangeLanguage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process login = new System.Diagnostics.Process();
            login.StartInfo.FileName = "cr-dl";
            login.StartInfo.Arguments = "language " + SiteLanguage.Text;
            login.EnableRaisingEvents = true;
            login.Start();
            login.WaitForExit();
        }

        private void CRdlGithubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DasKraken/CR-dl");
        }

        private void CRdlguiGithubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Abu3safeer/CR-dl-gui");
        }

        private void SpecifySubtitleLanguages_CheckedChanged(object sender, EventArgs e)
        {
            if(SpecifySubtitleLanguages.Checked)
            {
                SubtitleLanguages.Enabled = true;
            }
            else
            {
                SubtitleLanguages.Enabled = false;
            }
            CommandPrepare();
        }

        private void UseResolution_CheckedChanged(object sender, EventArgs e)
        {
            if(UseResolution.Checked)
            {
                Resolution.Enabled = true;
            }
            else
            {
                Resolution.Enabled = false;
            }
            CommandPrepare();
        }

        private void UseSeasons_CheckedChanged(object sender, EventArgs e)
        {
            if(UseSeasons.Checked)
            {
                Seasons.Enabled = true;
                UseSeason.Checked = false;
            }
            else
            {
                Seasons.Enabled = false;
            }
            CommandPrepare();
        }

        private void UseEpisodes_CheckedChanged(object sender, EventArgs e)
        {
            if (UseEpisodes.Checked)
            {
                Episodes.Enabled = true;
                UseEpisode.Checked = false;
            }
            else
            {
                Episodes.Enabled = false;
            }
            CommandPrepare();
        }

        private void UseSeason_CheckedChanged(object sender, EventArgs e)
        {
            if (UseSeason.Checked)
            {
                Season.Enabled = true;
                UseSeasons.Checked = false;
            }
            else
            {
                Season.Enabled = false;
            }
            CommandPrepare();
        }

        private void UseEpisode_CheckedChanged(object sender, EventArgs e)
        {
            if (UseEpisode.Checked)
            {
                Episode.Enabled = true;
                UseEpisodes.Checked = false;
            }
            else
            {
                Episode.Enabled = false;
            }
            CommandPrepare();
        }


        private void URL_TextChanged(object sender, EventArgs e)
        {
            CommandPrepare();
        }

        private void Proxy_TextChanged(object sender, EventArgs e)
        {
            CommandPrepare();
        }

        private void UseProxy_CheckedChanged(object sender, EventArgs e)
        {
            CommandPrepare();
        }

        private void ProxyForVideo_CheckedChanged(object sender, EventArgs e)
        {
            CommandPrepare();
        }

        private void Resolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommandPrepare();
        }

        private void DefaultSubtitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommandPrepare();
        }

        private void ConnectionsNumber_ValueChanged(object sender, EventArgs e)
        {
            CommandPrepare();
        }

        private void Attempts_ValueChanged(object sender, EventArgs e)
        {
            CommandPrepare();
        }

        private void Season_ValueChanged(object sender, EventArgs e)
        {
            CommandPrepare();
        }

        private void Seasons_TextChanged(object sender, EventArgs e)
        {
            CommandPrepare();
        }

        private void Episode_ValueChanged(object sender, EventArgs e)
        {
            CommandPrepare();
        }

        private void Episodes_TextChanged(object sender, EventArgs e)
        {
            CommandPrepare();
        }

        private void SoftsubSaveDirectory_TextChanged(object sender, EventArgs e)
        {
            CommandPrepare();
        }

        private void SubtitleLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommandPrepare();
        }

        private void AttachFonts_CheckedChanged(object sender, EventArgs e)
        {
            CommandPrepare();
        }

        private void LegacyPlayer_CheckedChanged(object sender, EventArgs e)
        {
            CommandPrepare();
        }

        private void SubtitltesOnly_CheckedChanged(object sender, EventArgs e)
        {
            CommandPrepare();
        }

        private void ListSubtitles_CheckedChanged(object sender, EventArgs e)
        {
            CommandPrepare();
        }

        private void HardsubSaveDirectory_TextChanged(object sender, EventArgs e)
        {
            CommandPrepare();
        }

        public void CommandPrepare()
        {
            string Command = "download ";

            // Default subtitle
            Command += "-l \"" + DefaultSubtitle.Text + "\" ";

            // Proxy
            if (UseProxy.Checked)
            {
                Command += "--httpProxy \"" + Proxy.Text + "\" ";
            }
            if (ProxyForVideo.Checked)
            {
                Command += "--httpProxyCdn \"" + Proxy.Text + "\" ";
            }

            // Connections
            Command += "-c \"" + ConnectionsNumber.Text + "\" ";

            // Attmepts
            Command += "--maxAttempts \"" + Attempts.Text + "\" ";

            // Season
            if (UseSeason.Checked)
            {
                Command += "--season \"" + Season.Text + "\" ";
            }
            else if (UseSeasons.Checked)
            {
                Command += "--seasons \"" + Seasons.Text + "\" ";
            }

            //Episdoes
            if (UseEpisode.Checked)
            {
                Command += "--episode \"" + Episode.Text + "\" ";
            }
            else if (UseEpisodes.Checked)
            {
                Command += "--episodes \"" + Episodes.Text + "\" ";
            }

            GenerateSoftsubCommand(Command);
            GenerateHardsubCommand(Command);

        }

        public string AddURLandResolution(string Command)
        {
            Command += " \"" + URL.Text + "\"";
            if(UseResolution.Checked)
            {
                Command += " \"" + Resolution.Text + "\"";
            }
            return Command;
        }

        public void GenerateSoftsubCommand(string Command)
        {

            if(SpecifySubtitleLanguages.Checked)
            {
                // Get selected subtitle languages
                var SL = "";
                foreach (var item in SubtitleLanguages.SelectedIndices)
                {
                    SL += SubtitleLanguages.Items[(int)item].ToString() + ",";
                }
                SL = SL.TrimEnd(',');

                Command += "--subLangs \"" + SL + "\" ";
            }
            
            if(AttachFonts.Checked)
            {
                Command += "--attachFonts ";
            }
            if(LegacyPlayer.Checked)
            {
                Command += "--legacyPlayer ";
            }
            if(SubtitltesOnly.Checked)
            {
                Command += "--subsOnly ";
            }
            if (ListSubtitles.Checked)
            {
                Command += "--listSubs ";
            }

            Command += "-o \"" + SoftsubSaveDirectory.Text + "\"";

            Command = AddURLandResolution(Command);

            SoftsubCommand.Text = Command;

        }

        public void GenerateHardsubCommand(string Command)
        {
            Command += "--hardsub ";
            Command += "-o \"" + HardsubSaveDirectory.Text + "\"";
            Command = AddURLandResolution(Command);
            HardsubCommand.Text = Command;
        }

        private void ExecuteSoftsubCommand_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cr-dl.exe", SoftsubCommand.Text);
        }

        private void ExecuteHardsubCommand_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cr-dl.exe",HardsubCommand.Text);
        }
    }
}
