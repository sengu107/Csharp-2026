using System;
using System.Data;
using HotelManagement.DTO;
using MySql.Data.MySqlClient;

namespace HotelManagement.DAL
{
    public class KhachHangDAL
    {
        
        public KhachHangDTO GetByCCCD(string cccd, UnitOfWork uow = null)
        {
            const string sql = "SELECT MaKH, HoTen, CCCD, SoDienThoai FROM KhachHang WHERE CCCD = @CCCD";
            var dt = DbHelper.ExecuteDataTable(sql,
                new[] { DbHelper.Param("@CCCD", MySqlDbType.VarChar, 20, cccd) }, uow);
            return dt.Rows.Count == 0 ? null : Map(dt.Rows[0]);
        }

        public KhachHangDTO GetById(int maKH, UnitOfWork uow = null)
        {
            const string sql = "SELECT MaKH, HoTen, CCCD, SoDienThoai FROM KhachHang WHERE MaKH = @MaKH";
            var dt = DbHelper.ExecuteDataTable(sql, new[] { DbHelper.Param("@MaKH", maKH) }, uow);
            return dt.Rows.Count == 0 ? null : Map(dt.Rows[0]);
        }

        
        public int Insert(KhachHangDTO kh, UnitOfWork uow = null)
        {
            const string sql =
                "INSERT INTO KhachHang (HoTen, CCCD, SoDienThoai) VALUES (@HoTen, @CCCD, @SDT); " +
                "SELECT LAST_INSERT_ID();";
            var ps = new[]
            {
                DbHelper.Param("@HoTen", MySqlDbType.VarChar, 100, kh.HoTen),
                DbHelper.Param("@CCCD", MySqlDbType.VarChar, 20, kh.CCCD),
                DbHelper.Param("@SDT", MySqlDbType.VarChar, 15, kh.SoDienThoai)
            };
            return Convert.ToInt32(DbHelper.ExecuteScalar(sql, ps, uow));
        }

        private static KhachHangDTO Map(DataRow r)
        {
            return new KhachHangDTO
            {
                MaKH = Convert.ToInt32(r["MaKH"]),
                HoTen = Convert.ToString(r["HoTen"]),
                CCCD = Convert.ToString(r["CCCD"]),
                SoDienThoai = r["SoDienThoai"] == DBNull.Value ? null : Convert.ToString(r["SoDienThoai"])
            };
        }
    }
}
