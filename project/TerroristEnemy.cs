using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class TerroristEnemy : Enemy
    {
        PlayerShip player;
        int w, h;
        public TerroristEnemy(int w, int h, int Wave, PlayerShip p) : base(w, h)
        {
            Wave--;
            this.w = w;
            this.h = h;
            Score = 10;
            Speed = (float)(0.5 * (1 + 0.1 * Wave)) * -1;
            HP = 5 + 2 * Wave;
            player = p;
        }
        public override void Update()
        {
            X += ((X + w / 2 - player.X - player.ImageX / 2) / Math.Abs(X + w / 2 - player.X - player.ImageX / 2)) * Speed;
            Y += ((Y + h - player.Y - player.ImageY) / Math.Abs(Y + h - player.Y - player.ImageY)) * Speed;
        }
    }
}
