using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class bullet : BaseC
    {
        public static List<bullet> allBullets = new List<bullet>();



        private int damage;
        private int image_height, image_width;
        private int speed;

        private string direction;
        public int Damage { get => damage; set => damage = value; }
        public int Image_height { get => image_height; set => image_height = value; }
        public int Speed { get => speed; set => speed = value; }

        public bullet(float x, float y, int height, int width, int speed, string direction) : base(-1, -1, width, height)
        {
            X = x;
            Y = y;
            image_height = height;
            image_width = width;
            this.speed = speed;
            this.direction = direction;
            allBullets.Add(this);
        }
        private bool update(int right)
        {

            if (direction == "N") Y -= speed;
            if (direction == "NE")
            {
                Y -= speed;
                X -= speed;
            }
            if (direction == "NW")
            {
                X += speed;
                Y-= speed;
            }
            if (Y + image_height <= 0 || X < 0 || X + image_width > right) return false;
            return true;
        }
        public static void MoveBullets(int right)
        {

            for (int i = 0; i < allBullets.Count; i++)
            {
                if (allBullets[i].update(right) == false) allBullets.Remove(allBullets[i]);
                else allBullets[i].UpdateHitbox();
            }
        }
    }
}
