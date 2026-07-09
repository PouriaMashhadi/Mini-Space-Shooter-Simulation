using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class ShooterEnemy : Enemy
    {
        public static List<ShooterEnemy> allShooters = new List<ShooterEnemy>();
        private static long EnemyFireRate = 2000 * TimeSpan.TicksPerMillisecond;
        public long lastShoot = 0;

        public static void Shoot(int EnemyWidth, int EnemyHeight, int BulletWidth, int BulletHeight, int BulletSpeed)
        {
            foreach (var enemy in allShooters)
            {
                long now = DateTime.Now.Ticks;
                if (now > enemy.lastShoot + EnemyFireRate)
                {
                    enemy.lastShoot = now;
                    new EnemyBullet(enemy.X + (EnemyWidth - BulletWidth) / 2 + 1, enemy.Y + EnemyHeight, BulletWidth, BulletHeight, BulletSpeed, "S");
                }
            }
        }

        public ShooterEnemy(int w, int h, int Wave) : base(w, h)
        {
            Wave--;
            Score = 3;
            Speed = (float)(0.5 * (1 + 0.1 * Wave));
            HP = 3 + 2 * Wave;
            allShooters.Add(this);
        }
        public void Kill() => allShooters.Remove(this);
        public override void Update()
        {
            Y += Speed;
        }
    }
}
