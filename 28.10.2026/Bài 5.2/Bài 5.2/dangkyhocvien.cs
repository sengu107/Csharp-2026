using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dangkyhocvien
{
    public partial class Form1 : Form
    {
        private const string connStr = "Server=localhost;Database=dangkyhocvien;Uid=root;Pwd=senchan;";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblBirthday_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void LoadCourses()
        {
            cboCourse.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, tenkhoahoc FROM khoahoc";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            string ten = reader.GetString("tenkhoahoc");

                            cboCourse.Items.Add(new ComboboxItem(id, ten));
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Lỗi tải danh sách khóa học: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            cboCourse.DisplayMember = "Text";
            cboCourse.ValueMember = "Value";
        }

        private void btn_Dangky_Click(object sender, EventArgs e)
        {
            string phone = mtxtPhone.Text.Trim();
            string birthDateText = dtpBirthDate.Text.Trim();

            // Validate cơ bản
            if (string.IsNullOrWhiteSpace(phone) || phone.Contains("_"))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số điện thoại.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(birthDateText, out DateTime birthDate))
            {
                MessageBox.Show("Ngày sinh không hợp lệ.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboCourse.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn khóa học.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ComboboxItem selectedCourse = (ComboboxItem)cboCourse.SelectedItem;
            int courseId = selectedCourse.Value;

        
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO hocvien (sodienthoai, ngaysinh, khoahoc_id) VALUES (@sdt, @ns, @khid)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@sdt", phone);
                        cmd.Parameters.AddWithValue("@ns", birthDate);
                        cmd.Parameters.AddWithValue("@khid", courseId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        $"THÔNG TIN ĐĂNG KÝ\n\n" +
                        $"Số điện thoại: {phone}\n" +
                        $"Ngày sinh: {birthDate:dd/MM/yyyy}\n" +
                        $"Khóa học: {selectedCourse.Text}",
                        "Đăng ký thành công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

               
                    mtxtPhone.Clear();
                    dtpBirthDate.Clear();
                    cboCourse.SelectedIndex = -1;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Lỗi lưu đăng ký: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

   
    public class ComboboxItem
    {
        public int Value { get; set; }
        public string Text { get; set; }

        public ComboboxItem(int value, string text)
        {
            Value = value;
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}