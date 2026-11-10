using Bai_6_4.BUS;
using Bai_6_4.DAL;
using Bai_6_4.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Bai_6._4
{
    public partial class frmQuanLyGarage : Form
    {
        private PhuTungBUS ptBUS = new PhuTungBUS();
        private PhieuSuaChuaBUS pscBUS = new PhieuSuaChuaBUS();
        private XeDAL xeDAL = new XeDAL();
        private int maPhuTungDangChon = 0;

        private List<ChiTietSuaChuaDTO> danhSachChiTietTam = new List<ChiTietSuaChuaDTO>();

        public frmQuanLyGarage()
        {
            InitializeComponent();
            LoadDataToForms();
            RegisterEvents();
        }

        private void LoadDataToForms()
        {
            try
            {
              
                DataTable dtPT = ptBUS.LayDanhSach();
                dgvPhuTung.DataSource = dtPT;

                cbChonPhuTung.DataSource = dtPT;
                cbChonPhuTung.DisplayMember = "TenPhuTung";
                cbChonPhuTung.ValueMember = "MaPhuTung";

            
                dgvXeKhach.DataSource = xeDAL.TraCuuXe("");

           
                dgvDanhSachPhieu.DataSource = pscBUS.LayDanhSachPhieu();

               
                SetupChiTietGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu ban đầu từ CSDL: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupChiTietGridView()
        {
            dgvChiTietPhieu.AutoGenerateColumns = false;
            dgvChiTietPhieu.Columns.Clear();

            dgvChiTietPhieu.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaPhuTung", HeaderText = "Mã PT", Width = 60 });
            dgvChiTietPhieu.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenPhuTung", HeaderText = "Tên phụ tùng", Width = 150 });
            dgvChiTietPhieu.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoLuong", HeaderText = "Số lượng", Width = 70 });
            dgvChiTietPhieu.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DonGia", HeaderText = "Đơn giá", Width = 90 });
            dgvChiTietPhieu.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TienCong", HeaderText = "Tiền công", Width = 90 });
        }

        private void RegisterEvents()
        {
            // TAB 1: Tiếp nhận xe & Khách hàng
            btnTraCuu.Click += BtnTraCuu_Click;
            btnLuuXeKhach.Click += BtnLuuXeKhach_Click;
            btnXoaXe.Click += BtnXoaXe_Click;

            // TAB 2: Quản lý kho phụ tùng
            btnThemPT.Click += BtnThemPT_Click;
            btnSuaPT.Click += BtnSuaPT_Click;
            btnXoaPT.Click += BtnXoaPT_Click;
            dgvPhuTung.CellClick += DgvPhuTung_CellClick;

            // TAB 3: Lập phiếu sửa chữa (Transaction) & Thanh toán
            btnThemChiTiet.Click += BtnThemChiTiet_Click;
            btnLapPhieuTransaction.Click += BtnLapPhieuTransaction_Click;
            btnThanhToan.Click += BtnThanhToan_Click;
        }

     
        private void BtnTraCuu_Click(object sender, EventArgs e)
        {
            string keyword = txtTraCuuBienSo.Text.Trim();
            dgvXeKhach.DataSource = xeDAL.TraCuuXe(keyword);
        }

        private void BtnLuuXeKhach_Click(object sender, EventArgs e)
        {
            string tenKH = txtTenKH.Text.Trim();
            string dt = txtDienThoai.Text.Trim();
            string dc = txtDiaChi.Text.Trim();
            string bienSo = txtBienSoMoi.Text.Trim();
            string hieuXe = txtHieuXe.Text.Trim();
            int namSX = 0;
            int.TryParse(txtNamSX.Text.Trim(), out namSX);

            if (string.IsNullOrEmpty(bienSo) || string.IsNullOrEmpty(tenKH))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên khách hàng và Biển số xe!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KhachHangDTO kh = new KhachHangDTO { TenKH = tenKH, DienThoai = dt, DiaChi = dc };
            XeDTO xe = new XeDTO { BienSo = bienSo, HieuXe = hieuXe, NamSanXuat = namSX };

            string error = "";
            bool kq = xeDAL.ThemMoiKhachHangVaXe(kh, xe, out error);

            if (kq)
            {
                MessageBox.Show("Thêm mới thông tin chủ xe và xe thành công vào CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvXeKhach.DataSource = xeDAL.TraCuuXe("");

                txtTenKH.Clear();
                txtDienThoai.Clear();
                txtDiaChi.Clear();
                txtBienSoMoi.Clear();
                txtHieuXe.Clear();
                txtNamSX.Clear();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!\nChi tiết: " + error, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnXoaXe_Click(object sender, EventArgs e)
        {
            if (dgvXeKhach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn xe cần xóa từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string bienSo = dgvXeKhach.CurrentRow.Cells["BienSo"].Value.ToString();
            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa xe biển số {bienSo} không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string error = "";
                bool kq = xeDAL.XoaKhachHangVaXe(bienSo, out error);
                if (kq)
                {
                    MessageBox.Show("Xóa xe và thông tin chủ xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvXeKhach.DataSource = xeDAL.TraCuuXe("");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!\nChi tiết: " + error, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnThemPT_Click(object sender, EventArgs e)
        {
            try
            {
                PhuTungDTO pt = new PhuTungDTO
                {
                    TenPhuTung = txtTenPT.Text.Trim(),
                    DonGia = decimal.Parse(txtDonGiaPT.Text.Trim()),
                    SoLuongTon = int.Parse(txtSoLuongTonPT.Text.Trim())
                };

                if (ptBUS.ThemPhuTung(pt))
                {
                    MessageBox.Show("Thêm phụ tùng mới vào kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvPhuTung.DataSource = ptBUS.LayDanhSach();

                    txtTenPT.Clear();
                    txtDonGiaPT.Clear();
                    txtSoLuongTonPT.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi dữ liệu phụ tùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnSuaXe_Click(object sender, EventArgs e)
        {
            if (dgvXeKhach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn xe cần sửa từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string bienSo = dgvXeKhach.CurrentRow.Cells["BienSo"].Value.ToString();
            string tenKH = txtTenKH.Text.Trim();
            string dt = txtDienThoai.Text.Trim();
            string dc = txtDiaChi.Text.Trim();
            string hieuXe = txtHieuXe.Text.Trim();
            int namSX = 0;
            int.TryParse(txtNamSX.Text.Trim(), out namSX);
            if (string.IsNullOrEmpty(tenKH))
            {
                MessageBox.Show("Vui lòng nhập Tên khách hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            KhachHangDTO kh = new KhachHangDTO { TenKH = tenKH, DienThoai = dt, DiaChi = dc };
            XeDTO xe = new XeDTO { BienSo = bienSo, HieuXe = hieuXe, NamSanXuat = namSX };
            string error = "";
            bool kq = xeDAL.SuaThongTinXeVaKhachHang(xe, kh, out error);
            if (kq)
            {
                MessageBox.Show("Cập nhật thông tin chủ xe và xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvXeKhach.DataSource = xeDAL.TraCuuXe("");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!\nChi tiết: " + error, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSuaPT_Click(object sender, EventArgs e)
        {
            try
            {
                if (maPhuTungDangChon == 0)
                {
                    MessageBox.Show("Vui lòng chọn phụ tùng cần cập nhật từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PhuTungDTO pt = new PhuTungDTO
                {
                    MaPhuTung = maPhuTungDangChon, 
                    TenPhuTung = txtTenPT.Text.Trim(),
                    DonGia = decimal.Parse(txtDonGiaPT.Text.Trim()),
                    SoLuongTon = int.Parse(txtSoLuongTonPT.Text.Trim())
                };

                if (ptBUS.SuaPhuTung(pt))
                {
                    MessageBox.Show("Cập nhật thông tin phụ tùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvPhuTung.DataSource = ptBUS.LayDanhSach();
                    maPhuTungDangChon = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi dữ liệu phụ tùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoaPT_Click(object sender, EventArgs e)
        {
            if (maPhuTungDangChon == 0)
            {
                MessageBox.Show("Vui lòng chọn phụ tùng cần xóa từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa phụ tùng mã {maPhuTungDangChon} không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ptBUS.XoaPhuTung(maPhuTungDangChon))
                {
                    MessageBox.Show("Xóa phụ tùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvPhuTung.DataSource = ptBUS.LayDanhSach();
                    maPhuTungDangChon = 0;
                    txtTenPT.Clear();
                    txtDonGiaPT.Clear();
                    txtSoLuongTonPT.Clear();
                }
                else
                {
                    MessageBox.Show("Xóa phụ tùng thất bại do đang được sử dụng trong hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DgvPhuTung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhuTung.Rows[e.RowIndex];
    
                maPhuTungDangChon = Convert.ToInt32(row.Cells["MaPhuTung"].Value);

                txtTenPT.Text = row.Cells["TenPhuTung"].Value.ToString();
                txtDonGiaPT.Text = row.Cells["DonGia"].Value.ToString();
                txtSoLuongTonPT.Text = row.Cells["SoLuongTon"].Value.ToString();
            }
        }

  
        private void BtnThemChiTiet_Click(object sender, EventArgs e)
        {
            if (cbChonPhuTung.SelectedValue == null) return;

            int maPT = Convert.ToInt32(cbChonPhuTung.SelectedValue);
            string tenPT = cbChonPhuTung.Text;
            int soLuong = (int)nudSoLuongPT.Value;
            decimal tienCong = 0;
            decimal.TryParse(txtTienCong.Text.Trim(), out tienCong);

        
            DataRowView rowView = cbChonPhuTung.SelectedItem as DataRowView;
            decimal donGia = 0;
            if (rowView != null)
            {
                donGia = Convert.ToDecimal(rowView["DonGia"]);
            }

            danhSachChiTietTam.Add(new ChiTietSuaChuaDTO
            {
                MaPhuTung = maPT,
                TenPhuTung = tenPT,
                SoLuong = soLuong,
                DonGia = donGia,
                TienCong = tienCong
            });

            dgvChiTietPhieu.DataSource = null;
            dgvChiTietPhieu.DataSource = danhSachChiTietTam;

            TinhTongTienTamTinh();
        }

        private void TinhTongTienTamTinh()
        {
            decimal tongTien = 0;
            foreach (var item in danhSachChiTietTam)
            {
             
                tongTien += (item.SoLuong * item.DonGia) + item.TienCong;
            }
            lblTongTienValue.Text = tongTien.ToString("N0") + " VNĐ";
        }

        private void BtnLapPhieuTransaction_Click(object sender, EventArgs e)
        {
            string bienSo = txtBienSoPhieu.Text.Trim();
            string noiDung = txtNoiDungSua.Text.Trim();

            if (string.IsNullOrEmpty(bienSo))
            {
                MessageBox.Show("Vui lòng nhập biển số xe để lập phiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (danhSachChiTietTam.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một phụ tùng/dịch vụ vào phiếu sửa chữa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tongTienChiPhi = 0;
            foreach (var item in danhSachChiTietTam)
            {
                tongTienChiPhi += (item.SoLuong * item.DonGia) + item.TienCong;
            }

            PhieuSuaChuaDTO phieu = new PhieuSuaChuaDTO
            {
                BienSo = bienSo,
                NoiDungSua = noiDung,
                TongTien = tongTienChiPhi,
                TrangThai = "Dang sua"
            };

            string error = "";
            bool kq = pscBUS.LapPhieuMoi(phieu, danhSachChiTietTam, out error);

            if (kq)
            {
                MessageBox.Show("Lập phiếu sửa chữa thành công và đã tự động trừ kho phụ tùng bằng Transaction!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                danhSachChiTietTam.Clear();
                dgvChiTietPhieu.DataSource = null;
                lblTongTienValue.Text = "0 VNĐ";

             
                dgvPhuTung.DataSource = ptBUS.LayDanhSach();
                dgvDanhSachPhieu.DataSource = pscBUS.LayDanhSachPhieu();
            }
            else
            {
                MessageBox.Show("Lập phiếu thất bại do Transaction bị hủy (Rollback)!\nChi tiết: " + error, "Cảnh báo Kho & Giao dịch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachPhieu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu sửa chữa cần thanh toán trên lưới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maPhieu = Convert.ToInt32(dgvDanhSachPhieu.CurrentRow.Cells["MaPhieu"].Value);

            if (pscBUS.ThanhToan(maPhieu))
            {
                MessageBox.Show("Đã thanh toán và chuyển trạng thái hóa đơn sang 'Da thanh toan' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDanhSachPhieu.DataSource = pscBUS.LayDanhSachPhieu();
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}