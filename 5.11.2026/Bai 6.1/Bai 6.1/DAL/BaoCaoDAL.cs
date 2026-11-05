using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Market.DAL
{
    public class BaoCaoDAL
    {
       
        public decimal TongDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            string sql = @"SELECT IFNULL(SUM(TongTien), 0)
                            FROM HoaDon
                            WHERE NgayLap BETWEEN @Tu AND @Den";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Tu", tuNgay.Date);
                cmd.Parameters.AddWithValue("@Den", denNgay.Date.AddDays(1).AddSeconds(-1));
                conn.Open();
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

        public decimal DoanhThuHomNay()
        {
            return TongDoanhThu(DateTime.Today, DateTime.Today);
        }

        public decimal DoanhThuThangNay()
        {
            var dauThang = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            return TongDoanhThu(dauThang, DateTime.Today);
        }

        public DataTable Top5SanPhamBanChay()
        {
            var dt = new DataTable();
            string sql = @"SELECT sp.MaSP, sp.TenSP,
                                   SUM(ct.SoLuong) AS TongSoLuongBan,
                                   SUM(ct.SoLuong * ct.DonGia) AS TongDoanhThu
                            FROM ChiTietHoaDon ct
                            JOIN SanPham sp ON ct.MaSP = sp.MaSP
                            GROUP BY sp.MaSP, sp.TenSP
                            ORDER BY TongSoLuongBan DESC
                            LIMIT 5";

            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }
    }
}
