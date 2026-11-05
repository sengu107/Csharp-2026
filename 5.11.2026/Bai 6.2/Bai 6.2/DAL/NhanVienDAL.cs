using System.Data;
using MySql.Data.MySqlClient;
using HRM.DTO;

namespace HRM.DAL 
{
    public class NhanVienDAL
    {
        public DataTable GetAllNhanVien()
        {
           
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"SELECT nv.MaNV, nv.HoTen, nv.NgaySinh, nv.CCCD, nv.MaPB, pb.TenPB, nv.LuongCoBan, nv.HeSoLuong 
                                FROM NhanVien nv 
                                LEFT JOIN PhongBan pb ON nv.MaPB = pb.MaPB";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        

        public bool Insert(NhanVienDTO nv)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO NhanVien (HoTen, NgaySinh, CCCD, MaPB, LuongCoBan, HeSoLuong) 
                                VALUES (@HoTen, @NgaySinh, @CCCD, @MaPB, @LuongCoBan, @HeSoLuong)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                cmd.Parameters.AddWithValue("@CCCD", nv.CCCD);
                cmd.Parameters.AddWithValue("@MaPB", nv.MaPB);
                cmd.Parameters.AddWithValue("@LuongCoBan", nv.LuongCoBan);
                cmd.Parameters.AddWithValue("@HeSoLuong", nv.HeSoLuong);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(NhanVienDTO nv)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"UPDATE NhanVien 
                                SET HoTen=@HoTen, NgaySinh=@NgaySinh, CCCD=@CCCD, MaPB=@MaPB, LuongCoBan=@LuongCoBan, HeSoLuong=@HeSoLuong 
                                WHERE MaNV=@MaNV";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                cmd.Parameters.AddWithValue("@CCCD", nv.CCCD);
                cmd.Parameters.AddWithValue("@MaPB", nv.MaPB);
                cmd.Parameters.AddWithValue("@LuongCoBan", nv.LuongCoBan);
                cmd.Parameters.AddWithValue("@HeSoLuong", nv.HeSoLuong);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int maNV)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", maNV);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable Search(string keyword)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"SELECT nv.MaNV, nv.HoTen, nv.NgaySinh, nv.CCCD, pb.TenPB, nv.LuongCoBan, nv.HeSoLuong 
                                FROM NhanVien nv 
                                LEFT JOIN PhongBan pb ON nv.MaPB = pb.MaPB
                                WHERE nv.HoTen LIKE @Keyword OR nv.CCCD LIKE @Keyword OR pb.TenPB LIKE @Keyword";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}