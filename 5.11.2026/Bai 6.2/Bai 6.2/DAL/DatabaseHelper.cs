using System.Configuration;
using MySql.Data.MySqlClient;

namespace HRM.DAL
{
    public class DatabaseHelper
    {
        
        private static string connectionString = ConfigurationManager.ConnectionStrings["HRMDB"].ConnectionString;

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}