using System;
using System.Data;
using MySql.Data.MySqlClient;

public class CongViecDAL : DBHelper
{
   
    public DataTable GetTasksByProjectAndStatus(int maDuAn, string trangThai)
    {
        using (MySqlConnection conn = GetConnection())
        {
            string query = "SELECT * FROM CongViec WHERE MaDuAn = @MaDuAn";
            if (!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả")
            {
                query += " AND TrangThai = @TrangThai";
            }

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaDuAn", maDuAn);
                if (!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả")
                {
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                }

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }

 
    public bool InsertTask(CongViecDTO t)
    {
        using (MySqlConnection conn = GetConnection())
        {
            string query = "INSERT INTO CongViec (MaDuAn, TenTask, MoTa, HanNop, DoUuTien, TrangThai) " +
                           "VALUES (@MaDuAn, @TenTask, @MoTa, @HanNop, @DoUuTien, @TrangThai)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaDuAn", t.MaDuAn);
                cmd.Parameters.AddWithValue("@TenTask", t.TenTask);
                cmd.Parameters.AddWithValue("@MoTa", t.MoTa);
                cmd.Parameters.AddWithValue("@HanNop", t.HanNop);
                cmd.Parameters.AddWithValue("@DoUuTien", t.DoUuTien);
                cmd.Parameters.AddWithValue("@TrangThai", t.TrangThai);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }


    public bool UpdateTaskStatus(int maTask, string trangThaiMoi)
    {
        using (MySqlConnection conn = GetConnection())
        {
            string query = "UPDATE CongViec SET TrangThai = @TrangThai WHERE MaTask = @MaTask";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TrangThai", trangThaiMoi);
                cmd.Parameters.AddWithValue("@MaTask", maTask);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }

    public bool AssignTaskToMember(int maTask, int maThanhVien)
    {
        using (MySqlConnection conn = GetConnection())
        {
            string query = "INSERT INTO PhanCong (MaTask, MaThanhVien) VALUES (@MaTask, @MaThanhVien)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaTask", maTask);
                cmd.Parameters.AddWithValue("@MaThanhVien", maThanhVien);

                conn.Open();
                try
                {
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch
                {
                    return false; 
                }
            }
        }
    }


    public MySqlDataReader GetOverdueTasks()
    {
        MySqlConnection conn = GetConnection();
        string query = "SELECT t.TenTask, d.TenDuAn, t.HanNop, t.TrangThai " +
                       "FROM CongViec t JOIN DuAn d ON t.MaDuAn = d.MaDuAn " +
                       "WHERE t.HanNop < NOW() AND t.TrangThai != 'Done'";

        MySqlCommand cmd = new MySqlCommand(query, conn);
        conn.Open();
        return cmd.ExecuteReader(CommandBehavior.CloseConnection);
    }

  
    public DataTable GetMemberPerformance(int maDuAn)
    {
        using (MySqlConnection conn = GetConnection())
        {
            string query = @"
                SELECT tv.HoTen, 
                       COUNT(t.MaTask) AS TongSoTask,
                       SUM(CASE WHEN t.TrangThai = 'Done' THEN 1 ELSE 0 END) AS TaskHoanThanh,
                       CAST((SUM(CASE WHEN t.TrangThai = 'Done' THEN 1 ELSE 0 END) * 100.0) / NULLIF(COUNT(t.MaTask), 0) AS DECIMAL(5,2)) AS PhanTrangHoanThanh
                FROM ThanhVien tv
                JOIN PhanCong pc ON tv.MaThanhVien = pc.MaThanhVien
                JOIN CongViec t ON pc.MaTask = t.MaTask
                WHERE t.MaDuAn = @MaDuAn
                GROUP BY tv.MaThanhVien, tv.HoTen";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaDuAn", maDuAn);
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}