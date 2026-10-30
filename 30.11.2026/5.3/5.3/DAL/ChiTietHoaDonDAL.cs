using System.Collections.Generic;
using MySql.Data.MySqlClient;
using CafePOS.DTO;

namespace CafePOS.DAL
{
    public class ChiTietHoaDonDAL
    {
       
        public List<ChiTietHienThiDTO> GetByHoaDon(int maHoaDon)
        {
            var list = new List<ChiTietHienThiDTO>();
            using (var conn = DBHelper.GetConnection())
            using (var cmd = new MySqlCommand(
                "SELECT ct.MaMon, m.TenMon, ct.SoLuong, ct.DonGia " +
                "FROM ChiTietHoaDon ct JOIN MonAn m ON ct.MaMon = m.MaMon " +
                "WHERE ct.MaHoaDon = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", maHoaDon);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ChiTietHienThiDTO
                        {
                            MaMon = reader.GetInt32("MaMon"),
                            TenMon = reader.GetString("TenMon"),
                            SoLuong = reader.GetInt32("SoLuong"),
                            DonGia = reader.GetDecimal("DonGia")
                        });
                    }
                }
            }
            return list;
        }

        public bool DaTonTai(int maHoaDon, int maMon)
        {
            using (var conn = DBHelper.GetConnection())
            using (var cmd = new MySqlCommand(
                "SELECT COUNT(*) FROM ChiTietHoaDon WHERE MaHoaDon=@hd AND MaMon=@mon", conn))
            {
                cmd.Parameters.AddWithValue("@hd", maHoaDon);
                cmd.Parameters.AddWithValue("@mon", maMon);
                conn.Open();
                return System.Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public bool ThemMoi(ChiTietHoaDonDTO ct)
        {
            using (var conn = DBHelper.GetConnection())
            using (var cmd = new MySqlCommand(
                "INSERT INTO ChiTietHoaDon (MaHoaDon, MaMon, SoLuong, DonGia) VALUES (@hd, @mon, @sl, @gia)", conn))
            {
                cmd.Parameters.AddWithValue("@hd", ct.MaHoaDon);
                cmd.Parameters.AddWithValue("@mon", ct.MaMon);
                cmd.Parameters.AddWithValue("@sl", ct.SoLuong);
                cmd.Parameters.AddWithValue("@gia", ct.DonGia);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        
        public bool CongDonSoLuong(int maHoaDon, int maMon, int soLuongThem)
        {
            using (var conn = DBHelper.GetConnection())
            using (var cmd = new MySqlCommand(
                "UPDATE ChiTietHoaDon SET SoLuong = SoLuong + @sl WHERE MaHoaDon=@hd AND MaMon=@mon", conn))
            {
                cmd.Parameters.AddWithValue("@sl", soLuongThem);
                cmd.Parameters.AddWithValue("@hd", maHoaDon);
                cmd.Parameters.AddWithValue("@mon", maMon);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
