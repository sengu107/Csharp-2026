using System;
using System.Collections.Generic;
using System.Data;
using HotelManagement.DTO;
using MySql.Data.MySqlClient;

namespace HotelManagement.DAL
{
    public class PhongDAL
    {
       
        public DataTable GetAll()
        {
            const string sql = "SELECT SoPhong, LoaiPhong, GiaTheoGio, TrangThai FROM Phong ORDER BY SoPhong";
            return DbHelper.ExecuteDataTable(sql);
        }

        public List<PhongDTO> GetByTrangThai(string trangThai)
        {
            const string sql =
                "SELECT SoPhong, LoaiPhong, GiaTheoGio, TrangThai FROM Phong " +
                "WHERE TrangThai = @TrangThai ORDER BY SoPhong";
            var dt = DbHelper.ExecuteDataTable(sql,
                new[] { DbHelper.Param("@TrangThai", MySqlDbType.VarChar, 30, trangThai) });

            var list = new List<PhongDTO>();
            foreach (DataRow r in dt.Rows) list.Add(Map(r));
            return list;
        }

        public PhongDTO GetBySoPhong(string soPhong, UnitOfWork uow = null)
        {
            const string sql =
                "SELECT SoPhong, LoaiPhong, GiaTheoGio, TrangThai FROM Phong WHERE SoPhong = @SoPhong";
            var dt = DbHelper.ExecuteDataTable(sql,
                new[] { DbHelper.Param("@SoPhong", MySqlDbType.VarChar, 10, soPhong) }, uow);
            return dt.Rows.Count == 0 ? null : Map(dt.Rows[0]);
        }

       
        public int CapNhatTrangThai(string soPhong, string trangThaiMoi, string trangThaiCu, UnitOfWork uow = null)
        {
            const string sql =
                "UPDATE Phong SET TrangThai = @Moi " +
                "WHERE SoPhong = @SoPhong AND (@Cu IS NULL OR TrangThai = @Cu)";
            var ps = new[]
            {
                DbHelper.Param("@Moi", MySqlDbType.VarChar, 30, trangThaiMoi),
                DbHelper.Param("@SoPhong", MySqlDbType.VarChar, 10, soPhong),
                DbHelper.Param("@Cu", MySqlDbType.VarChar, 30, trangThaiCu)
            };
            return DbHelper.ExecuteNonQuery(sql, ps, uow);
        }

        private static PhongDTO Map(DataRow r)
        {
            return new PhongDTO
            {
                SoPhong = Convert.ToString(r["SoPhong"]),
                LoaiPhong = Convert.ToString(r["LoaiPhong"]),
                GiaTheoGio = Convert.ToDecimal(r["GiaTheoGio"]),
                TrangThai = Convert.ToString(r["TrangThai"])
            };
        }
    }
}
