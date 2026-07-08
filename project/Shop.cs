using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Project.Properties;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
            // Static Sizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Size = new Size(1059, 750);
            //Hover
            StylePic(picShip1);
            StylePic(picShip2);
            StylePic(picShip3);
            StylePic(picShip4);

            StylePic(picBullet1);
            StylePic(picBullet2);
            StylePic(picBullet3);

            btnBack.MouseEnter += (s, e) => btnBack.BackColor = Color.FromArgb(80, 140, 220);
            btnBack.MouseLeave += (s, e) => btnBack.BackColor = Color.Transparent;
        }
        private static void StylePic(PictureBox pb)
        {
            pb.MouseEnter += (s, e) => pb.BackColor = Color.FromArgb(255, 255, 128);
            pb.MouseLeave += (s, e) => pb.BackColor = Color.Transparent;
            pb.MouseEnter += (s, e) => AudioManager.PlaySFX(SFXType.ShopHover);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void picShip2_Click(object sender, EventArgs e)
        {

        }
    }
}
