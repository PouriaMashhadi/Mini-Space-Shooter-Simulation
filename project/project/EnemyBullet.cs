using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    internal class EnemyBullet : BaseC
    {
        public static List<EnemyBullet> AllBullets = new List<EnemyBullet>();
        public EnemyBullet(int x, int y, int w, int h) : base(x, y, w, h)
        {
            AllBullets.Add(this);
        }
        //complete after 5.3
    }
}
