using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    internal class PlayerShip:BaseC
    {
        private int hp_count;
        private bullet bullet_Type;

        public bool goUp, goDown, goLeft, goRight;
        public int HP_count { get => hp_count; set => hp_count = value; }
        public bullet Bullet_Type { get => bullet_Type;}
        public PlayerShip(int hp_count, bullet bullet_Type)
        {
            HP_count = hp_count;
            this.bullet_Type = bullet_Type;
        }
    }
}
