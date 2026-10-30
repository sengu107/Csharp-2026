using System.Collections.Generic;
using CafePOS.DAL;
using CafePOS.DTO;

namespace CafePOS.BUS
{
    public class BanAnBUS
    {
        private readonly BanAnDAL dal = new BanAnDAL();

        public List<BanAnDTO> GetAll() => dal.GetAll();

        public bool DoiTrangThai(int maBan, string trangThai)
        {
            if (trangThai != "Trong" && trangThai != "Co khach")
                throw new System.Exception("Trang thai ban khong hop le");
            return dal.CapNhatTrangThai(maBan, trangThai);
        }
    }
}
