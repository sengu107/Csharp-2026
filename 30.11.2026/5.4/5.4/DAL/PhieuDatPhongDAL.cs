using System;
using System.Data;
using HotelManagement.DTO;
using MySql.Data.MySqlClient;

namespace HotelManagement.DAL
{
    public class PhieuDatPhongDAL
    {
      
        public int Insert(PhieuDatPhongDTO p, UnitOfWork uow = null)
        {
            const string sql =
                "INSERT INTO PhieuDatPhong (SoPhong, MaKH, NgayNhanPhong) " +
                "VALUES (@SoPhong, @MaKH, @NgayNhan); " +
                "SELECT LAST_INSERT_ID();";
            var ps = new[]
            {
                DbHelper.Param("@SoPhong", MySqlDbType.VarChar, 10, p.SoPhong),
                DbHelper.Param("@MaKH", p.MaKH),
                DbHelper.Param("@NgayNhan", p.NgayNhanPhong)
            };
            return Convert.ToInt32(DbHelper.ExecuteScalar(sql, ps, uow));
        }

        public PhieuDatPhongDTO GetById(int maPhieu, UnitOfWork uow = null)
        {
            const string sql =
                "SELECT MaPhieu, SoPhong, MaKH, NgayNhanPhong, NgayTraPhong, TongTienThanhToan " +
                "FROM PhieuDatPhong WHERE MaPhieu = @MaPhieu";
            var dt = DbHelper.ExecuteDataTable(sql, new[] { DbHelper.Param("@MaPhieu", maPhieu) }, uow);
            return dt.Rows.Count == 0 ? null : Map(dt.Rows[0]);
        }

   
        public DataTable GetDanhSachDangO()
        {
            const string sql =
                "SELECT p.MaPhieu, p.SoPhong, k.HoTen, p.NgayNhanPhong, " +
                "       CONCAT(p.SoPhong, ' - ', k.HoTen) AS HienThi " +
                "FROM PhieuDatPhong p JOIN KhachHang k ON k.MaKH = p.MaKH " +
                "WHERE p.NgayTraPhong IS NULL ORDER BY p.SoPhong";
            return DbHelper.ExecuteDataTable(sql);
        }

        public int CapNhatThanhToan(int maPhieu, DateTime ngayTra, decimal tongTien, UnitOfWork uow = null)
        {
            const string sql =
                "UPDATE PhieuDatPhong SET NgayTraPhong = @NgayTra, TongTienThanhToan = @Tong " +
                "WHERE MaPhieu = @MaPhieu AND NgayTraPhong IS NULL";
            var ps = new[]
            {
                DbHelper.Param("@NgayTra", ngayTra),
                DbHelper.Param("@Tong", tongTien),
                DbHelper.Param("@MaPhieu", maPhieu)
            };
            return DbHelper.ExecuteNonQuery(sql, ps, uow);
        }

        private static PhieuDatPhongDTO Map(DataRow r)
        {
            return new PhieuDatPhongDTO
            {
                MaPhieu = Convert.ToInt32(r["MaPhieu"]),
                SoPhong = Convert.ToString(r["SoPhong"]),
                MaKH = Convert.ToInt32(r["MaKH"]),
                NgayNhanPhong = Convert.ToDateTime(r["NgayNhanPhong"]),
                NgayTraPhong = r["NgayTraPhong"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["NgayTraPhong"]),
                TongTienThanhToan = r["TongTienThanhToan"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(r["TongTienThanhToan"])
            };
        }
    }
}
