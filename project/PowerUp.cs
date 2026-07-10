using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class PowerUp : BaseC
    {
        public static List<PowerUp> allPowerUps = new List<PowerUp>();
        long startingTimer;
        private int powerUpNumber;
        private bool show = true;
        public bool Show { get => show; }
        public int PowerUpNumber { get { return powerUpNumber; } }
        public PowerUp(float x, float y, int w, int h) : base(x, y, w, h)
        {
            Random rnd = new Random(DateTime.Now.Second);
            powerUpNumber = rnd.Next() % 4;
            allPowerUps.Add(this);
        }
        public void Picked()
        {
            startingTimer = DateTime.Now.Ticks;
            show = false;
        }
        public void Update(int speed)
        {
            Y += speed;
        }
        public bool checkFinished()
        {
            if (DateTime.Now.Ticks - startingTimer > 5 * TimeSpan.TicksPerSecond) return true;
            return false;
        }
    }
}
