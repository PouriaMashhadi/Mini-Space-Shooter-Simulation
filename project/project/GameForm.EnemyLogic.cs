using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    public partial class GameForm : Form
    {
        private void Check_Enemy_Collision()
        {
            foreach (var i in BaseC.AllObject)
            {
                if (i is Enemy)
                {
                    if (player.Hitbox.IntersectsWith((i as Enemy).Hitbox))
                    {
                        Take_damage();
                    }
                }
            }
        }
        private void Check_bullet_Collision_withEnemy()
        {
            foreach (var i in BaseC.AllObject)
            {
                foreach (var en in BaseC.AllObject)
                {
                    if (en is Enemy)
                    {
                        if (i is bullet)
                        {
                            if ((en as Enemy).Hitbox.IntersectsWith((i as bullet).Hitbox))
                            {
                                if ((en as Enemy).TakeDamage() == false)
                                {
                                    player.EnemyKilled((en as Enemy));
                                }
                                bullet.allBullets.Remove((i as bullet));
                            }
                        }
                    }
                }
            }
        }
        private void Check_Player_Collision_withEnemyBullet()
        {
            foreach (var i in BaseC.AllObject)
            {
                if (i is EnemyBullet)
                {
                    if (player.Hitbox.IntersectsWith((i as EnemyBullet).Hitbox))
                    {
                        Take_damage();
                        EnemyBullet.AllBullets.Remove((i as EnemyBullet));

                    }
                }
            }
        }
    }
}
