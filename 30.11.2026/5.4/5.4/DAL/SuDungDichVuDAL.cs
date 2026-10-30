using System;
using System.Data;
using HotelManagement.DTO;

namespace HotelManagement.DAL
{
    public class SuDungDichVuDAL
    {
        public void Insert(SuDungDichVuDTO sd, UnitOfWork uow = null)
        {
            const string sql =
                "INSERT INTO SuDungDichVu (MaPhieu, MaDV, SoLuong, ThoiGian) " +
                "VALUES (@MaPhieu, @MaDV, @SoLuong, @ThoiGian)";
            var ps = new[]
            {
                DbHelper.Param("@MaPhieu", sd.MaPhieu),
                DbHelper.Param("@MaDV", sd.MaDV),
                DbHelper.Param("@SoLuong", sd.SoLuong),
                DbHelper.Param("@ThoiGian", sd.ThoiGian)
            };
            DbHelper.ExecuteNonQuery(sql, ps, uow);
        }


        public DataTable GetChiTietByPhieu(int maPhieu, UnitOfWork uow = null)
        {
            const string sql =
                "SELECT s.MaSD, d.TenDV, d.DonGia, s.SoLuong, d.DonGia * s.SoLuong AS ThanhTien, s.ThoiGian " +
                "FROM SuDungDichVu s JOIN DichVu d ON d.MaDV = s.MaDV " +
                "WHERE s.MaPhieu = @MaPhieu ORDER BY s.ThoiGian, s.MaSD";
            return DbHelper.ExecuteDataTable(sql, new[] { DbHelper.Param("@MaPhieu", maPhieu) }, uow);
        }

        public decimal TinhTongTien(int maPhieu, UnitOfWork uow = null)
        {
            const string sql =
                "SELECT IFNULL(SUM(d.DonGia * s.SoLuong), 0) " +
                "FROM SuDungDichVu s JOIN DichVu d ON d.MaDV = s.MaDV " +
                "WHERE s.MaPhieu = @MaPhieu";
            return Convert.ToDecimal(
                DbHelper.ExecuteScalar(sql, new[] { DbHelper.Param("@MaPhieu", maPhieu) }, uow));
        }
    }
}
