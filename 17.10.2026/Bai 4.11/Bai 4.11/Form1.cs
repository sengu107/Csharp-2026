
using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Bai_4._11
{
    public partial class Form1 : Form
    {
        // Danh sách đơn sửa chữa
        private readonly BindingList<RepairOrder> orders = new();
        private readonly BindingSource bindingSource = new();

        // Danh sách sau khi tìm kiếm và lọc
        private BindingList<RepairOrder> filteredOrders = new();

        private string imagePath = "";
        private bool isLoading = false;

        private TextBox txtTimKiem;
        private ComboBox cbLocTrangThai;

        private ToolStripStatusLabel lblSoDon;
        private ToolStripStatusLabel lblTongChiPhi;

        private readonly string[] trangThaiList =
        {
            "Mới tiếp nhận",
            "Đang sửa",
            "Chờ linh kiện",
            "Hoàn tất",
            "Đã hủy"
        };

        public Form1()
        {
            InitializeComponent();

            KhoiTaoDuLieu();
            KhoiTaoBang();
            KhoiTaoTimKiem();
            KhoiTaoMenu();
            KhoiTaoStatusStrip();

            // Gắn sự kiện
            btnThem.Click += btnThem_Click;
            button3.Click += button3_Click;

            dataGridView1.SelectionChanged +=
                dataGridView1_SelectionChanged;

            pbAnh.Click += label6_Click;

            // Tìm kiếm tức thời
            txtTimKiem.TextChanged += (s, e) => ApDungBoLoc();

            // Lọc theo trạng thái
            cbLocTrangThai.SelectedIndexChanged +=
                (s, e) => ApDungBoLoc();

            // Cấu hình OpenFileDialog
            openFileDialog1.Filter =
                "Ảnh thiết bị|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            openFileDialog1.Title = "Chọn ảnh thiết bị";

            // Thiết lập ban đầu
            cbloaithietbi.DropDownStyle =
                ComboBoxStyle.DropDownList;

            comboBox2.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cbloaithietbi.Items.AddRange(new object[]
            {
                "Điện thoại",
                "Laptop",
                "Máy tính bàn",
                "Máy tính bảng",
                "Máy in",
                "Thiết bị khác"
            });

            comboBox2.Items.AddRange(trangThaiList);

            comboBox2.SelectedIndex = 0;
            cbLocTrangThai.SelectedIndex = 0;

            // Cập nhật lại giao diện
            ApDungBoLoc();
        }

        // =========================
        // MODEL
        // =========================

        public class RepairOrder
        {
            public string MaDon { get; set; } = "";
            public string TenKhachHang { get; set; } = "";
            public string SoDienThoai { get; set; } = "";
            public string LoaiThietBi { get; set; } = "";
            public string MoTaLoi { get; set; } = "";
            public DateTime NgayTiepNhan { get; set; }
            public decimal ChiPhiDuKien { get; set; }
            public string TrangThai { get; set; } = "";
            public string AnhPath { get; set; } = "";
        }

        // =========================
        // KHỞI TẠO
        // =========================

        private void KhoiTaoDuLieu()
        {
            bindingSource.DataSource = filteredOrders;
        }

        private void KhoiTaoBang()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Columns.Clear();

            ThemCot("MaDon", "Mã đơn", 90);
            ThemCot("TenKhachHang", "Khách hàng", 150);
            ThemCot("SoDienThoai", "Số điện thoại", 110);
            ThemCot("LoaiThietBi", "Thiết bị", 110);
            ThemCot("MoTaLoi", "Mô tả lỗi", 160);

            var cotNgay = new DataGridViewTextBoxColumn
            {
                Name = "NgayTiepNhan",
                HeaderText = "Ngày tiếp nhận",
                DataPropertyName = "NgayTiepNhan",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy"
                }
            };

            dataGridView1.Columns.Add(cotNgay);

            var cotChiPhi = new DataGridViewTextBoxColumn
            {
                Name = "ChiPhiDuKien",
                HeaderText = "Chi phí (VNĐ)",
                DataPropertyName = "ChiPhiDuKien",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            };

            dataGridView1.Columns.Add(cotChiPhi);

            ThemCot("TrangThai", "Trạng thái", 120);

            dataGridView1.DataSource = bindingSource;
        }

        private void ThemCot(
            string property,
            string header,
            int width)
        {
            dataGridView1.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = property,
                    HeaderText = header,
                    DataPropertyName = property,
                    Width = width
                });
        }

        private void KhoiTaoTimKiem()
        {
            // Tạo khu vực tìm kiếm phía trên DataGridView
            Panel panel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 42
            };

            Label lblTim = new Label
            {
                Text = "Tìm kiếm:",
                AutoSize = true,
                Location = new Point(8, 12)
            };

            txtTimKiem = new TextBox
            {
                Location = new Point(85, 7),
                Width = 220,
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };

            Label lblLoc = new Label
            {
                Text = "Trạng thái:",
                AutoSize = true,
                Location = new Point(320, 12)
            };

            cbLocTrangThai = new ComboBox
            {
                Location = new Point(395, 7),
                Width = 170,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };

            cbLocTrangThai.Items.Add("Tất cả");
            cbLocTrangThai.Items.AddRange(trangThaiList);

            panel.Controls.Add(lblTim);
            panel.Controls.Add(txtTimKiem);
            panel.Controls.Add(lblLoc);
            panel.Controls.Add(cbLocTrangThai);

            // Đưa DataGridView vào Panel để bố cục co giãn
            tableLayoutPanel1.Controls.Remove(dataGridView1);

            Panel rightPanel = new Panel
            {
                Dock = DockStyle.Fill
            };

            dataGridView1.Dock = DockStyle.Fill;

            rightPanel.Controls.Add(dataGridView1);
            rightPanel.Controls.Add(panel);

            tableLayoutPanel1.Controls.Add(rightPanel, 1, 0);
        }

        private void KhoiTaoMenu()
        {
            ToolStripMenuItem menuFile =
                new ToolStripMenuItem("Tệp");

            ToolStripMenuItem menuXuat =
                new ToolStripMenuItem("Xuất CSV");

            ToolStripMenuItem menuThoat =
                new ToolStripMenuItem("Thoát");

            menuXuat.Click += (s, e) => XuatCSV();

            menuThoat.Click += (s, e) =>
            {
                var result = MessageBox.Show(
                    "Bạn có muốn thoát ứng dụng?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    Close();
            };

            menuFile.DropDownItems.Add(menuXuat);
            menuFile.DropDownItems.Add(new ToolStripSeparator());
            menuFile.DropDownItems.Add(menuThoat);

            mstrip1.Items.Add(menuFile);
        }

        private void KhoiTaoStatusStrip()
        {
            lblSoDon = new ToolStripStatusLabel();
            lblTongChiPhi = new ToolStripStatusLabel();

            statusStrip1.Items.Clear();
            statusStrip1.Items.Add(lblSoDon);
            statusStrip1.Items.Add(new ToolStripStatusLabel
            {
                Spring = true
            });
            statusStrip1.Items.Add(lblTongChiPhi);
        }

        // =========================
        // KIỂM TRA DỮ LIỆU
        // =========================

        private bool KiemTraDuLieu(RepairOrder dangSua = null)
        {
            errorProvider1.Clear();
            bool hopLe = true;

            if (string.IsNullOrWhiteSpace(txtmadon.Text))
            {
                errorProvider1.SetError(
                    txtmadon, "Mã đơn không được để trống.");

                hopLe = false;
            }
            else if (orders.Any(o =>
                o.MaDon.Equals(
                    txtmadon.Text.Trim(),
                    StringComparison.OrdinalIgnoreCase)
                && !ReferenceEquals(o, dangSua)))
            {
                errorProvider1.SetError(
                    txtmadon, "Mã đơn đã tồn tại.");

                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txttenkhachhang.Text))
            {
                errorProvider1.SetError(
                    txttenkhachhang,
                    "Tên khách hàng không được để trống.");

                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtsodienthoai.Text))
            {
                errorProvider1.SetError(
                    txtsodienthoai,
                    "Số điện thoại không được để trống.");

                hopLe = false;
            }

            if (cbloaithietbi.SelectedIndex < 0)
            {
                errorProvider1.SetError(
                    cbloaithietbi, "Vui lòng chọn loại thiết bị.");

                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtmotaloi.Text))
            {
                errorProvider1.SetError(
                    txtmotaloi, "Mô tả lỗi không được để trống.");

                hopLe = false;
            }

            if (!decimal.TryParse(
                    textBox5.Text.Trim(),
                    NumberStyles.Number,
                    CultureInfo.CurrentCulture,
                    out decimal chiPhi)
                || chiPhi < 0)
            {
                // Thử đọc số theo định dạng không phụ thuộc vùng
                if (!decimal.TryParse(
                        textBox5.Text.Trim(),
                        NumberStyles.Number,
                        CultureInfo.InvariantCulture,
                        out chiPhi)
                    || chiPhi < 0)
                {
                    errorProvider1.SetError(
                        textBox5,
                        "Chi phí phải là số không âm.");

                    hopLe = false;
                }
            }

            if (comboBox2.SelectedIndex < 0)
            {
                errorProvider1.SetError(
                    comboBox2, "Vui lòng chọn trạng thái.");

                hopLe = false;
            }

            return hopLe;
        }

        private bool DocChiPhi(out decimal chiPhi)
        {
            return decimal.TryParse(
                       textBox5.Text.Trim(),
                       NumberStyles.Number,
                       CultureInfo.CurrentCulture,
                       out chiPhi)
                   || decimal.TryParse(
                       textBox5.Text.Trim(),
                       NumberStyles.Number,
                       CultureInfo.InvariantCulture,
                       out chiPhi);
        }

        // =========================
        // ĐỌC / HIỂN THỊ FORM
        // =========================

        private RepairOrder DocThongTin()
        {
            DocChiPhi(out decimal chiPhi);

            return new RepairOrder
            {
                MaDon = txtmadon.Text.Trim(),
                TenKhachHang = txttenkhachhang.Text.Trim(),
                SoDienThoai = txtsodienthoai.Text.Trim(),
                LoaiThietBi = cbloaithietbi.Text,
                MoTaLoi = txtmotaloi.Text.Trim(),
                NgayTiepNhan = dateTimePicker1.Value.Date,
                ChiPhiDuKien = chiPhi,
                TrangThai = comboBox2.Text,
                AnhPath = imagePath
            };
        }

        private void NapThongTin(RepairOrder order)
        {
            if (order == null) return;

            isLoading = true;

            txtmadon.Text = order.MaDon;
            txttenkhachhang.Text = order.TenKhachHang;
            txtsodienthoai.Text = order.SoDienThoai;
            cbloaithietbi.SelectedItem = order.LoaiThietBi;
            txtmotaloi.Text = order.MoTaLoi;

            dateTimePicker1.Value = order.NgayTiepNhan;

            textBox5.Text = order.ChiPhiDuKien.ToString(
                "0.##", CultureInfo.CurrentCulture);

            comboBox2.SelectedItem = order.TrangThai;

            imagePath = order.AnhPath ?? "";
            HienThiAnh(imagePath);

            errorProvider1.Clear();

            isLoading = false;
        }

        private void XoaForm()
        {
            isLoading = true;

            txtmadon.Clear();
            txttenkhachhang.Clear();
            txtsodienthoai.Clear();
            txtmotaloi.Clear();
            textBox5.Clear();

            cbloaithietbi.SelectedIndex = -1;
            comboBox2.SelectedIndex = 0;

            dateTimePicker1.Value = DateTime.Today;

            imagePath = "";
            HienThiAnh("");

            errorProvider1.Clear();

            dataGridView1.ClearSelection();

            isLoading = false;
        }

        // =========================
        // THÊM
        // =========================

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
            {
                MessageBox.Show(
                    "Vui lòng kiểm tra lại thông tin.",
                    "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            RepairOrder order = DocThongTin();

            orders.Add(order);

            ApDungBoLoc();
            XoaForm();

            MessageBox.Show(
                "Thêm đơn sửa chữa thành công.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =========================
        // SỬA
        // =========================

        private void button2_Click(object sender, EventArgs e)
        {
            RepairOrder dangSua =
                dataGridView1.CurrentRow?.DataBoundItem as RepairOrder;

            if (dangSua == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn đơn cần sửa trong bảng.");

                return;
            }

            if (!KiemTraDuLieu(dangSua))
            {
                MessageBox.Show(
                    "Vui lòng kiểm tra lại thông tin.");

                return;
            }

            var result = MessageBox.Show(
                "Bạn có chắc muốn cập nhật đơn này?",
                "Xác nhận sửa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            RepairOrder thongTinMoi = DocThongTin();

            dangSua.MaDon = thongTinMoi.MaDon;
            dangSua.TenKhachHang = thongTinMoi.TenKhachHang;
            dangSua.SoDienThoai = thongTinMoi.SoDienThoai;
            dangSua.LoaiThietBi = thongTinMoi.LoaiThietBi;
            dangSua.MoTaLoi = thongTinMoi.MoTaLoi;
            dangSua.NgayTiepNhan = thongTinMoi.NgayTiepNhan;
            dangSua.ChiPhiDuKien = thongTinMoi.ChiPhiDuKien;
            dangSua.TrangThai = thongTinMoi.TrangThai;
            dangSua.AnhPath = thongTinMoi.AnhPath;

            ApDungBoLoc();

            MessageBox.Show("Cập nhật đơn thành công.");
        }

        // =========================
        // XÓA
        // =========================

        private void button3_Click(object sender, EventArgs e)
        {
            RepairOrder order =
                dataGridView1.CurrentRow?.DataBoundItem as RepairOrder;

            if (order == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn đơn cần xóa.");

                return;
            }

            var result = MessageBox.Show(
                $"Bạn có chắc muốn xóa đơn {order.MaDon}?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            orders.Remove(order);

            ApDungBoLoc();
            XoaForm();
        }

        // =========================
        // CHỌN DÒNG
        // =========================

        private void dataGridView1_SelectionChanged(
            object sender, EventArgs e)
        {
            if (isLoading) return;

            RepairOrder order =
                dataGridView1.CurrentRow?.DataBoundItem as RepairOrder;

            if (order != null)
                NapThongTin(order);
        }

        // Designer đã gắn sự kiện này.
        private void dataGridView1_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            // Việc nạp dữ liệu được xử lý trong SelectionChanged.
        }

        // =========================
        // TÌM KIẾM VÀ LỌC
        // =========================

        private void ApDungBoLoc()
        {
            if (txtTimKiem == null || cbLocTrangThai == null)
                return;

            string tuKhoa = txtTimKiem.Text.Trim();
            string trangThai = cbLocTrangThai.Text;

            var ketQua = orders.Where(o =>
                (string.IsNullOrWhiteSpace(tuKhoa)
                 || o.MaDon.Contains(
                     tuKhoa, StringComparison.OrdinalIgnoreCase)
                 || o.TenKhachHang.Contains(
                     tuKhoa, StringComparison.OrdinalIgnoreCase)
                 || o.SoDienThoai.Contains(
                     tuKhoa, StringComparison.OrdinalIgnoreCase))
                &&
                (trangThai == "Tất cả"
                 || string.IsNullOrEmpty(trangThai)
                 || o.TrangThai == trangThai)
            ).ToList();

            filteredOrders = new BindingList<RepairOrder>(ketQua);

            bindingSource.DataSource = filteredOrders;
            bindingSource.ResetBindings(false);

            CapNhatStatusStrip();
        }

        private void CapNhatStatusStrip()
        {
            lblSoDon.Text =
                $"Số đơn đang hiển thị: {filteredOrders.Count}";

            decimal tongChiPhi = filteredOrders
                .Where(o => o.TrangThai != "Hoàn tất")
                .Sum(o => o.ChiPhiDuKien);

            lblTongChiPhi.Text =
                $"Tổng chi phí chưa hoàn tất: {tongChiPhi:N0} VNĐ";
        }

        // =========================
        // CHỌN ẢNH
        // =========================

        private void label6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            imagePath = openFileDialog1.FileName;
            HienThiAnh(imagePath);
        }

        private void HienThiAnh(string path)
        {
            Image anhCu = pbAnh.Image;
            pbAnh.Image = null;
            anhCu?.Dispose();

            if (string.IsNullOrWhiteSpace(path)
                || !File.Exists(path))
                return;

            try
            {
                // Không giữ khóa file ảnh sau khi đọc
                using (var stream = new FileStream(
                    path, FileMode.Open, FileAccess.Read))
                using (var temp = Image.FromStream(stream))
                {
                    pbAnh.Image = new Bitmap(temp);
                }

                pbAnh.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                imagePath = "";

                MessageBox.Show(
                    "Không thể mở ảnh: " + ex.Message,
                    "Lỗi ảnh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // XUẤT CSV
        // =========================

        private void XuatCSV()
        {
            using SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "CSV (*.csv)|*.csv",
                Title = "Xuất danh sách đơn sửa chữa",
                FileName = "RepairOrders.csv"
            };

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using StreamWriter writer = new StreamWriter(
                    saveDialog.FileName,
                    false,
                    new UTF8Encoding(true));

                writer.WriteLine(
                    "Mã đơn,Tên khách hàng,Số điện thoại,Loại thiết bị," +
                    "Mô tả lỗi,Ngày tiếp nhận,Chi phí dự kiến,Trạng thái");

                foreach (RepairOrder o in filteredOrders)
                {
                    string[] fields =
                    {
                        o.MaDon,
                        o.TenKhachHang,
                        o.SoDienThoai,
                        o.LoaiThietBi,
                        o.MoTaLoi,
                        o.NgayTiepNhan.ToString("dd/MM/yyyy"),
                        o.ChiPhiDuKien.ToString("N0"),
                        o.TrangThai
                    };

                    writer.WriteLine(string.Join(",",
                        fields.Select(CSVField)));
                }

                MessageBox.Show(
                    "Xuất CSV thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xuất CSV: " + ex.Message);
            }
        }

        private string CSVField(string value)
        {
            value ??= "";

            return "\"" + value.Replace("\"", "\"\"") + "\"";
        }
    }
}
