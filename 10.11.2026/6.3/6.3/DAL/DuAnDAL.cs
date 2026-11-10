using System.Data;
using MySql.Data.MySqlClient;
using ProjectTaskManagement.DTO; 

namespace ProjectTaskManagement.DAL { 
    public class DuAnDAL : DBHelper
    {

        public DataTable GetAllDuAn()
        {
            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT * FROM DuAn";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    
        public int Insert(DuAnDTO da) 
        {
            using (MySqlConnection conn = GetConnection())
            {
                string query = "INSERT INTO DuAn (TenDuAn, NgayBatDau, NgayKetThuc, TrangThai) VALUES (@TenDuAn, @NgayBatDau, @NgayKetThuc, @TrangThai); SELECT LAST_INSERT_ID();";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDuAn", da.TenDuAn);
                    cmd.Parameters.AddWithValue("@NgayBatDau", (object)da.NgayBatDau ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", (object)da.NgayKetThuc ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@TrangThai", da.TrangThai);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public bool Update(DuAnDTO da)
        {
            using (MySqlConnection conn = GetConnection())
            {
                string query = "UPDATE DuAn SET TenDuAn = @TenDuAn, NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc, TrangThai = @TrangThai WHERE MaDuAn = @MaDuAn";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaDuAn", da.MaDuAn);
                    cmd.Parameters.AddWithValue("@TenDuAn", da.TenDuAn);
                    cmd.Parameters.AddWithValue("@NgayBatDau", (object)da.NgayBatDau ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", (object)da.NgayKetThuc ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@TrangThai", da.TrangThai);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Delete(int maDuAn)
        {
            using (MySqlConnection conn = GetConnection())
            {
                string query = "DELETE FROM DuAn WHERE MaDuAn = @MaDuAn";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaDuAn", maDuAn);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}