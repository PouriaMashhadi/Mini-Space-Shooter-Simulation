using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
using Project.Properties;
using WMPLib;

namespace Project
{
    public partial class AboutForm : Form
    {
        string path = @"Music\AboutTheme.mp3";
        private FormScaler scaler;

        public AboutForm()
        {
            InitializeComponent();

            //Dynamic Sizing
            scaler = new FormScaler(this);
            //Title
            lblTitle.ForeColor = Color.FromArgb(122, 184, 245);
            //Divider
            pnlDivider.BackColor = Color.FromArgb(58, 106, 170);
            //lblVersion
            lblVersion.ForeColor = Color.FromArgb(122, 184, 245);
            //lblNames
            lblName1.ForeColor = Color.FromArgb(232, 240, 255);
            lblName2.ForeColor = Color.FromArgb(232, 240, 255);
            //lbl ID
            lblId1.ForeColor = Color.FromArgb(168, 196, 232);
            lblId2.ForeColor = Color.FromArgb(168, 196, 232);
            //lblEmail
            lblEmail1.ForeColor = Color.FromArgb(168, 196, 232);
            lblEmail2.ForeColor = Color.FromArgb(168, 196, 232);
            //link LinkedIn
            lnkLinkedIn1.LinkColor = Color.FromArgb(122, 184, 245);
            lnkLinkedIn1.ActiveLinkColor = Color.FromArgb(180, 220, 255);

            lnkLinkedIn2.LinkColor = Color.FromArgb(122, 184, 245);
            lnkLinkedIn2.ActiveLinkColor = Color.FromArgb(180, 220, 255);
            lnkLinkedIn1.LinkClicked += (s, e) =>
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://linkedin.com/in/pouria-mashhadi",
                    UseShellExecute = true
                });
            };
            lnkLinkedIn2.LinkClicked += (s, e) =>
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://linkedin.com/in/pouria-mashhadi",
                    UseShellExecute = true
                });
            };

            lnkGithub1.LinkClicked += (s, e) =>
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://github.com/PouriaMashhadi",
                    UseShellExecute = true
                });
            };

            lnkGithub2.LinkClicked += (s, e) =>
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://github.com/PouriaMashhadi",
                    UseShellExecute = true
                });
            };
            //back
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(58, 106, 170);
            btnBack.BackColor = Color.Transparent;
            btnBack.ForeColor = Color.FromArgb(122, 184, 245);
            btnBack.MouseEnter += (s, e) => btnBack.BackColor = Color.FromArgb(26, 58, 106);
            btnBack.MouseLeave += (s, e) => btnBack.BackColor = Color.Transparent;

            //bg Music 

            AudioManager.PlayMusic(path);
            

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            AudioManager.StopMusic();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AudioManager.StopMusic();
            this.Hide();
        }
    }
}
