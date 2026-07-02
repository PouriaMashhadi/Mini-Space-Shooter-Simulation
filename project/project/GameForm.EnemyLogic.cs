namespace project
{
    public partial class GameForm : Form
    {
        List<Enemy> Wave;

        private void SpawnEnemy()
        {
            int x, y = 10, distance = ClientSize.Width / (Wave.Count + 1);
            x = distance;

            foreach (var i in Wave)
            {
                i.Spawn(x, y);
                x += distance;
            }
        }
        private void RemoveEnemies()
        {
            for (int i = 0; i < Wave.Count; i++)
                if (Wave[i].Y > ClientSize.Height) { Wave.Remove(Wave[i]); i--; }
        }
        private void UpdateEnemies()
        {
            foreach (var i in Wave) i.Update();
            RemoveEnemies();
            Check_bullet_Collision_withEnemy();
            Check_Enemy_Collision();
            Check_Player_Collision_withEnemyBullet();
            ShooterEnemy.Shoot(SmallEnemyWidth, SmallEnemyHeight, bulletWidth, bulletHeight, BulletSpeed);
            EnemyBullet.MoveBullets(ClientSize.Height);
        }
        private void Check_Enemy_Collision()
        {
            foreach (var i in BaseC.AllObject)
            {
                if (i is Enemy)
                {
                    if (player.Hitbox.IntersectsWith((i as Enemy).Hitbox))
                    {
                        Player_Take_damage();
                    }
                }
            }
        }
        private void Check_bullet_Collision_withEnemy()
        {
            for (int i = 0; i < bullet.allBullets.Count; i++)
            {
                for (int j = 0; j < Wave.Count; j++)
                {
                    if (bullet.allBullets[i].Hitbox.IntersectsWith(Wave[j].Hitbox))
                    {
                        bool check = Wave[j].TakeDamage(bulletDamage);
                        if (Wave[j].TakeDamage(bulletDamage) == false)
                        {
                            if (Wave[j] is ShooterEnemy)
                                (Wave[j] as ShooterEnemy).Kill();
                            Wave.Remove(Wave[j]);
                        }
                        bullet.allBullets.Remove(bullet.allBullets[i]);
                        i--;
                        if (i < 0) break;
                    }
                }
            }
        }
        private void Check_Player_Collision_withEnemyBullet()
        {
            foreach (var i in BaseC.AllObject)
            {
                if (i is EnemyBullet)
                {
                    if (player.Hitbox.IntersectsWith((i as EnemyBullet).Hitbox))
                    {
                        Player_Take_damage();
                        EnemyBullet.AllBullets.Remove((i as EnemyBullet));

                    }
                }
            }
        }

    }
}
