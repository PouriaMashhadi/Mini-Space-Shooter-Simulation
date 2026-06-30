using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.ServiceProcess;
using System.Text;

namespace project
{
    internal class StandardEnemy : Enemy
    {
        public StandardEnemy(int w, int h, int Wave) : base(w, h)
        {
            //low health and score ,medium speed
            Wave--;
            Score = 1;
            Speed = (float)(0.5 * (1 + 0.1 * Wave));
            HP = 2 + 2 * Wave;
        }
        public override void Update()
        {
            Y += Speed;
        }
        public override bool TakeDamage(int damage)
        {
            HP -= damage;
            if (HP <= 0)
            {
                return false;
            }
            return true;
        }


    }
}
