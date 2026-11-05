using System.Collections.Generic;
using Market.DAL;
using Market.DTO;

namespace Market.BUS
{
    public class SanPhamBUS
    {
        private readonly SanPhamDAL dal = new SanPhamDAL();

        public List<SanPham> GetAll() => dal.GetAll();

        public List<SanPham> TimKiem(string tuKhoa) =>
            string.IsNullOrWhiteSpace(tuKhoa) ? dal.GetAll() : dal.TimKiem(tuKhoa);

        public SanPham GetByMa(string maSP) => dal.GetByMa(maSP);

        public (bool ok, string msg) ThemSua(SanPham sp, bool isUpdate)
        {
            if (string.IsNullOrWhiteSpace(sp.MaSP) || string.IsNullOrWhiteSpace(sp.TenSP))
                return (false, "Ma va ten san pham khong duoc de trong.");
            if (sp.GiaBan <= 0)
                return (false, "Gia ban phai lon hon 0.");
            if (sp.SoLuongTon < 0)
                return (false, "So luong ton khong duoc am.");

            bool ok = isUpdate ? dal.Update(sp) : dal.Insert(sp);
            return (ok, ok ? "Thanh cong." : "That bai.");
        }

        public (bool ok, string msg) Xoa(string maSP)
        {
            try
            {
                bool ok = dal.Delete(maSP);
                return (ok, ok ? "Da xoa." : "Khong xoa duoc.");
            }
            catch
            {
                return (false, "Khong the xoa: san pham da xuat hien trong hoa don.");
            }
        }
    }
}
