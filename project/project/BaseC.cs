using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    internal class BaseC
    {
        public static List<BaseC> AllObject = new List<BaseC>();

        private int x, y, w, h;
        private Rectangle hitbox;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public Rectangle Hitbox { get => hitbox; }
        public BaseC(int x, int y, int w, int h)
        {
            X = x;
            Y = y;
            this.w = w;
            this.h = h;
            hitbox = new Rectangle(x, y, w, h);
            AllObject.Add(this);
        }
        public void UpdateHitbox()
        {
            hitbox = new Rectangle(x, y, w, h);
        }
    }
}
