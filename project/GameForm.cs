using Project.Properties;
using WMPLib;

namespace Project
{
    public partial class GameForm : Form
    {
        private FormScaler scaler;
        string path = @"Music\audio2.mp3";

        public GameForm()
        {

             InitializeComponent();

            AudioManager.PlayMusic(path);
            //Dynamic Sizing
            scaler = new FormScaler(this);


            this.BackgroundImage = Image.FromFile(GameForm.Background_Themes_path);

            DoubleBuffered = true;
            GameTimer.Interval = 16; // 60fps
            SetUp();
        }
        int WaveCounter;
        bool GameOver = false;
        bool Win = false;
        private void SetUp()
        {
            // reset objects
            ClearStage();
            PlayerRepository repo = new PlayerRepository();
            PlayerData currentPlayer = repo.GetPlayer();
            // image init
            ImageSetUp();
            EnemyWaveSetUp(WaveCounter);
            GameTimer.Enabled = true;
            //player init
            int hp = 3;
            if (currentPlayer.ExtraLife==1) hp++;
            player = new PlayerShip(hp, PlayerSpeed, ShipWidth, ShipHeight);
            player.Reset(ClientSize.Width, ClientSize.Height);
        }

        private void GameTick(object sender, EventArgs e)
        {
            if (GameOver)
            {
                GameTimer.Stop();
                AudioManager.PlaySFX(SFXType.GameOver);
                MessageBox.Show("Game Over!\nTry again Later.");
                this.Close();
                return;
            }
            if (Win)
            {
                GameTimer.Stop();
                AudioManager.PlaySFX(SFXType.Winner);
                MessageBox.Show("Winnnnnnnnnnnnnnnnneeeeeeeeeeeeeeerrrrrrrrrrr !\n.");
                this.Close();
                return ;
            }
            else
            {
                PlayerDeath();
                lblHP.Text = player.HP_count.ToString();
                lblScoreCounter.Text=player.Score.ToString();
                player.Move(ClientSize.Width, ClientSize.Height);
                FireRateHolder();
                UpdateEnemies();
                UpdateAllHitboxes();
                UpdateCoins();
                bullet.MoveBullets(ClientSize.Width);
                UpdatePowerUps();
                if (CheckWaveStage())
                    EnemyWaveSetUp(++WaveCounter);
                if (WaveCounter > 10) Win = true;
                Invalidate();
            }
        }
        private void KeyDown_GameForm(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                var result = MessageBox.Show(
                    "Are You Sure You Want to Quit? coins and score will be saved but you need to start again!",
                    "Exit",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                    this.Close();

                return; 
            }

            if (e.KeyCode == Keys.W)
            {
                player.goUp = true;
            }
            if (e.KeyCode == Keys.S)
            {
                player.goDown = true;
            }
            if (e.KeyCode == Keys.A)
            {
                player.goLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                player.goRight = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                shootingBullet = true;
            }
        }
        private void KeyUp_GameForm(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D) player.goRight = false;
            if (e.KeyCode == Keys.S) player.goDown = false;
            if (e.KeyCode == Keys.A) player.goLeft = false;
            if (e.KeyCode == Keys.W) player.goUp = false;
            if (e.KeyCode == Keys.Space)
            {
                shootingBullet = false;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ClearStage();
            GameTimer.Enabled = false;
            PlayerRepository repository = new PlayerRepository();

            repository.SaveGame(player.Coin, player.Score);

            PlayerData currentPlayer = repository.GetPlayer();
            currentPlayer.ExtraLife = 0;
            repository.UpdatePlayer(currentPlayer);

            AudioManager.StopMusic();
            AudioManager.StopSFX();
            base.OnFormClosing(e);
        }
    }
}
