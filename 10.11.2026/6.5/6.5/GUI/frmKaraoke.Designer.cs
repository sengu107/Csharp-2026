namespace KaraokeApp
{
    partial class frmKaraoke
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being cleaned up.
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        // Windows Form Designer generated code

        private void InitializeComponent()
        {
            flpRooms = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            dgvChiTiet = new DataGridView();
            lblTenPhongChon = new Label();
            btnMoPhong = new Button();
            groupBox2 = new GroupBox();
            btnThemDV = new Button();
            nudSoLuong = new NumericUpDown();
            label2 = new Label();
            cbDichVu = new ComboBox();
            label1 = new Label();
            btnThanhToan = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            SuspendLayout();
            // 
            // flpRooms
            // 
            flpRooms.AutoScroll = true;
            flpRooms.Location = new Point(12, 15);
            flpRooms.Margin = new Padding(3, 4, 3, 4);
            flpRooms.Name = "flpRooms";
            flpRooms.Size = new Size(560, 650);
            flpRooms.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvChiTiet);
            groupBox1.Controls.Add(lblTenPhongChon);
            groupBox1.Location = new Point(590, 15);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(460, 400);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi tiết sử dụng phòng";
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Location = new Point(6, 69);
            dgvChiTiet.Margin = new Padding(3, 4, 3, 4);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.RowTemplate.Height = 24;
            dgvChiTiet.Size = new Size(448, 319);
            dgvChiTiet.TabIndex = 1;
            // 
            // lblTenPhongChon
            // 
            lblTenPhongChon.AutoSize = true;
            lblTenPhongChon.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenPhongChon.ForeColor = Color.Blue;
            lblTenPhongChon.Location = new Point(16, 28);
            lblTenPhongChon.Name = "lblTenPhongChon";
            lblTenPhongChon.Size = new Size(190, 20);
            lblTenPhongChon.TabIndex = 0;
            lblTenPhongChon.Text = "Chưa chọn phòng nào";
            // 
            // btnMoPhong
            // 
            btnMoPhong.BackColor = Color.LimeGreen;
            btnMoPhong.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMoPhong.ForeColor = Color.White;
            btnMoPhong.Location = new Point(590, 681);
            btnMoPhong.Margin = new Padding(3, 4, 3, 4);
            btnMoPhong.Name = "btnMoPhong";
            btnMoPhong.Size = new Size(150, 56);
            btnMoPhong.TabIndex = 2;
            btnMoPhong.Text = "Mở Phòng";
            btnMoPhong.UseVisualStyleBackColor = false;
            btnMoPhong.Click += btnMoPhong_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThemDV);
            groupBox2.Controls.Add(nudSoLuong);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cbDichVu);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(590, 431);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(460, 225);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gọi dịch vụ / Đồ uống";
            // 
            // btnThemDV
            // 
            btnThemDV.Location = new Point(315, 150);
            btnThemDV.Margin = new Padding(3, 4, 3, 4);
            btnThemDV.Name = "btnThemDV";
            btnThemDV.Size = new Size(120, 44);
            btnThemDV.TabIndex = 4;
            btnThemDV.Text = "Thêm Dịch Vụ";
            btnThemDV.UseVisualStyleBackColor = true;
            btnThemDV.Click += btnThemDV_Click;
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(132, 98);
            nudSoLuong.Margin = new Padding(3, 4, 3, 4);
            nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(120, 27);
            nudSoLuong.TabIndex = 3;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 100);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Số lượng:";
            // 
            // cbDichVu
            // 
            cbDichVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDichVu.FormattingEnabled = true;
            cbDichVu.Location = new Point(132, 44);
            cbDichVu.Margin = new Padding(3, 4, 3, 4);
            cbDichVu.Name = "cbDichVu";
            cbDichVu.Size = new Size(303, 28);
            cbDichVu.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 48);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Chọn đồ uống:";
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.Crimson;
            btnThanhToan.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(900, 681);
            btnThanhToan.Margin = new Padding(3, 4, 3, 4);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(150, 56);
            btnThanhToan.TabIndex = 4;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // frmKaraoke
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 762);
            Controls.Add(btnThanhToan);
            Controls.Add(groupBox2);
            Controls.Add(btnMoPhong);
            Controls.Add(groupBox1);
            Controls.Add(flpRooms);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmKaraoke";
            Text = "Hệ thống Quản lý Đặt phòng & Dịch vụ Karaoke";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            ResumeLayout(false);

        }



        private System.Windows.Forms.FlowLayoutPanel flpRooms;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Label lblTenPhongChon;
        private System.Windows.Forms.Button btnMoPhong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDichVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThanhToan;
       
    }
}