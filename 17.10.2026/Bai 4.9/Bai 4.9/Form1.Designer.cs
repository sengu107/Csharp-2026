namespace Bai_4._9
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
            grbxthongtinlichhen = new GroupBox();
            btnthem = new Button();
            btncapnhat = new Button();
            btnxoa = new Button();
            btnlammoi = new Button();
            cbbacsi = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtlidokham = new TextBox();
            cbtrangthai = new ComboBox();
            dtpngaygiohen = new DateTimePicker();
            txtsdt = new TextBox();
            txtmalichhen = new TextBox();
            txthotenbenhnhan = new TextBox();
            pnlphai = new Panel();
            dataGridView1 = new DataGridView();
            pnlloc = new Panel();
            lbltim = new Label();
            txttimkiem = new TextBox();
            chklocngay = new CheckBox();
            dtploc = new DateTimePicker();
            lblloctrangthai = new Label();
            cbloctrangthai = new ComboBox();
            ep = new ErrorProvider(components);
            mstrip = new MenuStrip();
            mnufile = new ToolStripMenuItem();
            mnuxuatcsv = new ToolStripMenuItem();
            mnuthoat = new ToolStripMenuItem();
            sstrip = new StatusStrip();
            lblsoluong = new ToolStripStatusLabel();
            tableLayoutPanel1.SuspendLayout();
            grbxthongtinlichhen.SuspendLayout();
            pnlphai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlloc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ep).BeginInit();
            mstrip.SuspendLayout();
            sstrip.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74F));
            tableLayoutPanel1.Controls.Add(grbxthongtinlichhen, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlphai, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1552, 814);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // grbxthongtinlichhen
            // 
            grbxthongtinlichhen.Controls.Add(btnthem);
            grbxthongtinlichhen.Controls.Add(btncapnhat);
            grbxthongtinlichhen.Controls.Add(btnxoa);
            grbxthongtinlichhen.Controls.Add(btnlammoi);
            grbxthongtinlichhen.Controls.Add(cbbacsi);
            grbxthongtinlichhen.Controls.Add(label7);
            grbxthongtinlichhen.Controls.Add(label6);
            grbxthongtinlichhen.Controls.Add(label5);
            grbxthongtinlichhen.Controls.Add(label4);
            grbxthongtinlichhen.Controls.Add(label3);
            grbxthongtinlichhen.Controls.Add(label2);
            grbxthongtinlichhen.Controls.Add(label1);
            grbxthongtinlichhen.Controls.Add(txtlidokham);
            grbxthongtinlichhen.Controls.Add(cbtrangthai);
            grbxthongtinlichhen.Controls.Add(dtpngaygiohen);
            grbxthongtinlichhen.Controls.Add(txtsdt);
            grbxthongtinlichhen.Controls.Add(txtmalichhen);
            grbxthongtinlichhen.Controls.Add(txthotenbenhnhan);
            grbxthongtinlichhen.Dock = DockStyle.Fill;
            grbxthongtinlichhen.Location = new Point(3, 3);
            grbxthongtinlichhen.Name = "grbxthongtinlichhen";
            grbxthongtinlichhen.Size = new Size(397, 808);
            grbxthongtinlichhen.TabIndex = 1;
            grbxthongtinlichhen.TabStop = false;
            grbxthongtinlichhen.Text = "Thông Tin Lịch Hẹn";
            // 
            // btnthem
            // 
            btnthem.Location = new Point(103, 556);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(85, 34);
            btnthem.TabIndex = 17;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            // 
            // btncapnhat
            // 
            btncapnhat.Location = new Point(103, 611);
            btncapnhat.Name = "btncapnhat";
            btncapnhat.Size = new Size(85, 34);
            btncapnhat.TabIndex = 18;
            btncapnhat.Text = "Cập nhật";
            btncapnhat.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(206, 556);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(85, 34);
            btnxoa.TabIndex = 19;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnlammoi
            // 
            btnlammoi.Location = new Point(206, 613);
            btnlammoi.Name = "btnlammoi";
            btnlammoi.Size = new Size(85, 34);
            btnlammoi.TabIndex = 20;
            btnlammoi.Text = "Làm mới";
            btnlammoi.UseVisualStyleBackColor = true;
            // 
            // cbbacsi
            // 
            cbbacsi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbacsi.FormattingEnabled = true;
            cbbacsi.Location = new Point(177, 294);
            cbbacsi.Name = "cbbacsi";
            cbbacsi.Size = new Size(182, 28);
            cbbacsi.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 419);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 13;
            label7.Text = "Trạng Thái";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 357);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 12;
            label6.Text = "Lí do khám";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 297);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 11;
            label5.Text = "Bác sĩ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 237);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 9;
            label4.Text = "Ngày giờ hẹn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 177);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 8;
            label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 122);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 7;
            label2.Text = "Họ tên bệnh nhân";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 71);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 6;
            label1.Text = "Mã Lịch Hẹn";
            // 
            // txtlidokham
            // 
            txtlidokham.Location = new Point(177, 356);
            txtlidokham.Name = "txtlidokham";
            txtlidokham.Size = new Size(182, 27);
            txtlidokham.TabIndex = 5;
            // 
            // cbtrangthai
            // 
            cbtrangthai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbtrangthai.FormattingEnabled = true;
            cbtrangthai.Location = new Point(177, 415);
            cbtrangthai.Name = "cbtrangthai";
            cbtrangthai.Size = new Size(182, 28);
            cbtrangthai.TabIndex = 4;
            // 
            // dtpngaygiohen
            // 
            dtpngaygiohen.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpngaygiohen.Format = DateTimePickerFormat.Custom;
            dtpngaygiohen.Location = new Point(154, 236);
            dtpngaygiohen.Name = "dtpngaygiohen";
            dtpngaygiohen.Size = new Size(239, 27);
            dtpngaygiohen.TabIndex = 3;
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(177, 173);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(182, 27);
            txtsdt.TabIndex = 2;
            // 
            // txtmalichhen
            // 
            txtmalichhen.Location = new Point(177, 67);
            txtmalichhen.Name = "txtmalichhen";
            txtmalichhen.Size = new Size(182, 27);
            txtmalichhen.TabIndex = 0;
            // 
            // txthotenbenhnhan
            // 
            txthotenbenhnhan.Location = new Point(177, 118);
            txthotenbenhnhan.Name = "txthotenbenhnhan";
            txthotenbenhnhan.Size = new Size(182, 27);
            txthotenbenhnhan.TabIndex = 1;
            // 
            // pnlphai
            // 
            pnlphai.Controls.Add(dataGridView1);
            pnlphai.Controls.Add(pnlloc);
            pnlphai.Dock = DockStyle.Fill;
            pnlphai.Location = new Point(406, 3);
            pnlphai.Name = "pnlphai";
            pnlphai.Size = new Size(1143, 808);
            pnlphai.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1143, 753);
            dataGridView1.TabIndex = 0;
            // 
            // pnlloc
            // 
            pnlloc.Controls.Add(lbltim);
            pnlloc.Controls.Add(txttimkiem);
            pnlloc.Controls.Add(chklocngay);
            pnlloc.Controls.Add(dtploc);
            pnlloc.Controls.Add(lblloctrangthai);
            pnlloc.Controls.Add(cbloctrangthai);
            pnlloc.Dock = DockStyle.Top;
            pnlloc.Location = new Point(0, 0);
            pnlloc.Name = "pnlloc";
            pnlloc.Size = new Size(1143, 55);
            pnlloc.TabIndex = 1;
            pnlloc.Paint += pnlloc_Paint;
            // 
            // lbltim
            // 
            lbltim.AutoSize = true;
            lbltim.Location = new Point(8, 18);
            lbltim.Name = "lbltim";
            lbltim.Size = new Size(105, 20);
            lbltim.TabIndex = 0;
            lbltim.Text = "Tìm (tên/SĐT):";
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(115, 14);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(200, 27);
            txttimkiem.TabIndex = 1;
            // 
            // chklocngay
            // 
            chklocngay.AutoSize = true;
            chklocngay.Location = new Point(335, 16);
            chklocngay.Name = "chklocngay";
            chklocngay.Size = new Size(93, 24);
            chklocngay.TabIndex = 2;
            chklocngay.Text = "Lọc ngày:";
            chklocngay.UseVisualStyleBackColor = true;
            // 
            // dtploc
            // 
            dtploc.Format = DateTimePickerFormat.Short;
            dtploc.Location = new Point(430, 14);
            dtploc.Name = "dtploc";
            dtploc.Size = new Size(130, 27);
            dtploc.TabIndex = 3;
            // 
            // lblloctrangthai
            // 
            lblloctrangthai.AutoSize = true;
            lblloctrangthai.Location = new Point(575, 18);
            lblloctrangthai.Name = "lblloctrangthai";
            lblloctrangthai.Size = new Size(78, 20);
            lblloctrangthai.TabIndex = 4;
            lblloctrangthai.Text = "Trạng thái:";
            // 
            // cbloctrangthai
            // 
            cbloctrangthai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbloctrangthai.FormattingEnabled = true;
            cbloctrangthai.Location = new Point(660, 14);
            cbloctrangthai.Name = "cbloctrangthai";
            cbloctrangthai.Size = new Size(140, 28);
            cbloctrangthai.TabIndex = 5;
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
            mstrip.Size = new Size(1552, 28);
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
            mnuxuatcsv.Size = new Size(161, 26);
            mnuxuatcsv.Text = "Xuất CSV...";
            // 
            // mnuthoat
            // 
            mnuthoat.Name = "mnuthoat";
            mnuthoat.Size = new Size(161, 26);
            mnuthoat.Text = "Thoát";
            // 
            // sstrip
            // 
            sstrip.ImageScalingSize = new Size(20, 20);
            sstrip.Items.AddRange(new ToolStripItem[] { lblsoluong });
            sstrip.Location = new Point(0, 842);
            sstrip.Name = "sstrip";
            sstrip.Size = new Size(1552, 26);
            sstrip.TabIndex = 1;
            sstrip.Text = "statusStrip1";
            // 
            // lblsoluong
            // 
            lblsoluong.Name = "lblsoluong";
            lblsoluong.Size = new Size(96, 20);
            lblsoluong.Text = "Số lịch hẹn: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1552, 868);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(sstrip);
            Controls.Add(mstrip);
            MainMenuStrip = mstrip;
            Name = "Form1";
            Text = "Quản lý lịch hẹn phòng khám";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            grbxthongtinlichhen.ResumeLayout(false);
            grbxthongtinlichhen.PerformLayout();
            pnlphai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlloc.ResumeLayout(false);
            pnlloc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ep).EndInit();
            mstrip.ResumeLayout(false);
            mstrip.PerformLayout();
            sstrip.ResumeLayout(false);
            sstrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlphai;
        private Panel pnlloc;
        private DataGridView dataGridView1;
        private GroupBox grbxthongtinlichhen;
        private TextBox txtmalichhen;
        private TextBox txthotenbenhnhan;
        private ComboBox cbtrangthai;
        private ComboBox cbbacsi;
        private DateTimePicker dtpngaygiohen;
        private TextBox txtsdt;
        private TextBox txtlidokham;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ErrorProvider ep;
        private StatusStrip sstrip;
        private MenuStrip mstrip;
        private ToolStripMenuItem mnufile;
        private ToolStripMenuItem mnuxuatcsv;
        private ToolStripMenuItem mnuthoat;
        private ToolStripStatusLabel lblsoluong;
        private Button btnthem;
        private Button btncapnhat;
        private Button btnxoa;
        private Button btnlammoi;
        private Label lbltim;
        private TextBox txttimkiem;
        private CheckBox chklocngay;
        private DateTimePicker dtploc;
        private Label lblloctrangthai;
        private ComboBox cbloctrangthai;
    }
}