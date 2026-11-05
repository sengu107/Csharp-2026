using System.Collections.Generic;
using Market.DAL;
using Market.DTO;

namespace Market.BUS
{
    public class KhachHangBUS
    {
        private readonly KhachHangDAL dal = new KhachHangDAL();

        public List<KhachHang> GetAll() => dal.GetAll();
        public List<KhachHang> TimKiem(string tuKhoa) =>
            string.IsNullOrWhiteSpace(tuKhoa) ? dal.GetAll() : dal.TimKiem(tuKhoa);

        public (bool ok, string msg) ThemSua(KhachHang kh, bool isUpdate)
        {
            if (string.IsNullOrWhiteSpace(kh.TenKH))
                return (false, "Ten khach hang khong duoc de trong.");

            bool ok = isUpdate ? dal.Update(kh) : dal.Insert(kh);
            return (ok, ok ? "Thanh cong." : "That bai.");
        }

        public (bool ok, string msg) Xoa(int maKH)
        {
            try
            {
                bool ok = dal.Delete(maKH);
                return (ok, ok ? "Da xoa." : "Khong xoa duoc.");
            }
            catch
            {
                return (false, "Khong the xoa: khach hang da co hoa don lien quan.");
            }
        }
    }
}
