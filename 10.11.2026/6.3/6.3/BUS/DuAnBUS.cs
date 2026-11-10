using System.Data;
using ProjectTaskManagement.DAL;
using ProjectTaskManagement.DTO;

namespace ProjectTaskManagement.BUS
{
    public class DuAnBUS
    {
        private readonly DuAnDAL dal = new DuAnDAL();

        
        public DataTable LayDanhSachDuAn()
        {
            return dal.GetAllDuAn();
        }

        public string Validate(DuAnDTO duAn)
        {
            if (string.IsNullOrWhiteSpace(duAn.TenDuAn))
                return "Tên dự án không được để trống.";

            if (duAn.NgayBatDau.HasValue && duAn.NgayKetThuc.HasValue &&
                duAn.NgayKetThuc.Value < duAn.NgayBatDau.Value)
                return "Ngày kết thúc phải sau ngày bắt đầu.";

            return null;
        }

        
        public bool ThemDuAn(DuAnDTO duAn)
        {
            string loi = Validate(duAn);
            if (loi != null) throw new System.ArgumentException(loi);
            return dal.Insert(duAn) > 0;
        }

        public bool SuaDuAn(DuAnDTO duAn)
        {
            string loi = Validate(duAn);
            if (loi != null) throw new System.ArgumentException(loi);
            return dal.Update(duAn);
        }

        public bool XoaDuAn(int maDuAn)
        {
            return dal.Delete(maDuAn);
        }
    }
}