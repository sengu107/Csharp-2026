using MySql.Data.MySqlClient;

namespace KaraokeApp.DAL
{
    public class DBConnect
    {
        protected MySqlConnection GetConnection()
        {
            
            return new MySqlConnection("Server=localhost;Database=KaraokeDB;Uid=root;Pwd=senchan");
        }
    }
}