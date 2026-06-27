using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace project
{
    public partial class MainForm : Form
    {
        Image ShipImage, BulletImage, Background, HPImage, CoinImage;
        string Ship_skin_path = @"..\..\..\..\Resource\Spaceship.png", bullet_skin_path = @"..\..\..\..\Resource\bullet.png", Background_Themes_path = @"..\..\..\..\Resource\a.png";
        private void ImageSetUp()
        {
            ShipImage = Image.FromFile(Ship_skin_path);
            BulletImage = Image.FromFile(bullet_skin_path);
        }

        private void Paint_GameForm(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(ShipImage, player.X, player.Y, ShipWidth, ShipHeight);
            foreach (var b in bullet.allBullets)
            {
                e.Graphics.DrawImage(BulletImage, b.X, b.Y, bulletWidth, bulletHeight);
            }
        }
    }
}
