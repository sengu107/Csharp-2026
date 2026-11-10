using System.Configuration;
using MySql.Data.MySqlClient;

public class DBHelper
{
    protected MySqlConnection GetConnection()
    {
        string connStr = ConfigurationManager.ConnectionStrings["MySqlConStr"].ConnectionString;
        return new MySqlConnection(connStr);
    }
}