using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace project
{
    internal class Enemy : BaseC
    {
        public int HP { get; set; }
        public float Speed { get; set; }
        public int Score { get; set; }
        public int Size { get; set; }
        public Enemy(int w, int h) : base(-1, -1, w, h) { }
        public virtual bool TakeDamage(int damage) { return false; } //retrun false if the enemy is dead
        public virtual void Update() { }
        public void Spawn(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
