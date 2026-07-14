using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Project
{
    public partial class GameForm : Form
    {
        int bulletWidth = 20, bulletHeight = 20, ShipWidth = 100, ShipHeight = 100, SmallEnemyWidth = 30, SmallEnemyHeight = 30, CoinWidth = 40, CoinHeight = 40;
        int powerUpWidth = 30, powerUpHeight = 30;
        int scoutSize = 60, Shooterasize = 60, TerroristSize = 60, HeavyTankSize = 100; 
        Image ShipImage, BulletImage, Background, HPImage, StandardEnemyImage, EnemyBulletImage, CoinImage, TripleShotImage, ShieldImage, BoostImage, HpBuffImage;
        Image ShooterEnemyImage, ScoutEnemyImage, TerroristEnemyImage, HeavyTankEnemyImage;
        public static string Ship_skin_path = @"img\Spaceship.png", bullet_skin_path = @"img\EnemyBullet.png", Background_Themes_path = @"img\Options2.jpg";
        public string Standard_skin_path = @"img\Enemy.png", Enemy_Bullet_Path = @"img\EnemyBullet.png", Coin_Skin_path = @"img\Coins.png";
        public string Triple_shot_path = @"img\Triple.png", ExtraHealth_path = @"img\ExtraHealth.png", Boost_path = @"img\Boost.png", Shield_path = @"img\Shield.png";
        private void ImageSetUp()
        {
            ShipImage = Image.FromFile(Ship_skin_path);
            BulletImage = Image.FromFile(bullet_skin_path);
            StandardEnemyImage = Image.FromFile(Standard_skin_path);
            ScoutEnemyImage = Image.FromFile(@"img\ScoutEnemy.png");
            ShooterEnemyImage = Image.FromFile(@"img\ShooterEnemy.png");
            HeavyTankEnemyImage = Image.FromFile(@"img\HeavyTankEnemy.png");
            TerroristEnemyImage = Image.FromFile(@"img\TerroristEnemy.png");
            EnemyBulletImage = Image.FromFile(Enemy_Bullet_Path);
            CoinImage = Image.FromFile(Coin_Skin_path);
            TripleShotImage = Image.FromFile(Triple_shot_path);
            ShieldImage = Image.FromFile(Shield_path);
            BoostImage = Image.FromFile(Boost_path);
            HpBuffImage = Image.FromFile(ExtraHealth_path);
        }


        private void UpdateAllHitboxes()
        {
            foreach (var i in BaseC.AllObject) i.UpdateHitbox();
        }

        private void Paint_GameForm(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(ShipImage, player.X, player.Y, ShipWidth, ShipHeight);
            if (Shield)
            {
                e.Graphics.DrawImage(ShieldImage, player.X, player.Y, ShipWidth, ShipHeight);
            }
            foreach (var b in bullet.allBullets)
            {
                e.Graphics.DrawImage(BulletImage, b.X, b.Y, bulletWidth, bulletHeight);
            }
            foreach (var i in Wave)
            {
                if (i is HeavyTankEnemy)
                    e.Graphics.DrawImage(HeavyTankEnemyImage, i.X, i.Y, HeavyTankSize, HeavyTankSize);
                else if (i is ScoutEnemy)
                    e.Graphics.DrawImage(ScoutEnemyImage, i.X, i.Y, scoutSize, scoutSize);
                else if (i is ShooterEnemy)
                    e.Graphics.DrawImage(ShooterEnemyImage, i.X, i.Y, Shooterasize , Shooterasize);
                else if (i is TerroristEnemy)
                    e.Graphics.DrawImage(TerroristEnemyImage, i.X, i.Y, TerroristSize , TerroristSize);
                else
                    e.Graphics.DrawImage(StandardEnemyImage, i.X, i.Y, SmallEnemyWidth, SmallEnemyHeight);

            }
            foreach (var b in EnemyBullet.AllBullets)
            {
                e.Graphics.DrawImage(EnemyBulletImage, b.X, b.Y, bulletWidth, bulletHeight);
            }
            foreach (var c in BaseC.AllObject)
                if (c is Coin)
                {
                    e.Graphics.DrawImage(CoinImage, c.X, c.Y, CoinWidth, CoinHeight);
                }
            foreach (var i in PowerUp.allPowerUps)
            {
                if (!i.Show) continue;
                switch (i.PowerUpNumber)
                {
                    case 0: e.Graphics.DrawImage(TripleShotImage, i.X, i.Y, powerUpWidth, powerUpHeight); break;
                    case 1: e.Graphics.DrawImage(ShieldImage, i.X, i.Y, powerUpWidth, powerUpHeight); break;
                    case 2: e.Graphics.DrawImage(HpBuffImage, i.X, i.Y, powerUpWidth, powerUpHeight); break;
                    case 3: e.Graphics.DrawImage(BoostImage, i.X, i.Y, powerUpWidth, powerUpHeight); break;
                }
            }

            //draw hit box
            //foreach (var i in BaseC.AllObject)
            //    e.Graphics.DrawRectangle(new Pen(Color.Red), i.Hitbox);
        }
    }
}
