namespace project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            GameTimer.Interval = 16; // 60fps
            SetUp();
        }

        private void SetUp()
        {
            // image init
            ImageSetUp();

            //player init
            int hp = 3;
            if (does_have_ExtraLive) hp++;
            player = new PlayerShip(hp, new bullet(1, bulletHeight, BulletSpeed), PlayerSpeed, ShipWidth, ShipHeight);
            player.Reset(ClientSize.Width, ClientSize.Height);

        }

        private void GameTick(object sender, EventArgs e)
        {
            player.Move(ClientSize.Width, ClientSize.Height);
            FireRateHolder();
            bullet.MoveBullets();           
            Invalidate();
        }
        private void KeyDown_GameForm(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up )
            {
                player.goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                player.goDown = true;
            }
            if (e.KeyCode == Keys.Left )
            {
                player.goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
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
            if (e.KeyCode == Keys.Right) player.goRight = false;
            if (e.KeyCode == Keys.Down) player.goDown = false;
            if (e.KeyCode == Keys.Left) player.goLeft = false;
            if (e.KeyCode == Keys.Up) player.goUp = false;
            if (e.KeyCode == Keys.Space)
            {
                shootingBullet = false;
            }
        }

    }
}
