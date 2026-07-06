using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    internal class EnemyBullet : BaseC
    {
        int speed;
        public string Direction;
        public static List<EnemyBullet> AllBullets = new List<EnemyBullet>();
        public EnemyBullet(float x, float y, int w, int h, int speed, string dir) : base(x, y, w, h)
        {
            AllBullets.Add(this);
            this.speed = speed;
            Direction = dir;
        }
        private bool update(int bottom, int right)
        {
            if (Direction == "S") Y += speed;
            if (Direction == "N") Y -= speed;
            if (Direction == "E") X += speed;
            if (Direction == "W") X -= speed;
            if (Direction == "SE")
            {
                Y += speed / 2;
                X += speed / 2;
            }
            if (Direction == "SW")
            {
                Y += speed / 2;
                X -= speed / 2;
            }
            if (Direction == "NE")
            {
                Y -= speed / 2;
                X += speed / 2;
            }
            if (Direction == "NW")
            {
                Y -= speed / 2;
                X -= speed / 2;
            }



            if (Y >= bottom || Y <= 0 || X >= right || X <= 0) return false;
            return true;
        }
        public static void MoveBullets(int bottom, int right)
        {

            for (int i = 0; i < AllBullets.Count; i++)
            {
                if (AllBullets[i].update(bottom, right) == false) AllBullets.Remove(AllBullets[i]);
                else AllBullets[i].UpdateHitbox();
            }
        }
    }
}
