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
        private FormScaler scaler;

        private static readonly Color HoverColor = Color.FromArgb(255, 255, 128);
        private static readonly Color SelectedColor = Color.FromArgb(120, 220, 120);

        private PictureBox selectedShipPic;
        private PictureBox selectedBulletPic;

        public Shop()
        {
            InitializeComponent();
            // Dynamic Sizing
            scaler = new FormScaler(this);

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

            SelectShip(picShip1);
            GameForm.Ship_skin_path = @"img\Spaceship.png";
            GameForm.bullet_skin_path = @"img\EnemyBullet.png";
        }

        private void StylePic(PictureBox pb)
        {
            pb.MouseEnter += (s, e) =>
            {
                if (pb != selectedShipPic && pb != selectedBulletPic)
                    pb.BackColor = HoverColor;
            };

            pb.MouseLeave += (s, e) =>
            {
                if (pb != selectedShipPic && pb != selectedBulletPic)
                    pb.BackColor = Color.Transparent;
            };

            pb.MouseEnter += (s, e) => AudioManager.PlaySFX(SFXType.ShopHover);
        }

        private void SelectShip(PictureBox pic)
        {
            if (selectedShipPic != null)
                selectedShipPic.BackColor = Color.Transparent;

            selectedShipPic = pic;
            selectedShipPic.BackColor = SelectedColor;
        }

        private void SelectBullet(PictureBox pic)
        {
            if (selectedBulletPic != null)
                selectedBulletPic.BackColor = Color.Transparent;

            selectedBulletPic = pic;
            selectedBulletPic.BackColor = SelectedColor;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void picShip2_Click(object sender, EventArgs e)
        {
            GameForm.Ship_skin_path = @"img\ship2.png";
            SelectShip(picShip2);
        }

        private void picShip3_Click(object sender, EventArgs e)
        {
            GameForm.Ship_skin_path = @"img\ship3.png";
            SelectShip(picShip3);
        }

        private void picShip4_Click(object sender, EventArgs e)
        {
            GameForm.Ship_skin_path = @"img\ship4.png";
            SelectShip(picShip4);
        }

        private void picShip1_Click(object sender, EventArgs e)
        {
            GameForm.Ship_skin_path = @"img\Spaceship.png";
            SelectShip(picShip1);
        }

        private void pbTemplate1_Click(object sender, EventArgs e)
        {
            GameForm.Background_Themes_path = @"img\Options2.jpg";
            lblTem1.BackColor = Color.Green;
            lblTemplate2.BackColor = Color.Transparent;
        }

        private void pbTemplate2_Click(object sender, EventArgs e)
        {
            GameForm.Background_Themes_path = @"img\Template2.jpg";
            lblTemplate2.BackColor = Color.Green;
            lblTem1.BackColor = Color.Transparent;

        }

        private void picBullet3_Click(object sender, EventArgs e)
        {
            GameForm.bullet_skin_path = @"img\Bulletmain3.png";
            SelectBullet(picBullet3);
        }

        private void picBullet2_Click(object sender, EventArgs e)
        {
            GameForm.bullet_skin_path = @"img\Bulletmain2.png";
            SelectBullet(picBullet2);
        }

        private void picBullet1_Click(object sender, EventArgs e)
        {
            GameForm.bullet_skin_path = @"img\EnemyBullet.png";
            SelectBullet(picBullet1);

        }
    }
}