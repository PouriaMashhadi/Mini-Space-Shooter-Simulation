using System.Data.SQLite;
using Project.Database;

namespace Project
{
    internal class PlayerRepository
    {
        public PlayerData GetPlayer()
        {
            using SQLiteConnection connection = DatabaseManager.GetConnection();

            connection.Open();

            string query = "SELECT * FROM Player WHERE Id = 1";

            SQLiteCommand command = new SQLiteCommand(query, connection);

            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                PlayerData player = new PlayerData();

                player.Id = Convert.ToInt32(reader["Id"]);
                player.Coins = Convert.ToInt32(reader["Coins"]);
                player.HighScore = Convert.ToInt32(reader["HighScore"]);
                player.ExtraLife = Convert.ToInt32(reader["ExtraLife"]);

                return player;
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
    }
}