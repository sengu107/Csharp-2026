
namespace Bai5._5
{
    partial class Form1
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
            this.gbVatTu = new System.Windows.Forms.GroupBox();
            this.lblTongGiaTriTon = new System.Windows.Forms.Label();
            this.dgvVatTu = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchKeyword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbPhieuKho = new System.Windows.Forms.GroupBox();
            this.btnSavePhieu = new System.Windows.Forms.Button();
            this.lblTongTienPhieu = new System.Windows.Forms.Label();
            this.dgvChiTietPhieu = new System.Windows.Forms.DataGridView();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmDonGia = new System.Windows.Forms.NumericUpDown();
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoXuat = new System.Windows.Forms.RadioButton();
            this.rdoNhap = new System.Windows.Forms.RadioButton();
            this.nmNguongAnToan = new System.Windows.Forms.GroupBox();
            this.btnCanhBaoTon = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.gbVatTu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatTu)).BeginInit();
            this.gbPhieuKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            this.nmNguongAnToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbVatTu
            // 
            this.gbVatTu.Controls.Add(this.lblTongGiaTriTon);
            this.gbVatTu.Controls.Add(this.dgvVatTu);
            this.gbVatTu.Controls.Add(this.btnSearch);
            this.gbVatTu.Controls.Add(this.label1);
            this.gbVatTu.Controls.Add(this.txtSearchKeyword);
            this.gbVatTu.Location = new System.Drawing.Point(16, 15);
            this.gbVatTu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbVatTu.Name = "gbVatTu";
            this.gbVatTu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbVatTu.Size = new System.Drawing.Size(428, 524);
            this.gbVatTu.TabIndex = 0;
            this.gbVatTu.TabStop = false;
            this.gbVatTu.Text = "Danh mục Vật tư && Tồn kho";
            // 
            // lblTongGiaTriTon
            // 
            this.lblTongGiaTriTon.AutoSize = true;
            this.lblTongGiaTriTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongGiaTriTon.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTongGiaTriTon.Location = new System.Drawing.Point(8, 491);
            this.lblTongGiaTriTon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongGiaTriTon.Name = "lblTongGiaTriTon";
            this.lblTongGiaTriTon.Size = new System.Drawing.Size(238, 20);
            this.lblTongGiaTriTon.TabIndex = 4;
            this.lblTongGiaTriTon.Text = "Tổng giá trị tồn kho: 0 VNĐ";
            this.lblTongGiaTriTon.Click += new System.EventHandler(this.lblTongGiaTriTon_Click);
            // 
            // dgvVatTu
            // 
            this.dgvVatTu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVatTu.Location = new System.Drawing.Point(12, 91);
            this.dgvVatTu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvVatTu.Name = "dgvVatTu";
            this.dgvVatTu.ReadOnly = true;
            this.dgvVatTu.RowHeadersWidth = 51;
            this.dgvVatTu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVatTu.Size = new System.Drawing.Size(408, 396);
            this.dgvVatTu.TabIndex = 3;
            this.dgvVatTu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVatTu_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 55);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(408, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập mã hoặc tên vật tư:";
            // 
            // txtSearchKeyword
            // 
            this.txtSearchKeyword.Location = new System.Drawing.Point(187, 23);
            this.txtSearchKeyword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchKeyword.Name = "txtSearchKeyword";
            this.txtSearchKeyword.Size = new System.Drawing.Size(232, 22);
            this.txtSearchKeyword.TabIndex = 0;
            this.txtSearchKeyword.TextChanged += new System.EventHandler(this.txtSearchKeyword_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(813, 222);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(11, 10);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // gbPhieuKho
            // 
            this.gbPhieuKho.Controls.Add(this.btnSavePhieu);
            this.gbPhieuKho.Controls.Add(this.lblTongTienPhieu);
            this.gbPhieuKho.Controls.Add(this.dgvChiTietPhieu);
            this.gbPhieuKho.Controls.Add(this.btnAddToList);
            this.gbPhieuKho.Controls.Add(this.label4);
            this.gbPhieuKho.Controls.Add(this.label3);
            this.gbPhieuKho.Controls.Add(this.nmDonGia);
            this.gbPhieuKho.Controls.Add(this.nmSoLuong);
            this.gbPhieuKho.Controls.Add(this.cboNCC);
            this.gbPhieuKho.Controls.Add(this.label2);
            this.gbPhieuKho.Controls.Add(this.rdoXuat);
            this.gbPhieuKho.Controls.Add(this.rdoNhap);
            this.gbPhieuKho.Location = new System.Drawing.Point(452, 15);
            this.gbPhieuKho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPhieuKho.Name = "gbPhieuKho";
            this.gbPhieuKho.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPhieuKho.Size = new System.Drawing.Size(467, 430);
            this.gbPhieuKho.TabIndex = 2;
            this.gbPhieuKho.TabStop = false;
            this.gbPhieuKho.Text = "Thông tin Phiếu Kho";
            // 
            // btnSavePhieu
            // 
            this.btnSavePhieu.BackColor = System.Drawing.Color.LightGreen;
            this.btnSavePhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePhieu.Location = new System.Drawing.Point(269, 392);
            this.btnSavePhieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSavePhieu.Name = "btnSavePhieu";
            this.btnSavePhieu.Size = new System.Drawing.Size(190, 28);
            this.btnSavePhieu.TabIndex = 11;
            this.btnSavePhieu.Text = "LƯU PHIẾU KHO (TRANSACTION)";
            this.btnSavePhieu.UseVisualStyleBackColor = false;
            this.btnSavePhieu.Click += new System.EventHandler(this.btnSavePhieu_Click);
            // 
            // lblTongTienPhieu
            // 
            this.lblTongTienPhieu.AutoSize = true;
            this.lblTongTienPhieu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTongTienPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienPhieu.Location = new System.Drawing.Point(31, 394);
            this.lblTongTienPhieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTienPhieu.Name = "lblTongTienPhieu";
            this.lblTongTienPhieu.Size = new System.Drawing.Size(230, 24);
            this.lblTongTienPhieu.TabIndex = 10;
            this.lblTongTienPhieu.Text = "Tổng tiền phiếu: 0 VNĐ";
            this.lblTongTienPhieu.Click += new System.EventHandler(this.lblTongTienPhieu_Click);
            // 
            // dgvChiTietPhieu
            // 
            this.dgvChiTietPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieu.Location = new System.Drawing.Point(12, 150);
            this.dgvChiTietPhieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvChiTietPhieu.Name = "dgvChiTietPhieu";
            this.dgvChiTietPhieu.ReadOnly = true;
            this.dgvChiTietPhieu.RowHeadersWidth = 51;
            this.dgvChiTietPhieu.Size = new System.Drawing.Size(447, 214);
            this.dgvChiTietPhieu.TabIndex = 9;
            this.dgvChiTietPhieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPhieu_CellContentClick);
            // 
            // btnAddToList
            // 
            this.btnAddToList.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddToList.Location = new System.Drawing.Point(312, 55);
            this.btnAddToList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(147, 87);
            this.btnAddToList.TabIndex = 8;
            this.btnAddToList.Text = "Thêm vào phiếu";
            this.btnAddToList.UseVisualStyleBackColor = false;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng:";
            // 
            // nmDonGia
            // 
            this.nmDonGia.Location = new System.Drawing.Point(109, 118);
            this.nmDonGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmDonGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmDonGia.Name = "nmDonGia";
            this.nmDonGia.Size = new System.Drawing.Size(172, 22);
            this.nmDonGia.TabIndex = 5;
            this.nmDonGia.ValueChanged += new System.EventHandler(this.nmDonGia_ValueChanged);
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.Location = new System.Drawing.Point(109, 86);
            this.nmSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmSoLuong.Name = "nmSoLuong";
            this.nmSoLuong.Size = new System.Drawing.Size(172, 22);
            this.nmSoLuong.TabIndex = 4;
            this.nmSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmSoLuong.ValueChanged += new System.EventHandler(this.nmSoLuong_ValueChanged);
            // 
            // cboNCC
            // 
            this.cboNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(109, 53);
            this.cboNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(171, 24);
            this.cboNCC.TabIndex = 3;
            this.cboNCC.SelectedIndexChanged += new System.EventHandler(this.cboNCC_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhà cung cấp:";
            // 
            // rdoXuat
            // 
            this.rdoXuat.AutoSize = true;
            this.rdoXuat.Location = new System.Drawing.Point(168, 25);
            this.rdoXuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoXuat.Name = "rdoXuat";
            this.rdoXuat.Size = new System.Drawing.Size(79, 20);
            this.rdoXuat.TabIndex = 1;
            this.rdoXuat.Text = "Xuất kho";
            this.rdoXuat.UseVisualStyleBackColor = true;
            this.rdoXuat.CheckedChanged += new System.EventHandler(this.rdoXuat_CheckedChanged);
            // 
            // rdoNhap
            // 
            this.rdoNhap.AutoSize = true;
            this.rdoNhap.Checked = true;
            this.rdoNhap.Location = new System.Drawing.Point(8, 25);
            this.rdoNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoNhap.Name = "rdoNhap";
            this.rdoNhap.Size = new System.Drawing.Size(86, 20);
            this.rdoNhap.TabIndex = 0;
            this.rdoNhap.TabStop = true;
            this.rdoNhap.Text = "Nhập kho";
            this.rdoNhap.UseVisualStyleBackColor = true;
            this.rdoNhap.CheckedChanged += new System.EventHandler(this.rdoNhap_CheckedChanged);
            // 
            // nmNguongAnToan
            // 
            this.nmNguongAnToan.Controls.Add(this.btnCanhBaoTon);
            this.nmNguongAnToan.Controls.Add(this.numericUpDown1);
            this.nmNguongAnToan.Controls.Add(this.label5);
            this.nmNguongAnToan.Location = new System.Drawing.Point(452, 452);
            this.nmNguongAnToan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmNguongAnToan.Name = "nmNguongAnToan";
            this.nmNguongAnToan.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmNguongAnToan.Size = new System.Drawing.Size(467, 87);
            this.nmNguongAnToan.TabIndex = 3;
            this.nmNguongAnToan.TabStop = false;
            this.nmNguongAnToan.Text = "Cảnh báo tồn kho";
            // 
            // btnCanhBaoTon
            // 
            this.btnCanhBaoTon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCanhBaoTon.Location = new System.Drawing.Point(203, 13);
            this.btnCanhBaoTon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCanhBaoTon.Name = "btnCanhBaoTon";
            this.btnCanhBaoTon.Size = new System.Drawing.Size(256, 66);
            this.btnCanhBaoTon.TabIndex = 2;
            this.btnCanhBaoTon.Text = "Lọc tồn kho dưới ngưỡng";
            this.btnCanhBaoTon.UseVisualStyleBackColor = false;
            this.btnCanhBaoTon.Click += new System.EventHandler(this.btnCanhBaoTon_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(76, 51);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(119, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngưỡng an toàn <=:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 554);
            this.Controls.Add(this.nmNguongAnToan);
            this.Controls.Add(this.gbPhieuKho);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbVatTu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ XUẤT - NHẬP KHO NGUYÊN VẬT LIỆU";
            this.gbVatTu.ResumeLayout(false);
            this.gbVatTu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatTu)).EndInit();
            this.gbPhieuKho.ResumeLayout(false);
            this.gbPhieuKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            this.nmNguongAnToan.ResumeLayout(false);
            this.nmNguongAnToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVatTu;
        private System.Windows.Forms.Label lblTongGiaTriTon;
        private System.Windows.Forms.DataGridView dgvVatTu;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchKeyword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbPhieuKho;
        private System.Windows.Forms.Button btnSavePhieu;
        private System.Windows.Forms.Label lblTongTienPhieu;
        private System.Windows.Forms.DataGridView dgvChiTietPhieu;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmDonGia;
        private System.Windows.Forms.NumericUpDown nmSoLuong;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoXuat;
        private System.Windows.Forms.RadioButton rdoNhap;
        private System.Windows.Forms.GroupBox nmNguongAnToan;
        private System.Windows.Forms.Button btnCanhBaoTon;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
    }
}

