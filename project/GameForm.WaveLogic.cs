using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    public partial class GameForm : Form
    {
        private void EnemyWaveSetUp(int Counter)
        {
            //note: in 2 or more rows, scout enemy cant be above other type of enemy, because they are faster than them annd it wont look good
            switch (Counter)
            {
                case 1://10 standard
                    Wave = new List<Enemy> { new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter) };
                    SpawnEnemy(1);
                    break;
                case 2://10 standard
                    Wave = new List<Enemy> { new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), };
                    SpawnEnemy(2);
                    break;
                case 3:
                    Wave = new List<Enemy> { new ScoutEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ScoutEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ScoutEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ScoutEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ScoutEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter) };
                    SpawnEnemy(1);
                    break;
                case 4://2 st, 7 scout
                    Wave = new List<Enemy> { new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ScoutEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ScoutEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ScoutEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ScoutEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ScoutEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ScoutEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ScoutEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), };
                    SpawnEnemy(2);
                    break;
                case 5://4 terror, 1 shooter
                    Wave = new List<Enemy> { new TerroristEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter, player), new TerroristEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter, player), new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new TerroristEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter, player), new TerroristEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter, player) };
                    SpawnEnemy(1);
                    break;
                case 6://8 shooter
                    Wave = new List<Enemy> { new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter) };
                    SpawnEnemy(2);
                    break;
                case 7://6 terror
                    Wave = new List<Enemy> { new TerroristEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter, player), new TerroristEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter, player), new TerroristEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter, player), new TerroristEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter, player), new TerroristEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter, player), new TerroristEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter, player), };
                    SpawnEnemy(2);
                    break;
                case 8://6 shooter, 6 st
                    Wave = new List<Enemy> { new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter)};
                    SpawnEnemy(2);
                    break;
                case 9://20 st
                    Wave = new List<Enemy> { new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter) };
                    SpawnEnemy(3);
                    break;
                case 10:
                    Wave = new List<Enemy> { new HeavyTankEnemy(SmallEnemyWidth * 2, SmallEnemyHeight, WaveCounter) };
                    SpawnEnemy(1);
                    break;
            }

        }
        private bool CheckWaveStage()
        {
            if (Wave.Count == 0)
            {
                lblStageCounter.Text = $"{WaveCounter + 1}";
                return true;
            }// Wave finished
            return false;
        }
        private void ClearStage()
        {
            BaseC.AllObject.Clear();
            HeavyTankEnemy.allShooters.Clear();
            ShooterEnemy.allShooters.Clear();
            EnemyBullet.AllBullets.Clear();
            bullet.allBullets.Clear();
            PowerUp.allPowerUps.Clear();
            WaveCounter = 1;
        }
    }
}
