using System;
using System.Collections.Generic;
using System.Data;
using HotelManagement.DTO;

namespace HotelManagement.DAL
{
    public class DichVuDAL
    {
        public List<DichVuDTO> GetAll()
        {
            const string sql = "SELECT MaDV, TenDV, DonGia FROM DichVu ORDER BY TenDV";
            var dt = DbHelper.ExecuteDataTable(sql);
            var list = new List<DichVuDTO>();
            foreach (DataRow r in dt.Rows) list.Add(Map(r));
            return list;
        }

        public DichVuDTO GetById(int maDV, UnitOfWork uow = null)
        {
            const string sql = "SELECT MaDV, TenDV, DonGia FROM DichVu WHERE MaDV = @MaDV";
            var dt = DbHelper.ExecuteDataTable(sql, new[] { DbHelper.Param("@MaDV", maDV) }, uow);
            return dt.Rows.Count == 0 ? null : Map(dt.Rows[0]);
        }

        private static DichVuDTO Map(DataRow r)
        {
            return new DichVuDTO
            {
                MaDV = Convert.ToInt32(r["MaDV"]),
                TenDV = Convert.ToString(r["TenDV"]),
                DonGia = Convert.ToDecimal(r["DonGia"])
            };
        }
    }
}
