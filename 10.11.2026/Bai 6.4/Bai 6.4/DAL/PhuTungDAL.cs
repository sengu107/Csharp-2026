using Bai_6_4.DAL;
using Bai_6_4.DTO;
using MySql.Data.MySqlClient;
using System.Data;

namespace Bai_6_4.DAL
{
    public class PhuTungDAL : DBConnect
    {
        public DataTable LayDanhSachPhuTung()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT * FROM PhuTung";
                using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public bool ThemPhuTung(PhuTungDTO pt)
        {
            using (MySqlConnection conn = GetConnection())
            {
                string query = "INSERT INTO PhuTung (TenPhuTung, DonGia, SoLuongTon) VALUES (@Ten, @Gia, @Ton)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Ten", pt.TenPhuTung);
                    cmd.Parameters.AddWithValue("@Gia", pt.DonGia);
                    cmd.Parameters.AddWithValue("@Ton", pt.SoLuongTon);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

    
        public bool SuaPhuTung(PhuTungDTO pt)
        {
            using (MySqlConnection conn = GetConnection())
            {
                string query = "UPDATE PhuTung SET TenPhuTung = @Ten, DonGia = @Gia, SoLuongTon = @Ton WHERE MaPhuTung = @MaPT";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaPT", pt.MaPhuTung);
                    cmd.Parameters.AddWithValue("@Ten", pt.TenPhuTung);
                    cmd.Parameters.AddWithValue("@Gia", pt.DonGia);
                    cmd.Parameters.AddWithValue("@Ton", pt.SoLuongTon);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

   
        public bool XoaPhuTung(int maPT)
        {
            using (MySqlConnection conn = GetConnection())
            {
                string query = "DELETE FROM PhuTung WHERE MaPhuTung = @MaPT";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaPT", maPT);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}