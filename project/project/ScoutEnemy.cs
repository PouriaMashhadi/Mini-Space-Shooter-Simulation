using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    internal class ScoutEnemy : Enemy
    {
        public int updateHolder = 30;
        bool goLeft = false, goRight = true;
        public ScoutEnemy(int w, int h, int Wave) : base(w, h)
        {
            Wave--;
            Score = 2;
            Speed = (float)(0.5 * (2 + 0.1 * Wave));
            HP = 2 + 2 * Wave;
        }
        public override void Update()
        {
            if (goRight)
            {
                X += Speed * 2;
                updateHolder--;
            }
            if (goLeft)
            {
                X -= Speed * 2;
                updateHolder++;
            }
            if (updateHolder <= 0)
            {
                goRight = false;
                goLeft = true;
            }
            if (updateHolder >= 50)
            {
                goLeft = false;
                goRight = true;
            }
            Y += Speed;
        }
    }
}
