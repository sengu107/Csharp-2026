using System;
using System.Data;
using Market.DAL;

namespace Market.BUS
{
    public class BaoCaoBUS
    {
        private readonly BaoCaoDAL dal = new BaoCaoDAL();

        public decimal DoanhThuHomNay() => dal.DoanhThuHomNay();
        public decimal DoanhThuThangNay() => dal.DoanhThuThangNay();
        public decimal DoanhThuTheoKhoang(DateTime tu, DateTime den) => dal.TongDoanhThu(tu, den);
        public DataTable Top5SanPhamBanChay() => dal.Top5SanPhamBanChay();
    }
}
