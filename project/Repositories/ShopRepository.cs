using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Project.Database;

namespace Project
{
    internal class ShopRepository
    {
        public List<ShopItem> GetAllItems()
        {
            List<ShopItem> items = new List<ShopItem>();

            using SQLiteConnection connection = DatabaseManager.GetConnection();

            connection.Open();

            string query = "SELECT * FROM ShopItems";

            using SQLiteCommand command = new SQLiteCommand(query, connection);
            using SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ShopItem item = new ShopItem();

                item.Id = Convert.ToInt32(reader["Id"]);
                item.Name = reader["Name"].ToString();

                item.Category = (ShopItem.ShopCategory)Enum.Parse(
                    typeof(ShopItem.ShopCategory),
                    reader["Category"].ToString());

                item.Price = Convert.ToInt32(reader["Price"]);
                item.Purchased = Convert.ToInt32(reader["Purchased"]) == 1;
                item.Equipped = Convert.ToInt32(reader["Equipped"]) == 1;
                item.ImagePath = reader["ImagePath"].ToString();

                items.Add(item);
            }

            return items;
        }

        public ShopItem? GetItemById(int id)
        {
            using SQLiteConnection connection = DatabaseManager.GetConnection();

            connection.Open();

            string query = "SELECT * FROM ShopItems WHERE Id = @Id";

            using SQLiteCommand command = new SQLiteCommand(query, connection);

            command.Parameters.AddWithValue("@Id", id);

            using SQLiteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                ShopItem item = new ShopItem();

                item.Id = Convert.ToInt32(reader["Id"]);
                item.Name = reader["Name"].ToString();

                item.Category = (ShopItem.ShopCategory)Enum.Parse(
                    typeof(ShopItem.ShopCategory),
                    reader["Category"].ToString());

                item.Price = Convert.ToInt32(reader["Price"]);
                item.Purchased = Convert.ToInt32(reader["Purchased"]) == 1;
                item.Equipped = Convert.ToInt32(reader["Equipped"]) == 1;
                item.ImagePath = reader["ImagePath"].ToString();

                return item;
            }

            return null;
        }

        public void BuyItem(int itemId)
        {
            using SQLiteConnection connection = DatabaseManager.GetConnection();

            connection.Open();

            string query = @"
                UPDATE ShopItems
                SET Purchased = 1
                WHERE Id = @Id";

            using SQLiteCommand command = new SQLiteCommand(query, connection);

            command.Parameters.AddWithValue("@Id", itemId);

            command.ExecuteNonQuery();
        }

        public void EquipItem(int itemId, ShopItem.ShopCategory category)
        {
            using SQLiteConnection connection = DatabaseManager.GetConnection();

            connection.Open();

            string unequipQuery = @"
                UPDATE ShopItems
                SET Equipped = 0
                WHERE Category = @Category";

            using (SQLiteCommand command = new SQLiteCommand(unequipQuery, connection))
            {
                command.Parameters.AddWithValue("@Category", category.ToString());
                command.ExecuteNonQuery();
            }

            string equipQuery = @"
                UPDATE ShopItems
                SET Equipped = 1
                WHERE Id = @Id";

            using (SQLiteCommand command = new SQLiteCommand(equipQuery, connection))
            {
                command.Parameters.AddWithValue("@Id", itemId);
                command.ExecuteNonQuery();
            }
        }
    }
}