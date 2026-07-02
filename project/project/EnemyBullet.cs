using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    internal class EnemyBullet : BaseC
    {
        int speed;
        public static List<EnemyBullet> AllBullets = new List<EnemyBullet>();
        public EnemyBullet(float x, float y, int w, int h, int speed) : base(x, y, w, h)
        {
            AllBullets.Add(this);
            this.speed = speed;
        }
        private bool update(int a)
        {
            if (Y >= a) return false;
            Y += speed;
            return true;
        }
        public static void MoveBullets(int StopPoint)
        {

            for (int i = 0; i < AllBullets.Count; i++)
            {
                if (AllBullets[i].update(StopPoint) == false) AllBullets.Remove(AllBullets[i]);
                else AllBullets[i].UpdateHitbox();
            }
        }
    }
}
