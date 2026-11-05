using System;
using System.Windows.Forms;
using Market.BUS;
using Market.DTO;

namespace Market.GUI
{
    
    public partial class frmDanhMuc : Form
    {
        private readonly SanPhamBUS spBUS = new SanPhamBUS();
        private readonly KhachHangBUS khBUS = new KhachHangBUS();
        private readonly NhanVienBUS nvBUS = new NhanVienBUS();

        private int khDangChon = 0;
        private int nvDangChon = 0;

        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            TaiSanPham();
            TaiKhachHang();
            TaiNhanVien();
        }

        // =========================================================
        // SAN PHAM
        // =========================================================
        private void btnSPTimKiem_Click(object sender, EventArgs e) => TaiSanPham(txtSPTimKiem.Text);

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvSP.Rows[e.RowIndex];
            txtSPMa.Text = row.Cells["MaSP"].Value.ToString();
            txtSPTen.Text = row.Cells["TenSP"].Value.ToString();
            txtSPGia.Text = row.Cells["GiaBan"].Value.ToString();
            txtSPSL.Text = row.Cells["SoLuongTon"].Value.ToString();
            txtSPMa.Enabled = false; // khong cho sua khoa chinh khi dang chon de Sua
        }

        private void btnSPThem_Click(object sender, EventArgs e)
        {
            var sp = new SanPham
            {
                MaSP = txtSPMa.Text.Trim(),
                TenSP = txtSPTen.Text.Trim(),
                GiaBan = ParseDecimal(txtSPGia.Text),
                SoLuongTon = ParseInt(txtSPSL.Text)
            };
            var (ok, msg) = spBUS.ThemSua(sp, false);
            MessageBox.Show(msg);
            if (ok) { TaiSanPham(); LamMoiSanPham(); }
        }

        private void btnSPSua_Click(object sender, EventArgs e)
        {
            var sp = new SanPham
            {
                MaSP = txtSPMa.Text.Trim(),
                TenSP = txtSPTen.Text.Trim(),
                GiaBan = ParseDecimal(txtSPGia.Text),
                SoLuongTon = ParseInt(txtSPSL.Text)
            };
            var (ok, msg) = spBUS.ThemSua(sp, true);
            MessageBox.Show(msg);
            if (ok) { TaiSanPham(); LamMoiSanPham(); }
        }

        private void btnSPXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSPMa.Text)) return;
            if (MessageBox.Show("Xoa san pham " + txtSPMa.Text + "?", "Xac nhan",
                    MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            var (ok, msg) = spBUS.Xoa(txtSPMa.Text.Trim());
            MessageBox.Show(msg);
            if (ok) { TaiSanPham(); LamMoiSanPham(); }
        }

        private void btnSPLamMoi_Click(object sender, EventArgs e) => LamMoiSanPham();

        private void LamMoiSanPham()
        {
            txtSPMa.Text = txtSPTen.Text = txtSPGia.Text = txtSPSL.Text = "";
            txtSPMa.Enabled = true;
        }

        private void TaiSanPham(string tuKhoa = null)
        {
            dgvSP.DataSource = spBUS.TimKiem(tuKhoa);
        }

        // =========================================================
        // KHACH HANG
        // =========================================================
        private void btnKHTimKiem_Click(object sender, EventArgs e) => TaiKhachHang(txtKHTimKiem.Text);

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvKH.Rows[e.RowIndex];
            khDangChon = (int)row.Cells["MaKH"].Value;
            txtKHTen.Text = row.Cells["TenKH"].Value.ToString();
            txtKHDT.Text = row.Cells["DienThoai"].Value?.ToString() ?? "";
        }

        private void btnKHThem_Click(object sender, EventArgs e)
        {
            var kh = new KhachHang { TenKH = txtKHTen.Text.Trim(), DienThoai = txtKHDT.Text.Trim() };
            var (ok, msg) = khBUS.ThemSua(kh, false);
            MessageBox.Show(msg);
            if (ok) { TaiKhachHang(); LamMoiKhachHang(); }
        }

        private void btnKHSua_Click(object sender, EventArgs e)
        {
            if (khDangChon == 0) { MessageBox.Show("Chon khach hang can sua."); return; }
            var kh = new KhachHang { MaKH = khDangChon, TenKH = txtKHTen.Text.Trim(), DienThoai = txtKHDT.Text.Trim() };
            var (ok, msg) = khBUS.ThemSua(kh, true);
            MessageBox.Show(msg);
            if (ok) { TaiKhachHang(); LamMoiKhachHang(); }
        }

        private void btnKHXoa_Click(object sender, EventArgs e)
        {
            if (khDangChon == 0) { MessageBox.Show("Chon khach hang can xoa."); return; }
            if (MessageBox.Show("Xoa khach hang nay?", "Xac nhan", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            var (ok, msg) = khBUS.Xoa(khDangChon);
            MessageBox.Show(msg);
            if (ok) { TaiKhachHang(); LamMoiKhachHang(); }
        }

        private void btnKHLamMoi_Click(object sender, EventArgs e) => LamMoiKhachHang();

        private void LamMoiKhachHang()
        {
            khDangChon = 0;
            txtKHTen.Text = txtKHDT.Text = "";
        }

        private void TaiKhachHang(string tuKhoa = null)
        {
            dgvKH.DataSource = khBUS.TimKiem(tuKhoa);
        }

        // =========================================================
        // NHAN VIEN
        // =========================================================
        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvNV.Rows[e.RowIndex];
            nvDangChon = (int)row.Cells["MaNV"].Value;
            txtNVTen.Text = row.Cells["TenNV"].Value.ToString();
            txtNVDT.Text = row.Cells["SoDienThoai"].Value?.ToString() ?? "";
            txtNVChucVu.Text = row.Cells["ChucVu"].Value?.ToString() ?? "";
        }

        private void btnNVThem_Click(object sender, EventArgs e)
        {
            var nv = new NhanVien { TenNV = txtNVTen.Text.Trim(), SoDienThoai = txtNVDT.Text.Trim(), ChucVu = txtNVChucVu.Text.Trim() };
            var (ok, msg) = nvBUS.ThemSua(nv, false);
            MessageBox.Show(msg);
            if (ok) { TaiNhanVien(); LamMoiNhanVien(); }
        }

        private void btnNVSua_Click(object sender, EventArgs e)
        {
            if (nvDangChon == 0) { MessageBox.Show("Chon nhan vien can sua."); return; }
            var nv = new NhanVien { MaNV = nvDangChon, TenNV = txtNVTen.Text.Trim(), SoDienThoai = txtNVDT.Text.Trim(), ChucVu = txtNVChucVu.Text.Trim() };
            var (ok, msg) = nvBUS.ThemSua(nv, true);
            MessageBox.Show(msg);
            if (ok) { TaiNhanVien(); LamMoiNhanVien(); }
        }

        private void btnNVXoa_Click(object sender, EventArgs e)
        {
            if (nvDangChon == 0) { MessageBox.Show("Chon nhan vien can xoa."); return; }
            if (MessageBox.Show("Xoa nhan vien nay?", "Xac nhan", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            var (ok, msg) = nvBUS.Xoa(nvDangChon);
            MessageBox.Show(msg);
            if (ok) { TaiNhanVien(); LamMoiNhanVien(); }
        }

        private void btnNVLamMoi_Click(object sender, EventArgs e) => LamMoiNhanVien();

        private void LamMoiNhanVien()
        {
            nvDangChon = 0;
            txtNVTen.Text = txtNVDT.Text = txtNVChucVu.Text = "";
        }

        private void TaiNhanVien()
        {
            dgvNV.DataSource = nvBUS.GetAll();
        }

        // =========================================================
        private decimal ParseDecimal(string s) => decimal.TryParse(s, out var v) ? v : 0;
        private int ParseInt(string s) => int.TryParse(s, out var v) ? v : 0;
    }
}
