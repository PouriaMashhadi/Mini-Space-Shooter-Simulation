using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    internal class bullet : BaseC
    {
        
        private int damage;
        public int Damage { get => damage; set => damage = value; }
        public int Image_height { get => image_height; set => image_height = value; }
        public int Speed { get => speed; set => speed = value; }

        public bullet(int damage, int height, int width, int speed) : base(-1, -1, width, height)
        {
            Damage = damage;
        }
        private bool update()
        {
            if (Y + image_height <= 0) return false;
            Y -= speed;
            return true;
        }
        public static void MoveBullets()
        {

            for (int i = 0; i < allBullets.Count; i++)
            {
                if (allBullets[i].update() == false) allBullets.Remove(allBullets[i]);
                else allBullets[i].UpdateHitbox();
            }
        }
    }
}
