using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    internal class TerroristEnemy : Enemy
    {
        PlayerShip player;
        public TerroristEnemy(int w, int h, int Wave, PlayerShip p) : base(w, h)
        {
            Wave--;
            Score = 10;
            Speed = (float)(0.5 * (1 + 0.1 * Wave)) * -1;
            HP = 5 + 2 * Wave;
            player = p;
        }
        public override void Update()
        {
            X += ((X - player.X) / Math.Abs(X - player.X)) * Speed;
            Y += ((Y - player.Y) / Math.Abs(Y - player.Y)) * Speed;
        }
    }
}
