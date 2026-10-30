using System;
using MySql.Data.MySqlClient;
using CafePOS.DTO;

namespace CafePOS.DAL
{
    public class HoaDonDAL
    {
       
        public HoaDonDTO GetHoaDonChuaThanhToan(int maBan)
        {
            using (var conn = DBHelper.GetConnection())
            using (var cmd = new MySqlCommand(
                "SELECT MaHoaDon, MaBan, GioVao, GioRa, TongTien, TrangThai " +
                "FROM HoaDon WHERE MaBan=@maBan AND TrangThai=0 LIMIT 1", conn))
            {
                cmd.Parameters.AddWithValue("@maBan", maBan);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new HoaDonDTO
                        {
                            MaHoaDon = reader.GetInt32("MaHoaDon"),
                            MaBan = reader.GetInt32("MaBan"),
                            GioVao = reader.GetDateTime("GioVao"),
                            GioRa = reader.IsDBNull(reader.GetOrdinal("GioRa")) ? (DateTime?)null : reader.GetDateTime("GioRa"),
                            TongTien = reader.GetDecimal("TongTien"),
                            TrangThai = reader.GetBoolean("TrangThai")
                        };
                    }
                }
            }
            return null;
        }

       
        public int TaoHoaDonMoi(int maBan)
        {
            using (var conn = DBHelper.GetConnection())
            using (var cmd = new MySqlCommand(
                "INSERT INTO HoaDon (MaBan, GioVao, TongTien, TrangThai) VALUES (@maBan, NOW(), 0, 0); " +
                "SELECT LAST_INSERT_ID();", conn))
            {
                cmd.Parameters.AddWithValue("@maBan", maBan);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

       
        public decimal TinhTongTien(int maHoaDon, MySqlConnection conn, MySqlTransaction trans)
        {
            using (var cmd = new MySqlCommand(
                "SELECT IFNULL(SUM(SoLuong * DonGia), 0) FROM ChiTietHoaDon WHERE MaHoaDon=@id", conn, trans))
            {
                cmd.Parameters.AddWithValue("@id", maHoaDon);
                var result = cmd.ExecuteScalar();
                return Convert.ToDecimal(result);
            }
        }

       
        public void ThanhToan(int maHoaDon, decimal tongTien, MySqlConnection conn, MySqlTransaction trans)
        {
            using (var cmd = new MySqlCommand(
                "UPDATE HoaDon SET GioRa = NOW(), TongTien = @tongTien, TrangThai = 1 WHERE MaHoaDon = @id",
                conn, trans))
            {
                cmd.Parameters.AddWithValue("@tongTien", tongTien);
                cmd.Parameters.AddWithValue("@id", maHoaDon);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
