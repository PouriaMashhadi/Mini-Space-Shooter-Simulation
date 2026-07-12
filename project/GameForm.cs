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
        int WaveCounter = 1;
        bool GameOver = false;

        private void SetUp()
        {
            // reset objects
            
            ClearStage();

            // image init
            ImageSetUp();
            EnemyWaveSetUp(WaveCounter);

            //player init
            int hp = 3;
            if (does_have_ExtraLive) hp++;
            player = new PlayerShip(hp, PlayerSpeed, ShipWidth, ShipHeight);
            player.Reset(ClientSize.Width, ClientSize.Height);
        }

        private void GameTick(object sender, EventArgs e)
        {
            if (GameOver)
            {
                AudioManager.PlaySFX(SFXType.GameOver);

            }
            else
            {
                PlayerDeath();
                lblHP.Text = player.HP_count.ToString();
                player.Move(ClientSize.Width, ClientSize.Height);
                FireRateHolder();
                UpdateEnemies();
                UpdateAllHitboxes();
                UpdateCoins();
                bullet.MoveBullets(ClientSize.Width);
                UpdatePowerUps();
                if (CheckWaveStage())
                    EnemyWaveSetUp(++WaveCounter);
                if (WaveCounter > 10) GameOver = true;
                Invalidate();
            }
        }
        private void KeyDown_GameForm(object sender, KeyEventArgs e)
        {

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
            PlayerRepository repository = new PlayerRepository();

            repository.SaveGame(player.Coin, player.Score);

            AudioManager.StopMusic();
            AudioManager.StopSFX();
            base.OnFormClosing(e);
        }
    }
}
