using System;
using System.Collections.Generic;
using CafePOS.DAL;
using CafePOS.DTO;

namespace CafePOS.BUS
{
    public class MonAnBUS
    {
        private readonly MonAnDAL dal = new MonAnDAL();

        public List<MonAnDTO> GetAll() => dal.GetAll();

        public List<MonAnDTO> GetByDanhMuc(int maDanhMuc) => dal.GetByDanhMuc(maDanhMuc);

        public bool Them(MonAnDTO mon)
        {
            Validate(mon);
            return dal.Insert(mon);
        }

        public bool Sua(MonAnDTO mon)
        {
            Validate(mon);
            return dal.Update(mon);
        }

        public bool Xoa(int maMon) => dal.Delete(maMon);

       
        private void Validate(MonAnDTO mon)
        {
            if (string.IsNullOrWhiteSpace(mon.TenMon))
                throw new Exception("Ten mon khong duoc de trong");
            if (mon.DonGia < 0)
                throw new Exception("Don gia khong duoc nho hon 0");
            if (mon.MaDanhMuc <= 0)
                throw new Exception("Vui long chon danh muc cho mon an");
        }
    }
}
