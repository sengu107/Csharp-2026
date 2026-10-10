namespace Bai_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            epCheck.Clear();
            bool hopLe = true;

            if (string.IsNullOrWhiteSpace(txttendangnhap.Text))
            {
                epCheck.SetError(txttendangnhap, "Tên đăng nhập không được để trống!");
                hopLe = false;
            }

            if (string.IsNullOrEmpty(txtmatkhau.Text))
            {
                epCheck.SetError(txtmatkhau, "Mật khẩu không được để trống!");
                hopLe = false;
            }

            if (txtnhaplaimatkhau.Text != txtmatkhau.Text)
            {
                epCheck.SetError(txtnhaplaimatkhau, "Mật khẩu nhập lại không khớp!");
                hopLe = false;
            }

            if (TinhTuoi(dtpngaysinh.Value) < 18)
            {
                epCheck.SetError(dtpngaysinh, "Bạn phải từ 18 tuổi trở lên!");
                hopLe = false;
            }

            if (!chkbdieukhoandichvu.Checked)
            {
                epCheck.SetError(chkbdieukhoandichvu, "Bạn phải đồng ý Điều khoản dịch vụ!");
                hopLe = false;
            }

            if (hopLe)
            {
                MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txttendangnhap.Clear();
            txtmatkhau.Clear();
            txtnhaplaimatkhau.Clear();
            dtpngaysinh.Value = DateTime.Today;
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            chkbdieukhoandichvu.Checked = false;
            epCheck.Clear();
            txttendangnhap.Focus();
        }

        private int TinhTuoi(DateTime ngaySinh)
        {
            DateTime homNay = DateTime.Today;
            int tuoi = homNay.Year - ngaySinh.Year;
            if (ngaySinh.Date > homNay.AddYears(-tuoi))
                tuoi--;
            return tuoi;
        }
    }
}