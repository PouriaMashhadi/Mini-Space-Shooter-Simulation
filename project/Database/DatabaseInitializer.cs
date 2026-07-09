using System.Data.SQLite;

namespace Project.Database
{
    internal static class DatabaseInitializer
    {
        public static void Initialize()
        {
            using SQLiteConnection connection = DatabaseManager.GetConnection();

            connection.Open();

            // Player Table
            string createPlayerTable = @"
            CREATE TABLE IF NOT EXISTS Player
            (
                Id INTEGER PRIMARY KEY,
                Coins INTEGER NOT NULL,
                HighScore INTEGER NOT NULL,
                ExtraLife INTEGER NOT NULL
            );";

            using (SQLiteCommand command = new SQLiteCommand(createPlayerTable, connection))
            {
                command.ExecuteNonQuery();
            }

            // Shop Table
            string createShopTable = @"
            CREATE TABLE IF NOT EXISTS ShopItems
            (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT NOT NULL,
                Category TEXT NOT NULL,
                Price INTEGER NOT NULL,
                Purchased INTEGER NOT NULL,
                Equipped INTEGER NOT NULL,
                ImagePath TEXT NOT NULL
            );";

            using (SQLiteCommand command = new SQLiteCommand(createShopTable, connection))
            {
                command.ExecuteNonQuery();
            }

            // Player Seed
            string checkPlayer = "SELECT COUNT(*) FROM Player";

            using (SQLiteCommand command = new SQLiteCommand(checkPlayer, connection))
            {
                long count = (long)command.ExecuteScalar();

                if (count == 0)
                {
                    string insertPlayer = @"
                    INSERT INTO Player
                    (Id, Coins, HighScore, ExtraLife)
                    VALUES
                    (1, 0, 0, 0);";

                    using SQLiteCommand insert = new SQLiteCommand(insertPlayer, connection);
                    insert.ExecuteNonQuery();
                }
            }

            // Shop Seed
            string checkShop = "SELECT COUNT(*) FROM ShopItems";

            using (SQLiteCommand command = new SQLiteCommand(checkShop, connection))
            {
                long count = (long)command.ExecuteScalar();

                if (count == 0)
                {
                    string insertShop = @"
                    INSERT INTO ShopItems
                    (Name, Category, Price, Purchased, Equipped, ImagePath)
                    VALUES

                    ('Default Ship','Ship',0,1,1,'img\Spaceship.png'),
                    ('Ship 2','Ship',500,0,0,'img\ship2.png'),
                    ('Ship 3','Ship',700,0,0,'img\ship3.png'),
                    ('Ship 4','Ship',1000,0,0,'img\ship4.png'),

                    ('Default Bullet','Bullet',0,1,1,'img\EnemyBullet.png'),
                    ('Bullet 2','Bullet',300,0,0,'img\Bulletmain2.png'),
                    ('Bullet 3','Bullet',600,0,0,'img\Bulletmain3.png'),

                    ('Background 1','Background',0,1,1,'img\Options2.jpg'),
                    ('Background 2','Background',800,0,0,'img\Template2.jpg'),

                    ('Extra Life','Consumable',1000,0,0,'img\ExtraLife.png');";

                    using SQLiteCommand insert = new SQLiteCommand(insertShop, connection);
                    insert.ExecuteNonQuery();
                }
            }
        }
    }
}