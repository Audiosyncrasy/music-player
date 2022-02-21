using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();
            MediaPlayer.uiMode = "None";
            MediaPlayer.settings.autoStart = false;
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePathTextBox.Text = openFileDialog1.FileName;
            }

            MediaPlayer.URL = filePathTextBox.Text;
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            string currentUrl = MediaPlayer.URL;

            if (currentUrl == string.Empty)
            {
                string msg = "No media file selected. Please click the Browse button and select a media file.";
                string caption = "No media file selected";
                MessageBoxButtons btns = MessageBoxButtons.OK;

                MessageBox.Show(msg, caption, btns, MessageBoxIcon.Warning);
            }

            MediaPlayer.Ctlcontrols.play();
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.pause();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.stop();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
