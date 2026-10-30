using System;
using System.Collections.Generic;
using CafePOS.DAL;
using CafePOS.DTO;

namespace CafePOS.BUS
{
    public class DanhMucBUS
    {
        private readonly DanhMucDAL dal = new DanhMucDAL();

        public List<DanhMucDTO> GetAll() => dal.GetAll();

        public bool Them(DanhMucDTO dm)
        {
            Validate(dm);
            return dal.Insert(dm);
        }

        public bool Sua(DanhMucDTO dm)
        {
            Validate(dm);
            return dal.Update(dm);
        }

        public bool Xoa(int maDanhMuc) => dal.Delete(maDanhMuc);

        private void Validate(DanhMucDTO dm)
        {
            if (string.IsNullOrWhiteSpace(dm.TenDanhMuc))
                throw new Exception("Ten danh muc khong duoc de trong");
        }
    }
}
