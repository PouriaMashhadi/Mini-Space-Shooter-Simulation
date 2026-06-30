using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    public partial class GameForm : Form
    {
        private void EnemyWaveSetUp(int Counter)
        {
            switch (Counter)
            {
                case 1:
                    Wave = new List<Enemy> { new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), new StandardEnemy(SmallEnemyWidth, SmallEnemyHeight, WaveCounter), };
                    SpawnEnemy();
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
    }
}
