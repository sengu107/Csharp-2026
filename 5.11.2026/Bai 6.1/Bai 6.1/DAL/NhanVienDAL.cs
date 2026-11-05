using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Market.DTO;

namespace Market.DAL
{
    public class NhanVienDAL
    {
        public List<NhanVien> GetAll()
        {
            var list = new List<NhanVien>();
            string sql = "SELECT MaNV, TenNV, SoDienThoai, ChucVu FROM NhanVien ORDER BY TenNV";

            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhanVien
                        {
                            MaNV = (int)reader["MaNV"],
                            TenNV = reader["TenNV"].ToString(),
                            SoDienThoai = reader["SoDienThoai"] as string,
                            ChucVu = reader["ChucVu"] as string
                        });
                    }
                }
            }
            return list;
        }

        public bool Insert(NhanVien nv)
        {
            string sql = @"INSERT INTO NhanVien (TenNV, SoDienThoai, ChucVu)
                            VALUES (@TenNV, @SDT, @ChucVu)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@TenNV", nv.TenNV);
                cmd.Parameters.AddWithValue("@SDT", (object)nv.SoDienThoai ?? System.DBNull.Value);
                cmd.Parameters.AddWithValue("@ChucVu", (object)nv.ChucVu ?? System.DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(NhanVien nv)
        {
            string sql = @"UPDATE NhanVien SET TenNV=@TenNV, SoDienThoai=@SDT, ChucVu=@ChucVu
                            WHERE MaNV=@MaNV";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@TenNV", nv.TenNV);
                cmd.Parameters.AddWithValue("@SDT", (object)nv.SoDienThoai ?? System.DBNull.Value);
                cmd.Parameters.AddWithValue("@ChucVu", (object)nv.ChucVu ?? System.DBNull.Value);
                cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int maNV)
        {
            string sql = "DELETE FROM NhanVien WHERE MaNV=@MaNV";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
