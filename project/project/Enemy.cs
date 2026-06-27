using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    internal class Enemy : BaseC
    {
        public int HP { get; set; }
        public int Level { get; set; }  
        public Enemy(int x, int y, int w, int h) : base(x, y, w, h) { }
        public bool TakeDamage()
        {
            HP--;
            if (HP != 0) return true;
            Death();
            return false;
        }   
        private void Death()
        {
            AllObject.Remove(this);
        }
        //complete in 5.3
    }
}
