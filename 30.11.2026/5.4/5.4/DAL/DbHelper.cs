using System;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace HotelManagement.DAL
{
    
    public static class DbHelper
    {
        public static string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString; }
        }

        public static MySqlConnection CreateConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public static MySqlParameter Param(string name, object value)
        {
            return new MySqlParameter(name, value ?? DBNull.Value);
        }

        public static MySqlParameter Param(string name, MySqlDbType type, int size, object value)
        {
            var p = new MySqlParameter(name, type, size);
            p.Value = value ?? DBNull.Value;
            return p;
        }

        private static T Run<T>(string sql, MySqlParameter[] ps, UnitOfWork uow, Func<MySqlCommand, T> action)
        {
            if (uow != null)
            {
                using (var cmd = new MySqlCommand(sql, uow.Tran.Connection, uow.Tran))
                {
                    if (ps != null) cmd.Parameters.AddRange(ps);
                    return action(cmd);
                }
            }

            using (var conn = CreateConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                if (ps != null) cmd.Parameters.AddRange(ps);
                conn.Open();
                return action(cmd);
            }
        }

        public static int ExecuteNonQuery(string sql, MySqlParameter[] ps = null, UnitOfWork uow = null)
        {
            return Run(sql, ps, uow, cmd => cmd.ExecuteNonQuery());
        }

        public static object ExecuteScalar(string sql, MySqlParameter[] ps = null, UnitOfWork uow = null)
        {
            return Run<object>(sql, ps, uow, cmd => cmd.ExecuteScalar());
        }

        public static DataTable ExecuteDataTable(string sql, MySqlParameter[] ps = null, UnitOfWork uow = null)
        {
            return Run(sql, ps, uow, cmd =>
            {
                var dt = new DataTable();
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                return dt;
            });
        }
    }
}
