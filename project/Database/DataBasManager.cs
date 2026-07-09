using System.Data.SQLite;

namespace Project.Database
{
    public static class DatabaseManager
    {
        private const string ConnectionString = "Data Source=game.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(ConnectionString);
        }
    }
}