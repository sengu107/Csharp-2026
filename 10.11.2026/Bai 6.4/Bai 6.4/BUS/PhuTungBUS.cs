using System.Data;
using Bai_6_4.DAL;
using Bai_6_4.DTO;


namespace Bai_6_4.BUS
{
    public class PhuTungBUS
    {
        private PhuTungDAL dal = new PhuTungDAL();

        public DataTable LayDanhSach()
        {
            return dal.LayDanhSachPhuTung();
        }

        public bool ThemPhuTung(PhuTungDTO pt)
        {
            return dal.ThemPhuTung(pt);
        }
        public bool SuaPhuTung(PhuTungDTO pt)
        {
            return dal.SuaPhuTung(pt);
        }
        public bool XoaPhuTung(int maPT)
        {
            return dal.XoaPhuTung(maPT);
        }
    }
}