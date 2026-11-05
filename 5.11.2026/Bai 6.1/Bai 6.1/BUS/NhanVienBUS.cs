using System.Collections.Generic;
using Market.DAL;
using Market.DTO;

namespace Market.BUS
{
    public class NhanVienBUS
    {
        private readonly NhanVienDAL dal = new NhanVienDAL();

        public List<NhanVien> GetAll() => dal.GetAll();

        public (bool ok, string msg) ThemSua(NhanVien nv, bool isUpdate)
        {
            if (string.IsNullOrWhiteSpace(nv.TenNV))
                return (false, "Ten nhan vien khong duoc de trong.");

            bool ok = isUpdate ? dal.Update(nv) : dal.Insert(nv);
            return (ok, ok ? "Thanh cong." : "That bai.");
        }

        public (bool ok, string msg) Xoa(int maNV)
        {
            try
            {
                bool ok = dal.Delete(maNV);
                return (ok, ok ? "Da xoa." : "Khong xoa duoc.");
            }
            catch
            {
                return (false, "Khong the xoa: nhan vien da co hoa don lien quan.");
            }
        }
    }
}
