using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    public partial class MainForm : Form
    {
        bool does_have_ExtraLive;

        //classes
        PlayerShip player;
        bullet bulletTypes;
        List<bullet> allBullets = new List<bullet>();
        bool shootingBullet;
        int BulletFireRate;
        //player variables
        int PlayerSpeed = 3, ShipWidth = 100, ShipHeight = 100, BulletSpeed = 4, bulletWidth = 2, bulletHeight = 20;
        private void PlayerMovment()
        {
            if (player.goUp && player.Y - PlayerSpeed > 0) player.Y -= PlayerSpeed;
            if (player.goDown && player.Y + PlayerSpeed + ShipHeight < ClientSize.Height) player.Y += PlayerSpeed;
            if (player.goLeft && player.X - PlayerSpeed > 0) player.X -= PlayerSpeed;
            if (player.goRight && player.X + PlayerSpeed + ShipWidth < ClientSize.Width) player.X += PlayerSpeed;
        }
        private void BulletsMovement()
        {
            foreach (var b in allBullets)
            {
                b.Y -= BulletSpeed;
            }
        }
        private void Shoot()
        {
            bullet tmp = new bullet(1);
            tmp.X = player.X + (ShipWidth + bulletWidth) / 2;
            tmp.Y = player.Y - bulletHeight;
            allBullets.Add(tmp);
        }
    }
}
