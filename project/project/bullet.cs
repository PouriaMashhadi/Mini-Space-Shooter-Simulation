using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    internal class bullet:BaseC
    {
        
        private int damage;
        public int Damage { get => damage; set => damage = value; }
        public bullet(int damage)
        {
            Damage = damage;
        }

    }
}
