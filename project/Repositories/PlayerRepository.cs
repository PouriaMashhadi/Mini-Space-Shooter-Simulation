
using System.Data.SQLite;
using Project.Database;

namespace Project
{
    internal class PlayerRepository
    {
        public PlayerData? GetPlayer()
        {
            using SQLiteConnection connection = DatabaseManager.GetConnection();

            connection.Open();

            string query = "SELECT * FROM Player WHERE Id = 1";

            using SQLiteCommand command = new SQLiteCommand(query, connection);
            using SQLiteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new PlayerData
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Coins = Convert.ToInt32(reader["Coins"]),
                    HighScore = Convert.ToInt32(reader["HighScore"]),
                    ExtraLife = Convert.ToInt32(reader["ExtraLife"])
                };
            }

            return null;
        }

        public void UpdatePlayer(PlayerData player)
        {
            using SQLiteConnection connection = DatabaseManager.GetConnection();

            connection.Open();

            string query = @"
            UPDATE Player
            SET
                Coins = @Coins,
                HighScore = @HighScore,
                ExtraLife = @ExtraLife
            WHERE Id = @Id";

            using SQLiteCommand command = new SQLiteCommand(query, connection);

            command.Parameters.AddWithValue("@Id", player.Id);
            command.Parameters.AddWithValue("@Coins", player.Coins);
            command.Parameters.AddWithValue("@HighScore", player.HighScore);
            command.Parameters.AddWithValue("@ExtraLife", player.ExtraLife);

            command.ExecuteNonQuery();
        }

        public void SaveGame(int earnedCoins, int score)
        {
            PlayerData? player = GetPlayer();

            if (player == null)
                return;

            player.Coins += earnedCoins;

            if (score > player.HighScore)
                player.HighScore = score;

            UpdatePlayer(player);
        }
    }
}
