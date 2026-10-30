using HotelManagement.DAL;
using HotelManagement.DTO;

namespace HotelManagement.BUS
{
    public class KhachHangBUS
    {
        private readonly KhachHangDAL _dal = new KhachHangDAL();

     
        public KhachHangDTO TimTheoCCCD(string cccd)
        {
            return _dal.GetByCCCD(ChuanHoaCCCD(cccd));
        }

        public static string ChuanHoaCCCD(string cccd)
        {
            cccd = (cccd ?? "").Trim();
            if (cccd.Length == 0)
                throw new BusinessException("Vui lòng nhập số CCCD.");
            foreach (char c in cccd)
            {
                if (c < '0' || c > '9')
                    throw new BusinessException("CCCD chỉ được chứa chữ số.");
            }
            if (cccd.Length != 12 && cccd.Length != 9)
                throw new BusinessException("CCCD phải gồm 12 chữ số (hoặc CMND cũ 9 số).");
            return cccd;
        }

      
        public static string ChuanHoaSoDienThoai(string sdt)
        {
            sdt = (sdt ?? "").Trim();
            if (sdt.Length == 0) return null;
            foreach (char c in sdt)
            {
                if (c < '0' || c > '9')
                    throw new BusinessException("Số điện thoại chỉ được chứa chữ số.");
            }
            if (sdt.Length < 9 || sdt.Length > 11)
                throw new BusinessException("Số điện thoại phải có từ 9 đến 11 chữ số.");
            return sdt;
        }
    }
}
