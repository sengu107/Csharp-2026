using System.Configuration;
using MySql.Data.MySqlClient;

namespace Market.DAL
{
    public static class DatabaseHelper
    {
        private static readonly string connStr =
            ConfigurationManager.ConnectionStrings["SalesDB"].ConnectionString;

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }
    }
}
