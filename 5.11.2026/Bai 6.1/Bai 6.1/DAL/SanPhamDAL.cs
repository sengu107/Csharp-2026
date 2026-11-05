using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Market.DTO;

namespace Market.DAL
{
    public class SanPhamDAL
    {
        public List<SanPham> GetAll()
        {
            var list = new List<SanPham>();
            string sql = "SELECT MaSP, TenSP, GiaBan, SoLuongTon FROM SanPham ORDER BY MaSP";

            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
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

        public List<SanPham> TimKiem(string tuKhoa)
        {
            var list = new List<SanPham>();
            string sql = @"SELECT MaSP, TenSP, GiaBan, SoLuongTon FROM SanPham
                            WHERE TenSP LIKE @tk OR MaSP LIKE @tk
                            ORDER BY TenSP";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@tk", "%" + tuKhoa + "%");
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        list.Add(Map(reader));
                }
            }
            return list;
        }

        public SanPham GetByMa(string maSP)
        {
            string sql = "SELECT MaSP, TenSP, GiaBan, SoLuongTon FROM SanPham WHERE MaSP=@MaSP";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) return Map(reader);
                }
            }
            return null;
        }

        public bool Insert(SanPham sp)
        {
            string sql = @"INSERT INTO SanPham (MaSP, TenSP, GiaBan, SoLuongTon)
                            VALUES (@MaSP, @TenSP, @Gia, @SL)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
                cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
                cmd.Parameters.AddWithValue("@Gia", sp.GiaBan);
                cmd.Parameters.AddWithValue("@SL", sp.SoLuongTon);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(SanPham sp)
        {
            string sql = @"UPDATE SanPham SET TenSP=@TenSP, GiaBan=@Gia, SoLuongTon=@SL
                            WHERE MaSP=@MaSP";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
                cmd.Parameters.AddWithValue("@Gia", sp.GiaBan);
                cmd.Parameters.AddWithValue("@SL", sp.SoLuongTon);
                cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(string maSP)
        {
            string sql = "DELETE FROM SanPham WHERE MaSP=@MaSP";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        private SanPham Map(MySqlDataReader reader)
        {
            return new SanPham
            {
                MaSP = reader["MaSP"].ToString(),
                TenSP = reader["TenSP"].ToString(),
                GiaBan = (decimal)reader["GiaBan"],
                SoLuongTon = (int)reader["SoLuongTon"]
            };
        }
    }
}
