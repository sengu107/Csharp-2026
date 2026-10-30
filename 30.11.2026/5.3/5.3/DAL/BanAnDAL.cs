using System.Collections.Generic;
using MySql.Data.MySqlClient;
using CafePOS.DTO;

namespace CafePOS.DAL
{
    public class BanAnDAL
    {
        public List<BanAnDTO> GetAll()
        {
            var list = new List<BanAnDTO>();
            using (var conn = DBHelper.GetConnection())
            using (var cmd = new MySqlCommand("SELECT MaBan, TenBan, TrangThai FROM BanAn ORDER BY MaBan", conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new BanAnDTO
                        {
                            MaBan = reader.GetInt32("MaBan"),
                            TenBan = reader.GetString("TenBan"),
                            TrangThai = reader.GetString("TrangThai")
                        });
                    }
                }
            }
            return list;
        }

        public bool CapNhatTrangThai(int maBan, string trangThai)
        {
            using (var conn = DBHelper.GetConnection())
            using (var cmd = new MySqlCommand("UPDATE BanAn SET TrangThai=@tt WHERE MaBan=@maBan", conn))
            {
                cmd.Parameters.AddWithValue("@tt", trangThai);
                cmd.Parameters.AddWithValue("@maBan", maBan);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

     
        public void CapNhatTrangThai(int maBan, string trangThai, MySqlConnection conn, MySqlTransaction trans)
        {
            using (var cmd = new MySqlCommand("UPDATE BanAn SET TrangThai=@tt WHERE MaBan=@maBan", conn, trans))
            {
                cmd.Parameters.AddWithValue("@tt", trangThai);
                cmd.Parameters.AddWithValue("@maBan", maBan);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
