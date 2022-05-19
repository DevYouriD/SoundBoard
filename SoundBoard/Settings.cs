using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SoundBoard
{
    public partial class Settings : Form
    {
        public Settings()
        {
            this.Icon = SoundBoard.Properties.Resources.Icon;
            InitializeComponent();
        }

        // DECLARE CUSTOM DIRECTORY PATH
        public string CustomDirectoryPath { get; set; } = 
            System.Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic) + @"\customSoundsDirectory\";

        //SET CUSTOM SOUND TO THEIR RESPECTIVE BUTTON
        private void setcstmsoundbtn1_Click(object sender, EventArgs e)
        {
            // CHECK IF CUSTOMDIRECTORY EXISTS
            if (Directory.Exists(CustomDirectoryPath))
            {
                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = CustomDirectoryPath;
                        openFileDialog.Filter = "wav files (*.wav)|*.wav";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //GET PATH OF SPECIFIED FILE
                            string filePath = openFileDialog.FileName;
                            Properties.Settings.Default["customSound1Path"] = filePath;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
                catch (Exception exeption) { Debug.WriteLine(exeption); }
            }
            else
            {
                Directory.CreateDirectory(CustomDirectoryPath);

                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = CustomDirectoryPath;
                        openFileDialog.Filter = "wav files (*.wav)|*.wav";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //GET PATH OF SPECIFIED FILE
                            string filePath = openFileDialog.FileName;
                            Properties.Settings.Default["customSound1Path"] = filePath;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
                catch (Exception exeption) { Debug.WriteLine(exeption); }
            }
        }
        private void setcstmsoundbtn2_Click(object sender, EventArgs e)
        {
            // CHECK IF CUSTOMDIRECTORY EXISTS
            if (Directory.Exists(CustomDirectoryPath))
            {
                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = CustomDirectoryPath;
                        openFileDialog.Filter = "wav files (*.wav)|*.wav";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //GET PATH OF SPECIFIED FILE
                            string filePath = openFileDialog.FileName;
                            Properties.Settings.Default["customSound2Path"] = filePath;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
                catch (Exception exeption) { Debug.WriteLine(exeption); }
            }
            else
            {
                Directory.CreateDirectory(CustomDirectoryPath);

                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = CustomDirectoryPath;
                        openFileDialog.Filter = "wav files (*.wav)|*.wav";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //GET PATH OF SPECIFIED FILE
                            string filePath = openFileDialog.FileName;
                            Properties.Settings.Default["customSound2Path"] = filePath;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
                catch (Exception exeption) { Debug.WriteLine(exeption); }
            }
        }
        private void setcstmsoundbtn3_Click(object sender, EventArgs e)
        {
            // CHECK IF CUSTOMDIRECTORY EXISTS
            if (Directory.Exists(CustomDirectoryPath))
            {
                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = CustomDirectoryPath;
                        openFileDialog.Filter = "wav files (*.wav)|*.wav";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //GET PATH OF SPECIFIED FILE
                            string filePath = openFileDialog.FileName;
                            Properties.Settings.Default["customSound3Path"] = filePath;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
                catch (Exception exeption) { Debug.WriteLine(exeption); }
            }
            else
            {
                Directory.CreateDirectory(CustomDirectoryPath);

                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = CustomDirectoryPath;
                        openFileDialog.Filter = "wav files (*.wav)|*.wav";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //GET PATH OF SPECIFIED FILE
                            string filePath = openFileDialog.FileName;
                            Properties.Settings.Default["customSound3Path"] = filePath;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
                catch (Exception exeption) { Debug.WriteLine(exeption); }
            }
        }
        private void setcstmsoundbtn4_Click(object sender, EventArgs e)
        {
            // CHECK IF CUSTOMDIRECTORY EXISTS
            if (Directory.Exists(CustomDirectoryPath))
            {
                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = CustomDirectoryPath;
                        openFileDialog.Filter = "wav files (*.wav)|*.wav";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //GET PATH OF SPECIFIED FILE
                            string filePath = openFileDialog.FileName;
                            Properties.Settings.Default["customSound4Path"] = filePath;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
                catch (Exception exeption) { Debug.WriteLine(exeption); }
            }
            else
            {
                Directory.CreateDirectory(CustomDirectoryPath);

                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = CustomDirectoryPath;
                        openFileDialog.Filter = "wav files (*.wav)|*.wav";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //GET PATH OF SPECIFIED FILE
                            string filePath = openFileDialog.FileName;
                            Properties.Settings.Default["customSound4Path"] = filePath;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
                catch (Exception exeption) { Debug.WriteLine(exeption); }
            }
        }
        private void setcstmsoundbtn5_Click(object sender, EventArgs e)
        {
            // CHECK IF CUSTOMDIRECTORY EXISTS
            if (Directory.Exists(CustomDirectoryPath))
            {
                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = CustomDirectoryPath;
                        openFileDialog.Filter = "wav files (*.wav)|*.wav";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //GET PATH OF SPECIFIED FILE
                            string filePath = openFileDialog.FileName;
                            Properties.Settings.Default["customSound5Path"] = filePath;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
                catch (Exception exeption) { Debug.WriteLine(exeption); }
            }
            else
            {
                Directory.CreateDirectory(CustomDirectoryPath);

                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = CustomDirectoryPath;
                        openFileDialog.Filter = "wav files (*.wav)|*.wav";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //GET PATH OF SPECIFIED FILE
                            string filePath = openFileDialog.FileName;
                            Properties.Settings.Default["customSound5Path"] = filePath;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
                catch (Exception exeption) { Debug.WriteLine(exeption); }
            }
        }
        private void setcstmsoundbtn6_Click(object sender, EventArgs e)
        {
            // CHECK IF CUSTOMDIRECTORY EXISTS
            if (Directory.Exists(CustomDirectoryPath))
            {
                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = CustomDirectoryPath;
                        openFileDialog.Filter = "wav files (*.wav)|*.wav";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //GET PATH OF SPECIFIED FILE
                            string filePath = openFileDialog.FileName;
                            Properties.Settings.Default["customSound6Path"] = filePath;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
                catch (Exception exeption) { Debug.WriteLine(exeption); }
            }
            else
            {
                Directory.CreateDirectory(CustomDirectoryPath);

                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = CustomDirectoryPath;
                        openFileDialog.Filter = "wav files (*.wav)|*.wav";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //GET PATH OF SPECIFIED FILE
                            string filePath = openFileDialog.FileName;
                            Properties.Settings.Default["customSound6Path"] = filePath;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
                catch (Exception exeption) { Debug.WriteLine(exeption); }
            }
        }
        private void setcstmsoundbtn7_Click(object sender, EventArgs e)
        {
            // CHECK IF CUSTOMDIRECTORY EXISTS
            if (Directory.Exists(CustomDirectoryPath))
            {
                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = CustomDirectoryPath;
                        openFileDialog.Filter = "wav files (*.wav)|*.wav";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //GET PATH OF SPECIFIED FILE
                            string filePath = openFileDialog.FileName;
                            Properties.Settings.Default["customSound7Path"] = filePath;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
                catch (Exception exeption) { Debug.WriteLine(exeption); }
            }
            else
            {
                Directory.CreateDirectory(CustomDirectoryPath);

                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = CustomDirectoryPath;
                        openFileDialog.Filter = "wav files (*.wav)|*.wav";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //GET PATH OF SPECIFIED FILE
                            string filePath = openFileDialog.FileName;
                            Properties.Settings.Default["customSound7Path"] = filePath;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
                catch (Exception exeption) { Debug.WriteLine(exeption); }
            }
        }
        private void setcstmsoundbtn8_Click(object sender, EventArgs e)
        {
            // CHECK IF CUSTOMDIRECTORY EXISTS
            if (Directory.Exists(CustomDirectoryPath))
            {
                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = CustomDirectoryPath;
                        openFileDialog.Filter = "wav files (*.wav)|*.wav";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //GET PATH OF SPECIFIED FILE
                            string filePath = openFileDialog.FileName;
                            Properties.Settings.Default["customSound8Path"] = filePath;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
                catch (Exception exeption) { Debug.WriteLine(exeption); }
            }
            else
            {
                Directory.CreateDirectory(CustomDirectoryPath);

                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = CustomDirectoryPath;
                        openFileDialog.Filter = "wav files (*.wav)|*.wav";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //GET PATH OF SPECIFIED FILE
                            string filePath = openFileDialog.FileName;
                            Properties.Settings.Default["customSound8Path"] = filePath;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
                catch (Exception exeption) { Debug.WriteLine(exeption); }
            }
        }
        private void setcstmsoundbtn9_Click(object sender, EventArgs e)
        {
            // CHECK IF CUSTOMDIRECTORY EXISTS
            if (Directory.Exists(CustomDirectoryPath))
            {
                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = CustomDirectoryPath;
                        openFileDialog.Filter = "wav files (*.wav)|*.wav";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //GET PATH OF SPECIFIED FILE
                            string filePath = openFileDialog.FileName;
                            Properties.Settings.Default["customSound9Path"] = filePath;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
                catch (Exception exeption) { Debug.WriteLine(exeption); }
            }
            else
            {
                Directory.CreateDirectory(CustomDirectoryPath);

                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = CustomDirectoryPath;
                        openFileDialog.Filter = "wav files (*.wav)|*.wav";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //GET PATH OF SPECIFIED FILE
                            string filePath = openFileDialog.FileName;
                            Properties.Settings.Default["customSound9Path"] = filePath;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
                catch (Exception exeption) { Debug.WriteLine(exeption); }
            }
        }

        // RETURN TO THE HOME WINDOW
        private void returnbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ADD NEW SOUND FILES
        private void plusbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(CustomDirectoryPath))
                {
                    addSoundFile();
                    return;
                }
                // Try to create the directory.
                Directory.CreateDirectory(CustomDirectoryPath);
                addSoundFile();
            }
            catch (Exception exeption) { Debug.WriteLine(exeption); System.Windows.Forms.MessageBox.Show("File already exists."); }
        }

        // EXIT THE APPLICATION
        private void exitbtn2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        // ADD SOUND FILES FUNCTIONALITY
        private void addSoundFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "wav files (*.wav)|*.wav";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;
                    string filename = openFileDialog.SafeFileName;
                    //.wav file gets added to AddedSounds folder
                    string sourceFile = filePath;
                    string destinationFile = CustomDirectoryPath + filename.ToString();
                    System.IO.File.Copy(sourceFile, destinationFile);
                }
                RefreshListbox();
            }
        }
        // REFRESH LISTBOX FUNCTIONALITY
        public void RefreshListbox()
        {
            //DISPLAY ADDED SOUNDS IN LISTBOX
            listBox1.Items.Clear();
            DirectoryInfo dinfo2 = new DirectoryInfo(CustomDirectoryPath);
            FileInfo[] smFiles2 = dinfo2.GetFiles("*.wav");
            foreach (FileInfo file in smFiles2)
            {
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(file.Name));
            }
        }

        // RESET ALL CUSTOM BUTTONS
        private void resetbtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["customSound1Path"] = "";
            Properties.Settings.Default["customSound2Path"] = "";
            Properties.Settings.Default["customSound3Path"] = "";
            Properties.Settings.Default["customSound4Path"] = "";
            Properties.Settings.Default["customSound5Path"] = "";
            Properties.Settings.Default["customSound6Path"] = "";
            Properties.Settings.Default["customSound7Path"] = "";
            Properties.Settings.Default["customSound8Path"] = "";
            Properties.Settings.Default["customSound9Path"] = "";
            Properties.Settings.Default.Save();
        }
    }
}
