using HRM.DAL;
using System.Data;

namespace HRM.BUS
{
    public class ChamCongBUS
    {
        private ChamCongDAL dal = new ChamCongDAL();

        public DataTable GetBangChamCongByThang(string thangNam) => dal.GetBangChamCongByThang(thangNam);
        public bool SaveBangChamCong(DataTable dt, string thangNam) => dal.SaveBangChamCong(dt, thangNam);
    }
}