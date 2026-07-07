using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Project
{
    public partial class GameForm : Form
    {
        int bulletWidth = 20, bulletHeight = 20, ShipWidth = 100, ShipHeight = 100, SmallEnemyWidth = 30, SmallEnemyHeight = 30;
        Image ShipImage, BulletImage, Background, HPImage, StandardEnemyImage, EnemyBulletImage;
        string Ship_skin_path = @"img\Spaceship.png", bullet_skin_path = @"img\EnemyBullet.png", Background_Themes_path = @"img\Options2.jpg";
        string Standard_skin_path = @"img\Enemy.png", Enemy_Bullet_Path = @"img\EnemyBullet.png";

        private void ImageSetUp()
        {
            ShipImage = Image.FromFile(Ship_skin_path);
            BulletImage = Image.FromFile(bullet_skin_path);
            StandardEnemyImage = Image.FromFile(Standard_skin_path);
            EnemyBulletImage = Image.FromFile(Enemy_Bullet_Path);
        }


        private void UpdateAllHitboxes()
        {
            foreach (var i in BaseC.AllObject) i.UpdateHitbox();
        }

        private void Paint_GameForm(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(ShipImage, player.X, player.Y, ShipWidth, ShipHeight);
            foreach (var b in bullet.allBullets)
            {
                e.Graphics.DrawImage(BulletImage, b.X, b.Y, bulletWidth, bulletHeight);
            }
            foreach (var i in Wave)
            {
                if (i is HeavyTankEnemy)
                    e.Graphics.DrawImage(StandardEnemyImage, i.X, i.Y, SmallEnemyWidth * 2, SmallEnemyHeight);
                else 
                    e.Graphics.DrawImage(StandardEnemyImage, i.X, i.Y, SmallEnemyWidth * 2, SmallEnemyHeight);
            }
            foreach (var b in EnemyBullet.AllBullets)
            {
                e.Graphics.DrawImage(EnemyBulletImage, b.X, b.Y, bulletWidth, bulletHeight);
            }
            //draw hit box
            //foreach (var i in BaseC.AllObject)
            //    e.Graphics.DrawRectangle(new Pen(Color.Red), i.Hitbox);
        }
    }
}
