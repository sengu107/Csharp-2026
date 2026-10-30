using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using HotelManagement.BUS;
using HotelManagement.DTO;

namespace HotelManagement.GUI
{
    public partial class frmMain : Form
    {
        private static readonly CultureInfo VN = new CultureInfo("vi-VN");
        private const string TatCa = "-- Tất cả --";

        private readonly PhongBUS _phongBus = new PhongBUS();
        private readonly KhachHangBUS _khBus = new KhachHangBUS();
        private readonly DichVuBUS _dvBus = new DichVuBUS();
        private readonly LuuTruBUS _luuTruBus = new LuuTruBUS();

        private DataTable _dtPhong;
        private DataView _viewPhong;
        private bool _loading;
        private bool _khachCu;

        public frmMain()
        {
            InitializeComponent();

            // Đăng ký sự kiện trực tiếp không dùng Guard bọc ngoài tổng quát
            this.Load += (s, e) => SafeExecute(RefreshAll);

            this.cboLocLoai.SelectedIndexChanged += (s, e) => ApplyFilter();
            this.cboLocTrangThai.SelectedIndexChanged += (s, e) => ApplyFilter();
            this.btnTaiLai.Click += (s, e) => SafeExecute(RefreshAll);
            this.btnDonXong.Click += (s, e) => SafeExecute(DonXong);
            this.dgvPhong.CellFormatting += DgvPhong_CellFormatting;

            this.txtCCCD.TextChanged += TxtCCCD_TextChanged;
            this.btnTraCuu.Click += (s, e) => SafeExecute(TraCuuKhach);
            this.btnCheckIn.Click += (s, e) => SafeExecute(DoCheckIn);

            this.cboPhongDV.SelectedIndexChanged += (s, e) => SafeExecute(LoadChiTietDichVu);
            this.btnThemDV.Click += (s, e) => SafeExecute(ThemDichVu);

            this.btnXemHoaDon.Click += (s, e) => SafeExecute(XemHoaDon);
            this.btnThanhToan.Click += (s, e) => SafeExecute(ThanhToan);
        }

        private void SafeExecute(Action action)
        {
            try
            {
                action();
            }
            catch (BusinessException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi hệ thống (kiểm tra CSDL và chuỗi kết nối trong App.config):\n\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string Money(decimal v)
        {
            return v.ToString("N0", VN) + " đ";
        }

        private static int SelectedMaPhieu(ComboBox cbo)
        {
            var drv = cbo.SelectedItem as DataRowView;
            return drv == null ? 0 : Convert.ToInt32(drv["MaPhieu"]);
        }

        private void RefreshAll()
        {
            LoadPhong();
            LoadPhongTrong();
            LoadPhieuDangO();
            LoadDichVu();
        }

        private void LoadPhong()
        {
            _loading = true;
            try
            {
                string selLoai = cboLocLoai.SelectedItem?.ToString() ?? TatCa;
                string selTT = cboLocTrangThai.SelectedItem?.ToString() ?? TatCa;

                _dtPhong = _phongBus.GetAll();
                _viewPhong = new DataView(_dtPhong);

                cboLocLoai.Items.Clear();
                cboLocLoai.Items.Add(TatCa);
                foreach (DataRow r in _viewPhong.ToTable(true, "LoaiPhong").Rows)
                    cboLocLoai.Items.Add(Convert.ToString(r["LoaiPhong"]) ?? string.Empty);

                cboLocLoai.SelectedItem = cboLocLoai.Items.Contains(selLoai) ? selLoai : TatCa;
                cboLocTrangThai.SelectedItem = cboLocTrangThai.Items.Contains(selTT) ? selTT : TatCa;

                dgvPhong.DataSource = _viewPhong;
                StyleGridPhong();
            }
            finally
            {
                _loading = false;
            }
            ApplyFilter();
        }

        private void StyleGridPhong()
        {
            SetHeader(dgvPhong, "SoPhong", "Số phòng");
            SetHeader(dgvPhong, "LoaiPhong", "Loại phòng");
            SetHeader(dgvPhong, "GiaTheoGio", "Giá theo giờ");
            SetHeader(dgvPhong, "TrangThai", "Trạng thái");
            if (dgvPhong.Columns.Contains("GiaTheoGio"))
            {
                dgvPhong.Columns["GiaTheoGio"].DefaultCellStyle.Format = "N0";
                dgvPhong.Columns["GiaTheoGio"].DefaultCellStyle.FormatProvider = VN;
            }
        }

        private static void SetHeader(DataGridView grid, string column, string header)
        {
            if (grid.Columns.Contains(column)) grid.Columns[column].HeaderText = header;
        }

        private static string Esc(string s)
        {
            return s.Replace("'", "''");
        }

        private void ApplyFilter()
        {
            if (_loading || _viewPhong == null) return;

            var conds = new List<string>();
            string loai = cboLocLoai.SelectedItem as string;
            string tt = cboLocTrangThai.SelectedItem as string;
            if (!string.IsNullOrEmpty(loai) && loai != TatCa)
                conds.Add("LoaiPhong = '" + Esc(loai) + "'");
            if (!string.IsNullOrEmpty(tt) && tt != TatCa)
                conds.Add("TrangThai = '" + Esc(tt) + "'");

            _viewPhong.RowFilter = string.Join(" AND ", conds.ToArray());
            lblDemPhong.Text = "Hiển thị " + _viewPhong.Count + " / " + _dtPhong.Rows.Count + " phòng";
        }

        private void DgvPhong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;
            if (dgvPhong.Columns[e.ColumnIndex].DataPropertyName != "TrangThai") return;

            string v = Convert.ToString(e.Value);
            if (v == TrangThaiPhong.Trong) e.CellStyle.ForeColor = Color.ForestGreen;
            else if (v == TrangThaiPhong.DangO) e.CellStyle.ForeColor = Color.Firebrick;
            else e.CellStyle.ForeColor = Color.DarkOrange;
        }

        private void DonXong()
        {
            var drv = dgvPhong.CurrentRow == null ? null : dgvPhong.CurrentRow.DataBoundItem as DataRowView;
            if (drv == null)
                throw new BusinessException("Vui lòng chọn một phòng trong danh sách.");

            string soPhong = Convert.ToString(drv["SoPhong"]);
            _phongBus.HoanTatDonDep(soPhong);
            RefreshAll();
        }

        private void LoadPhongTrong()
        {
            cboPhongTrong.DataSource = null;
            cboPhongTrong.DisplayMember = "HienThi";
            cboPhongTrong.ValueMember = "SoPhong";
            cboPhongTrong.DataSource = _phongBus.GetPhongTrong();
        }

        private void SetKhachReadOnly(bool readOnly)
        {
            txtHoTen.ReadOnly = readOnly;
            txtSDT.ReadOnly = readOnly;
        }

        private void TxtCCCD_TextChanged(object sender, EventArgs e)
        {
            if (_khachCu)
            {
                txtHoTen.Clear();
                txtSDT.Clear();
                _khachCu = false;
            }
            SetKhachReadOnly(false);
            lblKhach.ForeColor = Color.DimGray;
            lblKhach.Text = "Nhập số CCCD rồi bấm Tra cứu.";
        }

        private void TraCuuKhach()
        {
            KhachHangDTO kh = _khBus.TimTheoCCCD(txtCCCD.Text);
            if (kh != null)
            {
                txtHoTen.Text = kh.HoTen;
                txtSDT.Text = kh.SoDienThoai ?? "";
                SetKhachReadOnly(true);
                _khachCu = true;
                lblKhach.ForeColor = Color.ForestGreen;
                lblKhach.Text = "Khách đã có trong hệ thống (mã KH " + kh.MaKH + ").";
            }
            else
            {
                txtHoTen.Clear();
                txtSDT.Clear();
                SetKhachReadOnly(false);
                _khachCu = false;
                lblKhach.ForeColor = Color.DarkOrange;
                lblKhach.Text = "Khách mới - vui lòng nhập họ tên và số điện thoại.";
                txtHoTen.Focus();
            }
        }

        private void DoCheckIn()
        {
            var phong = cboPhongTrong.SelectedItem as PhongDTO;
            if (phong == null)
                throw new BusinessException("Hiện không có phòng trống để nhận.");

            int maPhieu = _luuTruBus.CheckIn(txtCCCD.Text, txtHoTen.Text, txtSDT.Text, phong.SoPhong);

            MessageBox.Show(
                "Nhận phòng thành công!\nMã phiếu: " + maPhieu + "\nPhòng: " + phong.SoPhong,
                "Check-in", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _khachCu = false;
            txtCCCD.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            SetKhachReadOnly(false);
            RefreshAll();
        }

        private void LoadDichVu()
        {
            cboDichVu.DataSource = null;
            cboDichVu.DisplayMember = "HienThi";
            cboDichVu.ValueMember = "MaDV";
            cboDichVu.DataSource = _dvBus.GetAll();
        }

        private static void BindPhieu(ComboBox cbo, DataTable dt)
        {
            cbo.DataSource = null;
            cbo.DisplayMember = "HienThi";
            cbo.ValueMember = "MaPhieu";
            cbo.DataSource = dt;
            if (dt.Rows.Count == 0) cbo.SelectedIndex = -1;
        }

        private void LoadPhieuDangO()
        {
            DataTable dt = _luuTruBus.GetDanhSachDangO();

            BindPhieu(cboPhongDV, dt.Copy());
            BindPhieu(cboPhongCO, dt.Copy());
            LoadChiTietDichVu();
        }

        private void LoadChiTietDichVu()
        {
            int maPhieu = SelectedMaPhieu(cboPhongDV);
            if (maPhieu == 0)
            {
                dgvDichVu.DataSource = null;
                lblTongDV.Text = "Tổng tiền dịch vụ: 0 đ";
                return;
            }

            dgvDichVu.DataSource = _luuTruBus.GetDichVuDaDung(maPhieu);
            if (dgvDichVu.Columns.Contains("MaSD")) dgvDichVu.Columns["MaSD"].Visible = false;
            SetHeader(dgvDichVu, "TenDV", "Dịch vụ");
            SetHeader(dgvDichVu, "DonGia", "Đơn giá");
            SetHeader(dgvDichVu, "SoLuong", "SL");
            SetHeader(dgvDichVu, "ThanhTien", "Thành tiền");
            SetHeader(dgvDichVu, "ThoiGian", "Thời gian gọi");
            foreach (string col in new[] { "DonGia", "ThanhTien" })
            {
                if (!dgvDichVu.Columns.Contains(col)) continue;
                dgvDichVu.Columns[col].DefaultCellStyle.Format = "N0";
                dgvDichVu.Columns[col].DefaultCellStyle.FormatProvider = VN;
            }
            if (dgvDichVu.Columns.Contains("ThoiGian"))
                dgvDichVu.Columns["ThoiGian"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

            lblTongDV.Text = "Tổng tiền dịch vụ: " + Money(_luuTruBus.GetTongTienDichVu(maPhieu));
        }

        private void ThemDichVu()
        {
            int maPhieu = SelectedMaPhieu(cboPhongDV);
            if (maPhieu == 0)
                throw new BusinessException("Chưa có phòng nào đang ở để gọi dịch vụ.");

            var dv = cboDichVu.SelectedItem as DichVuDTO;
            if (dv == null)
                throw new BusinessException("Vui lòng chọn dịch vụ.");

            _luuTruBus.GoiDichVu(new SuDungDichVuDTO
            {
                MaPhieu = maPhieu,
                MaDV = dv.MaDV,
                SoLuong = (int)nudSoLuong.Value
            });

            nudSoLuong.Value = 1;
            LoadChiTietDichVu();
        }

        private void XemHoaDon()
        {
            int maPhieu = SelectedMaPhieu(cboPhongCO);
            if (maPhieu == 0)
                throw new BusinessException("Chưa có phòng nào đang ở để tính tiền.");

            HoaDonDTO hd = _luuTruBus.TinhHoaDonTamThoi(maPhieu);
            txtHoaDon.Text = BuildInvoiceText(hd, _luuTruBus.GetDichVuDaDung(maPhieu), true);
            btnThanhToan.Enabled = true;
        }

        private void ThanhToan()
        {
            int maPhieu = SelectedMaPhieu(cboPhongCO);
            if (maPhieu == 0)
                throw new BusinessException("Chưa chọn phòng cần thanh toán.");

            var drvSelected = cboPhongCO.SelectedItem as DataRowView;
            string ten = drvSelected != null ? Convert.ToString(drvSelected["HienThi"]) : "Phòng chọn";

            DialogResult kq = MessageBox.Show(
                "Xác nhận thanh toán và trả phòng:\n" + ten + "\n\nSố tiền sẽ được tính lại tại thời điểm xác nhận.",
                "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq != DialogResult.Yes) return;

            DataTable dtDichVu = _luuTruBus.GetDichVuDaDung(maPhieu);

            HoaDonDTO hd = _luuTruBus.CheckOut(maPhieu);
            string text = BuildInvoiceText(hd, dtDichVu, false);

            RefreshAll();

            txtHoaDon.Text = text;
            btnThanhToan.Enabled = false;

            MessageBox.Show(
                "Thanh toán thành công!\nTổng tiền: " + Money(hd.TongTien) + "\nPhòng " + hd.SoPhong + " chuyển sang trạng thái dọn dẹp.",
                "Check-out", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static string BuildInvoiceText(HoaDonDTO hd, DataTable dv, bool tamTinh)
        {
            var sb = new StringBuilder();
            sb.AppendLine(tamTinh ? "=========== HÓA ĐƠN TẠM TÍNH ===========" : "=========== HÓA ĐƠN THANH TOÁN ===========");
            sb.AppendLine("Mã phiếu    : " + hd.MaPhieu);
            sb.AppendLine("Phòng       : " + hd.SoPhong + " (" + hd.LoaiPhong + ")");
            sb.AppendLine("Khách hàng  : " + hd.HoTen + " - CCCD " + hd.CCCD);
            sb.AppendLine("Nhận phòng  : " + hd.NgayNhanPhong.ToString("dd/MM/yyyy HH:mm"));
            sb.AppendLine((tamTinh ? "Tính đến    : " : "Trả phòng   : ") + hd.NgayTraPhong.ToString("dd/MM/yyyy HH:mm"));
            sb.AppendLine();
            sb.AppendLine("--- Tiền phòng (làm tròn lên theo giờ) ---");
            sb.AppendLine(hd.SoGio + " giờ x " + Money(hd.GiaTheoGio) + " = " + Money(hd.TienPhong));
            sb.AppendLine();
            sb.AppendLine("--- Dịch vụ đã dùng ---");
            if (dv.Rows.Count == 0)
            {
                sb.AppendLine("(không sử dụng dịch vụ)");
            }
            else
            {
                foreach (DataRow r in dv.Rows)
                {
                    sb.AppendLine(string.Format("{0} x{1} ({2}) = {3}",
                        r["TenDV"], r["SoLuong"],
                        Money(Convert.ToDecimal(r["DonGia"])),
                        Money(Convert.ToDecimal(r["ThanhTien"]))));
                }
            }
            sb.AppendLine("Tiền dịch vụ: " + Money(hd.TienDichVu));
            sb.AppendLine();
            sb.AppendLine("------------------------------------------");
            sb.AppendLine("TỔNG THANH TOÁN: " + Money(hd.TongTien));
            if (tamTinh)
            {
                sb.AppendLine();
                sb.AppendLine("(Tạm tính - số tiền chính thức được tính lại khi xác nhận thanh toán.)");
            }
            return sb.ToString();
        }

        private void lblLocLoai_Click(object sender, EventArgs e)
        {
        }
    }
}