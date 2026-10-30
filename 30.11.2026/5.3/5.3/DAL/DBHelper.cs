using MySql.Data.MySqlClient;

namespace CafePOS.DAL
{
    
    public static class DBHelper
    {
        private static readonly string connStr =
            "Server=localhost;Port=3306;Database=CafePOSDB;Uid=root;Pwd=senchan;Charset=utf8mb4;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }
    }
}
