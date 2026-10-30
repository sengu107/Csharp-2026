using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using CafePOS.DAL;
using CafePOS.DTO;

namespace CafePOS.BUS
{
    public class HoaDonBUS
    {
        private readonly HoaDonDAL hoaDonDAL = new HoaDonDAL();
        private readonly ChiTietHoaDonDAL chiTietDAL = new ChiTietHoaDonDAL();
        private readonly BanAnDAL banAnDAL = new BanAnDAL();

       
        public HoaDonDTO LayHoacTaoHoaDon(int maBan)
        {
            var hd = hoaDonDAL.GetHoaDonChuaThanhToan(maBan);
            if (hd == null)
            {
                int maHoaDon = hoaDonDAL.TaoHoaDonMoi(maBan);
                hd = new HoaDonDTO { MaHoaDon = maHoaDon, MaBan = maBan, TrangThai = false };
            }
            return hd;
        }

        public List<ChiTietHienThiDTO> GetChiTiet(int maHoaDon) => chiTietDAL.GetByHoaDon(maHoaDon);

        
        public void ThemMon(int maBan, MonAnDTO mon, int soLuong)
        {
            if (soLuong <= 0)
                throw new Exception("So luong phai lon hon 0");

            var hd = LayHoacTaoHoaDon(maBan);

            if (chiTietDAL.DaTonTai(hd.MaHoaDon, mon.MaMon))
                chiTietDAL.CongDonSoLuong(hd.MaHoaDon, mon.MaMon, soLuong);
            else
                chiTietDAL.ThemMoi(new ChiTietHoaDonDTO
                {
                    MaHoaDon = hd.MaHoaDon,
                    MaMon = mon.MaMon,
                    SoLuong = soLuong,
                    DonGia = mon.DonGia
                });

            banAnDAL.CapNhatTrangThai(maBan, "Co khach");
        }

     
        public decimal ThanhToan(int maBan)
        {
            var hd = hoaDonDAL.GetHoaDonChuaThanhToan(maBan);
            if (hd == null)
                throw new Exception("Ban nay chua co hoa don can thanh toan");

            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                MySqlTransaction trans = conn.BeginTransaction();
                try
                {
                    decimal tongTien = hoaDonDAL.TinhTongTien(hd.MaHoaDon, conn, trans);

                    if (tongTien <= 0)
                        throw new Exception("Hoa don chua co mon nao, khong the thanh toan");

                    hoaDonDAL.ThanhToan(hd.MaHoaDon, tongTien, conn, trans);
                    banAnDAL.CapNhatTrangThai(maBan, "Trong", conn, trans);

                    trans.Commit();
                    return tongTien;
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }
    }
}
