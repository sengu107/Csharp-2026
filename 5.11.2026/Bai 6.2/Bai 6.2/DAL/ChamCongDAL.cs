using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace HRM.DAL
{
    public class ChamCongDAL
    {
        private MySqlDataAdapter adapter;
        private MySqlCommandBuilder commandBuilder;

        public DataTable GetBangChamCongByThang(string thangNam)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

              
                string insertMissingQuery = @"
                    INSERT INTO BangChamCong (MaNV, ThangNam, SoNgayCong, SoGioOT)
                    SELECT MaNV, @ThangNam, 0, 0 
                    FROM NhanVien 
                    WHERE MaNV NOT IN (
                        SELECT MaNV FROM BangChamCong WHERE ThangNam = @ThangNam
                    );";
                using (MySqlCommand cmdInsert = new MySqlCommand(insertMissingQuery, conn))
                {
                    cmdInsert.Parameters.AddWithValue("@ThangNam", thangNam);
                    cmdInsert.ExecuteNonQuery();
                }

                
                string query = @"SELECT MaCong, MaNV, ThangNam, SoNgayCong, SoGioOT 
                                 FROM BangChamCong 
                                 WHERE ThangNam = @ThangNam";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ThangNam", thangNam);

                adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public bool SaveBangChamCong(DataTable dtChamCong, string thangNam)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string selectQuery = @"SELECT MaCong, MaNV, ThangNam, SoNgayCong, SoGioOT 
                                       FROM BangChamCong 
                                       WHERE ThangNam = @ThangNam";
                MySqlCommand cmdSelect = new MySqlCommand(selectQuery, conn);
                cmdSelect.Parameters.AddWithValue("@ThangNam", thangNam);

                adapter = new MySqlDataAdapter(cmdSelect);
                commandBuilder = new MySqlCommandBuilder(adapter);

           
                adapter.Update(dtChamCong);
                return true;
            }
        }
    }
}