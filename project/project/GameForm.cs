namespace project
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            GameTimer.Interval = 16; // 60fps
            SetUp();
        }
       
        private void SetUp()
        {
            bulletTypes = new bullet(1);
            int hp = 3;
            if (does_have_ExtraLive) hp++;
            player = new PlayerShip(hp, PlayerSpeed, ShipWidth, ShipHeight);
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
            e.SuppressKeyPress = true;

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
            if (e.KeyCode == Keys.Space && !shootingBullet)
            {
                shootingBullet = true ;
                Shoot();
            }
        }
        private void KeyUp_GameForm(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) player.goRight = false;
            if (e.KeyCode == Keys.S) player.goDown = false;
            if (e.KeyCode == Keys.A) player.goLeft = false;
            if (e.KeyCode == Keys.D) player.goUp = false;
            if (e.KeyCode == Keys.Space)
            {
                shootingBullet = false;
            }
        }

    }
}
