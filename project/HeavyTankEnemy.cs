using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class HeavyTankEnemy : Enemy
    {
        public static List<HeavyTankEnemy> allShooters = new List<HeavyTankEnemy>();
        private static long EnemyFireRate = 5000 * TimeSpan.TicksPerMillisecond;
        public long lastShoot = 0;


        public static void Shoot(int EnemyWidth, int EnemyHeight, int BulletWidth, int BulletHeight, int BulletSpeed)
        {
            foreach (var enemy in allShooters)
            {
                long now = DateTime.Now.Ticks;
                if (now > enemy.lastShoot + EnemyFireRate)
                {
                    enemy.lastShoot = now;
                    EnemyShoot(enemy, EnemyWidth, EnemyHeight, BulletWidth, BulletHeight, BulletSpeed);
                }
            }
        }
        private static void EnemyShoot(HeavyTankEnemy enemy, int EnemyWidth, int EnemyHeight, int BulletWidth, int BulletHeight, int BulletSpeed)
        {
            EnemyBullet S = new EnemyBullet(enemy.X + (EnemyWidth - BulletWidth)/ 2, enemy.Y + EnemyHeight, BulletWidth, BulletHeight, BulletSpeed, "S");
            EnemyBullet N = new EnemyBullet(enemy.X + (EnemyWidth - BulletWidth) / 2, enemy.Y + EnemyHeight, BulletWidth, BulletHeight, BulletSpeed, "N");
            EnemyBullet E = new EnemyBullet(enemy.X + (EnemyWidth - BulletWidth) / 2, enemy.Y + EnemyHeight, BulletWidth, BulletHeight, BulletSpeed, "E");
            EnemyBullet W = new EnemyBullet(enemy.X + (EnemyWidth - BulletWidth) / 2, enemy.Y + EnemyHeight, BulletWidth, BulletHeight, BulletSpeed, "W");
            EnemyBullet SW = new EnemyBullet(enemy.X + (EnemyWidth - BulletWidth) / 2, enemy.Y + EnemyHeight, BulletWidth, BulletHeight, BulletSpeed, "SW");
            EnemyBullet SE = new EnemyBullet(enemy.X + (EnemyWidth - BulletWidth) / 2, enemy.Y + EnemyHeight, BulletWidth, BulletHeight, BulletSpeed, "SE");
            EnemyBullet NE = new EnemyBullet(enemy.X + (EnemyWidth - BulletWidth) / 2, enemy.Y + EnemyHeight, BulletWidth, BulletHeight, BulletSpeed, "NE");
            EnemyBullet NW = new EnemyBullet(enemy.X + (EnemyWidth - BulletWidth) / 2, enemy.Y + EnemyHeight, BulletWidth, BulletHeight, BulletSpeed, "NW");
        }
        public HeavyTankEnemy(int w, int h, int Wave) : base(w, h)
        {
            Wave--;
            Score = 10;
            Speed = (float)(0.5 * (0.5 + 0.1 * Wave));
            HP = 5 + 2 * Wave;
            allShooters.Add(this);
        }
        public void Kill() => allShooters.Remove(this);

        public override void Update()
        {
            Y += Speed;
        }

    }
}
