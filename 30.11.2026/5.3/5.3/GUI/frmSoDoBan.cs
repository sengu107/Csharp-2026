using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CafePOS.BUS;
using CafePOS.DTO;

namespace CafePOS.GUI
{
    public partial class frmSoDoBan : Form
    {
        private readonly BanAnBUS banAnBUS = new BanAnBUS();
        private readonly DanhMucBUS danhMucBUS = new DanhMucBUS();
        private readonly MonAnBUS monAnBUS = new MonAnBUS();
        private readonly HoaDonBUS hoaDonBUS = new HoaDonBUS();

        private int? maBanDangChon = null;
        private Button btnDangChon = null;

        private System.ComponentModel.IContainer components = null;

        private FlowLayoutPanel flpBanAn;
        private DataGridView dgvChiTiet;
        private ComboBox cboDanhMuc;
        private ComboBox cboMon;
        private NumericUpDown numSoLuong;
        private Button btnThemMon;
        private Button btnThanhToan;
        private Button btnQuanLyThucDon;
        private Label lblBanDangChon;
        private Label lblDanhMuc;
        private Label lblMon;
        private Label lblSoLuong;
        private Label lblTongTien;

        public frmSoDoBan()
        {
            InitializeComponent();
            this.Load += frmSoDoBan_Load;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            flpBanAn = new FlowLayoutPanel();
            btnQuanLyThucDon = new Button();
            lblBanDangChon = new Label();
            dgvChiTiet = new DataGridView();
            lblDanhMuc = new Label();
            cboDanhMuc = new ComboBox();
            lblMon = new Label();
            cboMon = new ComboBox();
            lblSoLuong = new Label();
            numSoLuong = new NumericUpDown();
            btnThemMon = new Button();
            lblTongTien = new Label();
            btnThanhToan = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            SuspendLayout();
            // 
            // flpBanAn
            // 
            flpBanAn.AutoScroll = true;
            flpBanAn.BorderStyle = BorderStyle.FixedSingle;
            flpBanAn.Location = new Point(11, 13);
            flpBanAn.Margin = new Padding(3, 4, 3, 4);
            flpBanAn.Name = "flpBanAn";
            flpBanAn.Size = new Size(434, 719);
            flpBanAn.TabIndex = 0;
            // 
            // btnQuanLyThucDon
            // 
            btnQuanLyThucDon.Location = new Point(11, 747);
            btnQuanLyThucDon.Margin = new Padding(3, 4, 3, 4);
            btnQuanLyThucDon.Name = "btnQuanLyThucDon";
            btnQuanLyThucDon.Size = new Size(206, 47);
            btnQuanLyThucDon.TabIndex = 1;
            btnQuanLyThucDon.Text = "Quản Lý Thực Đơn";
            btnQuanLyThucDon.UseVisualStyleBackColor = true;
            btnQuanLyThucDon.Click += btnQuanLyThucDon_Click;
            // 
            // lblBanDangChon
            // 
            lblBanDangChon.AutoSize = true;
            lblBanDangChon.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblBanDangChon.Location = new Point(469, 20);
            lblBanDangChon.Name = "lblBanDangChon";
            lblBanDangChon.Size = new Size(149, 25);
            lblBanDangChon.TabIndex = 2;
            lblBanDangChon.Text = "Chưa Chọn Bàn";
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.BackgroundColor = SystemColors.ButtonFace;
            dgvChiTiet.ColumnHeadersHeight = 29;
            dgvChiTiet.Location = new Point(469, 60);
            dgvChiTiet.Margin = new Padding(3, 4, 3, 4);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.Size = new Size(743, 400);
            dgvChiTiet.TabIndex = 3;
            // 
            // lblDanhMuc
            // 
            lblDanhMuc.AutoSize = true;
            lblDanhMuc.Location = new Point(586, 498);
            lblDanhMuc.Name = "lblDanhMuc";
            lblDanhMuc.Size = new Size(79, 20);
            lblDanhMuc.TabIndex = 4;
            lblDanhMuc.Text = "Danh Mục:";
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDanhMuc.Location = new Point(683, 494);
            cboDanhMuc.Margin = new Padding(3, 4, 3, 4);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(228, 28);
            cboDanhMuc.TabIndex = 5;
            cboDanhMuc.SelectedIndexChanged += cboDanhMuc_SelectedIndexChanged;
            // 
            // lblMon
            // 
            lblMon.AutoSize = true;
            lblMon.Location = new Point(586, 545);
            lblMon.Name = "lblMon";
            lblMon.Size = new Size(42, 20);
            lblMon.TabIndex = 6;
            lblMon.Text = "Món:";
            // 
            // cboMon
            // 
            cboMon.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMon.Location = new Point(683, 541);
            cboMon.Margin = new Padding(3, 4, 3, 4);
            cboMon.Name = "cboMon";
            cboMon.Size = new Size(228, 28);
            cboMon.TabIndex = 7;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(586, 591);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(75, 20);
            lblSoLuong.TabIndex = 8;
            lblSoLuong.Text = "Số Lượng:";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(683, 587);
            numSoLuong.Margin = new Padding(3, 4, 3, 4);
            numSoLuong.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(91, 27);
            numSoLuong.TabIndex = 9;
            numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnThemMon
            // 
            btnThemMon.Location = new Point(798, 587);
            btnThemMon.Margin = new Padding(3, 4, 3, 4);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(113, 40);
            btnThemMon.TabIndex = 10;
            btnThemMon.Text = "Thêm Món";
            btnThemMon.UseVisualStyleBackColor = true;
            btnThemMon.Click += btnThemMon_Click;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.DarkGreen;
            lblTongTien.Location = new Point(469, 627);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(0, 25);
            lblTongTien.TabIndex = 11;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.Black;
            btnThanhToan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(740, 645);
            btnThanhToan.Margin = new Padding(3, 4, 3, 4);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(171, 53);
            btnThanhToan.TabIndex = 12;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // frmSoDoBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 804);
            Controls.Add(flpBanAn);
            Controls.Add(btnQuanLyThucDon);
            Controls.Add(lblBanDangChon);
            Controls.Add(dgvChiTiet);
            Controls.Add(lblDanhMuc);
            Controls.Add(cboDanhMuc);
            Controls.Add(lblMon);
            Controls.Add(cboMon);
            Controls.Add(lblSoLuong);
            Controls.Add(numSoLuong);
            Controls.Add(btnThemMon);
            Controls.Add(lblTongTien);
            Controls.Add(btnThanhToan);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmSoDoBan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ QUÁN CAFE";
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void frmSoDoBan_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
            LoadSoDoBan();
        }


        private void LoadSoDoBan()
        {
            flpBanAn.Controls.Clear();
            var dsBan = banAnBUS.GetAll();

            foreach (var ban in dsBan)
            {
                var btn = new Button
                {
                    Text = ban.TenBan + Environment.NewLine + ban.TrangThai,
                    Width = 100,
                    Height = 80,
                    Margin = new Padding(8),
                    Tag = ban.MaBan,
                    BackColor = ban.TrangThai == "Trong" ? Color.MediumSeaGreen : Color.IndianRed,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                btn.Click += BtnBan_Click;
                flpBanAn.Controls.Add(btn);
            }
        }

        private void BtnBan_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            maBanDangChon = (int)btn.Tag;
            btnDangChon = btn;

            lblBanDangChon.Text = "Ban dang chon: " + btn.Text.Split('\n')[0];
            LoadChiTietBan(maBanDangChon.Value);
        }


        private void LoadChiTietBan(int maBan)
        {
            var hd = hoaDonBUS.LayHoacTaoHoaDon(maBan);
            var dsChiTiet = hoaDonBUS.GetChiTiet(hd.MaHoaDon);

            dgvChiTiet.DataSource = null;
            dgvChiTiet.DataSource = dsChiTiet;

            if (dgvChiTiet.Columns["TenMon"] != null) dgvChiTiet.Columns["TenMon"].HeaderText = "Ten mon";
            if (dgvChiTiet.Columns["SoLuong"] != null) dgvChiTiet.Columns["SoLuong"].HeaderText = "So luong";
            if (dgvChiTiet.Columns["DonGia"] != null) dgvChiTiet.Columns["DonGia"].HeaderText = "Don gia";
            if (dgvChiTiet.Columns["ThanhTien"] != null) dgvChiTiet.Columns["ThanhTien"].HeaderText = "Thanh tien";
            if (dgvChiTiet.Columns["MaMon"] != null) dgvChiTiet.Columns["MaMon"].Visible = false;

            decimal tong = dsChiTiet.Sum(x => x.ThanhTien);
            lblTongTien.Text = "Tong tien: " + tong.ToString("N0") + " d";
        }

        private void LoadDanhMuc()
        {
            var ds = danhMucBUS.GetAll();
            cboDanhMuc.DisplayMember = "TenDanhMuc";
            cboDanhMuc.ValueMember = "MaDanhMuc";
            cboDanhMuc.DataSource = ds;
        }

        private void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDanhMuc.SelectedValue == null) return;
            int maDanhMuc = (int)cboDanhMuc.SelectedValue;
            var dsMon = monAnBUS.GetByDanhMuc(maDanhMuc);
            cboMon.DisplayMember = "TenMon";
            cboMon.ValueMember = "MaMon";
            cboMon.DataSource = dsMon;
        }


        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (maBanDangChon == null)
            {
                MessageBox.Show("Vui long chon 1 ban truoc.", "Thong bao");
                return;
            }
            if (cboMon.SelectedItem == null)
            {
                MessageBox.Show("Vui long chon mon an.", "Thong bao");
                return;
            }

            try
            {
                var mon = (MonAnDTO)cboMon.SelectedItem;
                int soLuong = (int)numSoLuong.Value;

                hoaDonBUS.ThemMon(maBanDangChon.Value, mon, soLuong);

                LoadChiTietBan(maBanDangChon.Value);
                LoadSoDoBan(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi");
            }
        }

        
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (maBanDangChon == null)
            {
                MessageBox.Show("Vui long chon 1 ban truoc.", "Thong bao");
                return;
            }

            var xacNhan = MessageBox.Show("Xac nhan thanh toan cho ban nay?", "Xac nhan",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacNhan != DialogResult.Yes) return;

            try
            {
                decimal tongTien = hoaDonBUS.ThanhToan(maBanDangChon.Value);
                MessageBox.Show("Thanh toan thanh cong. Tong tien: " + tongTien.ToString("N0") + " d", "Thanh cong");

                dgvChiTiet.DataSource = null;
                lblTongTien.Text = "";
                maBanDangChon = null;
                lblBanDangChon.Text = "Chua chon ban";
                LoadSoDoBan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi");
            }
        }

        private void btnQuanLyThucDon_Click(object sender, EventArgs e)
        {
            var f = new frmThucDon();
            f.ShowDialog();
            LoadDanhMuc(); 
        }
    }
}