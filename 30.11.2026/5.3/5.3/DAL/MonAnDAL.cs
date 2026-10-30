using System.Collections.Generic;
using MySql.Data.MySqlClient;
using CafePOS.DTO;

namespace CafePOS.DAL
{
    public class MonAnDAL
    {
        public List<MonAnDTO> GetAll()
        {
            var list = new List<MonAnDTO>();
            using (var conn = DBHelper.GetConnection())
            using (var cmd = new MySqlCommand("SELECT MaMon, TenMon, MaDanhMuc, DonGia FROM MonAn ORDER BY MaMon", conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        list.Add(Map(reader));
                }
            }
            return list;
        }

        public List<MonAnDTO> GetByDanhMuc(int maDanhMuc)
        {
            var list = new List<MonAnDTO>();
            using (var conn = DBHelper.GetConnection())
            using (var cmd = new MySqlCommand("SELECT MaMon, TenMon, MaDanhMuc, DonGia FROM MonAn WHERE MaDanhMuc=@id ORDER BY TenMon", conn))
            {
                cmd.Parameters.AddWithValue("@id", maDanhMuc);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        list.Add(Map(reader));
                }
            }
            return list;
        }

        public bool Insert(MonAnDTO mon)
        {
            using (var conn = DBHelper.GetConnection())
            using (var cmd = new MySqlCommand(
                "INSERT INTO MonAn (TenMon, MaDanhMuc, DonGia) VALUES (@ten, @danhmuc, @gia)", conn))
            {
                cmd.Parameters.AddWithValue("@ten", mon.TenMon);
                cmd.Parameters.AddWithValue("@danhmuc", mon.MaDanhMuc);
                cmd.Parameters.AddWithValue("@gia", mon.DonGia);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(MonAnDTO mon)
        {
            using (var conn = DBHelper.GetConnection())
            using (var cmd = new MySqlCommand(
                "UPDATE MonAn SET TenMon=@ten, MaDanhMuc=@danhmuc, DonGia=@gia WHERE MaMon=@id", conn))
            {
                cmd.Parameters.AddWithValue("@ten", mon.TenMon);
                cmd.Parameters.AddWithValue("@danhmuc", mon.MaDanhMuc);
                cmd.Parameters.AddWithValue("@gia", mon.DonGia);
                cmd.Parameters.AddWithValue("@id", mon.MaMon);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int maMon)
        {
            using (var conn = DBHelper.GetConnection())
            using (var cmd = new MySqlCommand("DELETE FROM MonAn WHERE MaMon=@id", conn))
            {
                cmd.Parameters.AddWithValue("@id", maMon);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        private MonAnDTO Map(System.Data.IDataReader reader)
        {
            return new MonAnDTO
            {
                MaMon = reader.GetInt32(reader.GetOrdinal("MaMon")),
                TenMon = reader.GetString(reader.GetOrdinal("TenMon")),
                MaDanhMuc = reader.IsDBNull(reader.GetOrdinal("MaDanhMuc")) ? 0 : reader.GetInt32(reader.GetOrdinal("MaDanhMuc")),
                DonGia = reader.GetDecimal(reader.GetOrdinal("DonGia"))
            };
        }
    }
}
