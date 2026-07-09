using Project.Properties;
using System;
using System.Windows.Forms;

namespace Project
{
    public partial class Shop : Form
    {
        private readonly PlayerRepository playerRepository = new PlayerRepository();
        private readonly ShopRepository shopRepository = new ShopRepository();
        private PlayerData? player;

        private FormScaler scaler;

        private static readonly Color HoverColor = Color.FromArgb(255, 255, 128);
        private static readonly Color SelectedColor = Color.FromArgb(120, 220, 120);

        private PictureBox selectedShipPic;
        private PictureBox selectedBulletPic;
        private PictureBox selectedBackgroundPic;


        public Shop()
        {
            InitializeComponent();

            scaler = new FormScaler(this);

            StylePic(picShip1);
            StylePic(picShip2);
            StylePic(picShip3);
            StylePic(picShip4);

            StylePic(picBullet1);
            StylePic(picBullet2);
            StylePic(picBullet3);

            StylePic(pbTemplate1);
            StylePic(pbTemplate2);

            StylePic(pbExtraHealth);


            btnBack.MouseEnter += (s, e) =>
                btnBack.BackColor = Color.FromArgb(80, 140, 220);

            btnBack.MouseLeave += (s, e) =>
                btnBack.BackColor = Color.Transparent;


            SelectShip(picShip1);
        }


        private void StylePic(PictureBox pb)
        {
            pb.MouseEnter += (s, e) =>
            {
                if (pb != selectedShipPic &&
                    pb != selectedBulletPic &&
                    pb != selectedBackgroundPic)
                {
                    pb.BackColor = HoverColor;
                }
            };


            pb.MouseLeave += (s, e) =>
            {
                if (pb != selectedShipPic &&
                    pb != selectedBulletPic &&
                    pb != selectedBackgroundPic)
                {
                    pb.BackColor = Color.Transparent;
                }
            };


            pb.MouseEnter += (s, e) =>
                AudioManager.PlaySFX(SFXType.ShopHover);
        }


        private void SelectShip(PictureBox pic)
        {
            if (selectedShipPic != null)
                selectedShipPic.BackColor = Color.Transparent;

            selectedShipPic = pic;
            selectedShipPic.BackColor = SelectedColor;
        }


        private void SelectBullet(PictureBox pic)
        {
            if (selectedBulletPic != null)
                selectedBulletPic.BackColor = Color.Transparent;

            selectedBulletPic = pic;
            selectedBulletPic.BackColor = SelectedColor;
        }


        private void SelectBackground(PictureBox pic)
        {
            if (selectedBackgroundPic != null)
                selectedBackgroundPic.BackColor = Color.Transparent;

            selectedBackgroundPic = pic;
            selectedBackgroundPic.BackColor = SelectedColor;
        }


        private void SelectItem(int itemId, PictureBox pictureBox)
        {
            ShopItem? item = shopRepository.GetItemById(itemId);

            if (item == null)
                return;


            if (!item.Purchased)
            {
                MessageBox.Show("Not Purchased yet.");
                return;
            }


            shopRepository.EquipItem(item.Id, item.Category);


            switch (item.Category)
            {
                case ShopItem.ShopCategory.Ship:

                    GameForm.Ship_skin_path = item.ImagePath;
                    SelectShip(pictureBox);

                    break;


                case ShopItem.ShopCategory.Bullet:

                    GameForm.bullet_skin_path = item.ImagePath;
                    SelectBullet(pictureBox);

                    break;


                case ShopItem.ShopCategory.Background:

                    GameForm.Background_Themes_path = item.ImagePath;
                    SelectBackground(pictureBox);

                    break;
            }
        }



        private void LoadEquippedItems()
        {
            var items = shopRepository.GetAllItems();


            foreach (var item in items)
            {
                if (!item.Equipped)
                    continue;


                switch (item.Category)
                {
                    case ShopItem.ShopCategory.Ship:

                        GameForm.Ship_skin_path = item.ImagePath;

                        if (item.Id == 1)
                            SelectShip(picShip1);

                        else if (item.Id == 2)
                            SelectShip(picShip2);

                        else if (item.Id == 3)
                            SelectShip(picShip3);

                        else if (item.Id == 4)
                            SelectShip(picShip4);

                        break;



                    case ShopItem.ShopCategory.Bullet:

                        GameForm.bullet_skin_path = item.ImagePath;


                        if (item.Id == 5)
                            SelectBullet(picBullet1);

                        else if (item.Id == 6)
                            SelectBullet(picBullet2);

                        else if (item.Id == 7)
                            SelectBullet(picBullet3);

                        break;



                    case ShopItem.ShopCategory.Background:

                        GameForm.Background_Themes_path = item.ImagePath;


                        if (item.Id == 8)
                            SelectBackground(pbTemplate1);

                        else if (item.Id == 9)
                            SelectBackground(pbTemplate2);

                        break;
                }
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        private void picShip1_Click(object sender, EventArgs e)
        {
            SelectItem(1, picShip1);
        }


        private void picShip2_Click(object sender, EventArgs e)
        {
            SelectItem(2, picShip2);
        }


        private void picShip3_Click(object sender, EventArgs e)
        {
            SelectItem(3, picShip3);
        }


        private void picShip4_Click(object sender, EventArgs e)
        {
            SelectItem(4, picShip4);
        }



        private void picBullet1_Click(object sender, EventArgs e)
        {
            SelectItem(5, picBullet1);
        }


        private void picBullet2_Click(object sender, EventArgs e)
        {
            SelectItem(6, picBullet2);
        }


        private void picBullet3_Click(object sender, EventArgs e)
        {
            SelectItem(7, picBullet3);
        }



        private void pbTemplate1_Click(object sender, EventArgs e)
        {
            SelectItem(8, pbTemplate1);
        }


        private void pbTemplate2_Click(object sender, EventArgs e)
        {
            SelectItem(9, pbTemplate2);
        }



        private void Shop_Load(object sender, EventArgs e)
        {
            player = playerRepository.GetPlayer();

            LoadEquippedItems();
        }
    }
}