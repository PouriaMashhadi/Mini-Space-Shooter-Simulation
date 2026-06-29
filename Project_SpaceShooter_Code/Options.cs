using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WF1_Training.Properties;

namespace WF1_Training
{
    public partial class Options : Form
    {
        string path = @"Music\Options.mp3";

        public Options()
        {
            InitializeComponent();

            //Tracking Last Setting 
            trkMusic.Value = AudioManager.MusicVolume;
            trkSFX.Value = AudioManager.SFXVolume;
            chkAudio.Checked = !AudioManager.IsMusicMuted;
            chkSFX.Checked = !AudioManager.IsSFXMuted;

            //Static Sizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Size = new Size(826, 512);
            //trkAudio
            trkMusic.ValueChanged += (s, e) =>
            {
                AudioManager.SetMusicVolume(trkMusic.Value);
            };
            trkMusic.Value = AudioManager.MusicVolume;
            chkAudio.Checked = !AudioManager.IsMusicMuted;
            //trkSFX
            trkSFX.ValueChanged += (s, e) =>
            {
                AudioManager.SetSFXVolume(trkSFX.Value);
            };
            trkSFX.Value = AudioManager.SFXVolume;
            chkSFX.Checked = !AudioManager.IsSFXMuted;
            //back
            btnBack.MouseEnter += (s, e) => btnBack.BackColor = Color.FromArgb(26, 58, 106);
            btnBack.MouseLeave += (s, e) => btnBack.BackColor = Color.Transparent;
            btnBack.MouseEnter += (s, e) => AudioManager.PlaySFX(SFXType.ButtonHover);
            AudioManager.PlayMusic(path);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            AudioManager.StopMusic();
        }

        private void chkAudio_CheckedChanged(object sender, EventArgs e)
        {
            AudioManager.MuteMusic(!chkAudio.Checked);
        }

        private void chkSFX_CheckedChanged(object sender, EventArgs e)
        {
            AudioManager.MuteSFX(!chkSFX.Checked);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AudioManager.StopMusic();
            this.Hide();
        }

    }
}
