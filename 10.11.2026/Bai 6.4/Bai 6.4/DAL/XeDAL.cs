using System.Data;
using MySql.Data.MySqlClient;
using Bai_6_4.DTO;

namespace Bai_6_4.DAL
{
    public class XeDAL : DBConnect
    {
       
        public DataTable TraCuuXe(string bienSo)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                string query = @"SELECT x.BienSo, x.HieuXe, x.NamSanXuat, k.MaKH, k.TenKH, k.DienThoai, k.DiaChi 
                                 FROM Xe x JOIN KhachHang k ON x.MaKH = k.MaKH 
                                 WHERE x.BienSo LIKE @BienSo";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BienSo", "%" + bienSo + "%");
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }


        public bool ThemMoiKhachHangVaXe(KhachHangDTO kh, XeDTO xe, out string error)
        {
            error = "";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlTransaction trans = conn.BeginTransaction();
                try
                {
                  
                    string queryKH = "INSERT INTO KhachHang (TenKH, DienThoai, DiaChi) VALUES (@TenKH, @DienThoai, @DiaChi); SELECT LAST_INSERT_ID();";
                    long maKH = 0;
                    using (MySqlCommand cmdKH = new MySqlCommand(queryKH, conn, trans))
                    {
                        cmdKH.Parameters.AddWithValue("@TenKH", kh.TenKH);
                        cmdKH.Parameters.AddWithValue("@DienThoai", string.IsNullOrEmpty(kh.DienThoai) ? (object)DBNull.Value : kh.DienThoai);
                        cmdKH.Parameters.AddWithValue("@DiaChi", string.IsNullOrEmpty(kh.DiaChi) ? (object)DBNull.Value : kh.DiaChi);
                        maKH = Convert.ToInt64(cmdKH.ExecuteScalar());
                    }

                  
                    string queryXe = "INSERT INTO Xe (BienSo, MaKH, HieuXe, NamSanXuat) VALUES (@BienSo, @MaKH, @HieuXe, @NamSanXuat)";
                    using (MySqlCommand cmdXe = new MySqlCommand(queryXe, conn, trans))
                    {
                        cmdXe.Parameters.AddWithValue("@BienSo", xe.BienSo);
                        cmdXe.Parameters.AddWithValue("@MaKH", maKH);
                        cmdXe.Parameters.AddWithValue("@HieuXe", string.IsNullOrEmpty(xe.HieuXe) ? (object)DBNull.Value : xe.HieuXe);
                        cmdXe.Parameters.AddWithValue("@NamSanXuat", xe.NamSanXuat);
                        cmdXe.ExecuteNonQuery();
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
        public bool XoaKhachHangVaXe(string bienSo, out string error)
        {
            error = "";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlTransaction trans = conn.BeginTransaction();
                try
                {
                    string queryXoaXe = "DELETE FROM Xe WHERE BienSo = @BienSo";
                    using (MySqlCommand cmdXoaXe = new MySqlCommand(queryXoaXe, conn, trans))
                    {
                        cmdXoaXe.Parameters.AddWithValue("@BienSo", bienSo);
                        cmdXoaXe.ExecuteNonQuery();
                    }
                    string queryXoaKH = @"DELETE k FROM KhachHang k 
                                          LEFT JOIN Xe x ON k.MaKH = x.MaKH 
                                          WHERE x.BienSo IS NULL";
                    using (MySqlCommand cmdXoaKH = new MySqlCommand(queryXoaKH, conn, trans))
                    {
                        cmdXoaKH.ExecuteNonQuery();
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
        public bool SuaThongTinXeVaKhachHang(XeDTO xe, KhachHangDTO kh, out string error)
        {
            error = "";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlTransaction trans = conn.BeginTransaction();
                try
                {
                    string querySuaXe = "UPDATE Xe SET HieuXe = @HieuXe, NamSanXuat = @NamSanXuat WHERE BienSo = @BienSo";
                    using (MySqlCommand cmdSuaXe = new MySqlCommand(querySuaXe, conn, trans))
                    {
                        cmdSuaXe.Parameters.AddWithValue("@BienSo", xe.BienSo);
                        cmdSuaXe.Parameters.AddWithValue("@HieuXe", string.IsNullOrEmpty(xe.HieuXe) ? (object)DBNull.Value : xe.HieuXe);
                        cmdSuaXe.Parameters.AddWithValue("@NamSanXuat", xe.NamSanXuat);
                        cmdSuaXe.ExecuteNonQuery();
                    }
                    string querySuaKH = "UPDATE KhachHang k JOIN Xe x ON k.MaKH = x.MaKH SET k.TenKH = @TenKH, k.DienThoai = @DienThoai, k.DiaChi = @DiaChi WHERE x.BienSo = @BienSo";
                    using (MySqlCommand cmdSuaKH = new MySqlCommand(querySuaKH, conn, trans))
                    {
                        cmdSuaKH.Parameters.AddWithValue("@BienSo", xe.BienSo);
                        cmdSuaKH.Parameters.AddWithValue("@TenKH", kh.TenKH);
                        cmdSuaKH.Parameters.AddWithValue("@DienThoai", string.IsNullOrEmpty(kh.DienThoai) ? (object)DBNull.Value : kh.DienThoai);
                        cmdSuaKH.Parameters.AddWithValue("@DiaChi", string.IsNullOrEmpty(kh.DiaChi) ? (object)DBNull.Value : kh.DiaChi);
                        cmdSuaKH.ExecuteNonQuery();
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