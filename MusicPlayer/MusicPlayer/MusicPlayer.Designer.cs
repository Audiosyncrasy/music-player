namespace MusicPlayer
{
    partial class MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.MediaPlayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(784, 500);
            this.MediaPlayer.TabIndex = 0;
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.BrowseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BrowseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseBtn.Location = new System.Drawing.Point(2, 769);
            this.BrowseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(236, 92);
            this.BrowseBtn.TabIndex = 1;
            this.BrowseBtn.Text = "BROWSE";
            this.BrowseBtn.UseVisualStyleBackColor = false;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBtn.Location = new System.Drawing.Point(237, 769);
            this.PlayBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(236, 92);
            this.PlayBtn.TabIndex = 2;
            this.PlayBtn.Text = "PLAY";
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.PauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PauseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseBtn.Location = new System.Drawing.Point(471, 769);
            this.PauseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(236, 92);
            this.PauseBtn.TabIndex = 3;
            this.PauseBtn.Text = "PAUSE";
            this.PauseBtn.UseVisualStyleBackColor = false;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopBtn.Location = new System.Drawing.Point(705, 769);
            this.StopBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(236, 92);
            this.StopBtn.TabIndex = 4;
            this.StopBtn.Text = "STOP";
            this.StopBtn.UseVisualStyleBackColor = false;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(939, 769);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(236, 92);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathTextBox.Location = new System.Drawing.Point(2, 711);
            this.filePathTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filePathTextBox.Multiline = true;
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(471, 58);
            this.filePathTextBox.TabIndex = 6;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1176, 863);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.MediaPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox filePathTextBox;
    }
}

