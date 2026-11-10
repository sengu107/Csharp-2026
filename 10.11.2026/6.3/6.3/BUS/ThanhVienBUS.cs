using System.Data;

namespace ProjectTaskManagement.BUS
{
    public class ThanhVienBUS
    {
        private readonly ThanhVienDAL dal = new ThanhVienDAL();

       
        public DataTable LayDanhSachThanhVien()
        {
            return dal.GetAllThanhVien();
        }
    }
}