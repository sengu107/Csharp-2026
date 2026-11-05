using System;
using System.Data;
using System.Windows.Forms;
using HRM.BUS;
using HRM.DTO;
using HRM.DAL;


namespace HRM.GUI
{
    public partial class MainForm : Form
    {
        private NhanVienBUS nhanVienBUS = new NhanVienBUS();
        private ChamCongBUS chamCongBUS = new ChamCongBUS();
        private LuongBUS luongBUS = new LuongBUS();

        private DataTable dtChamCong;
        private int selectedMaNV = -1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNhanVienData();
        }

        private void LoadNhanVienData()
        {
            dgvNhanVien.DataSource = nhanVienBUS.GetAllNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVienDTO nv = new NhanVienDTO
                {
                    HoTen = txtHoTen.Text.Trim(),
                    CCCD = txtCCCD.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value,
                    LuongCoBan = decimal.Parse(txtLuongCoBan.Text),
                    HeSoLuong = double.Parse(txtHeSoLuong.Text),
                    MaPB = int.Parse(txtMaPB.Text)
                };

                if (nhanVienBUS.Insert(nv))
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    LoadNhanVienData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedMaNV <= 0) return;

            try
            {
                NhanVienDTO nv = new NhanVienDTO
                {
                    MaNV = selectedMaNV,
                    HoTen = txtHoTen.Text.Trim(),
                    CCCD = txtCCCD.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value,
                    LuongCoBan = decimal.Parse(txtLuongCoBan.Text),
                    HeSoLuong = double.Parse(txtHeSoLuong.Text),
                    MaPB = int.Parse(txtMaPB.Text)
                };

                if (nhanVienBUS.Update(nv))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadNhanVienData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedMaNV <= 0) return;

            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (nhanVienBUS.Delete(selectedMaNV))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadNhanVienData();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nhanVienBUS.Search(txtTimKiem.Text.Trim());
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                selectedMaNV = Convert.ToInt32(row.Cells["MaNV"].Value);
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtCCCD.Text = row.Cells["CCCD"].Value?.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                txtLuongCoBan.Text = row.Cells["LuongCoBan"].Value.ToString();
                txtHeSoLuong.Text = row.Cells["HeSoLuong"].Value.ToString();
                txtMaPB.Text = row.Cells["MaPB"].Value.ToString();
            }
        }

        
        private void btnNapChamCong_Click(object sender, EventArgs e)
        {
            string thangNam = txtThangNam.Text.Trim();
            dtChamCong = chamCongBUS.GetBangChamCongByThang(thangNam);
            dgvChamCong.DataSource = dtChamCong;

            if (dgvChamCong.Columns.Contains("MaNV")) dgvChamCong.Columns["MaNV"].ReadOnly = true;
            if (dgvChamCong.Columns.Contains("HoTen")) dgvChamCong.Columns["HoTen"].ReadOnly = true;
            if (dgvChamCong.Columns.Contains("ThangNam")) dgvChamCong.Columns["ThangNam"].ReadOnly = true;
        }

        private void btnLuuChamCong_Click(object sender, EventArgs e)
        {
            string thangNam = txtThangNam.Text.Trim();
            if (dtChamCong != null && chamCongBUS.SaveBangChamCong(dtChamCong, thangNam))
            {
                MessageBox.Show("Lưu bảng chấm công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
        private void btnChotLuong_Click(object sender, EventArgs e)
        {
            string thangNam = txtThangNam.Text.Trim();
            try
            {
                if (luongBUS.ChotLuongThang(thangNam))
                {
                    MessageBox.Show($"Đã chốt lương tháng {thangNam} thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chốt lương: " + ex.Message, "Lỗi Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}