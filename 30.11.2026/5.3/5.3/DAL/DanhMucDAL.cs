using System.Collections.Generic;
using MySql.Data.MySqlClient;
using CafePOS.DTO;

namespace CafePOS.DAL
{
    public class DanhMucDAL
    {
        public List<DanhMucDTO> GetAll()
        {
            var list = new List<DanhMucDTO>();
            using (var conn = DBHelper.GetConnection())
            using (var cmd = new MySqlCommand("SELECT MaDanhMuc, TenDanhMuc FROM DanhMuc ORDER BY MaDanhMuc", conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new DanhMucDTO
                        {
                            MaDanhMuc = reader.GetInt32("MaDanhMuc"),
                            TenDanhMuc = reader.GetString("TenDanhMuc")
                        });
                    }
                }
            }
            return list;
        }

        public bool Insert(DanhMucDTO dm)
        {
            using (var conn = DBHelper.GetConnection())
            using (var cmd = new MySqlCommand("INSERT INTO DanhMuc (TenDanhMuc) VALUES (@ten)", conn))
            {
                cmd.Parameters.AddWithValue("@ten", dm.TenDanhMuc);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(DanhMucDTO dm)
        {
            using (var conn = DBHelper.GetConnection())
            using (var cmd = new MySqlCommand("UPDATE DanhMuc SET TenDanhMuc=@ten WHERE MaDanhMuc=@id", conn))
            {
                cmd.Parameters.AddWithValue("@ten", dm.TenDanhMuc);
                cmd.Parameters.AddWithValue("@id", dm.MaDanhMuc);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int maDanhMuc)
        {
            using (var conn = DBHelper.GetConnection())
            using (var cmd = new MySqlCommand("DELETE FROM DanhMuc WHERE MaDanhMuc=@id", conn))
            {
                cmd.Parameters.AddWithValue("@id", maDanhMuc);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
