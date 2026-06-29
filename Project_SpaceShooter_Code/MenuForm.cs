using Project;
using System.Numerics;
using WF1_Training.Properties;
using WMPLib;


namespace WF1_Training
{

    public partial class MenuForm : Form
    {
        string path = @"Music\MenuTheme.mp3";
        public MenuForm()
        {
            InitializeComponent();

            //Static Sizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Size = new Size(826, 512);

            // Form
            this.BackColor = Color.FromArgb(5, 13, 26);

            // Title
            lblTitle.ForeColor = Color.FromArgb(122, 184, 245);

            // Play
            StyleButton(btnPlay);

            // Options
            StyleButton(btnOptions);


            // Shop
            StyleButton(btnShop);


            //About
            StyleButton(btnAbout);

            //Quit
            StyleButton(btnQuit);


            //bg Music 
            AudioManager.PlayMusic(path);
            

        }
        private void StyleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.FromArgb(58, 106, 170);
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.FromArgb(232, 240, 255);
            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(80, 140, 220);
            btn.MouseLeave += (s, e) => btn.BackColor = Color.Transparent;
            btn.MouseEnter += (s, e) => AudioManager.PlaySFX(SFXType.ButtonHover);
        }
        private void BtnOption_Click(object sender, EventArgs e)
        {
            AudioManager.StopMusic();
            this.Hide();
            Options newOptions = new Options();
            newOptions.ShowDialog();
            this.Show();
            AudioManager.PlayMusic(path);
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shop about = new Shop();
            about.ShowDialog();
            this.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AudioManager.StopMusic();
            this.Hide();
            AboutForm about = new AboutForm();
            about.ShowDialog();
            this.Show();
            AudioManager.PlayMusic(path);

        }
    }
}
