namespace strike
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mp3Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mp4Button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.outputPathLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.noUpdateButton = new System.Windows.Forms.RadioButton();
            this.autoUpdateButton = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.updateCheckLabel = new System.Windows.Forms.Label();
            this.notificationBanner = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notificationBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mp3Button
            // 
            this.mp3Button.Location = new System.Drawing.Point(28, 51);
            this.mp3Button.Margin = new System.Windows.Forms.Padding(2);
            this.mp3Button.Name = "mp3Button";
            this.mp3Button.Size = new System.Drawing.Size(226, 46);
            this.mp3Button.TabIndex = 0;
            this.mp3Button.Text = "Download MP3";
            this.mp3Button.UseVisualStyleBackColor = true;
            this.mp3Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(457, 19);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Enter the link to a YouTube video / playlist here";
            // 
            // mp4Button
            // 
            this.mp4Button.Location = new System.Drawing.Point(258, 51);
            this.mp4Button.Margin = new System.Windows.Forms.Padding(2);
            this.mp4Button.Name = "mp4Button";
            this.mp4Button.Size = new System.Drawing.Size(226, 46);
            this.mp4Button.TabIndex = 3;
            this.mp4Button.Text = "Download MP4";
            this.mp4Button.UseVisualStyleBackColor = true;
            this.mp4Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 101);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(456, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Set output path";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // outputPathLabel
            // 
            this.outputPathLabel.AutoSize = true;
            this.outputPathLabel.ForeColor = System.Drawing.Color.White;
            this.outputPathLabel.Location = new System.Drawing.Point(25, 134);
            this.outputPathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputPathLabel.Name = "outputPathLabel";
            this.outputPathLabel.Size = new System.Drawing.Size(66, 13);
            this.outputPathLabel.TabIndex = 5;
            this.outputPathLabel.Text = "Output path:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(28, 171);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(172, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Open file location on download";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // noUpdateButton
            // 
            this.noUpdateButton.AutoSize = true;
            this.noUpdateButton.ForeColor = System.Drawing.Color.White;
            this.noUpdateButton.Location = new System.Drawing.Point(282, 207);
            this.noUpdateButton.Name = "noUpdateButton";
            this.noUpdateButton.Size = new System.Drawing.Size(128, 17);
            this.noUpdateButton.TabIndex = 9;
            this.noUpdateButton.Text = "Disable auto updating";
            this.noUpdateButton.UseVisualStyleBackColor = true;
            this.noUpdateButton.CheckedChanged += new System.EventHandler(this.noUpdateButton_CheckedChanged);
            // 
            // autoUpdateButton
            // 
            this.autoUpdateButton.AutoSize = true;
            this.autoUpdateButton.ForeColor = System.Drawing.Color.White;
            this.autoUpdateButton.Location = new System.Drawing.Point(197, 207);
            this.autoUpdateButton.Name = "autoUpdateButton";
            this.autoUpdateButton.Size = new System.Drawing.Size(79, 17);
            this.autoUpdateButton.TabIndex = 10;
            this.autoUpdateButton.Text = "App startup";
            this.autoUpdateButton.UseVisualStyleBackColor = true;
            this.autoUpdateButton.CheckedChanged += new System.EventHandler(this.autoUpdateButton_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(206, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(278, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Update yt-dlp";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Update yt-dlp on:";
            // 
            // updateCheckLabel
            // 
            this.updateCheckLabel.AutoSize = true;
            this.updateCheckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCheckLabel.ForeColor = System.Drawing.Color.White;
            this.updateCheckLabel.Location = new System.Drawing.Point(107, 9);
            this.updateCheckLabel.Name = "updateCheckLabel";
            this.updateCheckLabel.Size = new System.Drawing.Size(320, 13);
            this.updateCheckLabel.TabIndex = 13;
            this.updateCheckLabel.Text = "YT-DLP IS CHECKING FOR UPDATES, PLEASE WAIT.";
            this.updateCheckLabel.Visible = false;
            // 
            // notificationBanner
            // 
            this.notificationBanner.BackColor = System.Drawing.Color.Blue;
            this.notificationBanner.Controls.Add(this.updateCheckLabel);
            this.notificationBanner.Location = new System.Drawing.Point(-10, -3);
            this.notificationBanner.Name = "notificationBanner";
            this.notificationBanner.Size = new System.Drawing.Size(531, 27);
            this.notificationBanner.TabIndex = 14;
            this.notificationBanner.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::strike.Properties.Resources.GitHub_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(447, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(510, 247);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.notificationBanner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.autoUpdateButton);
            this.Controls.Add(this.noUpdateButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.outputPathLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mp4Button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mp3Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Strike | yt-dlp UI";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.notificationBanner.ResumeLayout(false);
            this.notificationBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mp3Button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button mp4Button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label outputPathLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton noUpdateButton;
        private System.Windows.Forms.RadioButton autoUpdateButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label updateCheckLabel;
        private System.Windows.Forms.Panel notificationBanner;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

