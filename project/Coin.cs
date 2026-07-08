using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class Coin : BaseC
    {
        int speed;

        public Coin(float x, float y, int w, int h, int speed) : base(x, y, w, h)
        {
            this.speed = speed;
        }
        public void Update()
        {
            Y += speed;
        }
    }
}
