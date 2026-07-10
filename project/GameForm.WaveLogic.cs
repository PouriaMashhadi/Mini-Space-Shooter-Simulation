using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    public partial class GameForm : Form
    {
        private void EnemyWaveSetUp(int Counter)
        {
            switch (Counter)
            {
                case 1:
                    Wave = new List<Enemy> { new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter) };
                    break;
                case 2:
                    Wave = new List<Enemy> { new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), };
                    break;
                case 3:
                    Wave = new List<Enemy> { new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ScoutEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ScoutEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ScoutEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter) };
                    break;
                case 4:
                    Wave = new List<Enemy> { new ScoutEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ScoutEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ScoutEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ScoutEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ScoutEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter) };
                    break;
                case 5:
                    Wave = new List<Enemy> { new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter) };
                    break;
                case 6:
                    Wave = new List<Enemy> { new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter) };
                    break;
                case 7:
                    Wave = new List<Enemy> { new TerroristEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter, player) };
                    break;
                case 8:
                    Wave = new List<Enemy> { new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new ShooterEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter) };
                    break;
                case 9:
                    Wave = new List<Enemy> { new TerroristEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter, player), new TerroristEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter, player), new TerroristEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter, player) };
                    break;
                case 10:
                    Wave = new List<Enemy> { new HeavyTankEnemy(SmallEnemyWidth * 2, SmallEnemyHeight, WaveCounter) };
                    break;

            }
            SpawnEnemy();
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
        }
    }
}
