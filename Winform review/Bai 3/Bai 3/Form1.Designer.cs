namespace Bai_3
{
    partial class Form1
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tblRoot = new TableLayoutPanel();
            gbNhapLieu = new GroupBox();
            tblNhap = new TableLayoutPanel();
            label1 = new Label();
            txtmavt = new TextBox();
            label2 = new Label();
            txttenvt = new TextBox();
            label3 = new Label();
            cbdonvitinh = new ComboBox();
            label4 = new Label();
            txtdongia = new TextBox();
            gbDanhSach = new GroupBox();
            lvvattu = new ListView();
            colMaVT = new ColumnHeader();
            colTenVT = new ColumnHeader();
            colDVT = new ColumnHeader();
            colDonGia = new ColumnHeader();
            flowNut = new FlowLayoutPanel();
            btnXoatatca = new Button();
            btnXoadong = new Button();
            btnCapnhat = new Button();
            btnThemmoi = new Button();
            tblRoot.SuspendLayout();
            gbNhapLieu.SuspendLayout();
            tblNhap.SuspendLayout();
            gbDanhSach.SuspendLayout();
            flowNut.SuspendLayout();
            SuspendLayout();
            // 
            // tblRoot
            // 
            tblRoot.ColumnCount = 2;
            tblRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
            tblRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64F));
            tblRoot.Controls.Add(gbNhapLieu, 0, 0);
            tblRoot.Controls.Add(gbDanhSach, 1, 0);
            tblRoot.Controls.Add(flowNut, 0, 1);
            tblRoot.Dock = DockStyle.Fill;
            tblRoot.Location = new Point(0, 0);
            tblRoot.Name = "tblRoot";
            tblRoot.Padding = new Padding(15);
            tblRoot.RowCount = 2;
            tblRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tblRoot.Size = new Size(1000, 480);
            tblRoot.TabIndex = 0;
            // 
            // gbNhapLieu
            // 
            gbNhapLieu.Controls.Add(tblNhap);
            gbNhapLieu.Dock = DockStyle.Fill;
            gbNhapLieu.Location = new Point(18, 18);
            gbNhapLieu.Name = "gbNhapLieu";
            gbNhapLieu.Padding = new Padding(10);
            gbNhapLieu.Size = new Size(343, 384);
            gbNhapLieu.TabIndex = 0;
            gbNhapLieu.TabStop = false;
            gbNhapLieu.Text = "Thông tin vật tư";
            // 
            // tblNhap
            // 
            tblNhap.ColumnCount = 2;
            tblNhap.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.91331F));
            tblNhap.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.0866852F));
            tblNhap.Controls.Add(label1, 0, 0);
            tblNhap.Controls.Add(txtmavt, 1, 0);
            tblNhap.Controls.Add(label2, 0, 1);
            tblNhap.Controls.Add(txttenvt, 1, 1);
            tblNhap.Controls.Add(label3, 0, 2);
            tblNhap.Controls.Add(cbdonvitinh, 1, 2);
            tblNhap.Controls.Add(label4, 0, 3);
            tblNhap.Controls.Add(txtdongia, 1, 3);
            tblNhap.Dock = DockStyle.Fill;
            tblNhap.Location = new Point(10, 30);
            tblNhap.Name = "tblNhap";
            tblNhap.RowCount = 5;
            tblNhap.RowStyles.Add(new RowStyle(SizeType.Absolute, 101F));
            tblNhap.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
            tblNhap.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblNhap.RowStyles.Add(new RowStyle(SizeType.Absolute, 86F));
            tblNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblNhap.Size = new Size(323, 344);
            tblNhap.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 40);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã vật tư";
            // 
            // txtmavt
            // 
            txtmavt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtmavt.Location = new Point(118, 37);
            txtmavt.Name = "txtmavt";
            txtmavt.Size = new Size(202, 27);
            txtmavt.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 130);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên vật tư";
            // 
            // txttenvt
            // 
            txttenvt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txttenvt.Location = new Point(118, 127);
            txttenvt.Name = "txttenvt";
            txttenvt.Size = new Size(202, 27);
            txttenvt.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 205);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "Đơn vị tính";
            // 
            // cbdonvitinh
            // 
            cbdonvitinh.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbdonvitinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbdonvitinh.FormattingEnabled = true;
            cbdonvitinh.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });
            cbdonvitinh.Location = new Point(118, 201);
            cbdonvitinh.Name = "cbdonvitinh";
            cbdonvitinh.Size = new Size(202, 28);
            cbdonvitinh.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 283);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 3;
            label4.Text = "Đơn giá nhập";
            // 
            // txtdongia
            // 
            txtdongia.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtdongia.Location = new Point(118, 279);
            txtdongia.Name = "txtdongia";
            txtdongia.Size = new Size(202, 27);
            txtdongia.TabIndex = 3;
            // 
            // gbDanhSach
            // 
            gbDanhSach.Controls.Add(lvvattu);
            gbDanhSach.Dock = DockStyle.Fill;
            gbDanhSach.Location = new Point(367, 18);
            gbDanhSach.Name = "gbDanhSach";
            gbDanhSach.Padding = new Padding(10);
            gbDanhSach.Size = new Size(615, 384);
            gbDanhSach.TabIndex = 1;
            gbDanhSach.TabStop = false;
            gbDanhSach.Text = "Danh sách vật tư";
            // 
            // lvvattu
            // 
            lvvattu.Columns.AddRange(new ColumnHeader[] { colMaVT, colTenVT, colDVT, colDonGia });
            lvvattu.Dock = DockStyle.Fill;
            lvvattu.FullRowSelect = true;
            lvvattu.GridLines = true;
            lvvattu.Location = new Point(10, 30);
            lvvattu.MultiSelect = false;
            lvvattu.Name = "lvvattu";
            lvvattu.Size = new Size(595, 344);
            lvvattu.TabIndex = 4;
            lvvattu.UseCompatibleStateImageBehavior = false;
            lvvattu.View = View.Details;
            lvvattu.SelectedIndexChanged += lvvattu_SelectedIndexChanged;
            // 
            // colMaVT
            // 
            colMaVT.Text = "Mã VT";
            colMaVT.Width = 90;
            // 
            // colTenVT
            // 
            colTenVT.Text = "Tên VT";
            colTenVT.Width = 200;
            // 
            // colDVT
            // 
            colDVT.Text = "Đơn vị tính";
            colDVT.Width = 110;
            // 
            // colDonGia
            // 
            colDonGia.Text = "Đơn giá";
            colDonGia.TextAlign = HorizontalAlignment.Right;
            colDonGia.Width = 120;
            // 
            // flowNut
            // 
            tblRoot.SetColumnSpan(flowNut, 2);
            flowNut.Controls.Add(btnXoatatca);
            flowNut.Controls.Add(btnXoadong);
            flowNut.Controls.Add(btnCapnhat);
            flowNut.Controls.Add(btnThemmoi);
            flowNut.Dock = DockStyle.Fill;
            flowNut.FlowDirection = FlowDirection.RightToLeft;
            flowNut.Location = new Point(18, 408);
            flowNut.Name = "flowNut";
            flowNut.Size = new Size(964, 54);
            flowNut.TabIndex = 5;
            // 
            // btnXoatatca
            // 
            btnXoatatca.Location = new Point(841, 3);
            btnXoatatca.Name = "btnXoatatca";
            btnXoatatca.Size = new Size(120, 38);
            btnXoatatca.TabIndex = 3;
            btnXoatatca.Text = "Xóa toàn bộ";
            btnXoatatca.UseVisualStyleBackColor = true;
            btnXoatatca.Click += btnXoatatca_Click;
            // 
            // btnXoadong
            // 
            btnXoadong.Location = new Point(715, 3);
            btnXoadong.Name = "btnXoadong";
            btnXoadong.Size = new Size(120, 38);
            btnXoadong.TabIndex = 2;
            btnXoadong.Text = "Xóa dòng";
            btnXoadong.UseVisualStyleBackColor = true;
            btnXoadong.Click += btnXoadong_Click;
            // 
            // btnCapnhat
            // 
            btnCapnhat.Location = new Point(589, 3);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(120, 38);
            btnCapnhat.TabIndex = 1;
            btnCapnhat.Text = "Cập nhật";
            btnCapnhat.UseVisualStyleBackColor = true;
            btnCapnhat.Click += btnCapnhat_Click;
            // 
            // btnThemmoi
            // 
            btnThemmoi.Anchor = AnchorStyles.None;
            btnThemmoi.Location = new Point(463, 3);
            btnThemmoi.Name = "btnThemmoi";
            btnThemmoi.Size = new Size(120, 38);
            btnThemmoi.TabIndex = 0;
            btnThemmoi.Text = "Thêm mới";
            btnThemmoi.UseVisualStyleBackColor = true;
            btnThemmoi.Click += btnThemmoi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 480);
            Controls.Add(tblRoot);
            MinimumSize = new Size(850, 420);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý vật tư";
            tblRoot.ResumeLayout(false);
            gbNhapLieu.ResumeLayout(false);
            tblNhap.ResumeLayout(false);
            tblNhap.PerformLayout();
            gbDanhSach.ResumeLayout(false);
            flowNut.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblRoot;
        private GroupBox gbNhapLieu;
        private TableLayoutPanel tblNhap;
        private Label label1;
        private TextBox txtmavt;
        private Label label2;
        private TextBox txttenvt;
        private Label label3;
        private ComboBox cbdonvitinh;
        private Label label4;
        private TextBox txtdongia;
        private GroupBox gbDanhSach;
        private ListView lvvattu;
        private ColumnHeader colMaVT;
        private ColumnHeader colTenVT;
        private ColumnHeader colDVT;
        private ColumnHeader colDonGia;
        private FlowLayoutPanel flowNut;
        private Button btnThemmoi;
        private Button btnCapnhat;
        private Button btnXoadong;
        private Button btnXoatatca;
    }
}