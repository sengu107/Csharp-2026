namespace Bai_4._6
{
    public partial class FormLogin : Form
    {
        public string UserName => txtUser.Text.Trim();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object? sender, EventArgs e)
        {
            if (UserName == "admin" && txtPass.Text == "123")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Đăng nhập",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Clear();
                txtPass.Focus();
            }
        }
    }
}