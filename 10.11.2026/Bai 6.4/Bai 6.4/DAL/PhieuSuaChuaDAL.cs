using Bai_6_4.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Bai_6_4.DAL
{
    public class PhieuSuaChuaDAL : DBConnect
    {
        public bool LapPhieuSuaChua(PhieuSuaChuaDTO phieu, List<ChiTietSuaChuaDTO> chiTietList, out string error)
        {
            error = "";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlTransaction trans = conn.BeginTransaction();
                try
                {

                    string queryPhieu = @"INSERT INTO PhieuSuaChua (BienSo, NgayNhan, NoiDungSua, TongTien, TrangThai) 
                                          VALUES (@BienSo, NOW(), @NoiDungSua, @TongTien, @TrangThai);
                                          SELECT LAST_INSERT_ID();";
                    long maPhieu = 0;
                    using (MySqlCommand cmd = new MySqlCommand(queryPhieu, conn, trans))
                    {
                        cmd.Parameters.AddWithValue("@BienSo", phieu.BienSo);
                        cmd.Parameters.AddWithValue("@NoiDungSua", string.IsNullOrEmpty(phieu.NoiDungSua) ? (object)DBNull.Value : phieu.NoiDungSua);
                        cmd.Parameters.AddWithValue("@TongTien", phieu.TongTien);
                        cmd.Parameters.AddWithValue("@TrangThai", phieu.TrangThai);
                        maPhieu = Convert.ToInt64(cmd.ExecuteScalar());
                    }


                    foreach (var ct in chiTietList)
                    {

                        string queryCheckTon = "SELECT SoLuongTon FROM PhuTung WHERE MaPhuTung = @MaPhuTung";
                        int soLuongTon = 0;
                        using (MySqlCommand cmdCheck = new MySqlCommand(queryCheckTon, conn, trans))
                        {
                            cmdCheck.Parameters.AddWithValue("@MaPhuTung", ct.MaPhuTung);
                            object result = cmdCheck.ExecuteScalar();
                            if (result != null) soLuongTon = Convert.ToInt32(result);
                        }


                        if (soLuongTon < ct.SoLuong)
                        {
                            trans.Rollback();
                            error = $"Phu tung ma {ct.MaPhuTung} khong du hang trong kho (Con lai: {soLuongTon}, Yeu cau: {ct.SoLuong}).";
                            return false;
                        }


                        string queryChiTiet = "INSERT INTO ChiTietSuaChua (MaPhieu, MaPhuTung, SoLuong, TienCong) VALUES (@MaPhieu, @MaPhuTung, @SoLuong, @TienCong)";
                        using (MySqlCommand cmdCT = new MySqlCommand(queryChiTiet, conn, trans))
                        {
                            cmdCT.Parameters.AddWithValue("@MaPhieu", maPhieu);
                            cmdCT.Parameters.AddWithValue("@MaPhuTung", ct.MaPhuTung);
                            cmdCT.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
                            cmdCT.Parameters.AddWithValue("@TienCong", ct.TienCong);
                            cmdCT.ExecuteNonQuery();
                        }

                        string queryUpdateKho = "UPDATE PhuTung SET SoLuongTon = SoLuongTon - @SoLuong WHERE MaPhuTung = @MaPhuTung";
                        using (MySqlCommand cmdUp = new MySqlCommand(queryUpdateKho, conn, trans))
                        {
                            cmdUp.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
                            cmdUp.Parameters.AddWithValue("@MaPhuTung", ct.MaPhuTung);
                            cmdUp.ExecuteNonQuery();
                        }
                    }


                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {

                    trans.Rollback();
                    error = "Loi he thong: " + ex.Message;
                    return false;
                }
            }
        }


        public bool ThanhToanPhieu(int maPhieu)
        {
            using (MySqlConnection conn = GetConnection())
            {
                string query = "UPDATE PhieuSuaChua SET TrangThai = 'Da thanh toan' WHERE MaPhieu = @MaPhieu";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    public DataTable LayDanhSachPhieuSuaChua()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT MaPhieu, BienSo, NgayNhan, NoiDungSua, TongTien, TrangThai FROM PhieuSuaChua";
                using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }

}