partial class FrmQuanLyTask
{
    private System.ComponentModel.IContainer components = null;

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
        label1 = new Label();
        cbDuAn = new ComboBox();
        label2 = new Label();
        cbTrangThaiFilter = new ComboBox();
        gbDuAn = new GroupBox();
        lblTenDuAn = new Label();
        txtTenDuAn = new TextBox();
        lblNgayBD = new Label();
        dtpBatDau = new DateTimePicker();
        lblNgayKT = new Label();
        dtpKetThuc = new DateTimePicker();
        lblTTDuAn = new Label();
        cbTrangThaiDuAn = new ComboBox();
        btnThemDuAn = new Button();
        gbTask = new GroupBox();
        lblTenTask = new Label();
        txtTenTask = new TextBox();
        lblMoTa = new Label();
        txtMoTa = new TextBox();
        lblHanNop = new Label();
        dtpHanNop = new DateTimePicker();
        lblDoUuTien = new Label();
        cbDoUuTien = new ComboBox();
        btnThemTask = new Button();
        lblThanhVien = new Label();
        cbThanhVien = new ComboBox();
        btnPhanCong = new Button();
        dgvTasks = new DataGridView();
        dgvThongKe = new DataGridView();
        btnDone = new Button();
        btnBaoCaoTreHan = new Button();
        label3 = new Label();
        label4 = new Label();
        gbDuAn.SuspendLayout();
        gbTask.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(20, 20);
        label1.Name = "label1";
        label1.Size = new Size(92, 20);
        label1.TabIndex = 14;
        label1.Text = "Chọn Dự Án:";
        // 
        // cbDuAn
        // 
        cbDuAn.FormattingEnabled = true;
        cbDuAn.Location = new Point(120, 17);
        cbDuAn.Name = "cbDuAn";
        cbDuAn.Size = new Size(250, 28);
        cbDuAn.TabIndex = 13;
        cbDuAn.SelectedIndexChanged += cbDuAn_SelectedIndexChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(400, 20);
        label2.Name = "label2";
        label2.Size = new Size(108, 20);
        label2.TabIndex = 12;
        label2.Text = "Lọc Trạng Thái:";
        // 
        // cbTrangThaiFilter
        // 
        cbTrangThaiFilter.FormattingEnabled = true;
        cbTrangThaiFilter.Location = new Point(506, 17);
        cbTrangThaiFilter.Name = "cbTrangThaiFilter";
        cbTrangThaiFilter.Size = new Size(150, 28);
        cbTrangThaiFilter.TabIndex = 11;
        cbTrangThaiFilter.SelectedIndexChanged += cbTrangThaiFilter_SelectedIndexChanged;
        // 
        // gbDuAn
        // 
        gbDuAn.Controls.Add(lblTenDuAn);
        gbDuAn.Controls.Add(txtTenDuAn);
        gbDuAn.Controls.Add(lblNgayBD);
        gbDuAn.Controls.Add(dtpBatDau);
        gbDuAn.Controls.Add(lblNgayKT);
        gbDuAn.Controls.Add(dtpKetThuc);
        gbDuAn.Controls.Add(lblTTDuAn);
        gbDuAn.Controls.Add(cbTrangThaiDuAn);
        gbDuAn.Controls.Add(btnThemDuAn);
        gbDuAn.Location = new Point(20, 60);
        gbDuAn.Name = "gbDuAn";
        gbDuAn.Size = new Size(350, 250);
        gbDuAn.TabIndex = 10;
        gbDuAn.TabStop = false;
        gbDuAn.Text = "Thêm Dự Án Mới";
        // 
        // lblTenDuAn
        // 
        lblTenDuAn.AutoSize = true;
        lblTenDuAn.Location = new Point(15, 30);
        lblTenDuAn.Name = "lblTenDuAn";
        lblTenDuAn.Size = new Size(60, 20);
        lblTenDuAn.TabIndex = 0;
        lblTenDuAn.Text = "Tên DA:";
        // 
        // txtTenDuAn
        // 
        txtTenDuAn.Location = new Point(100, 27);
        txtTenDuAn.Name = "txtTenDuAn";
        txtTenDuAn.Size = new Size(230, 27);
        txtTenDuAn.TabIndex = 1;
        // 
        // lblNgayBD
        // 
        lblNgayBD.AutoSize = true;
        lblNgayBD.Location = new Point(15, 70);
        lblNgayBD.Name = "lblNgayBD";
        lblNgayBD.Size = new Size(71, 20);
        lblNgayBD.TabIndex = 2;
        lblNgayBD.Text = "Ngày BĐ:";
        // 
        // dtpBatDau
        // 
        dtpBatDau.Format = DateTimePickerFormat.Short;
        dtpBatDau.Location = new Point(100, 67);
        dtpBatDau.Name = "dtpBatDau";
        dtpBatDau.Size = new Size(230, 27);
        dtpBatDau.TabIndex = 3;
        // 
        // lblNgayKT
        // 
        lblNgayKT.AutoSize = true;
        lblNgayKT.Location = new Point(15, 110);
        lblNgayKT.Name = "lblNgayKT";
        lblNgayKT.Size = new Size(68, 20);
        lblNgayKT.TabIndex = 4;
        lblNgayKT.Text = "Ngày KT:";
        // 
        // dtpKetThuc
        // 
        dtpKetThuc.Format = DateTimePickerFormat.Short;
        dtpKetThuc.Location = new Point(100, 107);
        dtpKetThuc.Name = "dtpKetThuc";
        dtpKetThuc.Size = new Size(230, 27);
        dtpKetThuc.TabIndex = 5;
        // 
        // lblTTDuAn
        // 
        lblTTDuAn.AutoSize = true;
        lblTTDuAn.Location = new Point(15, 150);
        lblTTDuAn.Name = "lblTTDuAn";
        lblTTDuAn.Size = new Size(81, 20);
        lblTTDuAn.TabIndex = 6;
        lblTTDuAn.Text = "Trạng Thái:";
        // 
        // cbTrangThaiDuAn
        // 
        cbTrangThaiDuAn.Location = new Point(100, 147);
        cbTrangThaiDuAn.Name = "cbTrangThaiDuAn";
        cbTrangThaiDuAn.Size = new Size(230, 28);
        cbTrangThaiDuAn.TabIndex = 7;
        // 
        // btnThemDuAn
        // 
        btnThemDuAn.BackColor = Color.LightSkyBlue;
        btnThemDuAn.Location = new Point(100, 190);
        btnThemDuAn.Name = "btnThemDuAn";
        btnThemDuAn.Size = new Size(130, 35);
        btnThemDuAn.TabIndex = 8;
        btnThemDuAn.Text = "Thêm Dự Án";
        btnThemDuAn.UseVisualStyleBackColor = false;
        btnThemDuAn.Click += btnThemDuAn_Click;
        // 
        // gbTask
        // 
        gbTask.Controls.Add(lblTenTask);
        gbTask.Controls.Add(txtTenTask);
        gbTask.Controls.Add(lblMoTa);
        gbTask.Controls.Add(txtMoTa);
        gbTask.Controls.Add(lblHanNop);
        gbTask.Controls.Add(dtpHanNop);
        gbTask.Controls.Add(lblDoUuTien);
        gbTask.Controls.Add(cbDoUuTien);
        gbTask.Controls.Add(btnThemTask);
        gbTask.Location = new Point(390, 60);
        gbTask.Name = "gbTask";
        gbTask.Size = new Size(350, 250);
        gbTask.TabIndex = 9;
        gbTask.TabStop = false;
        gbTask.Text = "Tạo Công Việc (Task) Mới";
        // 
        // lblTenTask
        // 
        lblTenTask.AutoSize = true;
        lblTenTask.Location = new Point(15, 30);
        lblTenTask.Name = "lblTenTask";
        lblTenTask.Size = new Size(66, 20);
        lblTenTask.TabIndex = 0;
        lblTenTask.Text = "Tên Task:";
        // 
        // txtTenTask
        // 
        txtTenTask.Location = new Point(100, 27);
        txtTenTask.Name = "txtTenTask";
        txtTenTask.Size = new Size(230, 27);
        txtTenTask.TabIndex = 1;
        // 
        // lblMoTa
        // 
        lblMoTa.AutoSize = true;
        lblMoTa.Location = new Point(15, 70);
        lblMoTa.Name = "lblMoTa";
        lblMoTa.Size = new Size(54, 20);
        lblMoTa.TabIndex = 2;
        lblMoTa.Text = "Mô Tả:";
        // 
        // txtMoTa
        // 
        txtMoTa.Location = new Point(100, 67);
        txtMoTa.Name = "txtMoTa";
        txtMoTa.Size = new Size(230, 27);
        txtMoTa.TabIndex = 3;
        // 
        // lblHanNop
        // 
        lblHanNop.AutoSize = true;
        lblHanNop.Location = new Point(15, 110);
        lblHanNop.Name = "lblHanNop";
        lblHanNop.Size = new Size(72, 20);
        lblHanNop.TabIndex = 4;
        lblHanNop.Text = "Hạn Nộp:";
        // 
        // dtpHanNop
        // 
        dtpHanNop.Format = DateTimePickerFormat.Short;
        dtpHanNop.Location = new Point(100, 107);
        dtpHanNop.Name = "dtpHanNop";
        dtpHanNop.Size = new Size(230, 27);
        dtpHanNop.TabIndex = 5;
        // 
        // lblDoUuTien
        // 
        lblDoUuTien.AutoSize = true;
        lblDoUuTien.Location = new Point(15, 150);
        lblDoUuTien.Name = "lblDoUuTien";
        lblDoUuTien.Size = new Size(63, 20);
        lblDoUuTien.TabIndex = 6;
        lblDoUuTien.Text = "Ưu Tiên:";
        // 
        // cbDoUuTien
        // 
        cbDoUuTien.Location = new Point(100, 147);
        cbDoUuTien.Name = "cbDoUuTien";
        cbDoUuTien.Size = new Size(230, 28);
        cbDoUuTien.TabIndex = 7;
        // 
        // btnThemTask
        // 
        btnThemTask.BackColor = Color.LightGreen;
        btnThemTask.Location = new Point(100, 190);
        btnThemTask.Name = "btnThemTask";
        btnThemTask.Size = new Size(130, 35);
        btnThemTask.TabIndex = 8;
        btnThemTask.Text = "Thêm Task";
        btnThemTask.UseVisualStyleBackColor = false;
        btnThemTask.Click += btnThemTask_Click;
        // 
        // lblThanhVien
        // 
        lblThanhVien.AutoSize = true;
        lblThanhVien.Location = new Point(760, 75);
        lblThanhVien.Name = "lblThanhVien";
        lblThanhVien.Size = new Size(147, 20);
        lblThanhVien.TabIndex = 8;
        lblThanhVien.Text = "Thành viên giao việc:";
        // 
        // cbThanhVien
        // 
        cbThanhVien.FormattingEnabled = true;
        cbThanhVien.Location = new Point(760, 100);
        cbThanhVien.Name = "cbThanhVien";
        cbThanhVien.Size = new Size(200, 28);
        cbThanhVien.TabIndex = 7;
        // 
        // btnPhanCong
        // 
        btnPhanCong.BackColor = Color.Khaki;
        btnPhanCong.Location = new Point(760, 140);
        btnPhanCong.Name = "btnPhanCong";
        btnPhanCong.Size = new Size(200, 35);
        btnPhanCong.TabIndex = 6;
        btnPhanCong.Text = "Phân Công Task";
        btnPhanCong.UseVisualStyleBackColor = false;
        btnPhanCong.Click += btnPhanCong_Click;
        // 
        // dgvTasks
        // 
        dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvTasks.Location = new Point(20, 360);
        dgvTasks.Name = "dgvTasks";
        dgvTasks.RowHeadersWidth = 51;
        dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvTasks.Size = new Size(940, 180);
        dgvTasks.TabIndex = 4;
        // 
        // dgvThongKe
        // 
        dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvThongKe.Location = new Point(20, 630);
        dgvThongKe.Name = "dgvThongKe";
        dgvThongKe.RowHeadersWidth = 51;
        dgvThongKe.Size = new Size(940, 150);
        dgvThongKe.TabIndex = 0;
        // 
        // btnDone
        // 
        btnDone.BackColor = Color.PaleGreen;
        btnDone.Location = new Point(20, 550);
        btnDone.Name = "btnDone";
        btnDone.Size = new Size(150, 35);
        btnDone.TabIndex = 3;
        btnDone.Text = "Chuyển sang Done";
        btnDone.UseVisualStyleBackColor = false;
        btnDone.Click += btnDone_Click;
        // 
        // btnBaoCaoTreHan
        // 
        btnBaoCaoTreHan.BackColor = Color.LightCoral;
        btnBaoCaoTreHan.Location = new Point(190, 550);
        btnBaoCaoTreHan.Name = "btnBaoCaoTreHan";
        btnBaoCaoTreHan.Size = new Size(160, 35);
        btnBaoCaoTreHan.TabIndex = 2;
        btnBaoCaoTreHan.Text = "Cảnh Báo Quá Hạn";
        btnBaoCaoTreHan.UseVisualStyleBackColor = false;
        btnBaoCaoTreHan.Click += btnBaoCaoTreHan_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        label3.Location = new Point(20, 330);
        label3.Name = "label3";
        label3.Size = new Size(253, 20);
        label3.TabIndex = 5;
        label3.Text = "Danh Sách Công Việc (Task)";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        label4.Location = new Point(20, 600);
        label4.Name = "label4";
        label4.Size = new Size(265, 20);
        label4.TabIndex = 1;
        label4.Text = "Thống Kê Tiến Độ Thành Viên ";
        // 
        // FrmQuanLyTask
        // 
        ClientSize = new Size(985, 805);
        Controls.Add(dgvThongKe);
        Controls.Add(label4);
        Controls.Add(btnBaoCaoTreHan);
        Controls.Add(btnDone);
        Controls.Add(dgvTasks);
        Controls.Add(label3);
        Controls.Add(btnPhanCong);
        Controls.Add(cbThanhVien);
        Controls.Add(lblThanhVien);
        Controls.Add(gbTask);
        Controls.Add(gbDuAn);
        Controls.Add(cbTrangThaiFilter);
        Controls.Add(label2);
        Controls.Add(cbDuAn);
        Controls.Add(label1);
        Name = "FrmQuanLyTask";
        Text = "Hệ thống Quản lý Công việc & Tiến độ Dự án ";
        Load += FrmQuanLyTask_Load;
        gbDuAn.ResumeLayout(false);
        gbDuAn.PerformLayout();
        gbTask.ResumeLayout(false);
        gbTask.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cbDuAn;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cbTrangThaiFilter;

    private System.Windows.Forms.GroupBox gbDuAn;
    private System.Windows.Forms.Label lblTenDuAn;
    private System.Windows.Forms.TextBox txtTenDuAn;
    private System.Windows.Forms.Label lblNgayBD;
    private System.Windows.Forms.DateTimePicker dtpBatDau;
    private System.Windows.Forms.Label lblNgayKT;
    private System.Windows.Forms.DateTimePicker dtpKetThuc;
    private System.Windows.Forms.Label lblTTDuAn;
    private System.Windows.Forms.ComboBox cbTrangThaiDuAn;
    private System.Windows.Forms.Button btnThemDuAn;

    private System.Windows.Forms.GroupBox gbTask;
    private System.Windows.Forms.Label lblTenTask;
    private System.Windows.Forms.TextBox txtTenTask;
    private System.Windows.Forms.Label lblMoTa;
    private System.Windows.Forms.TextBox txtMoTa;
    private System.Windows.Forms.Label lblHanNop;
    private System.Windows.Forms.DateTimePicker dtpHanNop;
    private System.Windows.Forms.Label lblDoUuTien;
    private System.Windows.Forms.ComboBox cbDoUuTien;
    private System.Windows.Forms.Button btnThemTask;

    private System.Windows.Forms.Label lblThanhVien;
    private System.Windows.Forms.ComboBox cbThanhVien;
    private System.Windows.Forms.Button btnPhanCong;

    private System.Windows.Forms.DataGridView dgvTasks;
    private System.Windows.Forms.DataGridView dgvThongKe;
    private System.Windows.Forms.Button btnDone;
    private System.Windows.Forms.Button btnBaoCaoTreHan;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
}