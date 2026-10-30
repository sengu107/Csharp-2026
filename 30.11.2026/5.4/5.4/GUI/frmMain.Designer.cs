using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.GUI
{
    public partial class frmMain
    {
        private IContainer components = null;

        private TabControl tabs;
        private TabPage tpPhong;
        private TabPage tpCheckIn;
        private TabPage tpDichVu;
        private TabPage tpCheckOut;


        private ComboBox cboLocLoai;
        private ComboBox cboLocTrangThai;
        private Button btnTaiLai;
        private Button btnDonXong;
        private Label lblDemPhong;
        private DataGridView dgvPhong;

  
        private TextBox txtCCCD;
        private TextBox txtHoTen;
        private TextBox txtSDT;
        private Button btnTraCuu;
        private Button btnCheckIn;
        private Label lblKhach;
        private ComboBox cboPhongTrong;

  
        private ComboBox cboPhongDV;
        private ComboBox cboDichVu;
        private NumericUpDown nudSoLuong;
        private Button btnThemDV;
        private DataGridView dgvDichVu;
        private Label lblTongDV;

   
        private ComboBox cboPhongCO;
        private Button btnXemHoaDon;
        private Button btnThanhToan;
        private TextBox txtHoaDon;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabs = new TabControl();
            tpPhong = new TabPage();
            lblLocLoai = new Label();
            cboLocLoai = new ComboBox();
            lblLocTrangThai = new Label();
            cboLocTrangThai = new ComboBox();
            btnTaiLai = new Button();
            btnDonXong = new Button();
            lblDemPhong = new Label();
            dgvPhong = new DataGridView();
            tpCheckIn = new TabPage();
            lblCCCD = new Label();
            txtCCCD = new TextBox();
            btnTraCuu = new Button();
            lblKhach = new Label();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblPhongTrong = new Label();
            cboPhongTrong = new ComboBox();
            btnCheckIn = new Button();
            tpDichVu = new TabPage();
            lblPhongDV = new Label();
            cboPhongDV = new ComboBox();
            lblDichVu = new Label();
            cboDichVu = new ComboBox();
            lblSoLuong = new Label();
            nudSoLuong = new NumericUpDown();
            btnThemDV = new Button();
            dgvDichVu = new DataGridView();
            lblTongDV = new Label();
            tpCheckOut = new TabPage();
            lblPhongCO = new Label();
            cboPhongCO = new ComboBox();
            btnXemHoaDon = new Button();
            txtHoaDon = new TextBox();
            btnThanhToan = new Button();
            tabs.SuspendLayout();
            tpPhong.SuspendLayout();
            ((ISupportInitialize)dgvPhong).BeginInit();
            tpCheckIn.SuspendLayout();
            tpDichVu.SuspendLayout();
            ((ISupportInitialize)nudSoLuong).BeginInit();
            ((ISupportInitialize)dgvDichVu).BeginInit();
            tpCheckOut.SuspendLayout();
            SuspendLayout();
            // 
            // tabs
            // 
            tabs.Controls.Add(tpPhong);
            tabs.Controls.Add(tpCheckIn);
            tabs.Controls.Add(tpDichVu);
            tabs.Controls.Add(tpCheckOut);
            tabs.Dock = DockStyle.Fill;
            tabs.Location = new Point(0, 0);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(1158, 600);
            tabs.TabIndex = 0;
            // 
            // tpPhong
            // 
            tpPhong.Controls.Add(lblLocLoai);
            tpPhong.Controls.Add(cboLocLoai);
            tpPhong.Controls.Add(lblLocTrangThai);
            tpPhong.Controls.Add(cboLocTrangThai);
            tpPhong.Controls.Add(btnTaiLai);
            tpPhong.Controls.Add(btnDonXong);
            tpPhong.Controls.Add(lblDemPhong);
            tpPhong.Controls.Add(dgvPhong);
            tpPhong.Location = new Point(4, 32);
            tpPhong.Name = "tpPhong";
            tpPhong.Size = new Size(1150, 564);
            tpPhong.TabIndex = 0;
            tpPhong.Text = "Danh sách phòng";
            tpPhong.UseVisualStyleBackColor = true;
            // 
            // lblLocLoai
            // 
            lblLocLoai.AutoSize = true;
            lblLocLoai.Location = new Point(15, 18);
            lblLocLoai.Name = "lblLocLoai";
            lblLocLoai.Size = new Size(100, 23);
            lblLocLoai.TabIndex = 0;
            lblLocLoai.Text = "Loại phòng:";
            lblLocLoai.Click += lblLocLoai_Click;
            // 
            // cboLocLoai
            // 
            cboLocLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocLoai.Location = new Point(121, 12);
            cboLocLoai.Name = "cboLocLoai";
            cboLocLoai.Size = new Size(150, 31);
            cboLocLoai.TabIndex = 1;
            // 
            // lblLocTrangThai
            // 
            lblLocTrangThai.AutoSize = true;
            lblLocTrangThai.Location = new Point(302, 18);
            lblLocTrangThai.Name = "lblLocTrangThai";
            lblLocTrangThai.Size = new Size(91, 23);
            lblLocTrangThai.TabIndex = 2;
            lblLocTrangThai.Text = "Trạng thái:";
            // 
            // cboLocTrangThai
            // 
            cboLocTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocTrangThai.Items.AddRange(new object[] { "-- Tất cả --", "Trống", "Đang ở", "Đang dọn" });
            cboLocTrangThai.Location = new Point(420, 12);
            cboLocTrangThai.Name = "cboLocTrangThai";
            cboLocTrangThai.Size = new Size(160, 31);
            cboLocTrangThai.TabIndex = 3;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(632, 12);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(90, 30);
            btnTaiLai.TabIndex = 4;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = true;
            // 
            // btnDonXong
            // 
            btnDonXong.Location = new Point(762, 11);
            btnDonXong.Name = "btnDonXong";
            btnDonXong.Size = new Size(180, 32);
            btnDonXong.TabIndex = 5;
            btnDonXong.Text = "Dọn xong → Trống";
            btnDonXong.UseVisualStyleBackColor = true;
            // 
            // lblDemPhong
            // 
            lblDemPhong.AutoSize = true;
            lblDemPhong.ForeColor = Color.DimGray;
            lblDemPhong.Location = new Point(15, 52);
            lblDemPhong.Name = "lblDemPhong";
            lblDemPhong.Size = new Size(0, 23);
            lblDemPhong.TabIndex = 6;
            // 
            // dgvPhong
            // 
            dgvPhong.AllowUserToAddRows = false;
            dgvPhong.AllowUserToDeleteRows = false;
            dgvPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhong.BackgroundColor = SystemColors.Window;
            dgvPhong.ColumnHeadersHeight = 29;
            dgvPhong.Location = new Point(8, 66);
            dgvPhong.MultiSelect = false;
            dgvPhong.Name = "dgvPhong";
            dgvPhong.ReadOnly = true;
            dgvPhong.RowHeadersVisible = false;
            dgvPhong.RowHeadersWidth = 51;
            dgvPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhong.Size = new Size(1134, 489);
            dgvPhong.TabIndex = 7;
            // 
            // tpCheckIn
            // 
            tpCheckIn.Controls.Add(lblCCCD);
            tpCheckIn.Controls.Add(txtCCCD);
            tpCheckIn.Controls.Add(btnTraCuu);
            tpCheckIn.Controls.Add(lblKhach);
            tpCheckIn.Controls.Add(lblHoTen);
            tpCheckIn.Controls.Add(txtHoTen);
            tpCheckIn.Controls.Add(lblSDT);
            tpCheckIn.Controls.Add(txtSDT);
            tpCheckIn.Controls.Add(lblPhongTrong);
            tpCheckIn.Controls.Add(cboPhongTrong);
            tpCheckIn.Controls.Add(btnCheckIn);
            tpCheckIn.Location = new Point(4, 32);
            tpCheckIn.Name = "tpCheckIn";
            tpCheckIn.Size = new Size(1150, 564);
            tpCheckIn.TabIndex = 1;
            tpCheckIn.Text = "Check-in";
            tpCheckIn.UseVisualStyleBackColor = true;
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(15, 21);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(83, 23);
            lblCCCD.TabIndex = 0;
            lblCCCD.Text = "Số CCCD:";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(130, 17);
            txtCCCD.MaxLength = 20;
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(200, 30);
            txtCCCD.TabIndex = 1;
            // 
            // btnTraCuu
            // 
            btnTraCuu.Location = new Point(345, 14);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(100, 30);
            btnTraCuu.TabIndex = 2;
            btnTraCuu.Text = "Tra cứu";
            btnTraCuu.UseVisualStyleBackColor = true;
            // 
            // lblKhach
            // 
            lblKhach.ForeColor = Color.DimGray;
            lblKhach.Location = new Point(15, 58);
            lblKhach.Name = "lblKhach";
            lblKhach.Size = new Size(840, 24);
            lblKhach.TabIndex = 3;
            lblKhach.Text = "Nhập số CCCD rồi bấm Tra cứu.";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(15, 101);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(66, 23);
            lblHoTen.TabIndex = 4;
            lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(130, 97);
            txtHoTen.MaxLength = 100;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(320, 30);
            txtHoTen.TabIndex = 5;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(15, 141);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(115, 23);
            lblSDT.TabIndex = 6;
            lblSDT.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(130, 137);
            txtSDT.MaxLength = 15;
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(200, 30);
            txtSDT.TabIndex = 7;
            // 
            // lblPhongTrong
            // 
            lblPhongTrong.AutoSize = true;
            lblPhongTrong.Location = new Point(15, 191);
            lblPhongTrong.Name = "lblPhongTrong";
            lblPhongTrong.Size = new Size(111, 23);
            lblPhongTrong.TabIndex = 8;
            lblPhongTrong.Text = "Phòng trống:";
            // 
            // cboPhongTrong
            // 
            cboPhongTrong.DisplayMember = "HienThi";
            cboPhongTrong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhongTrong.Location = new Point(130, 187);
            cboPhongTrong.Name = "cboPhongTrong";
            cboPhongTrong.Size = new Size(380, 31);
            cboPhongTrong.TabIndex = 9;
            cboPhongTrong.ValueMember = "SoPhong";
            // 
            // btnCheckIn
            // 
            btnCheckIn.Location = new Point(130, 235);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(220, 36);
            btnCheckIn.TabIndex = 10;
            btnCheckIn.Text = "Nhận phòng (Check-in)";
            btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // tpDichVu
            // 
            tpDichVu.Controls.Add(lblPhongDV);
            tpDichVu.Controls.Add(cboPhongDV);
            tpDichVu.Controls.Add(lblDichVu);
            tpDichVu.Controls.Add(cboDichVu);
            tpDichVu.Controls.Add(lblSoLuong);
            tpDichVu.Controls.Add(nudSoLuong);
            tpDichVu.Controls.Add(btnThemDV);
            tpDichVu.Controls.Add(dgvDichVu);
            tpDichVu.Controls.Add(lblTongDV);
            tpDichVu.Location = new Point(4, 32);
            tpDichVu.Name = "tpDichVu";
            tpDichVu.Size = new Size(1150, 564);
            tpDichVu.TabIndex = 2;
            tpDichVu.Text = "Gọi dịch vụ";
            tpDichVu.UseVisualStyleBackColor = true;
            // 
            // lblPhongDV
            // 
            lblPhongDV.AutoSize = true;
            lblPhongDV.Location = new Point(15, 21);
            lblPhongDV.Name = "lblPhongDV";
            lblPhongDV.Size = new Size(123, 23);
            lblPhongDV.TabIndex = 0;
            lblPhongDV.Text = "Phòng đang ở:";
            // 
            // cboPhongDV
            // 
            cboPhongDV.DisplayMember = "HienThi";
            cboPhongDV.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhongDV.Location = new Point(144, 18);
            cboPhongDV.Name = "cboPhongDV";
            cboPhongDV.Size = new Size(380, 31);
            cboPhongDV.TabIndex = 1;
            cboPhongDV.ValueMember = "MaPhieu";
            // 
            // lblDichVu
            // 
            lblDichVu.AutoSize = true;
            lblDichVu.Location = new Point(15, 61);
            lblDichVu.Name = "lblDichVu";
            lblDichVu.Size = new Size(71, 23);
            lblDichVu.TabIndex = 2;
            lblDichVu.Text = "Dịch vụ:";
            // 
            // cboDichVu
            // 
            cboDichVu.DisplayMember = "HienThi";
            cboDichVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDichVu.Location = new Point(144, 57);
            cboDichVu.Name = "cboDichVu";
            cboDichVu.Size = new Size(280, 31);
            cboDichVu.TabIndex = 3;
            cboDichVu.ValueMember = "MaDV";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(442, 60);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(82, 23);
            lblSoLuong.TabIndex = 4;
            lblSoLuong.Text = "Số lượng:";
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(530, 58);
            nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(70, 30);
            nudSoLuong.TabIndex = 5;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnThemDV
            // 
            btnThemDV.Location = new Point(622, 58);
            btnThemDV.Name = "btnThemDV";
            btnThemDV.Size = new Size(140, 30);
            btnThemDV.TabIndex = 6;
            btnThemDV.Text = "Thêm dịch vụ";
            btnThemDV.UseVisualStyleBackColor = true;
            // 
            // dgvDichVu
            // 
            dgvDichVu.AllowUserToAddRows = false;
            dgvDichVu.AllowUserToDeleteRows = false;
            dgvDichVu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDichVu.BackgroundColor = SystemColors.Window;
            dgvDichVu.ColumnHeadersHeight = 29;
            dgvDichVu.Location = new Point(15, 100);
            dgvDichVu.MultiSelect = false;
            dgvDichVu.Name = "dgvDichVu";
            dgvDichVu.ReadOnly = true;
            dgvDichVu.RowHeadersVisible = false;
            dgvDichVu.RowHeadersWidth = 51;
            dgvDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDichVu.Size = new Size(1803, 897);
            dgvDichVu.TabIndex = 7;
            // 
            // lblTongDV
            // 
            lblTongDV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTongDV.AutoSize = true;
            lblTongDV.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTongDV.Location = new Point(15, 1007);
            lblTongDV.Name = "lblTongDV";
            lblTongDV.Size = new Size(205, 25);
            lblTongDV.TabIndex = 8;
            lblTongDV.Text = "Tổng tiền dịch vụ: 0 đ";
            // 
            // tpCheckOut
            // 
            tpCheckOut.Controls.Add(lblPhongCO);
            tpCheckOut.Controls.Add(cboPhongCO);
            tpCheckOut.Controls.Add(btnXemHoaDon);
            tpCheckOut.Controls.Add(txtHoaDon);
            tpCheckOut.Controls.Add(btnThanhToan);
            tpCheckOut.Location = new Point(4, 32);
            tpCheckOut.Name = "tpCheckOut";
            tpCheckOut.Size = new Size(1150, 564);
            tpCheckOut.TabIndex = 3;
            tpCheckOut.Text = "Check-out & Hóa đơn";
            tpCheckOut.UseVisualStyleBackColor = true;
            // 
            // lblPhongCO
            // 
            lblPhongCO.AutoSize = true;
            lblPhongCO.Location = new Point(15, 21);
            lblPhongCO.Name = "lblPhongCO";
            lblPhongCO.Size = new Size(123, 23);
            lblPhongCO.TabIndex = 0;
            lblPhongCO.Text = "Phòng đang ở:";
            // 
            // cboPhongCO
            // 
            cboPhongCO.DisplayMember = "HienThi";
            cboPhongCO.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhongCO.Location = new Point(144, 17);
            cboPhongCO.Name = "cboPhongCO";
            cboPhongCO.Size = new Size(380, 31);
            cboPhongCO.TabIndex = 1;
            cboPhongCO.ValueMember = "MaPhieu";
            // 
            // btnXemHoaDon
            // 
            btnXemHoaDon.Location = new Point(549, 17);
            btnXemHoaDon.Name = "btnXemHoaDon";
            btnXemHoaDon.Size = new Size(110, 30);
            btnXemHoaDon.TabIndex = 2;
            btnXemHoaDon.Text = "Tính tiền";
            btnXemHoaDon.UseVisualStyleBackColor = true;
            // 
            // txtHoaDon
            // 
            txtHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtHoaDon.BackColor = Color.White;
            txtHoaDon.Font = new Font("Consolas", 10.5F);
            txtHoaDon.Location = new Point(15, 60);
            txtHoaDon.Multiline = true;
            txtHoaDon.Name = "txtHoaDon";
            txtHoaDon.ReadOnly = true;
            txtHoaDon.ScrollBars = ScrollBars.Vertical;
            txtHoaDon.Size = new Size(1803, 927);
            txtHoaDon.TabIndex = 3;
            // 
            // btnThanhToan
            btnThanhToan.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnThanhToan.Enabled = false;
            btnThanhToan.Location = new Point(665, 17);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(220, 30);
            btnThanhToan.TabIndex = 4;
            btnThanhToan.Text = "Xác nhận thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 600);
            Controls.Add(tabs);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(900, 640);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý khách sạn - HotelDB";
            tabs.ResumeLayout(false);
            tpPhong.ResumeLayout(false);
            tpPhong.PerformLayout();
            ((ISupportInitialize)dgvPhong).EndInit();
            tpCheckIn.ResumeLayout(false);
            tpCheckIn.PerformLayout();
            tpDichVu.ResumeLayout(false);
            tpDichVu.PerformLayout();
            ((ISupportInitialize)nudSoLuong).EndInit();
            ((ISupportInitialize)dgvDichVu).EndInit();
            tpCheckOut.ResumeLayout(false);
            tpCheckOut.PerformLayout();
            ResumeLayout(false);

            this.Load += (s, e) => RefreshAll();

            this.cboLocLoai.SelectedIndexChanged += (s, e) => ApplyFilter();
            this.cboLocTrangThai.SelectedIndexChanged += (s, e) => ApplyFilter();
            this.btnTaiLai.Click += (s, e) => RefreshAll();
            this.btnDonXong.Click += (s, e) => DonXong();
            this.dgvPhong.CellFormatting += DgvPhong_CellFormatting;

            this.txtCCCD.TextChanged += TxtCCCD_TextChanged;
            this.btnTraCuu.Click += (s, e) => TraCuuKhach();
            this.btnCheckIn.Click += (s, e) => DoCheckIn();

            this.cboPhongDV.SelectedIndexChanged += (s, e) => LoadChiTietDichVu();
            this.btnThemDV.Click += (s, e) => ThemDichVu();

            this.btnXemHoaDon.Click += (s, e) => XemHoaDon();
            this.btnThanhToan.Click += (s, e) => ThanhToan();   
        }

        private Label lblLocLoai;
        private Label lblLocTrangThai;
        private Label lblCCCD;
        private Label lblHoTen;
        private Label lblSDT;
        private Label lblPhongTrong;
        private Label lblPhongDV;
        private Label lblDichVu;
        private Label lblSoLuong;
        private Label lblPhongCO;

    }
}
