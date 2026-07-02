using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace project
{
    public partial class GameForm : Form
    {
        int bulletWidth = 2, bulletHeight = 20, ShipWidth = 100, ShipHeight = 100, SmallEnemyWidth = 30, SmallEnemyHeight = 30;
        Image ShipImage, BulletImage, Background, HPImage, StandardEnemyImage;
        string Ship_skin_path = @"..\..\..\..\Resource\Spaceship.png", bullet_skin_path = @"..\..\..\..\Resource\bullet.png", Background_Themes_path = @"..\..\..\..\Resource\a.png";
        string Standard_skin_path = @"..\..\..\..\Resource\Enemy.png";

        private void ImageSetUp()
        {
            ShipImage = Image.FromFile(Ship_skin_path);
            BulletImage = Image.FromFile(bullet_skin_path);
            StandardEnemyImage = Image.FromFile(Standard_skin_path);
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
                e.Graphics.DrawImage(StandardEnemyImage, i.X, i.Y, SmallEnemyWidth, SmallEnemyHeight);
            }
            //draw hit box
            foreach (var i in BaseC.AllObject)
                e.Graphics.DrawRectangle(new Pen(Color.Red), i.Hitbox);
        }
    }
}
