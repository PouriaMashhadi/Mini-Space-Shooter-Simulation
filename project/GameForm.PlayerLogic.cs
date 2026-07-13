using Project.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    public partial class GameForm : Form
    {
        bool does_have_ExtraLive;

        //classes
        PlayerShip player;
        bool shootingBullet;
        long FireRate = 200 * TimeSpan.TicksPerMillisecond;
        long DamageImmunity = 1000 * TimeSpan.TicksPerMillisecond;
        long LastFireTick, PlayerLastDamageTacken;
        //player variables
        int PlayerSpeed = 3, BulletSpeed = 10, bulletDamage = 1;

        private void Shoot()
        {
            if (TripleShot)
            {
                new bullet(player.X + (ShipWidth - bulletWidth) / 2, player.Y - bulletHeight, bulletHeight, bulletWidth, BulletSpeed, "N");
                new bullet(player.X + (ShipWidth - bulletWidth) / 2, player.Y - bulletHeight, bulletHeight, bulletWidth, BulletSpeed, "NE");
                new bullet(player.X + (ShipWidth - bulletWidth) / 2, player.Y - bulletHeight, bulletHeight, bulletWidth, BulletSpeed, "NW");
            }
            else
                new bullet(player.X + (ShipWidth - bulletWidth) / 2, player.Y - bulletHeight, bulletHeight, bulletWidth, BulletSpeed, "N");
                AudioManager.PlaySFX(SFXType.Shoot);

        }
        private void FireRateHolder()
        {
            if (shootingBullet)
            {
                long now = DateTime.Now.Ticks;
                if (Boost) FireRate /= 2;
                if (now - LastFireTick > FireRate)
                {
                    LastFireTick = now;
                    Shoot();
                }
            }
            FireRate = 200 * TimeSpan.TicksPerMillisecond; ;
        }
        private void Player_Take_damage()
        {
            if(!Shield)
            {
                player.HP_count--;
                AudioManager.PlaySFX(SFXType.Damage);

            }

        }
        private void PlayerDeath()
        {
            if (player.HP_count == 0) 
            {
                GameOver = true;

            }
        }

    }
}
