using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Market.BUS;
using Market.DTO;

namespace Market.GUI
{
   
    public partial class frmBanHang : Form
    {
        private readonly SanPhamBUS spBUS = new SanPhamBUS();
        private readonly KhachHangBUS khBUS = new KhachHangBUS();
        private readonly NhanVienBUS nvBUS = new NhanVienBUS();
        private readonly HoaDonBUS hdBUS = new HoaDonBUS();

        private readonly List<ChiTietHoaDon> gioHang = new List<ChiTietHoaDon>();

        public frmBanHang()
        {
            InitializeComponent();
        }

        private void frmBanHang_Load(object sender, EventArgs e) => NapDuLieuBanDau();

        private void NapDuLieuBanDau()
        {
            var dsNV = nvBUS.GetAll();
            cboNhanVien.DataSource = dsNV;
            cboNhanVien.DisplayMember = "TenNV";
            cboNhanVien.ValueMember = "MaNV";

            var dsKH = khBUS.GetAll();
            var dsKHCoKhachLe = new List<KhachHang> { new KhachHang { MaKH = 0, TenKH = "-- Khach le --" } };
            dsKHCoKhachLe.AddRange(dsKH);

            cboKhachHang.DataSource = dsKHCoKhachLe;
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";
        }

        private void txtMaSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ThemVaoGioHang();
                e.SuppressKeyPress = true;
            }
        }

        private void btnThemVaoGio_Click(object sender, EventArgs e) => ThemVaoGioHang();

        private void ThemVaoGioHang()
        {
            string maSP = txtMaSP.Text.Trim();
            if (string.IsNullOrEmpty(maSP)) return;

            var sp = spBUS.GetByMa(maSP);
            if (sp == null)
            {
                MessageBox.Show("Khong tim thay san pham co ma: " + maSP);
                return;
            }

            int soLuong = (int)nudSoLuong.Value;

            var dong = gioHang.FirstOrDefault(x => x.MaSP == sp.MaSP);
            if (dong != null)
                dong.SoLuong += soLuong;
            else
                gioHang.Add(new ChiTietHoaDon
                {
                    MaSP = sp.MaSP,
                    TenSP = sp.TenSP,
                    SoLuong = soLuong,
                    DonGia = sp.GiaBan
                });

            CapNhatGioHang();
            txtMaSP.Text = "";
            nudSoLuong.Value = 1;
            txtMaSP.Focus();
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow == null) return;
            string maSP = dgvGioHang.CurrentRow.Cells["MaSP"].Value?.ToString();
            var dong = gioHang.FirstOrDefault(x => x.MaSP == maSP);
            if (dong != null) gioHang.Remove(dong);
            CapNhatGioHang();
        }

        private void btnLamMoiGio_Click(object sender, EventArgs e)
        {
            gioHang.Clear();
            CapNhatGioHang();
        }

        private void CapNhatGioHang()
        {
            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = gioHang.Select(x => new
            {
                x.MaSP,
                x.TenSP,
                x.SoLuong,
                DonGia = x.DonGia.ToString("N0"),
                ThanhTien = x.ThanhTien.ToString("N0")
            }).ToList();

            decimal tongTien = gioHang.Sum(x => x.ThanhTien);
            lblTongTien.Text = "Tong tien: " + tongTien.ToString("N0") + " d";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (gioHang.Count == 0)
            {
                MessageBox.Show("Gio hang dang trong.");
                return;
            }
            if (cboNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui long chon nhan vien ban hang.");
                return;
            }

            int maNV = (int)cboNhanVien.SelectedValue;
            int maKHChon = (int)cboKhachHang.SelectedValue;
            int? maKH = maKHChon == 0 ? (int?)null : maKHChon;

            var (ok, msg, maHD) = hdBUS.ThanhToan(maNV, maKH, gioHang);

            MessageBox.Show(msg, ok ? "Thanh cong" : "Loi",
                MessageBoxButtons.OK, ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (ok)
            {
                gioHang.Clear();
                CapNhatGioHang();
                NapDuLieuBanDau(); // lam moi diem tich luy khach hang vua cap nhat
            }
        }
    }
}
