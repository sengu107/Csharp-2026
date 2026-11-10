using System.Data;
using System.Collections.Generic;
using KaraokeApp.DAL;

namespace KaraokeApp.BUS
{
    public class KaraokeBUS
    {
        private KaraokeDAL dal = new KaraokeDAL();

        public DataTable LayDanhSachPhong() => dal.LayDanhSachPhong();
        public DataTable LayDanhSachDichVu() => dal.LayDanhSachDichVu();
        public int LayMaHDCuaPhong(int maPhong) => dal.LayMaHDCuaPhong(maPhong);
        public bool MoPhong(int maPhong, out string error) => dal.MoPhong(maPhong, out error);
        public bool ThemDichVu(int maHD, int maDV, int soLuong, decimal donGia, out string error) => dal.ThemDichVuVaoHoaDon(maHD, maDV, soLuong, donGia, out error);
        public DataTable LayChiTietDichVu(int maHD) => dal.LayChiTietDichVu(maHD);
        public bool ThanhToan(int maHD, int maPhong, decimal tienPhong, decimal tienDV, Dictionary<int, int> dvList, out string error)
            => dal.ThanhToan(maHD, maPhong, tienPhong, tienDV, dvList, out error);
        public bool LayGioVaoCuaHoaDon(int maHD, out DateTime gioVao, out string error) => dal.LayGioVaoCuaHoaDon(maHD, out gioVao, out error);
    }
}