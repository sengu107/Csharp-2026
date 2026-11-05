using System.Collections.Generic;
using System.Linq;
using Market.DAL;
using Market.DTO;

namespace Market.BUS
{
    public class HoaDonBUS
    {
        private readonly HoaDonDAL dal = new HoaDonDAL();

        public (bool ok, string msg, int maHD) ThanhToan(int maNV, int? maKH, List<ChiTietHoaDon> gioHang)
        {
            if (gioHang == null || gioHang.Count == 0)
                return (false, "Gio hang dang trong.", -1);

            if (gioHang.Any(x => x.SoLuong <= 0))
                return (false, "So luong cua moi mat hang phai lon hon 0.", -1);

            decimal tongTien = gioHang.Sum(x => x.ThanhTien);

            try
            {
                int maHD = dal.ThanhToan(maNV, maKH, gioHang, tongTien);
                return (true, $"Thanh toan thanh cong. Ma hoa don: {maHD}", maHD);
            }
            catch (System.Exception ex)
            {
                return (false, ex.Message, -1);
            }
        }
    }
}
