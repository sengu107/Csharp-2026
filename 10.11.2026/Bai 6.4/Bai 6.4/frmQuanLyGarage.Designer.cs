using System;
using System.Windows.Forms;
namespace Bai_6._4
{
partial class frmQuanLyGarage : Form
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlGarage = new TabControl();
            tabTiepNhan = new TabPage();
            dgvXeKhach = new DataGridView();
            gbThongTin = new GroupBox();
            btnLuuXeKhach = new Button();
            txtNamSX = new TextBox();
            txtHieuXe = new TextBox();
            txtBienSoMoi = new TextBox();
            txtDiaChi = new TextBox();
            txtDienThoai = new TextBox();
            txtTenKH = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gbTraCuu = new GroupBox();
            btnTraCuu = new Button();
            txtTraCuuBienSo = new TextBox();
            tabKhoPhuTung = new TabPage();
            dgvPhuTung = new DataGridView();
            gbQuanLyPT = new GroupBox();
            btnXoaPT = new Button();
            btnSuaPT = new Button();
            btnThemPT = new Button();
            txtSoLuongTonPT = new TextBox();
            txtDonGiaPT = new TextBox();
            txtTenPT = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            tabPhieuSuaChua = new TabPage();
            dgvDanhSachPhieu = new DataGridView();
            gbLapPhieu = new GroupBox();
            btnThanhToan = new Button();
            btnLapPhieuTransaction = new Button();
            lblTongTienValue = new Label();
            lblTong = new Label();
            dgvChiTietPhieu = new DataGridView();
            gbChiTiet = new GroupBox();
            btnThemChiTiet = new Button();
            txtTienCong = new TextBox();
            label13 = new Label();
            nudSoLuongPT = new NumericUpDown();
            label12 = new Label();
            cbChonPhuTung = new ComboBox();
            label11 = new Label();
            txtNoiDungSua = new TextBox();
            label10 = new Label();
            txtBienSoPhieu = new TextBox();
            label14 = new Label();
            btnSuaXe = new Button();
            btnXoaXe = new Button();
            tabControlGarage.SuspendLayout();
            tabTiepNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvXeKhach).BeginInit();
            gbThongTin.SuspendLayout();
            gbTraCuu.SuspendLayout();
            tabKhoPhuTung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhuTung).BeginInit();
            gbQuanLyPT.SuspendLayout();
            tabPhieuSuaChua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachPhieu).BeginInit();
            gbLapPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieu).BeginInit();
            gbChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuongPT).BeginInit();
            SuspendLayout();
            // 
            // tabControlGarage
            // 
            tabControlGarage.Controls.Add(tabTiepNhan);
            tabControlGarage.Controls.Add(tabKhoPhuTung);
            tabControlGarage.Controls.Add(tabPhieuSuaChua);
            tabControlGarage.Dock = DockStyle.Fill;
            tabControlGarage.Location = new Point(0, 0);
            tabControlGarage.Margin = new Padding(3, 4, 3, 4);
            tabControlGarage.Name = "tabControlGarage";
            tabControlGarage.SelectedIndex = 0;
            tabControlGarage.Size = new Size(1639, 938);
            tabControlGarage.TabIndex = 0;
            // 
            // tabTiepNhan
            // 
            tabTiepNhan.Controls.Add(dgvXeKhach);
            tabTiepNhan.Controls.Add(gbThongTin);
            tabTiepNhan.Controls.Add(gbTraCuu);
            tabTiepNhan.Location = new Point(4, 29);
            tabTiepNhan.Margin = new Padding(3, 4, 3, 4);
            tabTiepNhan.Name = "tabTiepNhan";
            tabTiepNhan.Padding = new Padding(3, 4, 3, 4);
            tabTiepNhan.Size = new Size(1631, 905);
            tabTiepNhan.TabIndex = 0;
            tabTiepNhan.Text = "1. Tiếp Nhận Xe & Khách Hàng";
            tabTiepNhan.UseVisualStyleBackColor = true;
            // 
            // dgvXeKhach
            // 
            dgvXeKhach.BackgroundColor = SystemColors.ButtonHighlight;
            dgvXeKhach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvXeKhach.Location = new Point(480, 19);
            dgvXeKhach.Margin = new Padding(3, 4, 3, 4);
            dgvXeKhach.Name = "dgvXeKhach";
            dgvXeKhach.RowHeadersWidth = 51;
            dgvXeKhach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvXeKhach.Size = new Size(1143, 812);
            dgvXeKhach.TabIndex = 2;
            // 
            // gbThongTin
            // 
            gbThongTin.Controls.Add(btnXoaXe);
            gbThongTin.Controls.Add(btnSuaXe);
            gbThongTin.Controls.Add(btnLuuXeKhach);
            gbThongTin.Controls.Add(txtNamSX);
            gbThongTin.Controls.Add(txtHieuXe);
            gbThongTin.Controls.Add(txtBienSoMoi);
            gbThongTin.Controls.Add(txtDiaChi);
            gbThongTin.Controls.Add(txtDienThoai);
            gbThongTin.Controls.Add(txtTenKH);
            gbThongTin.Controls.Add(label6);
            gbThongTin.Controls.Add(label5);
            gbThongTin.Controls.Add(label4);
            gbThongTin.Controls.Add(label3);
            gbThongTin.Controls.Add(label2);
            gbThongTin.Controls.Add(label1);
            gbThongTin.Location = new Point(15, 131);
            gbThongTin.Margin = new Padding(3, 4, 3, 4);
            gbThongTin.Name = "gbThongTin";
            gbThongTin.Padding = new Padding(3, 4, 3, 4);
            gbThongTin.Size = new Size(450, 700);
            gbThongTin.TabIndex = 1;
            gbThongTin.TabStop = false;
            gbThongTin.Text = "Thông tin Khách hàng và Xe mới";
            // 
            // btnLuuXeKhach
            // 
            btnLuuXeKhach.BackColor = Color.LightGreen;
            btnLuuXeKhach.Location = new Point(20, 412);
            btnLuuXeKhach.Margin = new Padding(3, 4, 3, 4);
            btnLuuXeKhach.Name = "btnLuuXeKhach";
            btnLuuXeKhach.Size = new Size(114, 50);
            btnLuuXeKhach.TabIndex = 12;
            btnLuuXeKhach.Text = "Lưu Khách và Xe Mới";
            btnLuuXeKhach.UseVisualStyleBackColor = false;
            // 
            // txtNamSX
            // 
            txtNamSX.Location = new Point(130, 350);
            txtNamSX.Margin = new Padding(3, 4, 3, 4);
            txtNamSX.Name = "txtNamSX";
            txtNamSX.Size = new Size(290, 27);
            txtNamSX.TabIndex = 11;
            // 
            // txtHieuXe
            // 
            txtHieuXe.Location = new Point(130, 288);
            txtHieuXe.Margin = new Padding(3, 4, 3, 4);
            txtHieuXe.Name = "txtHieuXe";
            txtHieuXe.Size = new Size(290, 27);
            txtHieuXe.TabIndex = 10;
            // 
            // txtBienSoMoi
            // 
            txtBienSoMoi.Location = new Point(130, 225);
            txtBienSoMoi.Margin = new Padding(3, 4, 3, 4);
            txtBienSoMoi.Name = "txtBienSoMoi";
            txtBienSoMoi.Size = new Size(290, 27);
            txtBienSoMoi.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(130, 162);
            txtDiaChi.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(290, 27);
            txtDiaChi.TabIndex = 8;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(130, 100);
            txtDienThoai.Margin = new Padding(3, 4, 3, 4);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(290, 27);
            txtDienThoai.TabIndex = 7;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(130, 38);
            txtTenKH.Margin = new Padding(3, 4, 3, 4);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(290, 27);
            txtTenKH.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 354);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 5;
            label6.Text = "Năm sản xuất:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 291);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "Hiệu xe:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 229);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "Biển số:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 166);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 104);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "Điện thoại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 41);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Khách hàng:";
            // 
            // gbTraCuu
            // 
            gbTraCuu.Controls.Add(btnTraCuu);
            gbTraCuu.Controls.Add(txtTraCuuBienSo);
            gbTraCuu.Location = new Point(15, 19);
            gbTraCuu.Margin = new Padding(3, 4, 3, 4);
            gbTraCuu.Name = "gbTraCuu";
            gbTraCuu.Padding = new Padding(3, 4, 3, 4);
            gbTraCuu.Size = new Size(450, 100);
            gbTraCuu.TabIndex = 0;
            gbTraCuu.TabStop = false;
            gbTraCuu.Text = "Tra cứu Biển số";
            // 
            // btnTraCuu
            // 
            btnTraCuu.Location = new Point(325, 41);
            btnTraCuu.Margin = new Padding(3, 4, 3, 4);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(100, 38);
            btnTraCuu.TabIndex = 1;
            btnTraCuu.Text = "Tra cứu";
            btnTraCuu.UseVisualStyleBackColor = true;
            // 
            // txtTraCuuBienSo
            // 
            txtTraCuuBienSo.Font = new Font("Microsoft Sans Serif", 10F);
            txtTraCuuBienSo.Location = new Point(15, 44);
            txtTraCuuBienSo.Margin = new Padding(3, 4, 3, 4);
            txtTraCuuBienSo.Name = "txtTraCuuBienSo";
            txtTraCuuBienSo.Size = new Size(300, 26);
            txtTraCuuBienSo.TabIndex = 0;
            // 
            // tabKhoPhuTung
            // 
            tabKhoPhuTung.Controls.Add(dgvPhuTung);
            tabKhoPhuTung.Controls.Add(gbQuanLyPT);
            tabKhoPhuTung.Location = new Point(4, 29);
            tabKhoPhuTung.Margin = new Padding(3, 4, 3, 4);
            tabKhoPhuTung.Name = "tabKhoPhuTung";
            tabKhoPhuTung.Padding = new Padding(3, 4, 3, 4);
            tabKhoPhuTung.Size = new Size(1631, 905);
            tabKhoPhuTung.TabIndex = 1;
            tabKhoPhuTung.Text = "2. Quản Lý Kho Phụ Tùng";
            tabKhoPhuTung.UseVisualStyleBackColor = true;
            // 
            // dgvPhuTung
            // 
            dgvPhuTung.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPhuTung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhuTung.Location = new Point(430, 19);
            dgvPhuTung.Margin = new Padding(3, 4, 3, 4);
            dgvPhuTung.Name = "dgvPhuTung";
            dgvPhuTung.RowHeadersWidth = 51;
            dgvPhuTung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhuTung.Size = new Size(1193, 812);
            dgvPhuTung.TabIndex = 1;
            // 
            // gbQuanLyPT
            // 
            gbQuanLyPT.Controls.Add(btnXoaPT);
            gbQuanLyPT.Controls.Add(btnSuaPT);
            gbQuanLyPT.Controls.Add(btnThemPT);
            gbQuanLyPT.Controls.Add(txtSoLuongTonPT);
            gbQuanLyPT.Controls.Add(txtDonGiaPT);
            gbQuanLyPT.Controls.Add(txtTenPT);
            gbQuanLyPT.Controls.Add(label9);
            gbQuanLyPT.Controls.Add(label8);
            gbQuanLyPT.Controls.Add(label7);
            gbQuanLyPT.Location = new Point(15, 19);
            gbQuanLyPT.Margin = new Padding(3, 4, 3, 4);
            gbQuanLyPT.Name = "gbQuanLyPT";
            gbQuanLyPT.Padding = new Padding(3, 4, 3, 4);
            gbQuanLyPT.Size = new Size(400, 812);
            gbQuanLyPT.TabIndex = 0;
            gbQuanLyPT.TabStop = false;
            gbQuanLyPT.Text = "Thông tin Phụ tùng";
            // 
            // btnXoaPT
            // 
            btnXoaPT.ForeColor = Color.Red;
            btnXoaPT.Location = new Point(260, 262);
            btnXoaPT.Margin = new Padding(3, 4, 3, 4);
            btnXoaPT.Name = "btnXoaPT";
            btnXoaPT.Size = new Size(110, 44);
            btnXoaPT.TabIndex = 8;
            btnXoaPT.Text = "Xóa";
            btnXoaPT.UseVisualStyleBackColor = true;
            btnXoaPT.Click += BtnXoaPT_Click;
            // 
            // btnSuaPT
            // 
            btnSuaPT.Location = new Point(140, 262);
            btnSuaPT.Margin = new Padding(3, 4, 3, 4);
            btnSuaPT.Name = "btnSuaPT";
            btnSuaPT.Size = new Size(100, 44);
            btnSuaPT.TabIndex = 7;
            btnSuaPT.Text = "Cập nhật";
            btnSuaPT.UseVisualStyleBackColor = true;
            btnSuaPT.Click += BtnSuaPT_Click;
            // 
            // btnThemPT
            // 
            btnThemPT.Location = new Point(20, 262);
            btnThemPT.Margin = new Padding(3, 4, 3, 4);
            btnThemPT.Name = "btnThemPT";
            btnThemPT.Size = new Size(100, 44);
            btnThemPT.TabIndex = 6;
            btnThemPT.Text = "Thêm mới";
            btnThemPT.UseVisualStyleBackColor = true;
            // 
            // txtSoLuongTonPT
            // 
            txtSoLuongTonPT.Location = new Point(120, 171);
            txtSoLuongTonPT.Margin = new Padding(3, 4, 3, 4);
            txtSoLuongTonPT.Name = "txtSoLuongTonPT";
            txtSoLuongTonPT.Size = new Size(250, 27);
            txtSoLuongTonPT.TabIndex = 5;
            // 
            // txtDonGiaPT
            // 
            txtDonGiaPT.Location = new Point(120, 109);
            txtDonGiaPT.Margin = new Padding(3, 4, 3, 4);
            txtDonGiaPT.Name = "txtDonGiaPT";
            txtDonGiaPT.Size = new Size(250, 27);
            txtDonGiaPT.TabIndex = 4;
            // 
            // txtTenPT
            // 
            txtTenPT.Location = new Point(120, 46);
            txtTenPT.Margin = new Padding(3, 4, 3, 4);
            txtTenPT.Name = "txtTenPT";
            txtTenPT.Size = new Size(250, 27);
            txtTenPT.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 175);
            label9.Name = "label9";
            label9.Size = new Size(98, 20);
            label9.TabIndex = 2;
            label9.Text = "Số lượng tồn:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 112);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 1;
            label8.Text = "Đơn giá:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 50);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 0;
            label7.Text = "Tên phụ tùng:";
            // 
            // tabPhieuSuaChua
            // 
            tabPhieuSuaChua.Controls.Add(dgvDanhSachPhieu);
            tabPhieuSuaChua.Controls.Add(gbLapPhieu);
            tabPhieuSuaChua.Location = new Point(4, 29);
            tabPhieuSuaChua.Margin = new Padding(3, 4, 3, 4);
            tabPhieuSuaChua.Name = "tabPhieuSuaChua";
            tabPhieuSuaChua.Padding = new Padding(3, 4, 3, 4);
            tabPhieuSuaChua.Size = new Size(1631, 905);
            tabPhieuSuaChua.TabIndex = 2;
            tabPhieuSuaChua.Text = "3. Lập Phiếu & Thanh Toán (Transaction)";
            tabPhieuSuaChua.UseVisualStyleBackColor = true;
            // 
            // dgvDanhSachPhieu
            // 
            dgvDanhSachPhieu.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDanhSachPhieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachPhieu.Location = new Point(580, 19);
            dgvDanhSachPhieu.Margin = new Padding(3, 4, 3, 4);
            dgvDanhSachPhieu.Name = "dgvDanhSachPhieu";
            dgvDanhSachPhieu.RowHeadersWidth = 51;
            dgvDanhSachPhieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachPhieu.Size = new Size(1026, 812);
            dgvDanhSachPhieu.TabIndex = 1;
            // 
            // gbLapPhieu
            // 
            gbLapPhieu.Controls.Add(btnThanhToan);
            gbLapPhieu.Controls.Add(btnLapPhieuTransaction);
            gbLapPhieu.Controls.Add(lblTongTienValue);
            gbLapPhieu.Controls.Add(lblTong);
            gbLapPhieu.Controls.Add(dgvChiTietPhieu);
            gbLapPhieu.Controls.Add(gbChiTiet);
            gbLapPhieu.Controls.Add(txtNoiDungSua);
            gbLapPhieu.Controls.Add(label10);
            gbLapPhieu.Controls.Add(txtBienSoPhieu);
            gbLapPhieu.Controls.Add(label14);
            gbLapPhieu.Location = new Point(15, 19);
            gbLapPhieu.Margin = new Padding(3, 4, 3, 4);
            gbLapPhieu.Name = "gbLapPhieu";
            gbLapPhieu.Padding = new Padding(3, 4, 3, 4);
            gbLapPhieu.Size = new Size(550, 812);
            gbLapPhieu.TabIndex = 0;
            gbLapPhieu.TabStop = false;
            gbLapPhieu.Text = "Lập Phiếu Sửa Chữa ";
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.Cyan;
            btnThanhToan.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnThanhToan.Location = new Point(285, 650);
            btnThanhToan.Margin = new Padding(3, 4, 3, 4);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(240, 56);
            btnThanhToan.TabIndex = 9;
            btnThanhToan.Text = "Thanh Toán Hóa Đơn";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += BtnThanhToan_Click;
            // 
            // btnLapPhieuTransaction
            // 
            btnLapPhieuTransaction.BackColor = Color.Orange;
            btnLapPhieuTransaction.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnLapPhieuTransaction.Location = new Point(20, 650);
            btnLapPhieuTransaction.Margin = new Padding(3, 4, 3, 4);
            btnLapPhieuTransaction.Name = "btnLapPhieuTransaction";
            btnLapPhieuTransaction.Size = new Size(240, 56);
            btnLapPhieuTransaction.TabIndex = 8;
            btnLapPhieuTransaction.Text = "Lập Phiếu ";
            btnLapPhieuTransaction.UseVisualStyleBackColor = false;
            btnLapPhieuTransaction.Click += BtnLapPhieuTransaction_Click;
            // 
            // lblTongTienValue
            // 
            lblTongTienValue.AutoSize = true;
            lblTongTienValue.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblTongTienValue.ForeColor = Color.Blue;
            lblTongTienValue.Location = new Point(120, 600);
            lblTongTienValue.Name = "lblTongTienValue";
            lblTongTienValue.Size = new Size(63, 20);
            lblTongTienValue.TabIndex = 7;
            lblTongTienValue.Text = "0 VNĐ";
            // 
            // lblTong
            // 
            lblTong.AutoSize = true;
            lblTong.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblTong.Location = new Point(20, 600);
            lblTong.Name = "lblTong";
            lblTong.Size = new Size(93, 20);
            lblTong.TabIndex = 6;
            lblTong.Text = "Tổng tiền:";
            // 
            // dgvChiTietPhieu
            // 
            dgvChiTietPhieu.BackgroundColor = SystemColors.ButtonHighlight;
            dgvChiTietPhieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietPhieu.GridColor = SystemColors.HighlightText;
            dgvChiTietPhieu.Location = new Point(20, 356);
            dgvChiTietPhieu.Margin = new Padding(3, 4, 3, 4);
            dgvChiTietPhieu.Name = "dgvChiTietPhieu";
            dgvChiTietPhieu.RowHeadersWidth = 51;
            dgvChiTietPhieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietPhieu.Size = new Size(505, 225);
            dgvChiTietPhieu.TabIndex = 5;
            // 
            // gbChiTiet
            // 
            gbChiTiet.Controls.Add(btnThemChiTiet);
            gbChiTiet.Controls.Add(txtTienCong);
            gbChiTiet.Controls.Add(label13);
            gbChiTiet.Controls.Add(nudSoLuongPT);
            gbChiTiet.Controls.Add(label12);
            gbChiTiet.Controls.Add(cbChonPhuTung);
            gbChiTiet.Controls.Add(label11);
            gbChiTiet.Location = new Point(20, 169);
            gbChiTiet.Margin = new Padding(3, 4, 3, 4);
            gbChiTiet.Name = "gbChiTiet";
            gbChiTiet.Padding = new Padding(3, 4, 3, 4);
            gbChiTiet.Size = new Size(505, 175);
            gbChiTiet.TabIndex = 4;
            gbChiTiet.TabStop = false;
            gbChiTiet.Text = "Thêm phụ tùng thay thế và Tiền công";
            // 
            // btnThemChiTiet
            // 
            btnThemChiTiet.Location = new Point(360, 81);
            btnThemChiTiet.Margin = new Padding(3, 4, 3, 4);
            btnThemChiTiet.Name = "btnThemChiTiet";
            btnThemChiTiet.Size = new Size(130, 38);
            btnThemChiTiet.TabIndex = 6;
            btnThemChiTiet.Text = "Thêm vào phiếu";
            btnThemChiTiet.UseVisualStyleBackColor = true;
            // 
            // txtTienCong
            // 
            txtTienCong.Location = new Point(270, 84);
            txtTienCong.Margin = new Padding(3, 4, 3, 4);
            txtTienCong.Name = "txtTienCong";
            txtTienCong.Size = new Size(70, 27);
            txtTienCong.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(200, 88);
            label13.Name = "label13";
            label13.Size = new Size(77, 20);
            label13.TabIndex = 4;
            label13.Text = "Tiền công:";
            // 
            // nudSoLuongPT
            // 
            nudSoLuongPT.Location = new Point(90, 84);
            nudSoLuongPT.Margin = new Padding(3, 4, 3, 4);
            nudSoLuongPT.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuongPT.Name = "nudSoLuongPT";
            nudSoLuongPT.Size = new Size(90, 27);
            nudSoLuongPT.TabIndex = 3;
            nudSoLuongPT.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 88);
            label12.Name = "label12";
            label12.Size = new Size(72, 20);
            label12.TabIndex = 2;
            label12.Text = "Số lượng:";
            // 
            // cbChonPhuTung
            // 
            cbChonPhuTung.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChonPhuTung.FormattingEnabled = true;
            cbChonPhuTung.Location = new Point(90, 34);
            cbChonPhuTung.Margin = new Padding(3, 4, 3, 4);
            cbChonPhuTung.Name = "cbChonPhuTung";
            cbChonPhuTung.Size = new Size(250, 28);
            cbChonPhuTung.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 38);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 0;
            label11.Text = "Phụ tùng:";
            // 
            // txtNoiDungSua
            // 
            txtNoiDungSua.Location = new Point(120, 84);
            txtNoiDungSua.Margin = new Padding(3, 4, 3, 4);
            txtNoiDungSua.Multiline = true;
            txtNoiDungSua.Name = "txtNoiDungSua";
            txtNoiDungSua.Size = new Size(400, 62);
            txtNoiDungSua.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 88);
            label10.Name = "label10";
            label10.Size = new Size(101, 20);
            label10.TabIndex = 2;
            label10.Text = "Nội dung sửa:";
            // 
            // txtBienSoPhieu
            // 
            txtBienSoPhieu.Location = new Point(120, 34);
            txtBienSoPhieu.Margin = new Padding(3, 4, 3, 4);
            txtBienSoPhieu.Name = "txtBienSoPhieu";
            txtBienSoPhieu.Size = new Size(180, 27);
            txtBienSoPhieu.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(20, 38);
            label14.Name = "label14";
            label14.Size = new Size(60, 20);
            label14.TabIndex = 0;
            label14.Text = "Biển số:";
            // 
            // btnSuaXe
            // 
            btnSuaXe.BackColor = Color.LightGreen;
            btnSuaXe.Location = new Point(152, 412);
            btnSuaXe.Margin = new Padding(3, 4, 3, 4);
            btnSuaXe.Name = "btnSuaXe";
            btnSuaXe.Size = new Size(106, 50);
            btnSuaXe.TabIndex = 13;
            btnSuaXe.Text = "Sửa Thông Tin";
            btnSuaXe.UseVisualStyleBackColor = false;
            // 
            // btnXoaXe
            // 
            btnXoaXe.BackColor = Color.Red;
            btnXoaXe.Location = new Point(284, 412);
            btnXoaXe.Margin = new Padding(3, 4, 3, 4);
            btnXoaXe.Name = "btnXoaXe";
            btnXoaXe.Size = new Size(106, 50);
            btnXoaXe.TabIndex = 14;
            btnXoaXe.Text = "Xoá ";
            btnXoaXe.UseVisualStyleBackColor = false;
            // 
            // frmQuanLyGarage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1639, 938);
            Controls.Add(tabControlGarage);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmQuanLyGarage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý Garage và Bảo dưỡng ô tô";
            tabControlGarage.ResumeLayout(false);
            tabTiepNhan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvXeKhach).EndInit();
            gbThongTin.ResumeLayout(false);
            gbThongTin.PerformLayout();
            gbTraCuu.ResumeLayout(false);
            gbTraCuu.PerformLayout();
            tabKhoPhuTung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhuTung).EndInit();
            gbQuanLyPT.ResumeLayout(false);
            gbQuanLyPT.PerformLayout();
            tabPhieuSuaChua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachPhieu).EndInit();
            gbLapPhieu.ResumeLayout(false);
            gbLapPhieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieu).EndInit();
            gbChiTiet.ResumeLayout(false);
            gbChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuongPT).EndInit();
            ResumeLayout(false);

        }

        #region Private Control Declarations
        private System.Windows.Forms.TabControl tabControlGarage;
    private System.Windows.Forms.TabPage tabTiepNhan;
    private System.Windows.Forms.TabPage tabKhoPhuTung;
    private System.Windows.Forms.TabPage tabPhieuSuaChua;
    private System.Windows.Forms.GroupBox gbTraCuu;
    private System.Windows.Forms.Button btnTraCuu;
    private System.Windows.Forms.TextBox txtTraCuuBienSo;
    private System.Windows.Forms.GroupBox gbThongTin;
    private System.Windows.Forms.Button btnLuuXeKhach;
    private System.Windows.Forms.TextBox txtNamSX;
    private System.Windows.Forms.TextBox txtHieuXe;
    private System.Windows.Forms.TextBox txtBienSoMoi;
    private System.Windows.Forms.TextBox txtDiaChi;
    private System.Windows.Forms.TextBox txtDienThoai;
    private System.Windows.Forms.TextBox txtTenKH;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView dgvXeKhach;
    private System.Windows.Forms.GroupBox gbQuanLyPT;
    private System.Windows.Forms.Button btnXoaPT;
    private System.Windows.Forms.Button btnSuaPT;
    private System.Windows.Forms.Button btnThemPT;
    private System.Windows.Forms.TextBox txtSoLuongTonPT;
    private System.Windows.Forms.TextBox txtDonGiaPT;
    private System.Windows.Forms.TextBox txtTenPT;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.DataGridView dgvPhuTung;
    private System.Windows.Forms.GroupBox gbLapPhieu;
    private System.Windows.Forms.Button btnThanhToan;
    private System.Windows.Forms.Button btnLapPhieuTransaction;
    private System.Windows.Forms.Label lblTongTienValue;
    private System.Windows.Forms.Label lblTong;
    private System.Windows.Forms.DataGridView dgvChiTietPhieu;
    private System.Windows.Forms.GroupBox gbChiTiet;
    private System.Windows.Forms.Button btnThemChiTiet;
    private System.Windows.Forms.TextBox txtTienCong;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.NumericUpDown nudSoLuongPT;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.ComboBox cbChonPhuTung;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox txtNoiDungSua;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox txtBienSoPhieu;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.DataGridView dgvDanhSachPhieu;

        #endregion
        #endregion

        private Button btnXoaXe;
        private Button btnSuaXe;
    }
}
