using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Bai5._5.DTO;

namespace Bai5._5.DAL
{
    public class InventoryDAL : DatabaseAccess
    {
      
        public DataTable GetListVatTu() => ExecuteQuery("SELECT * FROM VatTu");

      
        public DataTable SearchVatTu(string keyword)
        {
            string query = "SELECT * FROM VatTu WHERE MaVatTu LIKE @kw OR TenVatTu LIKE @kw";
            MySqlParameter[] p = { new MySqlParameter("@kw", "%" + keyword + "%") };
            return ExecuteQuery(query, p);
        }

    
        public DataTable GetListNhaCungCap() => ExecuteQuery("SELECT * FROM NhaCungCap");

    
        public DataTable GetVatTuSapHet(decimal nguoangAnToan)
        {
            string query = "SELECT * FROM VatTu WHERE SoLuongTon <= @Ngong";
            MySqlParameter[] p = { new MySqlParameter("@Ngong", nguoangAnToan) };
            return ExecuteQuery(query, p);
        }

        
        public decimal GetTongGiaTriTonKho()
        {
            string query = @"SELECT IFNULL(SUM(v.SoLuongTon * IFNULL((
                                SELECT ct.DonGia FROM ChiTietPhieuKho ct WHERE ct.MaVatTu = v.MaVatTu ORDER BY ct.MaPhieu DESC LIMIT 1
                             ), 0)), 0) FROM VatTu v";
            object res = ExecuteScalar(query);
            return Convert.ToDecimal(res);
        }

      
        public bool LapPhieuKhoTransaction(string loaiPhieu, int? maNCC, List<ChiTietPhieuKhoDTO> listChiTiet, out string errorMessage)
        {
            errorMessage = "";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlTransaction trans = conn.BeginTransaction();
                try
                {
                  
                    decimal tongTien = 0;
                    foreach (var item in listChiTiet) tongTien += item.ThanhTien;

           
                    string q1 = "INSERT INTO PhieuKho (LoaiPhieu, NgayLap, MaNCC, TongTien) VALUES (@Loai, NOW(), @MaNCC, @TongTien); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmd1 = new MySqlCommand(q1, conn, trans);
                    cmd1.Parameters.AddWithValue("@Loai", loaiPhieu);
                    cmd1.Parameters.AddWithValue("@MaNCC", (object)maNCC ?? DBNull.Value);
                    cmd1.Parameters.AddWithValue("@TongTien", tongTien);
                    int maPhieu = Convert.ToInt32(cmd1.ExecuteScalar());

              
                    foreach (var ct in listChiTiet)
                    {
                   
                        string q2 = "INSERT INTO ChiTietPhieuKho (MaPhieu, MaVatTu, SoLuong, DonGia) VALUES (@MaPhieu, @MaVatTu, @SoLuong, @DonGia)";
                        MySqlCommand cmd2 = new MySqlCommand(q2, conn, trans);
                        cmd2.Parameters.AddWithValue("@MaPhieu", maPhieu);
                        cmd2.Parameters.AddWithValue("@MaVatTu", ct.MaVatTu);
                        cmd2.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
                        cmd2.Parameters.AddWithValue("@DonGia", ct.DonGia);
                        cmd2.ExecuteNonQuery();

                     
                        if (loaiPhieu == "NHAP")
                        {
                            string q3 = "UPDATE VatTu SET SoLuongTon = SoLuongTon + @SoLuong WHERE MaVatTu = @MaVatTu";
                            MySqlCommand cmd3 = new MySqlCommand(q3, conn, trans);
                            cmd3.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
                            cmd3.Parameters.AddWithValue("@MaVatTu", ct.MaVatTu);
                            cmd3.ExecuteNonQuery();
                        }
                        else if (loaiPhieu == "XUAT")
                        {
                           
                            string qCheck = "SELECT SoLuongTon FROM VatTu WHERE MaVatTu = @MaVatTu";
                            MySqlCommand cmdCheck = new MySqlCommand(qCheck, conn, trans);
                            cmdCheck.Parameters.AddWithValue("@MaVatTu", ct.MaVatTu);
                            decimal tonHienTai = Convert.ToDecimal(cmdCheck.ExecuteScalar());

                            if (tonHienTai < ct.SoLuong)
                            {
                                trans.Rollback(); 
                                errorMessage = $"Vật tư [{ct.MaVatTu}] không đủ hàng tồn kho! (Tồn hiện tại: {tonHienTai}, Cần xuất: {ct.SoLuong})";
                                return false;
                            }

                            string q3 = "UPDATE VatTu SET SoLuongTon = SoLuongTon - @SoLuong WHERE MaVatTu = @MaVatTu";
                            MySqlCommand cmd3 = new MySqlCommand(q3, conn, trans);
                            cmd3.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
                            cmd3.Parameters.AddWithValue("@MaVatTu", ct.MaVatTu);
                            cmd3.ExecuteNonQuery();
                        }
                    }

                    trans.Commit(); 
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    errorMessage = ex.Message;
                    return false;
                }
            }
        }
    }
}