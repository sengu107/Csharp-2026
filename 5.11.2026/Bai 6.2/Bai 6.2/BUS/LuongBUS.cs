using HRM.DAL;

namespace HRM.BUS
{
    public class LuongBUS
    {
        private LuongDAL dal = new LuongDAL();

        public bool ChotLuongThang(string thangNam) => dal.ChotLuongThang(thangNam);
    }
}