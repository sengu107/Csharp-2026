using System;
using System.Windows.Forms;
using Market.BUS;

namespace Market.GUI
{
   
    public partial class frmBaoCao : Form
    {
        private readonly BaoCaoBUS bcBUS = new BaoCaoBUS();

        public frmBaoCao()
        {
            InitializeComponent();
            dtpTu.Value = DateTime.Today.AddDays(-7);
            dtpDen.Value = DateTime.Today;
        }

        private void frmBaoCao_Load(object sender, EventArgs e) => NapBaoCao();

        private void btnXemDoanhThu_Click(object sender, EventArgs e)
        {
            decimal dt = bcBUS.DoanhThuTheoKhoang(dtpTu.Value, dtpDen.Value);
            lblDoanhThuKhoang.Text = "Doanh thu khoang da chon: " + dt.ToString("N0") + " d";
        }

        private void btnLamMoiBaoCao_Click(object sender, EventArgs e) => NapBaoCao();

        private void NapBaoCao()
        {
            lblDoanhThuHomNay.Text = bcBUS.DoanhThuHomNay().ToString("N0") + " d";
            lblDoanhThuThangNay.Text = bcBUS.DoanhThuThangNay().ToString("N0") + " d";
            dgvTop5.DataSource = bcBUS.Top5SanPhamBanChay();
        }
    }
}
