using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class BaseC
    {
        public static List<BaseC> AllObject = new List<BaseC>();
        private float x, y;
        private int  w, h;
        private Rectangle hitbox;

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public Rectangle Hitbox { get => hitbox; }
        public BaseC(float x, float y, int w, int h)
        {
            X = x;
            Y = y;
            this.w = w;
            this.h = h;
            hitbox = new Rectangle((int)x, (int)y, w, h);
            AllObject.Add(this);
        }
        public void UpdateHitbox()
        {
            hitbox = new Rectangle((int)x, (int)y, w, h);
        }
    }
}
