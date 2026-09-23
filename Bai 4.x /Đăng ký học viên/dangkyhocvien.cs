using Microsoft.VisualBasic.Devices;
using System.Xml.Linq;

namespace dangkyhocvien
{
    public partial class Form1 : Form
    {
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
            var courses = new[]
            {
                new {id=1, name="Lập trình hướng đối tượng"},
                new {id=2, name="Cơ sở lập trình web"},
                new {id=3, name="Python"},
                new {id=4, name="C++"},};
            cboCourse.DataSource = courses;
            cboCourse.DisplayMember = "name";
            cboCourse.ValueMember = "id";

        }
        private void btn_Dangky_Click(object sender, EventArgs e)
        {
            string phone = mtxtPhone.Text;
            string birthDate = dtpBirthDate.Text;
            string course = cboCourse.Text;
            MessageBox.Show(
            $"THÔNG TIN ĐĂNG KÝ\n\n" +
            $"Số điện thoại: {phone}\n" +
            $"Ngày sinh: {birthDate}\n" +
            $"Khóa học: {course}",
            "Thông tin đăng ký",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
    );

        }
    }
}

