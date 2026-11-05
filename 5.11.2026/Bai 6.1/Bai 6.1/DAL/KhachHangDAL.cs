using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Market.DTO;

namespace Market.DAL
{
    public class KhachHangDAL
    {
        public List<KhachHang> GetAll()
        {
            var list = new List<KhachHang>();
            string sql = "SELECT MaKH, TenKH, DienThoai, DiemTichLuy FROM KhachHang ORDER BY TenKH";

            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new KhachHang
                        {
                            MaKH = (int)reader["MaKH"],
                            TenKH = reader["TenKH"].ToString(),
                            DienThoai = reader["DienThoai"] as string,
                            DiemTichLuy = (int)reader["DiemTichLuy"]
                        });
                    }
                }
            }
            return list;
        }

        public List<KhachHang> TimKiem(string tuKhoa)
        {
            var list = new List<KhachHang>();
            string sql = @"SELECT MaKH, TenKH, DienThoai, DiemTichLuy FROM KhachHang
                            WHERE TenKH LIKE @tk OR DienThoai LIKE @tk";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@tk", "%" + tuKhoa + "%");
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new KhachHang
                        {
                            MaKH = (int)reader["MaKH"],
                            TenKH = reader["TenKH"].ToString(),
                            DienThoai = reader["DienThoai"] as string,
                            DiemTichLuy = (int)reader["DiemTichLuy"]
                        });
                    }
                }
            }
            return list;
        }

        public bool Insert(KhachHang kh)
        {
            string sql = @"INSERT INTO KhachHang (TenKH, DienThoai, DiemTichLuy)
                            VALUES (@TenKH, @DT, 0)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
                cmd.Parameters.AddWithValue("@DT", (object)kh.DienThoai ?? System.DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(KhachHang kh)
        {
            string sql = @"UPDATE KhachHang SET TenKH=@TenKH, DienThoai=@DT
                            WHERE MaKH=@MaKH";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
                cmd.Parameters.AddWithValue("@DT", (object)kh.DienThoai ?? System.DBNull.Value);
                cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int maKH)
        {
            string sql = "DELETE FROM KhachHang WHERE MaKH=@MaKH";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
