using System.Data;
using MySql.Data.MySqlClient;

public class ThanhVienDAL : DBHelper
{
    public DataTable GetAllThanhVien()
    {
        using (MySqlConnection conn = GetConnection())
        {
            string query = "SELECT * FROM ThanhVien";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }

    public bool InsertThanhVien(ThanhVienDTO tv)
    {
        using (MySqlConnection conn = GetConnection())
        {
            string query = "INSERT INTO ThanhVien (HoTen, Email, ChuyenMon) VALUES (@HoTen, @Email, @ChuyenMon)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@HoTen", tv.HoTen);
                cmd.Parameters.AddWithValue("@Email", tv.Email);
                cmd.Parameters.AddWithValue("@ChuyenMon", tv.ChuyenMon);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}