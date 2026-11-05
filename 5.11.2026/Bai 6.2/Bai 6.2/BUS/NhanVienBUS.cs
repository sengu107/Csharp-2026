using HRM.DAL;
using HRM.DTO;
using System.Data;

namespace HRM.BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAL dal = new NhanVienDAL();

        public DataTable GetAllNhanVien() => dal.GetAllNhanVien();
        public bool Insert(NhanVienDTO nv) => dal.Insert(nv);
        public bool Update(NhanVienDTO nv) => dal.Update(nv);
        public bool Delete(int maNV) => dal.Delete(maNV);
        public DataTable Search(string keyword) => dal.Search(keyword);
    }
}