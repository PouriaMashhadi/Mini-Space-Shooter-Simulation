using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    public partial class GameForm : Form
    {
        bool TripleShot = false, Shield = false, Boost = false;
        private void MakePowerUp(float x, float y)
        {
            Random rnd = new Random();
            if (rnd.Next() % 10 < 5)
            {
                PowerUp power = new PowerUp(x, y, powerUpWidth, powerUpHeight);
            }
        }
        private void Check_Collision()
        {
            for (int i = 0; i < PowerUp.allPowerUps.Count; i++)
            {
                if (PowerUp.allPowerUps[i].Hitbox.IntersectsWith(player.Hitbox))
                {
                    if (PowerUp.allPowerUps[i].PowerUpNumber == 2)
                    {
                        player.HP_count++;
                        BaseC.AllObject.Remove(PowerUp.allPowerUps[i]);
                        PowerUp.allPowerUps.RemoveAt(i);
                        i--;
                    }
                    else GivePower(PowerUp.allPowerUps[i]);
                }
            }
        }
        private void GivePower(PowerUp power)
        {
            power.Picked();
            switch (power.PowerUpNumber)
            {
                case 0:
                    TripleShot = true;
                    break;
                case 1:
                    Shield = true;
                    break;
                case 3:
                    Boost = true;
                    break;
            }
        }
        private void UpdatePowerUps()
        {

            foreach (var i in PowerUp.allPowerUps) i.Update((int)(PlayerSpeed * 0.6));
            Check_Collision();
            label1.Text = PowerUp.allPowerUps.Count.ToString();
            for (int i = 0; i < PowerUp.allPowerUps.Count; i++)
            {
                if (PowerUp.allPowerUps[i].checkFinished() && PowerUp.allPowerUps[i].Show == false)
                {

                    switch (PowerUp.allPowerUps[i].PowerUpNumber)
                    {
                        case 0:
                            TripleShot = false; break;
                        case 1: Shield = false; break;
                        case 3: Boost = false; break;
                    }
                    BaseC.AllObject.Remove(PowerUp.allPowerUps[i]);
                    PowerUp.allPowerUps.RemoveAt(i);

                    i--;
                }
            }
        }
    }
}
