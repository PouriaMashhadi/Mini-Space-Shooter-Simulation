namespace Project
{
    internal class ShopItem
    {
        internal enum ShopCategory
        {
            Ship,
            Bullet,
            Background,
            Consumable
        }
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public ShopCategory Category { get; set; }

        public int Price { get; set; }

        public bool Purchased { get; set; }

        public bool Equipped { get; set; }

        public string ImagePath { get; set; } = "";
    }
}