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
            bulletTypes = new bullet(1);
            int hp = 3;
            if (does_have_ExtraLive) hp++;
            player = new PlayerShip(hp,bulletTypes);
            player.X = ClientSize.Width / 2;
            player.Y = ClientSize.Height - 300;
            ImageSetUp();
        }        
       
        private void GameTick(object sender, EventArgs e)
        {
            PlayerMovment();
            BulletsMovement();
            if (shootingBullet == true)
                BulletFireRate -= 1;
            if (BulletFireRate == 0)
                shootingBullet = false;
            if(shootingBullet == false)
                BulletFireRate = 10;

            this.Invalidate();

        }
        private void KeyDown_GameForm(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;

            if (e.KeyCode == Keys.W && !player.goDown)
            {
                player.goUp = true;
            }
            if (e.KeyCode == Keys.S && !player.goUp)
            {
                player.goDown = true;
            }
            if (e.KeyCode == Keys.A && !player.goRight)
            {
                player.goLeft = true;
            }
            if (e.KeyCode == Keys.D && !player.goLeft)
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
            if (e.KeyCode == Keys.D) player.goRight = false;
            if (e.KeyCode == Keys.S) player.goDown = false;
            if (e.KeyCode == Keys.A) player.goLeft = false;
            if (e.KeyCode == Keys.W) player.goUp = false;
        }

    }
}
