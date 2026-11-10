using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace KaraokeApp.DAL
{
    public class KaraokeDAL : DBConnect
    {
        public DataTable LayDanhSachPhong()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT * FROM PhongHat";
                using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable LayDanhSachDichVu()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT * FROM DichVu";
                using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public int LayMaHDCuaPhong(int maPhong)
        {
            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT MaHD FROM HoaDon WHERE MaPhong = @MaPhong AND TrangThai = 0";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public bool MoPhong(int maPhong, out string error)
        {
            error = "";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlTransaction trans = conn.BeginTransaction();
                try
                {
                    string qHD = "INSERT INTO HoaDon (MaPhong, GioVao, TrangThai) VALUES (@MaPhong, NOW(), 0)";
                    using (MySqlCommand cmd = new MySqlCommand(qHD, conn, trans))
                    {
                        cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                        cmd.ExecuteNonQuery();
                    }

                    string qPhong = "UPDATE PhongHat SET TrangThai = 'Đang hát' WHERE MaPhong = @MaPhong";
                    using (MySqlCommand cmd = new MySqlCommand(qPhong, conn, trans))
                    {
                        cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                        cmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    error = ex.Message;
                    return false;
                }
            }
        }

        public bool ThemDichVuVaoHoaDon(int maHD, int maDV, int soLuong, decimal donGia, out string error)
        {
            error = "";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string qCheck = "SELECT SoLuong FROM ChiTietDichVu WHERE MaHD = @MaHD AND MaDV = @MaDV";
                using (MySqlCommand cmdCheck = new MySqlCommand(qCheck, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@MaHD", maHD);
                    cmdCheck.Parameters.AddWithValue("@MaDV", maDV);
                    object currentQty = cmdCheck.ExecuteScalar();

                    if (currentQty != null)
                    {
                        string qUpdate = "UPDATE ChiTietDichVu SET SoLuong = SoLuong + @SoLuong WHERE MaHD = @MaHD AND MaDV = @MaDV";
                        using (MySqlCommand cmdUp = new MySqlCommand(qUpdate, conn))
                        {
                            cmdUp.Parameters.AddWithValue("@SoLuong", soLuong);
                            cmdUp.Parameters.AddWithValue("@MaHD", maHD);
                            cmdUp.Parameters.AddWithValue("@MaDV", maDV);
                            cmdUp.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string qInsert = "INSERT INTO ChiTietDichVu (MaHD, MaDV, SoLuong, DonGia) VALUES (@MaHD, @MaDV, @SoLuong, @DonGia)";
                        using (MySqlCommand cmdIns = new MySqlCommand(qInsert, conn))
                        {
                            cmdIns.Parameters.AddWithValue("@MaHD", maHD);
                            cmdIns.Parameters.AddWithValue("@MaDV", maDV);
                            cmdIns.Parameters.AddWithValue("@SoLuong", soLuong);
                            cmdIns.Parameters.AddWithValue("@DonGia", donGia);
                            cmdIns.ExecuteNonQuery();
                        }
                    }
                }
                return true;
            }
        }

        public DataTable LayChiTietDichVu(int maHD)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                string query = @"SELECT ct.MaDV, dv.TenDV, ct.SoLuong, ct.DonGia, (ct.SoLuong * ct.DonGia) AS ThanhTien 
                                 FROM ChiTietDichVu ct 
                                 JOIN DichVu dv ON ct.MaDV = dv.MaDV 
                                 WHERE ct.MaHD = @MaHD";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
        public bool LayGioVaoCuaHoaDon(int maHD, out DateTime gioVao, out string error)
        {
            error = "";
            gioVao = DateTime.MinValue;
            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT GioVao FROM HoaDon WHERE MaHD = @MaHD";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && DateTime.TryParse(result.ToString(), out DateTime parsedDate))
                    {
                        gioVao = parsedDate;
                        return true;
                    }
                    else
                    {
                        error = "Không tìm thấy giờ vào cho hóa đơn này.";
                        return false;
                    }
                }
            }
        }
        public bool ThanhToan(int maHD, int maPhong, decimal tienPhong, decimal tienDV, Dictionary<int, int> danhSachSuDungDV, out string error)
        {
            error = "";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlTransaction trans = conn.BeginTransaction();
                try
                {
                    string qHD = @"UPDATE HoaDon 
                                   SET GioRa = NOW(), 
                                       TongTienPhong = @TienPhong, 
                                       TongTienDichVu = @TienDV, 
                                       TrangThai = 1 
                                   WHERE MaHD = @MaHD";
                    using (MySqlCommand cmd = new MySqlCommand(qHD, conn, trans))
                    {
                        cmd.Parameters.AddWithValue("@TienPhong", tienPhong);
                        cmd.Parameters.AddWithValue("@TienDV", tienDV);
                        cmd.Parameters.AddWithValue("@MaHD", maHD);
                        cmd.ExecuteNonQuery();
                    }

                    foreach (var item in danhSachSuDungDV)
                    {
                        int maDV = item.Key;
                        int soLuongDung = item.Value;

                        string qKho = "UPDATE DichVu SET TonKho = TonKho - @SoLuong WHERE MaDV = @MaDV";
                        using (MySqlCommand cmdKho = new MySqlCommand(qKho, conn, trans))
                        {
                            cmdKho.Parameters.AddWithValue("@SoLuong", soLuongDung);
                            cmdKho.Parameters.AddWithValue("@MaDV", maDV);
                            cmdKho.ExecuteNonQuery();
                        }
                    }

                    string qPhong = "UPDATE PhongHat SET TrangThai = 'Trống' WHERE MaPhong = @MaPhong";
                    using (MySqlCommand cmdPhong = new MySqlCommand(qPhong, conn, trans))
                    {
                        cmdPhong.Parameters.AddWithValue("@MaPhong", maPhong);
                        cmdPhong.ExecuteNonQuery();
                    }

                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    error = ex.Message;
                    return false;
                }
            }
        }
    }
}