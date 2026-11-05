namespace Market.GUI
{
    partial class frmBanHang
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
            this.lblNV = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.lblKH = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemVaoGio = new System.Windows.Forms.Button();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.btnXoaDong = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnLamMoiGio = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.SuspendLayout();

            //
            // lblNV
            //
            this.lblNV.Text = "Nhan vien ban:";
            this.lblNV.Location = new System.Drawing.Point(10, 15);
            this.lblNV.Size = new System.Drawing.Size(100, 23);
            //
            // cboNhanVien
            //
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.Location = new System.Drawing.Point(115, 12);
            this.cboNhanVien.Size = new System.Drawing.Size(220, 23);
            //
            // lblKH
            //
            this.lblKH.Text = "Khach hang:";
            this.lblKH.Location = new System.Drawing.Point(360, 15);
            this.lblKH.Size = new System.Drawing.Size(90, 23);
            //
            // cboKhachHang
            //
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.Location = new System.Drawing.Point(455, 12);
            this.cboKhachHang.Size = new System.Drawing.Size(220, 23);
            //
            // lblMaSP
            //
            this.lblMaSP.Text = "Ma SP:";
            this.lblMaSP.Location = new System.Drawing.Point(10, 55);
            this.lblMaSP.Size = new System.Drawing.Size(60, 23);
            //
            // txtMaSP
            //
            this.txtMaSP.Location = new System.Drawing.Point(75, 52);
            this.txtMaSP.Size = new System.Drawing.Size(150, 23);
            this.txtMaSP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaSP_KeyDown);
            //
            // lblSoLuong
            //
            this.lblSoLuong.Text = "So luong:";
            this.lblSoLuong.Location = new System.Drawing.Point(240, 55);
            this.lblSoLuong.Size = new System.Drawing.Size(65, 23);
            //
            // nudSoLuong
            //
            this.nudSoLuong.Location = new System.Drawing.Point(310, 52);
            this.nudSoLuong.Size = new System.Drawing.Size(80, 23);
            this.nudSoLuong.Minimum = 1;
            this.nudSoLuong.Maximum = 10000;
            this.nudSoLuong.Value = 1;
            //
            // btnThemVaoGio
            //
            this.btnThemVaoGio.Text = "Them vao gio hang";
            this.btnThemVaoGio.Location = new System.Drawing.Point(410, 51);
            this.btnThemVaoGio.Size = new System.Drawing.Size(160, 25);
            this.btnThemVaoGio.Click += new System.EventHandler(this.btnThemVaoGio_Click);
            //
            // dgvGioHang
            //
            this.dgvGioHang.Location = new System.Drawing.Point(10, 95);
            this.dgvGioHang.Size = new System.Drawing.Size(900, 330);
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.AllowUserToAddRows = false;
            //
            // btnXoaDong
            //
            this.btnXoaDong.Text = "Xoa dong da chon";
            this.btnXoaDong.Location = new System.Drawing.Point(10, 435);
            this.btnXoaDong.Size = new System.Drawing.Size(150, 30);
            this.btnXoaDong.Click += new System.EventHandler(this.btnXoaDong_Click);
            //
            // lblTongTien
            //
            this.lblTongTien.Text = "Tong tien: 0 d";
            this.lblTongTien.Location = new System.Drawing.Point(600, 440);
            this.lblTongTien.Size = new System.Drawing.Size(300, 30);
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // btnThanhToan
            //
            this.btnThanhToan.Text = "THANH TOAN";
            this.btnThanhToan.Location = new System.Drawing.Point(10, 480);
            this.btnThanhToan.Size = new System.Drawing.Size(180, 40);
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            //
            // btnLamMoiGio
            //
            this.btnLamMoiGio.Text = "Lam moi gio hang";
            this.btnLamMoiGio.Location = new System.Drawing.Point(200, 480);
            this.btnLamMoiGio.Size = new System.Drawing.Size(150, 40);
            this.btnLamMoiGio.Click += new System.EventHandler(this.btnLamMoiGio_Click);

            //
            // frmBanHang
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.lblNV);
            this.Controls.Add(this.cboNhanVien);
            this.Controls.Add(this.lblKH);
            this.Controls.Add(this.cboKhachHang);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.btnThemVaoGio);
            this.Controls.Add(this.dgvGioHang);
            this.Controls.Add(this.btnXoaDong);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnLamMoiGio);
            this.Name = "frmBanHang";
            this.Text = "Man hinh Ban hang";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label lblKH;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Button btnThemVaoGio;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Button btnXoaDong;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnLamMoiGio;
    }
}
