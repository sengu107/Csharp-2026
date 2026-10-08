namespace Bai_5
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
            components = new System.ComponentModel.Container();
            splitMain = new SplitContainer();
            tabMain = new TabControl();
            tabKhach = new TabPage();
            tblKhach = new TableLayoutPanel();
            txttenkh = new TextBox();
            label2 = new Label();
            txtsdt = new TextBox();
            label3 = new Label();
            txtdiachi = new TextBox();
            label1 = new Label();
            tabVanChuyen = new TabPage();
            tblVC = new TableLayoutPanel();
            label4 = new Label();
            cbloaivc = new ComboBox();
            label5 = new Label();
            dtpngaygiao = new DateTimePicker();
            label6 = new Label();
            txtghichu = new TextBox();
            gbHang = new GroupBox();
            dgvHang = new DataGridView();
            colTenHang = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colTrongLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            lblGoiY = new Label();
            statusStrip1 = new StatusStrip();
            lblThoiGian = new ToolStripStatusLabel();
            lblTongSL = new ToolStripStatusLabel();
            lblTongKL = new ToolStripStatusLabel();
            lblTongTien = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            tabMain.SuspendLayout();
            tabKhach.SuspendLayout();
            tblKhach.SuspendLayout();
            tabVanChuyen.SuspendLayout();
            tblVC.SuspendLayout();
            gbHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHang).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 0);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(tabMain);
            splitMain.Panel1.Padding = new Padding(10);
            splitMain.Panel1MinSize = 300;
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(gbHang);
            splitMain.Panel2.Padding = new Padding(10);
            splitMain.Panel2MinSize = 400;
            splitMain.Size = new Size(1150, 570);
            splitMain.SplitterDistance = 746;
            splitMain.TabIndex = 0;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabKhach);
            tabMain.Controls.Add(tabVanChuyen);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(10, 10);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(726, 550);
            tabMain.TabIndex = 0;
            // 
            // tabKhach
            // 
            tabKhach.Controls.Add(tblKhach);
            tabKhach.Location = new Point(4, 29);
            tabKhach.Name = "tabKhach";
            tabKhach.Padding = new Padding(10);
            tabKhach.Size = new Size(718, 517);
            tabKhach.TabIndex = 0;
            tabKhach.Text = "Khách hàng";
            tabKhach.UseVisualStyleBackColor = true;
            // 
            // tblKhach
            // 
            tblKhach.ColumnCount = 2;
            tblKhach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.6246414F));
            tblKhach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.37536F));
            tblKhach.Controls.Add(txttenkh, 1, 0);
            tblKhach.Controls.Add(label2, 0, 1);
            tblKhach.Controls.Add(txtsdt, 1, 1);
            tblKhach.Controls.Add(label3, 0, 2);
            tblKhach.Controls.Add(txtdiachi, 1, 2);
            tblKhach.Controls.Add(label1, 0, 0);
            tblKhach.Dock = DockStyle.Fill;
            tblKhach.Location = new Point(10, 10);
            tblKhach.Name = "tblKhach";
            tblKhach.RowCount = 4;
            tblKhach.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            tblKhach.RowStyles.Add(new RowStyle(SizeType.Absolute, 138F));
            tblKhach.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
            tblKhach.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblKhach.Size = new Size(698, 497);
            tblKhach.TabIndex = 0;
            // 
            // txttenkh
            // 
            txttenkh.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txttenkh.Location = new Point(133, 51);
            txttenkh.Name = "txttenkh";
            txttenkh.Size = new Size(562, 27);
            txttenkh.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 189);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại";
            // 
            // txtsdt
            // 
            txtsdt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtsdt.Location = new Point(133, 185);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(562, 27);
            txtsdt.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 280);
            label3.Margin = new Padding(3, 12, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ giao";
            // 
            // txtdiachi
            // 
            txtdiachi.Dock = DockStyle.Fill;
            txtdiachi.Location = new Point(133, 276);
            txtdiachi.Margin = new Padding(3, 8, 3, 8);
            txtdiachi.Multiline = true;
            txtdiachi.Name = "txtdiachi";
            txtdiachi.ScrollBars = ScrollBars.Vertical;
            txtdiachi.Size = new Size(562, 144);
            txtdiachi.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 55);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng";
            // 
            // tabVanChuyen
            // 
            tabVanChuyen.Controls.Add(tblVC);
            tabVanChuyen.Location = new Point(4, 29);
            tabVanChuyen.Name = "tabVanChuyen";
            tabVanChuyen.Padding = new Padding(10);
            tabVanChuyen.Size = new Size(718, 517);
            tabVanChuyen.TabIndex = 1;
            tabVanChuyen.Text = "Vận chuyển";
            tabVanChuyen.UseVisualStyleBackColor = true;
            // 
            // tblVC
            // 
            tblVC.ColumnCount = 2;
            tblVC.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tblVC.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68F));
            tblVC.Controls.Add(label4, 0, 0);
            tblVC.Controls.Add(cbloaivc, 1, 0);
            tblVC.Controls.Add(label5, 0, 1);
            tblVC.Controls.Add(dtpngaygiao, 1, 1);
            tblVC.Controls.Add(label6, 0, 2);
            tblVC.Controls.Add(txtghichu, 1, 2);
            tblVC.Dock = DockStyle.Fill;
            tblVC.Location = new Point(10, 10);
            tblVC.Name = "tblVC";
            tblVC.RowCount = 3;
            tblVC.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVC.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVC.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblVC.Size = new Size(698, 497);
            tblVC.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 12);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 0;
            label4.Text = "Loại vận chuyển";
            // 
            // cbloaivc
            // 
            cbloaivc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbloaivc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbloaivc.FormattingEnabled = true;
            cbloaivc.Items.AddRange(new object[] { "Tiêu chuẩn", "Nhanh", "Hỏa tốc" });
            cbloaivc.Location = new Point(226, 8);
            cbloaivc.Name = "cbloaivc";
            cbloaivc.Size = new Size(469, 28);
            cbloaivc.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 57);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 1;
            label5.Text = "Ngày giao";
            // 
            // dtpngaygiao
            // 
            dtpngaygiao.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpngaygiao.CustomFormat = "dd/MM/yyyy";
            dtpngaygiao.Format = DateTimePickerFormat.Custom;
            dtpngaygiao.Location = new Point(226, 54);
            dtpngaygiao.Name = "dtpngaygiao";
            dtpngaygiao.Size = new Size(469, 27);
            dtpngaygiao.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 102);
            label6.Margin = new Padding(3, 12, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 2;
            label6.Text = "Ghi chú";
            // 
            // txtghichu
            // 
            txtghichu.Dock = DockStyle.Fill;
            txtghichu.Location = new Point(226, 98);
            txtghichu.Margin = new Padding(3, 8, 3, 8);
            txtghichu.Multiline = true;
            txtghichu.Name = "txtghichu";
            txtghichu.ScrollBars = ScrollBars.Vertical;
            txtghichu.Size = new Size(469, 391);
            txtghichu.TabIndex = 2;
            // 
            // gbHang
            // 
            gbHang.Controls.Add(dgvHang);
            gbHang.Controls.Add(lblGoiY);
            gbHang.Dock = DockStyle.Fill;
            gbHang.Location = new Point(10, 10);
            gbHang.Name = "gbHang";
            gbHang.Padding = new Padding(8);
            gbHang.Size = new Size(380, 550);
            gbHang.TabIndex = 0;
            gbHang.TabStop = false;
            gbHang.Text = "Chi tiết hàng hóa";
            // 
            // dgvHang
            // 
            dgvHang.AllowUserToAddRows = false;
            dgvHang.AllowUserToDeleteRows = false;
            dgvHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHang.BackgroundColor = SystemColors.Window;
            dgvHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHang.Columns.AddRange(new DataGridViewColumn[] { colTenHang, colSoLuong, colTrongLuong, colDonGia, colThanhTien });
            dgvHang.Dock = DockStyle.Fill;
            dgvHang.Location = new Point(8, 28);
            dgvHang.Name = "dgvHang";
            dgvHang.RowHeadersWidth = 30;
            dgvHang.Size = new Size(364, 486);
            dgvHang.TabIndex = 3;
            dgvHang.CellValueChanged += dgvHang_CellValueChanged;
            dgvHang.DataError += dgvHang_DataError;
            dgvHang.RowsAdded += dgvHang_RowsChanged;
            dgvHang.RowsRemoved += dgvHang_RowsChanged;
            // 
            // colTenHang
            // 
            colTenHang.FillWeight = 36F;
            colTenHang.HeaderText = "Tên hàng";
            colTenHang.MinimumWidth = 6;
            colTenHang.Name = "colTenHang";
            // 
            // colSoLuong
            // 
            colSoLuong.FillWeight = 14F;
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            // 
            // colTrongLuong
            // 
            colTrongLuong.FillWeight = 16F;
            colTrongLuong.HeaderText = "Trọng lượng (kg)";
            colTrongLuong.MinimumWidth = 6;
            colTrongLuong.Name = "colTrongLuong";
            // 
            // colDonGia
            // 
            colDonGia.FillWeight = 16F;
            colDonGia.HeaderText = "Đơn giá";
            colDonGia.MinimumWidth = 6;
            colDonGia.Name = "colDonGia";
            // 
            // colThanhTien
            // 
            colThanhTien.FillWeight = 18F;
            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.MinimumWidth = 6;
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            // 
            // lblGoiY
            // 
            lblGoiY.Dock = DockStyle.Bottom;
            lblGoiY.ForeColor = Color.DimGray;
            lblGoiY.Location = new Point(8, 514);
            lblGoiY.Name = "lblGoiY";
            lblGoiY.Size = new Size(364, 28);
            lblGoiY.TabIndex = 4;
            lblGoiY.Text = "Phím tắt:  F2 = thêm dòng mới   |   Delete = xóa dòng đang chọn";
            lblGoiY.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTongSL, lblTongKL, lblTongTien, lblThoiGian });
            statusStrip1.Location = new Point(0, 570);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1150, 30);
            statusStrip1.TabIndex = 1;
            // 
            // lblThoiGian
            // 
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(649, 24);
            lblThoiGian.Spring = true;
            lblThoiGian.Text = "00/00/0000 00:00:00";
            lblThoiGian.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTongSL
            // 
            lblTongSL.BorderSides = ToolStripStatusLabelBorderSides.Left;
            lblTongSL.Name = "lblTongSL";
            lblTongSL.Padding = new Padding(8, 0, 8, 0);
            lblTongSL.Size = new Size(140, 24);
            lblTongSL.Text = "Tổng số lượng: 0";
            // 
            // lblTongKL
            // 
            lblTongKL.BorderSides = ToolStripStatusLabelBorderSides.Left;
            lblTongKL.Name = "lblTongKL";
            lblTongKL.Padding = new Padding(8, 0, 8, 0);
            lblTongKL.Size = new Size(181, 24);
            lblTongKL.Text = "Tổng trọng lượng: 0 kg";
            // 
            // lblTongTien
            // 
            lblTongTien.ActiveLinkColor = Color.Black;
            lblTongTien.BorderSides = ToolStripStatusLabelBorderSides.Left;
            lblTongTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.Black;
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Padding = new Padding(8, 0, 8, 0);
            lblTongTien.Size = new Size(126, 24);
            lblTongTien.Text = "Tổng tiền: 0 đ";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 600);
            Controls.Add(splitMain);
            Controls.Add(statusStrip1);
            MinimumSize = new Size(900, 480);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý đơn giao hàng";
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            tabMain.ResumeLayout(false);
            tabKhach.ResumeLayout(false);
            tblKhach.ResumeLayout(false);
            tblKhach.PerformLayout();
            tabVanChuyen.ResumeLayout(false);
            tblVC.ResumeLayout(false);
            tblVC.PerformLayout();
            gbHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHang).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitMain;
        private TabControl tabMain;
        private TabPage tabKhach;
        private TableLayoutPanel tblKhach;
        private Label label1;
        private TextBox txttenkh;
        private Label label2;
        private TextBox txtsdt;
        private Label label3;
        private TextBox txtdiachi;
        private TabPage tabVanChuyen;
        private TableLayoutPanel tblVC;
        private Label label4;
        private ComboBox cbloaivc;
        private Label label5;
        private DateTimePicker dtpngaygiao;
        private Label label6;
        private TextBox txtghichu;
        private GroupBox gbHang;
        private DataGridView dgvHang;
        private DataGridViewTextBoxColumn colTenHang;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colTrongLuong;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colThanhTien;
        private Label lblGoiY;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblThoiGian;
        private ToolStripStatusLabel lblTongSL;
        private ToolStripStatusLabel lblTongKL;
        private ToolStripStatusLabel lblTongTien;
        private System.Windows.Forms.Timer timer1;
        private ErrorProvider errorProvider1;
    }
}
