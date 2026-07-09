namespace Project
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
            HeavyTankEnemy.Shoot(SmallEnemyWidth * 2, SmallEnemyHeight, bulletWidth, bulletHeight, BulletSpeed);
            EnemyBullet.MoveBullets(ClientSize.Height, ClientSize.Width);
        }
        private void Check_Enemy_Collision()
        {
            long now = DateTime.Now.Ticks;
            for (int i = 0; i < Wave.Count; i++)
            {

                if (player.Hitbox.IntersectsWith(Wave[i].Hitbox))
                {
                    GiveScore(Wave[i]);
                    Wave.Remove(Wave[i]);
                    if (now - PlayerLastDamageTacken > DamageImmunity)
                    {
                        PlayerLastDamageTacken = now;
                        Player_Take_damage();
                    }
                    i--;
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
                            if (Wave[j] is HeavyTankEnemy)
                                (Wave[j] as HeavyTankEnemy).Kill();
                            GiveScore(Wave[j]);
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
            long now = DateTime.Now.Ticks;
            for (int i = 0; i < EnemyBullet.AllBullets.Count; i++)
            {

                if (player.Hitbox.IntersectsWith(EnemyBullet.AllBullets[i].Hitbox))
                {
                    EnemyBullet.AllBullets.Remove(EnemyBullet.AllBullets[i]);
                    if (now - PlayerLastDamageTacken > DamageImmunity)
                    {
                        Player_Take_damage();
                        PlayerLastDamageTacken = now;
                    }
                    i--;
                }

            }
        }
        private void GiveScore(Enemy enemy)
        {
            player.Score = enemy.Score;
            if (enemy is HeavyTankEnemy) new Coin(enemy.X + SmallEnemyWidth - CoinWidth / 2, enemy.Y + SmallEnemyHeight, CoinWidth, CoinHeight, PlayerSpeed);
            if (enemy is TerroristEnemy) new Coin(enemy.X + (SmallEnemyWidth - CoinWidth) / 2, enemy.Y + SmallEnemyHeight, CoinWidth, CoinHeight, PlayerSpeed);
        }
    }
}
