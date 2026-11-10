using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using KaraokeApp.BUS;

namespace KaraokeApp
{
    public partial class frmKaraoke : Form
    {
        private KaraokeBUS bus = new KaraokeBUS();
        private int selectedMaPhong = 0;
        private decimal currentGiaTheoGio = 0;

        public frmKaraoke()
        {
            InitializeComponent();
            LoadSoDoPhong();
            LoadComboBoxDichVu();
        }

        private void LoadSoDoPhong()
        {
            flpRooms.Controls.Clear();
            DataTable dtPhong = bus.LayDanhSachPhong();

            foreach (DataRow row in dtPhong.Rows)
            {
                Button btn = new Button
                {
                    Width = 140,
                    Height = 120,
                    Text = $"{row["TenPhong"]}\n({row["LoaiPhong"]})\nTrạng thái: {row["TrangThai"]}",
                    Tag = row
                };

                string trangThai = row["TrangThai"].ToString();
                if (trangThai == "Trống" || trangThai == "Trong")
                {
                    btn.BackColor = Color.LightGreen;
                }
                else
                {
                    btn.BackColor = Color.LightCoral;
                }

                btn.Click += BtnPhong_Click;
                flpRooms.Controls.Add(btn);
            }
        }

        private void LoadComboBoxDichVu()
        {
            cbDichVu.DataSource = bus.LayDanhSachDichVu();
            cbDichVu.DisplayMember = "TenDV";
            cbDichVu.ValueMember = "MaDV";
        }

        private void BtnPhong_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DataRow row = btn.Tag as DataRow;

            selectedMaPhong = Convert.ToInt32(row["MaPhong"]);
            currentGiaTheoGio = Convert.ToDecimal(row["GiaTheoGio"]);
            lblTenPhongChon.Text = $"Đang chọn: {row["TenPhong"]} - Giá: {currentGiaTheoGio:N0} VNĐ/h";

            int maHD = bus.LayMaHDCuaPhong(selectedMaPhong);
            if (maHD > 0)
            {
                dgvChiTiet.DataSource = bus.LayChiTietDichVu(maHD);
            }
            else
            {
                dgvChiTiet.DataSource = null;
            }
        }

        private void btnMoPhong_Click(object sender, EventArgs e)
        {
            if (selectedMaPhong == 0)
            {
                MessageBox.Show("Vui lòng chọn một phòng trống trên sơ đồ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string error = "";
            if (bus.MoPhong(selectedMaPhong, out error))
            {
                MessageBox.Show("Mở phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSoDoPhong();
            }
            else
            {
                MessageBox.Show("Mở phòng thất bại: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            if (selectedMaPhong == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maHD = bus.LayMaHDCuaPhong(selectedMaPhong);
            if (maHD == 0)
            {
                MessageBox.Show("Phòng này hiện đang trống, chưa mở phòng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maDV = Convert.ToInt32(cbDichVu.SelectedValue);
            int soLuong = (int)nudSoLuong.Value;
            DataRowView dvRow = cbDichVu.SelectedItem as DataRowView;
            decimal donGia = Convert.ToDecimal(dvRow["DonGia"]);

            string error = "";
            if (bus.ThemDichVu(maHD, maDV, soLuong, donGia, out error))
            {
                dgvChiTiet.DataSource = bus.LayChiTietDichVu(maHD);
            }
            else
            {
                MessageBox.Show("Thêm dịch vụ thất bại: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (selectedMaPhong == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần thanh toán!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maHD = bus.LayMaHDCuaPhong(selectedMaPhong);
            if (maHD == 0)
            {
                MessageBox.Show("Phòng này đang trống, không có hóa đơn để thanh toán!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin Giờ vào thông qua tầng BUS/DAL thay vì mở kết nối trực tiếp ở GUI
            DateTime gioVao = DateTime.MinValue;
            string error = "";
            if (!bus.LayGioVaoCuaHoaDon(maHD, out gioVao, out error))
            {
                MessageBox.Show("Lỗi khi lấy giờ vào: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime gioRa = DateTime.Now;
            TimeSpan span = gioRa - gioVao;
            double soGio = span.TotalHours;
            if (soGio < 0.1) soGio = 0.1;

            decimal tienPhong = (decimal)soGio * currentGiaTheoGio;

            decimal tienDV = 0;
            Dictionary<int, int> dvList = new Dictionary<int, int>();
            DataTable dtChiTiet = bus.LayChiTietDichVu(maHD);
            foreach (DataRow r in dtChiTiet.Rows)
            {
                int maDV = Convert.ToInt32(r["MaDV"]);
                int sl = Convert.ToInt32(r["SoLuong"]);
                decimal thanhTien = Convert.ToDecimal(r["ThanhTien"]);
                tienDV += thanhTien;
                dvList.Add(maDV, sl);
            }

            decimal tongTien = tienPhong + tienDV;

            DialogResult dr = MessageBox.Show($"--- HÓA ĐƠN THANH TOÁN ---\n" +
                                              $"Thời gian hát: {soGio:N2} giờ\n" +
                                              $"Tiền phòng: {tienPhong:N0} VNĐ\n" +
                                              $"Tiền dịch vụ: {tienDV:N0} VNĐ\n" +
                                              $"TỔNG CỘNG: {tongTien:N0} VNĐ\n\nBạn có muốn xác nhận thanh toán?",
                                              "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string loi = "";
                bool success = bus.ThanhToan(maHD, selectedMaPhong, tienPhong, tienDV, dvList, out loi);
                if (success)
                {
                    MessageBox.Show("Thanh toán thành công và đã cập nhật kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSoDoPhong();
                    dgvChiTiet.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Thanh toán thất bại do lỗi Transaction: " + loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}