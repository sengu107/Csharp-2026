namespace HRM.GUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.TabPage tabChamCong;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtLuongCoBan;
        private System.Windows.Forms.TextBox txtHeSoLuong;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblHeSo;
        private System.Windows.Forms.Label lblMaPB;
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.TextBox txtThangNam;
        private System.Windows.Forms.Button btnNapChamCong;
        private System.Windows.Forms.Button btnLuuChamCong;
        private System.Windows.Forms.Button btnChotLuong;
        private System.Windows.Forms.Label lblThangNam;

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
            tabControl1 = new TabControl();
            tabNhanVien = new TabPage();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblCCCD = new Label();
            txtCCCD = new TextBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblLuong = new Label();
            txtLuongCoBan = new TextBox();
            lblHeSo = new Label();
            txtHeSoLuong = new TextBox();
            lblMaPB = new Label();
            txtMaPB = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvNhanVien = new DataGridView();
            tabChamCong = new TabPage();
            lblThangNam = new Label();
            txtThangNam = new TextBox();
            btnNapChamCong = new Button();
            btnLuuChamCong = new Button();
            btnChotLuong = new Button();
            dgvChamCong = new DataGridView();
            tabControl1.SuspendLayout();
            tabNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            tabChamCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabNhanVien);
            tabControl1.Controls.Add(tabChamCong);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1087, 554);
            tabControl1.TabIndex = 0;
            // 
            // tabNhanVien
            // 
            tabNhanVien.Controls.Add(lblHoTen);
            tabNhanVien.Controls.Add(txtHoTen);
            tabNhanVien.Controls.Add(lblCCCD);
            tabNhanVien.Controls.Add(txtCCCD);
            tabNhanVien.Controls.Add(lblNgaySinh);
            tabNhanVien.Controls.Add(dtpNgaySinh);
            tabNhanVien.Controls.Add(lblLuong);
            tabNhanVien.Controls.Add(txtLuongCoBan);
            tabNhanVien.Controls.Add(lblHeSo);
            tabNhanVien.Controls.Add(txtHeSoLuong);
            tabNhanVien.Controls.Add(lblMaPB);
            tabNhanVien.Controls.Add(txtMaPB);
            tabNhanVien.Controls.Add(btnThem);
            tabNhanVien.Controls.Add(btnSua);
            tabNhanVien.Controls.Add(btnXoa);
            tabNhanVien.Controls.Add(txtTimKiem);
            tabNhanVien.Controls.Add(btnTimKiem);
            tabNhanVien.Controls.Add(dgvNhanVien);
            tabNhanVien.Location = new Point(4, 29);
            tabNhanVien.Name = "tabNhanVien";
            tabNhanVien.Padding = new Padding(3);
            tabNhanVien.Size = new Size(1079, 521);
            tabNhanVien.TabIndex = 0;
            tabNhanVien.Text = "Hồ sơ Nhân viên";
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(20, 20);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(100, 23);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ Tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(126, 17);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(180, 27);
            txtHoTen.TabIndex = 1;
            // 
            // lblCCCD
            // 
            lblCCCD.Location = new Point(380, 20);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(64, 23);
            lblCCCD.TabIndex = 2;
            lblCCCD.Text = "CCCD:";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(450, 18);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(180, 27);
            txtCCCD.TabIndex = 3;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Location = new Point(687, 22);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(100, 23);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(784, 18);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(200, 27);
            dtpNgaySinh.TabIndex = 5;
            // 
            // lblLuong
            // 
            lblLuong.Location = new Point(20, 60);
            lblLuong.Name = "lblLuong";
            lblLuong.Size = new Size(100, 23);
            lblLuong.TabIndex = 6;
            lblLuong.Text = "Lương CB:";
            // 
            // txtLuongCoBan
            // 
            txtLuongCoBan.Location = new Point(126, 57);
            txtLuongCoBan.Name = "txtLuongCoBan";
            txtLuongCoBan.Size = new Size(180, 27);
            txtLuongCoBan.TabIndex = 7;
            // 
            // lblHeSo
            // 
            lblHeSo.Location = new Point(344, 63);
            lblHeSo.Name = "lblHeSo";
            lblHeSo.Size = new Size(100, 23);
            lblHeSo.TabIndex = 8;
            lblHeSo.Text = "Hệ Số Lương:";
            // 
            // txtHeSoLuong
            // 
            txtHeSoLuong.Location = new Point(450, 60);
            txtHeSoLuong.Name = "txtHeSoLuong";
            txtHeSoLuong.Size = new Size(180, 27);
            txtHeSoLuong.TabIndex = 9;
            // 
            // lblMaPB
            // 
            lblMaPB.Location = new Point(687, 57);
            lblMaPB.Name = "lblMaPB";
            lblMaPB.Size = new Size(70, 23);
            lblMaPB.TabIndex = 10;
            lblMaPB.Text = "Mã PB:";
            // 
            // txtMaPB
            // 
            txtMaPB.Location = new Point(784, 56);
            txtMaPB.Name = "txtMaPB";
            txtMaPB.Size = new Size(200, 27);
            txtMaPB.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(20, 100);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(110, 100);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(200, 100);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(450, 102);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(200, 27);
            txtTimKiem.TabIndex = 15;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(660, 102);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 27);
            btnTimKiem.TabIndex = 16;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeight = 29;
            dgvNhanVien.Location = new Point(20, 140);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(1051, 370);
            dgvNhanVien.TabIndex = 17;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // tabChamCong
            // 
            tabChamCong.Controls.Add(lblThangNam);
            tabChamCong.Controls.Add(txtThangNam);
            tabChamCong.Controls.Add(btnNapChamCong);
            tabChamCong.Controls.Add(btnLuuChamCong);
            tabChamCong.Controls.Add(btnChotLuong);
            tabChamCong.Controls.Add(dgvChamCong);
            tabChamCong.Location = new Point(4, 29);
            tabChamCong.Name = "tabChamCong";
            tabChamCong.Padding = new Padding(3);
            tabChamCong.Size = new Size(1079, 521);
            tabChamCong.TabIndex = 1;
            tabChamCong.Text = "Chấm công & Tính lương";
            // 
            // lblThangNam
            // 
            lblThangNam.Location = new Point(20, 20);
            lblThangNam.Name = "lblThangNam";
            lblThangNam.Size = new Size(130, 20);
            lblThangNam.TabIndex = 0;
            lblThangNam.Text = "Tháng/Năm (MM/yyyy):";
            // 
            // txtThangNam
            // 
            txtThangNam.Location = new Point(150, 17);
            txtThangNam.Name = "txtThangNam";
            txtThangNam.Size = new Size(120, 27);
            txtThangNam.TabIndex = 1;
            txtThangNam.Text = "11/2026";
            // 
            // btnNapChamCong
            // 
            btnNapChamCong.Location = new Point(290, 15);
            btnNapChamCong.Name = "btnNapChamCong";
            btnNapChamCong.Size = new Size(120, 29);
            btnNapChamCong.TabIndex = 2;
            btnNapChamCong.Text = "Nạp Chấm Công";
            btnNapChamCong.Click += btnNapChamCong_Click;
            // 
            // btnLuuChamCong
            // 
            btnLuuChamCong.Location = new Point(420, 15);
            btnLuuChamCong.Name = "btnLuuChamCong";
            btnLuuChamCong.Size = new Size(120, 29);
            btnLuuChamCong.TabIndex = 3;
            btnLuuChamCong.Text = "Lưu Chấm Công";
            btnLuuChamCong.Click += btnLuuChamCong_Click;
            // 
            // btnChotLuong
            // 
            btnChotLuong.Location = new Point(550, 15);
            btnChotLuong.Name = "btnChotLuong";
            btnChotLuong.Size = new Size(150, 29);
            btnChotLuong.TabIndex = 4;
            btnChotLuong.Text = "Chốt Lương Tháng";
            btnChotLuong.Click += btnChotLuong_Click;
            // 
            // dgvChamCong
            // 
            dgvChamCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChamCong.ColumnHeadersHeight = 29;
            dgvChamCong.Location = new Point(20, 60);
            dgvChamCong.Name = "dgvChamCong";
            dgvChamCong.RowHeadersWidth = 51;
            dgvChamCong.Size = new Size(830, 450);
            dgvChamCong.TabIndex = 5;
            // 
            // MainForm
            // 
            ClientSize = new Size(1087, 554);
            Controls.Add(tabControl1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý Nhân sự & Tính lương (MySQL)";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            tabNhanVien.ResumeLayout(false);
            tabNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            tabChamCong.ResumeLayout(false);
            tabChamCong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).EndInit();
            ResumeLayout(false);
        }
    }
}