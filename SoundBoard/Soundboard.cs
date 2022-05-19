using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace SoundBoard
{
    public partial class Soundboard : Form
    {
        public Soundboard()
        {
            InitializeComponent();
        }

        // INITIALIZE SOUNDPLAYER AND SETTINGSPAGE
        SoundPlayer currentsound;
        Settings settings = new Settings();

        // PLAY DEFAULT SOUNDS
        private void soundbtn1_Click(object sender, EventArgs e)
        {
            currentsound = new SoundPlayer(Properties.Resources.Fart);
            currentsound.Play();
        }
        private void soundbtn2_Click(object sender, EventArgs e)
        {
            currentsound = new SoundPlayer(Properties.Resources.LawAndOrder);
            currentsound.Play();
        }
        private void soundbtn3_Click(object sender, EventArgs e)
        {
            currentsound = new SoundPlayer(Properties.Resources.Airhorn);
            currentsound.Play();
        }

        // PLAY CUSTOM SOUNDS
        private void cstmsoundbtn1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default["customSound1Path"].ToString()))
            {
                if (currentsound != null)
                {
                    currentsound.Stop();
                }
            }
            else
            {
                // CHECK IF CUSTOMDIRECTORY EXISTS
                try
                {
                    if (Directory.Exists(settings.CustomDirectoryPath))
                    {
                        string currentSoundFile = Properties.Settings.Default["customSound1Path"].ToString();
                        // CHECK IF FILE WITHIN CUSTOMDIRECTORY EXISTS
                        if (File.Exists(currentSoundFile))
                        {
                            string selectedFilePath = Properties.Settings.Default["customSound1Path"].ToString();
                            currentsound = new SoundPlayer(@"" + selectedFilePath);
                            currentsound.Play();
                        }
                        else { System.Windows.Forms.MessageBox.Show($"File doesn't exist within {settings.CustomDirectoryPath}"); }
                    }
                    else { System.Windows.Forms.MessageBox.Show("Custom sounds directory doesn't exist, go to settings to add custom sounds."); }
                }
                catch { return; }
            }
        }
        private void cstmsoundbtn2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default["customSound2Path"].ToString()))
            {
                if (currentsound != null)
                {
                    currentsound.Stop();
                }
            }
            else
            {
                // CHECK IF CUSTOMDIRECTORY EXISTS
                try
                {
                    if (Directory.Exists(settings.CustomDirectoryPath))
                    {
                        string currentSoundFile = Properties.Settings.Default["customSound2Path"].ToString();
                        // CHECK IF FILE WITHIN CUSTOMDIRECTORY EXISTS
                        if (File.Exists(currentSoundFile))
                        {
                            string selectedFilePath = Properties.Settings.Default["customSound2Path"].ToString();
                            currentsound = new SoundPlayer(@"" + selectedFilePath);
                            currentsound.Play();
                        }
                        else { System.Windows.Forms.MessageBox.Show($"File doesn't exist within {settings.CustomDirectoryPath}"); }
                    }
                    else { System.Windows.Forms.MessageBox.Show("Custom sounds directory doesn't exist, go to settings to add custom sounds."); }
                }
                catch { return; }
            }
        }
        private void cstmsoundbtn3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default["customSound3Path"].ToString()))
            {
                if (currentsound != null)
                {
                    currentsound.Stop();
                }
            }
            else
            {
                // CHECK IF CUSTOMDIRECTORY EXISTS
                try
                {
                    if (Directory.Exists(settings.CustomDirectoryPath))
                    {
                        string currentSoundFile = Properties.Settings.Default["customSound3Path"].ToString();
                        // CHECK IF FILE WITHIN CUSTOMDIRECTORY EXISTS
                        if (File.Exists(currentSoundFile))
                        {
                            string selectedFilePath = Properties.Settings.Default["customSound3Path"].ToString();
                            currentsound = new SoundPlayer(@"" + selectedFilePath);
                            currentsound.Play();
                        }
                        else { System.Windows.Forms.MessageBox.Show($"File doesn't exist within {settings.CustomDirectoryPath}"); }
                    }
                    else { System.Windows.Forms.MessageBox.Show("Custom sounds directory doesn't exist, go to settings to add custom sounds."); }
                }
                catch { return; }
            }
        }
        private void cstmsoundbtn4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default["customSound4Path"].ToString()))
            {
                if (currentsound != null)
                {
                    currentsound.Stop();
                }
            }
            else
            {
                // CHECK IF CUSTOMDIRECTORY EXISTS
                try
                {
                    if (Directory.Exists(settings.CustomDirectoryPath))
                    {
                        string currentSoundFile = Properties.Settings.Default["customSound4Path"].ToString();
                        // CHECK IF FILE WITHIN CUSTOMDIRECTORY EXISTS
                        if (File.Exists(currentSoundFile))
                        {
                            string selectedFilePath = Properties.Settings.Default["customSound4Path"].ToString();
                            currentsound = new SoundPlayer(@"" + selectedFilePath);
                            currentsound.Play();
                        }
                        else { System.Windows.Forms.MessageBox.Show($"File doesn't exist within {settings.CustomDirectoryPath}"); }
                    }
                    else { System.Windows.Forms.MessageBox.Show("Custom sounds directory doesn't exist, go to settings to add custom sounds."); }
                }
                catch { return; }
            }
        }
        private void cstmsoundbtn5_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default["customSound5Path"].ToString()))
            {
                if (currentsound != null)
                {
                    currentsound.Stop();
                }
            }
            else
            {
                // CHECK IF CUSTOMDIRECTORY EXISTS
                try
                {
                    if (Directory.Exists(settings.CustomDirectoryPath))
                    {
                        string currentSoundFile = Properties.Settings.Default["customSound5Path"].ToString();
                        // CHECK IF FILE WITHIN CUSTOMDIRECTORY EXISTS
                        if (File.Exists(currentSoundFile))
                        {
                            string selectedFilePath = Properties.Settings.Default["customSound5Path"].ToString();
                            currentsound = new SoundPlayer(@"" + selectedFilePath);
                            currentsound.Play();
                        }
                        else { System.Windows.Forms.MessageBox.Show($"File doesn't exist within {settings.CustomDirectoryPath}"); }
                    }
                    else { System.Windows.Forms.MessageBox.Show("Custom sounds directory doesn't exist, go to settings to add custom sounds."); }
                }
                catch { return; }
            }
        }
        private void cstmsoundbtn6_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default["customSound6Path"].ToString()))
            {
                if (currentsound != null)
                {
                    currentsound.Stop();
                }
            }
            else
            {
                // CHECK IF CUSTOMDIRECTORY EXISTS
                try
                {
                    if (Directory.Exists(settings.CustomDirectoryPath))
                    {
                        string currentSoundFile = Properties.Settings.Default["customSound6Path"].ToString();
                        // CHECK IF FILE WITHIN CUSTOMDIRECTORY EXISTS
                        if (File.Exists(currentSoundFile))
                        {
                            string selectedFilePath = Properties.Settings.Default["customSound6Path"].ToString();
                            currentsound = new SoundPlayer(@"" + selectedFilePath);
                            currentsound.Play();
                        }
                        else { System.Windows.Forms.MessageBox.Show($"File doesn't exist within {settings.CustomDirectoryPath}"); }
                    }
                    else { System.Windows.Forms.MessageBox.Show("Custom sounds directory doesn't exist, go to settings to add custom sounds."); }
                }
                catch { return; }
            }
        }
        private void cstmsoundbtn7_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default["customSound7Path"].ToString()))
            {
                if (currentsound != null)
                {
                    currentsound.Stop();
                }
            }
            else
            {
                // CHECK IF CUSTOMDIRECTORY EXISTS
                try
                {
                    if (Directory.Exists(settings.CustomDirectoryPath))
                    {
                        string currentSoundFile = Properties.Settings.Default["customSound7Path"].ToString();
                        // CHECK IF FILE WITHIN CUSTOMDIRECTORY EXISTS
                        if (File.Exists(currentSoundFile))
                        {
                            string selectedFilePath = Properties.Settings.Default["customSound7Path"].ToString();
                            currentsound = new SoundPlayer(@"" + selectedFilePath);
                            currentsound.Play();
                        }
                        else { System.Windows.Forms.MessageBox.Show($"File doesn't exist within {settings.CustomDirectoryPath}"); }
                    }
                    else { System.Windows.Forms.MessageBox.Show("Custom sounds directory doesn't exist, go to settings to add custom sounds."); }
                }
                catch { return; }
            }
        }
        private void cstmsoundbtn8_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default["customSound8Path"].ToString()))
            {
                if (currentsound != null)
                {
                    currentsound.Stop();
                }
            }
            else
            {
                // CHECK IF CUSTOMDIRECTORY EXISTS
                try
                {
                    if (Directory.Exists(settings.CustomDirectoryPath))
                    {
                        string currentSoundFile = Properties.Settings.Default["customSound8Path"].ToString();
                        // CHECK IF FILE WITHIN CUSTOMDIRECTORY EXISTS
                        if (File.Exists(currentSoundFile))
                        {
                            string selectedFilePath = Properties.Settings.Default["customSound8Path"].ToString();
                            currentsound = new SoundPlayer(@"" + selectedFilePath);
                            currentsound.Play();
                        }
                        else { System.Windows.Forms.MessageBox.Show($"File doesn't exist within {settings.CustomDirectoryPath}"); }
                    }
                    else { System.Windows.Forms.MessageBox.Show("Custom sounds directory doesn't exist, go to settings to add custom sounds."); }
                }
                catch { return; }
            }
        }
        private void cstmsoundbtn9_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default["customSound9Path"].ToString()))
            {
                if (currentsound != null)
                {
                    currentsound.Stop();
                }
            }
            else
            {
                // CHECK IF CUSTOMDIRECTORY EXISTS
                try
                {
                    if (Directory.Exists(settings.CustomDirectoryPath))
                    {
                        string currentSoundFile = Properties.Settings.Default["customSound9Path"].ToString();
                        // CHECK IF FILE WITHIN CUSTOMDIRECTORY EXISTS
                        if (File.Exists(currentSoundFile))
                        {
                            string selectedFilePath = Properties.Settings.Default["customSound9Path"].ToString();
                            currentsound = new SoundPlayer(@"" + selectedFilePath);
                            currentsound.Play();
                        }
                        else { System.Windows.Forms.MessageBox.Show($"File doesn't exist within {settings.CustomDirectoryPath}"); }
                    }
                    else { System.Windows.Forms.MessageBox.Show("Custom sounds directory doesn't exist, go to settings to add custom sounds."); }
                }
                catch { return; }
            }
        }

        // CONFIGURE CUSTOM SOUND BUTTON(S)
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (currentsound != null)
            {
                currentsound.Stop();
            }

            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(settings.CustomDirectoryPath))
                {
                    settings.RefreshListbox();
                }
            }
            catch { Debug.WriteLine("Directory doesn't exist."); return; }

            this.Hide();
            settings.ShowDialog();
            this.Show();
        }

        // EXIT THE APPLICATION
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
