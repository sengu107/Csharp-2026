using MySql.Data.MySqlClient;
using System.Configuration;

namespace Bai_6_4.DAL
{
    public class DBConnect
    {
        protected MySqlConnection GetConnection()
        {
            string connStr = ConfigurationManager.ConnectionStrings["GarageMySqlConStr"].ConnectionString;
            return new MySqlConnection(connStr);
        }
    }
}