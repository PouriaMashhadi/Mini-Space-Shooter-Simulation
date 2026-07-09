using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    public partial class GameForm : Form
    {
        private void UpdateCoins()
        {
            for (int i = 0; i < BaseC.AllObject.Count; i++)
            {
                if (BaseC.AllObject[i] is Coin)
                {
                    Coin tmp = (BaseC.AllObject[i] as Coin);
                    tmp.Update();
                    if (player.Hitbox.IntersectsWith(tmp.Hitbox))
                    {
                        BaseC.AllObject.Remove(tmp);
                        player.Coin++;
                        i--;
                    }
                }

            }
        }

    }
}
