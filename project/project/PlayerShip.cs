using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    internal class PlayerShip : BaseC
    {
        private int hp_count;
        private int speed;
        private int default_Hp;
        private int score = 0, coin = 0;
        public int ImageX, ImageY;
        public bool goUp, goDown, goLeft, goRight;
        public int HP_count { get => hp_count; set => hp_count = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Score { get => score; set => score = value; }
        public int Coin { get => coin; set => coin = value; }
        public PlayerShip(int hp_count, int speed, int imgx, int imgy) : base(-1, -1, imgx, imgy)
        {
            HP_count = hp_count;
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
            UpdateHitbox();
        }
        public void Reset(int clientX, int clientY)
        {
            X = (clientX - ImageX ) / 2;
            Y = clientY - 300;
            score = 0;
            coin = 0;
            hp_count = default_Hp;
        }
        public void EnemyKilled(Enemy enemy)
        {

        }
    }
}
