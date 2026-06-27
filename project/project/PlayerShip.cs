using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    internal class PlayerShip : BaseC
    {
        private int hp_count;
        private int speed;
        private bullet bullet_Type;
        private int default_Hp;
        public int ImageX, ImageY;
        public bool goUp, goDown, goLeft, goRight;
        public int HP_count { get => hp_count; set => hp_count = value; }
        public int Speed { get => speed; set => speed = value; }
        public bullet Bullet_Type { get => bullet_Type; }
        public PlayerShip(int hp_count, bullet bullet_Type, int speed, int imgx, int imgy)
        {
            HP_count = hp_count;
            this.bullet_Type = bullet_Type;
            this.speed = speed;
            ImageX = imgx;
            ImageY = imgy;
            default_Hp = hp_count;
        }

        public void Move(int clientX, int clientY)
        {
            if (goUp) Y -= speed;
            if (goDown) Y += speed;
            if (goLeft) X -= speed;
            if (goRight) X += speed;

            if (X < 0) X = 0;
            if (X + ImageX > clientX) X = clientX - ImageX;
            if (Y < 0) Y = 0;
            if (Y + ImageY > clientY) Y = clientY - ImageY;
        }
        public void Reset(int clientX, int clientY)
        {
            X = (clientX + ImageX) / 2;
            X = clientY - 300;
        }
    }
}
