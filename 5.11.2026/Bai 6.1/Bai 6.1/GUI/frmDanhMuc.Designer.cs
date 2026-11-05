namespace Market.GUI
{
    partial class frmDanhMuc
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();

            this.tabSanPham = new System.Windows.Forms.TabPage();
            this.lblSPTimKiem = new System.Windows.Forms.Label();
            this.txtSPTimKiem = new System.Windows.Forms.TextBox();
            this.btnSPTimKiem = new System.Windows.Forms.Button();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.lblSPMa = new System.Windows.Forms.Label();
            this.txtSPMa = new System.Windows.Forms.TextBox();
            this.lblSPTen = new System.Windows.Forms.Label();
            this.txtSPTen = new System.Windows.Forms.TextBox();
            this.lblSPGia = new System.Windows.Forms.Label();
            this.txtSPGia = new System.Windows.Forms.TextBox();
            this.lblSPSL = new System.Windows.Forms.Label();
            this.txtSPSL = new System.Windows.Forms.TextBox();
            this.btnSPThem = new System.Windows.Forms.Button();
            this.btnSPSua = new System.Windows.Forms.Button();
            this.btnSPXoa = new System.Windows.Forms.Button();
            this.btnSPLamMoi = new System.Windows.Forms.Button();

            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.lblKHTimKiem = new System.Windows.Forms.Label();
            this.txtKHTimKiem = new System.Windows.Forms.TextBox();
            this.btnKHTimKiem = new System.Windows.Forms.Button();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.lblKHTen = new System.Windows.Forms.Label();
            this.txtKHTen = new System.Windows.Forms.TextBox();
            this.lblKHDT = new System.Windows.Forms.Label();
            this.txtKHDT = new System.Windows.Forms.TextBox();
            this.btnKHThem = new System.Windows.Forms.Button();
            this.btnKHSua = new System.Windows.Forms.Button();
            this.btnKHXoa = new System.Windows.Forms.Button();
            this.btnKHLamMoi = new System.Windows.Forms.Button();

            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.lblNVTen = new System.Windows.Forms.Label();
            this.txtNVTen = new System.Windows.Forms.TextBox();
            this.lblNVDT = new System.Windows.Forms.Label();
            this.txtNVDT = new System.Windows.Forms.TextBox();
            this.lblNVChucVu = new System.Windows.Forms.Label();
            this.txtNVChucVu = new System.Windows.Forms.TextBox();
            this.btnNVThem = new System.Windows.Forms.Button();
            this.btnNVSua = new System.Windows.Forms.Button();
            this.btnNVXoa = new System.Windows.Forms.Button();
            this.btnNVLamMoi = new System.Windows.Forms.Button();

            this.tabControl.SuspendLayout();
            this.tabSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.tabKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.tabNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.SuspendLayout();

            //
            // tabControl
            //
            this.tabControl.Controls.Add(this.tabSanPham);
            this.tabControl.Controls.Add(this.tabKhachHang);
            this.tabControl.Controls.Add(this.tabNhanVien);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(934, 561);
            this.tabControl.TabIndex = 0;

            // ===================== TAB SAN PHAM =====================
            this.tabSanPham.Text = "San pham";
            this.tabSanPham.UseVisualStyleBackColor = true;
            this.tabSanPham.Padding = new System.Windows.Forms.Padding(3);

            this.lblSPTimKiem.Text = "Tim kiem:";
            this.lblSPTimKiem.Location = new System.Drawing.Point(10, 15);
            this.lblSPTimKiem.Size = new System.Drawing.Size(60, 23);

            this.txtSPTimKiem.Location = new System.Drawing.Point(75, 12);
            this.txtSPTimKiem.Size = new System.Drawing.Size(200, 23);

            this.btnSPTimKiem.Text = "Tim";
            this.btnSPTimKiem.Location = new System.Drawing.Point(285, 11);
            this.btnSPTimKiem.Size = new System.Drawing.Size(60, 25);
            this.btnSPTimKiem.Click += new System.EventHandler(this.btnSPTimKiem_Click);

            this.dgvSP.Location = new System.Drawing.Point(10, 45);
            this.dgvSP.Size = new System.Drawing.Size(900, 300);
            this.dgvSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSP.ReadOnly = true;
            this.dgvSP.AllowUserToAddRows = false;
            this.dgvSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSP_CellClick);

            this.lblSPMa.Text = "Ma SP:";
            this.lblSPMa.Location = new System.Drawing.Point(10, 360);
            this.lblSPMa.Size = new System.Drawing.Size(60, 23);

            this.txtSPMa.Location = new System.Drawing.Point(75, 357);
            this.txtSPMa.Size = new System.Drawing.Size(150, 23);

            this.lblSPTen.Text = "Ten SP:";
            this.lblSPTen.Location = new System.Drawing.Point(240, 360);
            this.lblSPTen.Size = new System.Drawing.Size(60, 23);

            this.txtSPTen.Location = new System.Drawing.Point(305, 357);
            this.txtSPTen.Size = new System.Drawing.Size(250, 23);

            this.lblSPGia.Text = "Gia ban:";
            this.lblSPGia.Location = new System.Drawing.Point(10, 395);
            this.lblSPGia.Size = new System.Drawing.Size(60, 23);

            this.txtSPGia.Location = new System.Drawing.Point(75, 392);
            this.txtSPGia.Size = new System.Drawing.Size(150, 23);

            this.lblSPSL.Text = "SL ton:";
            this.lblSPSL.Location = new System.Drawing.Point(240, 395);
            this.lblSPSL.Size = new System.Drawing.Size(60, 23);

            this.txtSPSL.Location = new System.Drawing.Point(305, 392);
            this.txtSPSL.Size = new System.Drawing.Size(150, 23);

            this.btnSPThem.Text = "Them";
            this.btnSPThem.Location = new System.Drawing.Point(10, 435);
            this.btnSPThem.Size = new System.Drawing.Size(90, 30);
            this.btnSPThem.Click += new System.EventHandler(this.btnSPThem_Click);

            this.btnSPSua.Text = "Sua";
            this.btnSPSua.Location = new System.Drawing.Point(110, 435);
            this.btnSPSua.Size = new System.Drawing.Size(90, 30);
            this.btnSPSua.Click += new System.EventHandler(this.btnSPSua_Click);

            this.btnSPXoa.Text = "Xoa";
            this.btnSPXoa.Location = new System.Drawing.Point(210, 435);
            this.btnSPXoa.Size = new System.Drawing.Size(90, 30);
            this.btnSPXoa.Click += new System.EventHandler(this.btnSPXoa_Click);

            this.btnSPLamMoi.Text = "Lam moi";
            this.btnSPLamMoi.Location = new System.Drawing.Point(310, 435);
            this.btnSPLamMoi.Size = new System.Drawing.Size(90, 30);
            this.btnSPLamMoi.Click += new System.EventHandler(this.btnSPLamMoi_Click);

            this.tabSanPham.Controls.Add(this.lblSPTimKiem);
            this.tabSanPham.Controls.Add(this.txtSPTimKiem);
            this.tabSanPham.Controls.Add(this.btnSPTimKiem);
            this.tabSanPham.Controls.Add(this.dgvSP);
            this.tabSanPham.Controls.Add(this.lblSPMa);
            this.tabSanPham.Controls.Add(this.txtSPMa);
            this.tabSanPham.Controls.Add(this.lblSPTen);
            this.tabSanPham.Controls.Add(this.txtSPTen);
            this.tabSanPham.Controls.Add(this.lblSPGia);
            this.tabSanPham.Controls.Add(this.txtSPGia);
            this.tabSanPham.Controls.Add(this.lblSPSL);
            this.tabSanPham.Controls.Add(this.txtSPSL);
            this.tabSanPham.Controls.Add(this.btnSPThem);
            this.tabSanPham.Controls.Add(this.btnSPSua);
            this.tabSanPham.Controls.Add(this.btnSPXoa);
            this.tabSanPham.Controls.Add(this.btnSPLamMoi);

            // ===================== TAB KHACH HANG =====================
            this.tabKhachHang.Text = "Khach hang";
            this.tabKhachHang.UseVisualStyleBackColor = true;
            this.tabKhachHang.Padding = new System.Windows.Forms.Padding(3);

            this.lblKHTimKiem.Text = "Tim kiem:";
            this.lblKHTimKiem.Location = new System.Drawing.Point(10, 15);
            this.lblKHTimKiem.Size = new System.Drawing.Size(60, 23);

            this.txtKHTimKiem.Location = new System.Drawing.Point(75, 12);
            this.txtKHTimKiem.Size = new System.Drawing.Size(200, 23);

            this.btnKHTimKiem.Text = "Tim";
            this.btnKHTimKiem.Location = new System.Drawing.Point(285, 11);
            this.btnKHTimKiem.Size = new System.Drawing.Size(60, 25);
            this.btnKHTimKiem.Click += new System.EventHandler(this.btnKHTimKiem_Click);

            this.dgvKH.Location = new System.Drawing.Point(10, 45);
            this.dgvKH.Size = new System.Drawing.Size(900, 300);
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKH.ReadOnly = true;
            this.dgvKH.AllowUserToAddRows = false;
            this.dgvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellClick);

            this.lblKHTen.Text = "Ten KH:";
            this.lblKHTen.Location = new System.Drawing.Point(10, 360);
            this.lblKHTen.Size = new System.Drawing.Size(60, 23);

            this.txtKHTen.Location = new System.Drawing.Point(75, 357);
            this.txtKHTen.Size = new System.Drawing.Size(250, 23);

            this.lblKHDT.Text = "Dien thoai:";
            this.lblKHDT.Location = new System.Drawing.Point(340, 360);
            this.lblKHDT.Size = new System.Drawing.Size(70, 23);

            this.txtKHDT.Location = new System.Drawing.Point(415, 357);
            this.txtKHDT.Size = new System.Drawing.Size(150, 23);

            this.btnKHThem.Text = "Them";
            this.btnKHThem.Location = new System.Drawing.Point(10, 400);
            this.btnKHThem.Size = new System.Drawing.Size(90, 30);
            this.btnKHThem.Click += new System.EventHandler(this.btnKHThem_Click);

            this.btnKHSua.Text = "Sua";
            this.btnKHSua.Location = new System.Drawing.Point(110, 400);
            this.btnKHSua.Size = new System.Drawing.Size(90, 30);
            this.btnKHSua.Click += new System.EventHandler(this.btnKHSua_Click);

            this.btnKHXoa.Text = "Xoa";
            this.btnKHXoa.Location = new System.Drawing.Point(210, 400);
            this.btnKHXoa.Size = new System.Drawing.Size(90, 30);
            this.btnKHXoa.Click += new System.EventHandler(this.btnKHXoa_Click);

            this.btnKHLamMoi.Text = "Lam moi";
            this.btnKHLamMoi.Location = new System.Drawing.Point(310, 400);
            this.btnKHLamMoi.Size = new System.Drawing.Size(90, 30);
            this.btnKHLamMoi.Click += new System.EventHandler(this.btnKHLamMoi_Click);

            this.tabKhachHang.Controls.Add(this.lblKHTimKiem);
            this.tabKhachHang.Controls.Add(this.txtKHTimKiem);
            this.tabKhachHang.Controls.Add(this.btnKHTimKiem);
            this.tabKhachHang.Controls.Add(this.dgvKH);
            this.tabKhachHang.Controls.Add(this.lblKHTen);
            this.tabKhachHang.Controls.Add(this.txtKHTen);
            this.tabKhachHang.Controls.Add(this.lblKHDT);
            this.tabKhachHang.Controls.Add(this.txtKHDT);
            this.tabKhachHang.Controls.Add(this.btnKHThem);
            this.tabKhachHang.Controls.Add(this.btnKHSua);
            this.tabKhachHang.Controls.Add(this.btnKHXoa);
            this.tabKhachHang.Controls.Add(this.btnKHLamMoi);

            // ===================== TAB NHAN VIEN =====================
            this.tabNhanVien.Text = "Nhan vien";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);

            this.dgvNV.Location = new System.Drawing.Point(10, 15);
            this.dgvNV.Size = new System.Drawing.Size(900, 300);
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNV.ReadOnly = true;
            this.dgvNV.AllowUserToAddRows = false;
            this.dgvNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNV_CellClick);

            this.lblNVTen.Text = "Ten NV:";
            this.lblNVTen.Location = new System.Drawing.Point(10, 330);
            this.lblNVTen.Size = new System.Drawing.Size(60, 23);

            this.txtNVTen.Location = new System.Drawing.Point(75, 327);
            this.txtNVTen.Size = new System.Drawing.Size(250, 23);

            this.lblNVDT.Text = "Dien thoai:";
            this.lblNVDT.Location = new System.Drawing.Point(340, 330);
            this.lblNVDT.Size = new System.Drawing.Size(70, 23);

            this.txtNVDT.Location = new System.Drawing.Point(415, 327);
            this.txtNVDT.Size = new System.Drawing.Size(150, 23);

            this.lblNVChucVu.Text = "Chuc vu:";
            this.lblNVChucVu.Location = new System.Drawing.Point(10, 365);
            this.lblNVChucVu.Size = new System.Drawing.Size(60, 23);

            this.txtNVChucVu.Location = new System.Drawing.Point(75, 362);
            this.txtNVChucVu.Size = new System.Drawing.Size(250, 23);

            this.btnNVThem.Text = "Them";
            this.btnNVThem.Location = new System.Drawing.Point(10, 405);
            this.btnNVThem.Size = new System.Drawing.Size(90, 30);
            this.btnNVThem.Click += new System.EventHandler(this.btnNVThem_Click);

            this.btnNVSua.Text = "Sua";
            this.btnNVSua.Location = new System.Drawing.Point(110, 405);
            this.btnNVSua.Size = new System.Drawing.Size(90, 30);
            this.btnNVSua.Click += new System.EventHandler(this.btnNVSua_Click);

            this.btnNVXoa.Text = "Xoa";
            this.btnNVXoa.Location = new System.Drawing.Point(210, 405);
            this.btnNVXoa.Size = new System.Drawing.Size(90, 30);
            this.btnNVXoa.Click += new System.EventHandler(this.btnNVXoa_Click);

            this.btnNVLamMoi.Text = "Lam moi";
            this.btnNVLamMoi.Location = new System.Drawing.Point(310, 405);
            this.btnNVLamMoi.Size = new System.Drawing.Size(90, 30);
            this.btnNVLamMoi.Click += new System.EventHandler(this.btnNVLamMoi_Click);

            this.tabNhanVien.Controls.Add(this.dgvNV);
            this.tabNhanVien.Controls.Add(this.lblNVTen);
            this.tabNhanVien.Controls.Add(this.txtNVTen);
            this.tabNhanVien.Controls.Add(this.lblNVDT);
            this.tabNhanVien.Controls.Add(this.txtNVDT);
            this.tabNhanVien.Controls.Add(this.lblNVChucVu);
            this.tabNhanVien.Controls.Add(this.txtNVChucVu);
            this.tabNhanVien.Controls.Add(this.btnNVThem);
            this.tabNhanVien.Controls.Add(this.btnNVSua);
            this.tabNhanVien.Controls.Add(this.btnNVXoa);
            this.tabNhanVien.Controls.Add(this.btnNVLamMoi);

            //
            // frmDanhMuc
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.tabControl);
            this.Name = "frmDanhMuc";
            this.Text = "Quan ly Danh muc";
            this.Load += new System.EventHandler(this.frmDanhMuc_Load);
            this.tabControl.ResumeLayout(false);
            this.tabSanPham.ResumeLayout(false);
            this.tabSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.tabKhachHang.ResumeLayout(false);
            this.tabKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.tabNhanVien.ResumeLayout(false);
            this.tabNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;

        private System.Windows.Forms.TabPage tabSanPham;
        private System.Windows.Forms.Label lblSPTimKiem;
        private System.Windows.Forms.TextBox txtSPTimKiem;
        private System.Windows.Forms.Button btnSPTimKiem;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.Label lblSPMa;
        private System.Windows.Forms.TextBox txtSPMa;
        private System.Windows.Forms.Label lblSPTen;
        private System.Windows.Forms.TextBox txtSPTen;
        private System.Windows.Forms.Label lblSPGia;
        private System.Windows.Forms.TextBox txtSPGia;
        private System.Windows.Forms.Label lblSPSL;
        private System.Windows.Forms.TextBox txtSPSL;
        private System.Windows.Forms.Button btnSPThem;
        private System.Windows.Forms.Button btnSPSua;
        private System.Windows.Forms.Button btnSPXoa;
        private System.Windows.Forms.Button btnSPLamMoi;

        private System.Windows.Forms.TabPage tabKhachHang;
        private System.Windows.Forms.Label lblKHTimKiem;
        private System.Windows.Forms.TextBox txtKHTimKiem;
        private System.Windows.Forms.Button btnKHTimKiem;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Label lblKHTen;
        private System.Windows.Forms.TextBox txtKHTen;
        private System.Windows.Forms.Label lblKHDT;
        private System.Windows.Forms.TextBox txtKHDT;
        private System.Windows.Forms.Button btnKHThem;
        private System.Windows.Forms.Button btnKHSua;
        private System.Windows.Forms.Button btnKHXoa;
        private System.Windows.Forms.Button btnKHLamMoi;

        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.Label lblNVTen;
        private System.Windows.Forms.TextBox txtNVTen;
        private System.Windows.Forms.Label lblNVDT;
        private System.Windows.Forms.TextBox txtNVDT;
        private System.Windows.Forms.Label lblNVChucVu;
        private System.Windows.Forms.TextBox txtNVChucVu;
        private System.Windows.Forms.Button btnNVThem;
        private System.Windows.Forms.Button btnNVSua;
        private System.Windows.Forms.Button btnNVXoa;
        private System.Windows.Forms.Button btnNVLamMoi;
    }
}
