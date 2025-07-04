using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Diagnostics;
using System.Threading;


namespace strike
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string outputPath = File.ReadAllText("output_path.txt").Trim();
            outputPathLabel.Text = $"Path: {outputPath}";


            string autoUpdater = File.ReadAllText("auto_update.txt").Trim().ToLower();

            if (autoUpdater == "false")
            {
                autoUpdateButton.Checked = false;
                noUpdateButton.Checked = true;
            }
            else if (autoUpdater == "true")
            {
                mp4Button.Enabled = false;
                mp3Button.Enabled = false;
                notificationBanner.Visible = true;
                updateCheckLabel.Visible = true;

                string updater = "/c yt-dlp --update";
                Process.Start("cmd.exe", updater);
                autoUpdateButton.Checked = true;

                var timer = new System.Windows.Forms.Timer();
                timer.Interval = 5000;

                timer.Tick += (s, e) =>
                {
                    notificationBanner.Visible = false;
                    updateCheckLabel.Visible = false;
                    mp4Button.Enabled = true;
                    mp3Button.Enabled = true;
                    timer.Stop();
                    timer.Dispose();
                };

                timer.Start();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();

            openFileDialog1.InitialDirectory = @"C:\\";
            folderBrowserDialog1.ShowDialog();

            string outputPath = folderBrowserDialog1.SelectedPath;

            File.WriteAllText("output_path.txt", outputPath);

            MessageBox.Show($"Your videos will now save to {outputPath}", "Output path saved!");

            outputPathLabel.Text = $"Path: {outputPath}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string videoOutputPath = File.ReadAllText("output_path.txt").Trim();

            videoOutputPath = videoOutputPath.Replace("\"", "").TrimEnd('\\');

            string processMP3 = $"/c yt-dlp -x --audio-format mp3 --embed-thumbnail --embed-metadata -o \"{videoOutputPath}\\%(title)s.%(ext)s\" \"{textBox1.Text}\"";

            Process.Start("cmd.exe", processMP3);

            if (checkBox1.Checked)
            {
                Process.Start(new ProcessStartInfo(videoOutputPath) { UseShellExecute = true });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string videoOutputPath = File.ReadAllText("output_path.txt").Trim();

            videoOutputPath = videoOutputPath.Replace("\"", "").TrimEnd('\\');

            string processMP4 = $"/c yt-dlp -f bestvideo+bestaudio --merge-output-format mp4 --embed-metadata -o \"{videoOutputPath}\\%(title)s.%(ext)s\" \"{textBox1.Text}\"";

            Process.Start("cmd.exe", processMP4);

            if (checkBox1.Checked)
            {
                Process.Start(new ProcessStartInfo(videoOutputPath) { UseShellExecute = true });
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string updater = $"/c yt-dlp --update";
            Process.Start("cmd.exe", updater);
        }

        private void noUpdateButton_CheckedChanged(object sender, EventArgs e)
        {
            File.WriteAllText("auto_update.txt", "false");
        }

        private void autoUpdateButton_CheckedChanged(object sender, EventArgs e)
        {
            File.WriteAllText("auto_update.txt", "true");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string githubUrl = "https://github.com/hypecrazed/titanium";

            Process.Start(new ProcessStartInfo(githubUrl) { UseShellExecute = true });
        }
    }
}
