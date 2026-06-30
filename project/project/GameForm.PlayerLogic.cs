using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    public partial class GameForm : Form
    {
        bool does_have_ExtraLive;

        //classes
        PlayerShip player;
        bool shootingBullet;
        long FireRate = 200 * TimeSpan.TicksPerMillisecond;
        long LastFireTick;
        //player variables
        int PlayerSpeed = 3, BulletSpeed = 10, bulletDamage = 1;

        private void Shoot()
        {
            bullet tmp = new bullet(1, bulletHeight, bulletWidth, BulletSpeed);
            tmp.X = player.X + (ShipWidth + bulletWidth) / 2;
            tmp.Y = player.Y - bulletHeight;
            bullet.allBullets.Add(tmp);
        }
        private void FireRateHolder()
        {
            if (shootingBullet)
            {
                long now = DateTime.Now.Ticks;
                if (now - LastFireTick > FireRate)
                {
                    LastFireTick = now;
                    Shoot();
                }
            }
        }
        
        private void Player_Take_damage()
        {
            player.HP_count--;
            //complete after 5.3
        }
        
    }
}
