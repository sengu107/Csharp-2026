using System.Windows.Forms;

namespace Market.GUI
{
   
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void miDanhMuc_Click(object sender, System.EventArgs e) => MoFormCon(new frmDanhMuc());

        private void miBanHang_Click(object sender, System.EventArgs e) => MoFormCon(new frmBanHang());

        private void miBaoCao_Click(object sender, System.EventArgs e) => MoFormCon(new frmBaoCao());

        private void miThoat_Click(object sender, System.EventArgs e) => Close();

        private void MoFormCon(Form f)
        {
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
    }
}
