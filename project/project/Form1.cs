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
        //shop vars
        string Ship_skin_path = @"..\..\..\..\Resource\Spaceship.png", bullet_skin_path = @"..\..\..\..\Resource\bullet.png", Background_Themes_path = @"..\..\..\..\Resource\a.png" ;
        bool does_have_ExtraLive;
        //images
        Image ShipImage, BulletImage, Background, HPImage, CoinImage;
        //classes
        PlayerShip player;
        bullet bulletTypes;
        List<bullet> allBullets = new List<bullet>();
        bool shootingBullet;
        int BulletFireRate;
        //player variables
        int PlayerSpeed = 3, ShipWidth = 100, ShipHeight = 100, BulletSpeed = 4, bulletWidth = 2, bulletHeight = 20;
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
        private void ImageSetUp()
        {
            ShipImage = Image.FromFile(Ship_skin_path);
            BulletImage = Image.FromFile(bullet_skin_path);
        }
        private void PlayerMovment()
        {

            if (player.goUp && player.Y - PlayerSpeed > 0) player.Y -= PlayerSpeed;
            if (player.goDown && player.Y + PlayerSpeed + ShipHeight < ClientSize.Height) player.Y += PlayerSpeed;
            if (player.goLeft && player.X - PlayerSpeed > 0) player.X -= PlayerSpeed;
            if (player.goRight && player.X + PlayerSpeed + ShipWidth < ClientSize.Width) player.X += PlayerSpeed;
        }
        
        private void BulletsMovement()
        {
            foreach(var b in allBullets)
            {
                b.Y -= BulletSpeed;
            }
        }
        private void Shoot()
        {
            bullet tmp = new bullet(1);
            tmp.X = player.X +( ShipWidth + bulletWidth)/2;
            tmp.Y = player.Y - bulletHeight;
            allBullets.Add(tmp);
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

        private void Paint_GameForm(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(ShipImage, player.X,player.Y, ShipWidth, ShipHeight);
            foreach(var b in allBullets)
            {
                e.Graphics.DrawImage(BulletImage, b.X, b.Y, bulletWidth, bulletHeight);
            }
        }
        
    }
}
