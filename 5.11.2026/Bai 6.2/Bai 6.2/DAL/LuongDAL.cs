using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace HRM.DAL
{
    public class LuongDAL
    {
        public bool ChotLuongThang(string thangNam)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string queryTinhLuong = @"
                        SELECT nv.MaNV, nv.LuongCoBan, nv.HeSoLuong, bcc.SoNgayCong, bcc.SoGioOT
                        FROM NhanVien nv
                        INNER JOIN BangChamCong bcc ON nv.MaNV = bcc.MaNV
                        WHERE bcc.ThangNam = @ThangNam";

                    MySqlCommand cmdGet = new MySqlCommand(queryTinhLuong, conn, transaction);
                    cmdGet.Parameters.AddWithValue("@ThangNam", thangNam);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmdGet);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        int maNV = Convert.ToInt32(row["MaNV"]);
                        decimal luongCoBan = Convert.ToDecimal(row["LuongCoBan"]);
                        double heSoLuong = Convert.ToDouble(row["HeSoLuong"]);
                        double soNgayCong = Convert.ToDouble(row["SoNgayCong"]);
                        double soGioOT = Convert.ToDouble(row["SoGioOT"]);

                        decimal thucLinh = (decimal)((((double)luongCoBan * heSoLuong) / 22.0) * soNgayCong + (soGioOT * 50000.0));

                        string queryUpsert = @"
                            INSERT INTO BangLuong (MaNV, ThangNam, ThucLinh) 
                            VALUES (@MaNV, @ThangNam, @ThucLinh)
                            ON DUPLICATE KEY UPDATE ThucLinh = @ThucLinh;";

                        MySqlCommand cmdUpsert = new MySqlCommand(queryUpsert, conn, transaction);
                        cmdUpsert.Parameters.AddWithValue("@MaNV", maNV);
                        cmdUpsert.Parameters.AddWithValue("@ThangNam", thangNam);
                        cmdUpsert.Parameters.AddWithValue("@ThucLinh", thucLinh);
                        cmdUpsert.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}