namespace Bai_4._10
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
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            btndatra = new Button();
            btnlammoi = new Button();
            btnxoa = new Button();
            btncapnhat = new Button();
            btnthem = new Button();
            dtphantra = new DateTimePicker();
            dtpngaymuon = new DateTimePicker();
            label9 = new Label();
            dtpngaytrathucte = new DateTimePicker();
            cbthietbi = new ComboBox();
            cbtinhtrang = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtsoluong = new TextBox();
            txthotensinhvien = new TextBox();
            txtmasinhvien = new TextBox();
            txtmaphieu = new TextBox();
            pnlphai = new Panel();
            dataGridView1 = new DataGridView();
            ep = new ErrorProvider(components);
            mstrip = new MenuStrip();
            mnufile = new ToolStripMenuItem();
            mnuxuatcsv = new ToolStripMenuItem();
            mnuthoat = new ToolStripMenuItem();
            sstrip = new StatusStrip();
            lblthongke = new ToolStripStatusLabel();
            pnlloc = new Panel();
            lbltim = new Label();
            txttimkiem = new TextBox();
            lblloc = new Label();
            cbloctinhtrang = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlphai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ep).BeginInit();
            mstrip.SuspendLayout();
            sstrip.SuspendLayout();
            pnlloc.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.2057228F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.79428F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlphai, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1643, 909);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pnlloc);
            groupBox1.Controls.Add(btndatra);
            groupBox1.Controls.Add(btnlammoi);
            groupBox1.Controls.Add(btnxoa);
            groupBox1.Controls.Add(btncapnhat);
            groupBox1.Controls.Add(btnthem);
            groupBox1.Controls.Add(dtphantra);
            groupBox1.Controls.Add(dtpngaymuon);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(dtpngaytrathucte);
            groupBox1.Controls.Add(cbthietbi);
            groupBox1.Controls.Add(cbtinhtrang);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtsoluong);
            groupBox1.Controls.Add(txthotensinhvien);
            groupBox1.Controls.Add(txtmasinhvien);
            groupBox1.Controls.Add(txtmaphieu);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(556, 903);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu mượn";
            // 
            // btndatra
            // 
            btndatra.Location = new Point(291, 634);
            btndatra.Name = "btndatra";
            btndatra.Size = new Size(190, 88);
            btndatra.TabIndex = 13;
            btndatra.Text = "Đánh dấu đã trả";
            btndatra.UseVisualStyleBackColor = true;
            // 
            // btnlammoi
            // 
            btnlammoi.Location = new Point(164, 686);
            btnlammoi.Name = "btnlammoi";
            btnlammoi.Size = new Size(100, 36);
            btnlammoi.TabIndex = 12;
            btnlammoi.Text = "Làm mới";
            btnlammoi.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(74, 686);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(80, 36);
            btnxoa.TabIndex = 11;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            // 
            // btncapnhat
            // 
            btncapnhat.Location = new Point(164, 634);
            btncapnhat.Name = "btncapnhat";
            btncapnhat.Size = new Size(100, 36);
            btncapnhat.TabIndex = 10;
            btncapnhat.Text = "Cập nhật";
            btncapnhat.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(74, 634);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(80, 36);
            btnthem.TabIndex = 9;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            // 
            // dtphantra
            // 
            dtphantra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtphantra.Format = DateTimePickerFormat.Short;
            dtphantra.Location = new Point(220, 341);
            dtphantra.Name = "dtphantra";
            dtphantra.Size = new Size(316, 27);
            dtphantra.TabIndex = 6;
            // 
            // dtpngaymuon
            // 
            dtpngaymuon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpngaymuon.Format = DateTimePickerFormat.Short;
            dtpngaymuon.Location = new Point(220, 283);
            dtpngaymuon.Name = "dtpngaymuon";
            dtpngaymuon.Size = new Size(316, 27);
            dtpngaymuon.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(123, 455);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 22;
            label9.Text = "Tình trạng";
            // 
            // dtpngaytrathucte
            // 
            dtpngaytrathucte.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpngaytrathucte.Format = DateTimePickerFormat.Short;
            dtpngaytrathucte.Location = new Point(220, 406);
            dtpngaytrathucte.Name = "dtpngaytrathucte";
            dtpngaytrathucte.ShowCheckBox = true;
            dtpngaytrathucte.Size = new Size(316, 27);
            dtpngaytrathucte.TabIndex = 7;
            // 
            // cbthietbi
            // 
            cbthietbi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbthietbi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbthietbi.FormattingEnabled = true;
            cbthietbi.Location = new Point(220, 198);
            cbthietbi.Name = "cbthietbi";
            cbthietbi.Size = new Size(316, 28);
            cbthietbi.TabIndex = 3;
            // 
            // cbtinhtrang
            // 
            cbtinhtrang.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbtinhtrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbtinhtrang.Enabled = false;
            cbtinhtrang.FormattingEnabled = true;
            cbtinhtrang.Location = new Point(220, 450);
            cbtinhtrang.Name = "cbtinhtrang";
            cbtinhtrang.Size = new Size(316, 28);
            cbtinhtrang.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(83, 406);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 21;
            label8.Text = "Ngày trả thực tế";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(141, 348);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 20;
            label7.Text = "Hạn trả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 288);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 19;
            label6.Text = "Ngày mượn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 240);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 18;
            label5.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 198);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 17;
            label4.Text = "Thiết bị";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 159);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 16;
            label3.Text = "Họ tên sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 109);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 15;
            label2.Text = "Mã sinh viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 57);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 14;
            label1.Text = "Mã phiếu";
            // 
            // txtsoluong
            // 
            txtsoluong.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtsoluong.Location = new Point(220, 240);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(316, 27);
            txtsoluong.TabIndex = 4;
            // 
            // txthotensinhvien
            // 
            txthotensinhvien.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txthotensinhvien.Location = new Point(220, 154);
            txthotensinhvien.Name = "txthotensinhvien";
            txthotensinhvien.Size = new Size(316, 27);
            txthotensinhvien.TabIndex = 2;
            // 
            // txtmasinhvien
            // 
            txtmasinhvien.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtmasinhvien.Location = new Point(220, 107);
            txtmasinhvien.Name = "txtmasinhvien";
            txtmasinhvien.Size = new Size(316, 27);
            txtmasinhvien.TabIndex = 1;
            // 
            // txtmaphieu
            // 
            txtmaphieu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtmaphieu.Location = new Point(220, 57);
            txtmaphieu.Name = "txtmaphieu";
            txtmaphieu.Size = new Size(316, 27);
            txtmaphieu.TabIndex = 0;
            // 
            // pnlphai
            // 
            pnlphai.Controls.Add(dataGridView1);
            pnlphai.Dock = DockStyle.Fill;
            pnlphai.Location = new Point(565, 3);
            pnlphai.Name = "pnlphai";
            pnlphai.Size = new Size(1075, 903);
            pnlphai.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1075, 903);
            dataGridView1.TabIndex = 0;
            // 
            // ep
            // 
            ep.ContainerControl = this;
            // 
            // mstrip
            // 
            mstrip.ImageScalingSize = new Size(20, 20);
            mstrip.Items.AddRange(new ToolStripItem[] { mnufile });
            mstrip.Location = new Point(0, 0);
            mstrip.Name = "mstrip";
            mstrip.Size = new Size(1643, 28);
            mstrip.TabIndex = 2;
            mstrip.Text = "menuStrip1";
            // 
            // mnufile
            // 
            mnufile.DropDownItems.AddRange(new ToolStripItem[] { mnuxuatcsv, mnuthoat });
            mnufile.Name = "mnufile";
            mnufile.Size = new Size(48, 24);
            mnufile.Text = "Tệp";
            // 
            // mnuxuatcsv
            // 
            mnuxuatcsv.Name = "mnuxuatcsv";
            mnuxuatcsv.Size = new Size(303, 26);
            mnuxuatcsv.Text = "Xuất CSV (danh sách đang lọc)...";
            // 
            // mnuthoat
            // 
            mnuthoat.Name = "mnuthoat";
            mnuthoat.Size = new Size(303, 26);
            mnuthoat.Text = "Thoát";
            // 
            // sstrip
            // 
            sstrip.ImageScalingSize = new Size(20, 20);
            sstrip.Items.AddRange(new ToolStripItem[] { lblthongke });
            sstrip.Location = new Point(0, 937);
            sstrip.Name = "sstrip";
            sstrip.Size = new Size(1643, 26);
            sstrip.TabIndex = 1;
            sstrip.Text = "statusStrip1";
            // 
            // lblthongke
            // 
            lblthongke.Name = "lblthongke";
            lblthongke.Size = new Size(200, 20);
            lblthongke.Text = "Tổng số phiếu: 0 | Quá hạn: 0";
            // 
            // pnlloc
            // 
            pnlloc.Controls.Add(lbltim);
            pnlloc.Controls.Add(txttimkiem);
            pnlloc.Controls.Add(lblloc);
            pnlloc.Controls.Add(cbloctinhtrang);
            pnlloc.Dock = DockStyle.Bottom;
            pnlloc.Location = new Point(3, 844);
            pnlloc.Name = "pnlloc";
            pnlloc.Size = new Size(550, 56);
            pnlloc.TabIndex = 23;
            // 
            // lbltim
            // 
            lbltim.AutoSize = true;
            lbltim.Location = new Point(8, 18);
            lbltim.Name = "lbltim";
            lbltim.Size = new Size(146, 20);
            lbltim.TabIndex = 0;
            lbltim.Text = "Tìm (mã SV/thiết bị):";
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(165, 14);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(104, 27);
            txttimkiem.TabIndex = 0;
            // 
            // lblloc
            // 
            lblloc.AutoSize = true;
            lblloc.Location = new Point(298, 18);
            lblloc.Name = "lblloc";
            lblloc.Size = new Size(79, 20);
            lblloc.TabIndex = 1;
            lblloc.Text = "Tình trạng:";
            // 
            // cbloctinhtrang
            // 
            cbloctinhtrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbloctinhtrang.FormattingEnabled = true;
            cbloctinhtrang.Location = new Point(383, 15);
            cbloctinhtrang.Name = "cbloctinhtrang";
            cbloctinhtrang.Size = new Size(150, 28);
            cbloctinhtrang.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1643, 963);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(sstrip);
            Controls.Add(mstrip);
            MainMenuStrip = mstrip;
            MinimumSize = new Size(1200, 700);
            Name = "Form1";
            Text = "Quản lý mượn trả thiết bị tại phòng thực hành";
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlphai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ep).EndInit();
            mstrip.ResumeLayout(false);
            mstrip.PerformLayout();
            sstrip.ResumeLayout(false);
            sstrip.PerformLayout();
            pnlloc.ResumeLayout(false);
            pnlloc.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlphai;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label1, label2, label3, label4, label5, label6, label7, label8, label9;
        private TextBox txtmaphieu, txtmasinhvien, txthotensinhvien, txtsoluong;
        private ComboBox cbthietbi, cbtinhtrang;
        private DateTimePicker dtpngaymuon, dtphantra, dtpngaytrathucte;
        private Button btnthem, btncapnhat, btnxoa, btnlammoi, btndatra;
        private ErrorProvider ep;
        private MenuStrip mstrip;
        private ToolStripMenuItem mnufile, mnuxuatcsv, mnuthoat;
        private StatusStrip sstrip;
        private ToolStripStatusLabel lblthongke;
        private Panel pnlloc;
        private Label lbltim;
        private TextBox txttimkiem;
        private Label lblloc;
        private ComboBox cbloctinhtrang;
    }
}