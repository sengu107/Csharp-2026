using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Market.DTO;

namespace Market.DAL
{
    public class HoaDonDAL
    {
        
        public int ThanhToan(int maNV, int? maKH, List<ChiTietHoaDon> gioHang, decimal tongTien)
        {
            if (gioHang == null || gioHang.Count == 0)
                throw new ArgumentException("Gio hang rong.");

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                MySqlTransaction trans = conn.BeginTransaction();

                try
                {
                    foreach (var ct in gioHang)
                    {
                        string sqlCheck = @"SELECT SoLuongTon FROM SanPham
                                             WHERE MaSP = @MaSP FOR UPDATE";
                        using (var cmdCheck = new MySqlCommand(sqlCheck, conn, trans))
                        {
                            cmdCheck.Parameters.AddWithValue("@MaSP", ct.MaSP);
                            object result = cmdCheck.ExecuteScalar();

                            if (result == null)
                                throw new Exception($"San pham {ct.MaSP} khong ton tai.");

                            int tonKho = Convert.ToInt32(result);
                            if (tonKho < ct.SoLuong)
                                throw new Exception($"San pham {ct.MaSP} khong du ton kho (con {tonKho}, can {ct.SoLuong}).");
                        }
                    }

                    string sqlHD = @"INSERT INTO HoaDon (NgayLap, MaNV, MaKH, TongTien)
                                      VALUES (NOW(), @MaNV, @MaKH, @TongTien)";
                    int maHD;
                    using (var cmdHD = new MySqlCommand(sqlHD, conn, trans))
                    {
                        cmdHD.Parameters.AddWithValue("@MaNV", maNV);
                        cmdHD.Parameters.AddWithValue("@MaKH", (object)maKH ?? DBNull.Value);
                        cmdHD.Parameters.AddWithValue("@TongTien", tongTien);
                        cmdHD.ExecuteNonQuery();
                        using (var cmdId = new MySqlCommand("SELECT LAST_INSERT_ID()", conn, trans))
                        {
                            maHD = Convert.ToInt32(cmdId.ExecuteScalar());
                        }
                    }

                    foreach (var ct in gioHang)
                    {
                        string sqlCT = @"INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia)
                                          VALUES (@MaHD, @MaSP, @SL, @DonGia)";
                        using (var cmdCT = new MySqlCommand(sqlCT, conn, trans))
                        {
                            cmdCT.Parameters.AddWithValue("@MaHD", maHD);
                            cmdCT.Parameters.AddWithValue("@MaSP", ct.MaSP);
                            cmdCT.Parameters.AddWithValue("@SL", ct.SoLuong);
                            cmdCT.Parameters.AddWithValue("@DonGia", ct.DonGia);
                            cmdCT.ExecuteNonQuery();
                        }

                        string sqlTru = "UPDATE SanPham SET SoLuongTon = SoLuongTon - @SL WHERE MaSP = @MaSP";
                        using (var cmdTru = new MySqlCommand(sqlTru, conn, trans))
                        {
                            cmdTru.Parameters.AddWithValue("@SL", ct.SoLuong);
                            cmdTru.Parameters.AddWithValue("@MaSP", ct.MaSP);
                            cmdTru.ExecuteNonQuery();
                        }
                    }

                    if (maKH.HasValue)
                    {
                        string sqlDiem = @"UPDATE KhachHang SET DiemTichLuy = DiemTichLuy + @Diem
                                            WHERE MaKH = @MaKH";
                        using (var cmdDiem = new MySqlCommand(sqlDiem, conn, trans))
                        {
                            cmdDiem.Parameters.AddWithValue("@Diem", (int)(tongTien / 100000));
                            cmdDiem.Parameters.AddWithValue("@MaKH", maKH.Value);
                            cmdDiem.ExecuteNonQuery();
                        }
                    }

                    trans.Commit();
                    return maHD;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw new Exception("Thanh toan that bai: " + ex.Message, ex);
                }
            }
        }

        public List<HoaDon> GetAll()
        {
            var list = new List<HoaDon>();
            string sql = "SELECT MaHD, NgayLap, MaNV, MaKH, TongTien FROM HoaDon ORDER BY NgayLap DESC";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new HoaDon
                        {
                            MaHD = (int)reader["MaHD"],
                            NgayLap = (DateTime)reader["NgayLap"],
                            MaNV = (int)reader["MaNV"],
                            MaKH = reader["MaKH"] == DBNull.Value ? (int?)null : (int)reader["MaKH"],
                            TongTien = (decimal)reader["TongTien"]
                        });
                    }
                }
            }
            return list;
        }
    }
}
