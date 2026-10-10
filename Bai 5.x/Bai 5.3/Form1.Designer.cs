namespace Bai_5._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbthongtinsanpham = new GroupBox();
            lblmasp = new Label();
            lbltensp = new Label();
            lbldongia = new Label();
            lblSoluong = new Label();
            lblDanhmuc = new Label();
            txtmasp = new TextBox();
            txtdongia = new TextBox();
            txttensp = new TextBox();
            txtsoluong = new TextBox();
            txtdanhmuc = new TextBox();
            grbChucnang = new GroupBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnEdit = new Button();
            btnTimkiem = new Button();
            dgvProducts = new DataGridView();
            grbthongtinsanpham.SuspendLayout();
            grbChucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // grbthongtinsanpham
            // 
            grbthongtinsanpham.Controls.Add(txtdanhmuc);
            grbthongtinsanpham.Controls.Add(txtsoluong);
            grbthongtinsanpham.Controls.Add(txttensp);
            grbthongtinsanpham.Controls.Add(txtdongia);
            grbthongtinsanpham.Controls.Add(txtmasp);
            grbthongtinsanpham.Controls.Add(lblDanhmuc);
            grbthongtinsanpham.Controls.Add(lblSoluong);
            grbthongtinsanpham.Controls.Add(lbldongia);
            grbthongtinsanpham.Controls.Add(lbltensp);
            grbthongtinsanpham.Controls.Add(lblmasp);
            grbthongtinsanpham.Location = new Point(12, 12);
            grbthongtinsanpham.Name = "grbthongtinsanpham";
            grbthongtinsanpham.Size = new Size(267, 321);
            grbthongtinsanpham.TabIndex = 0;
            grbthongtinsanpham.TabStop = false;
            grbthongtinsanpham.Text = "Thông tin sản phẩm";
            // 
            // lblmasp
            // 
            lblmasp.AutoSize = true;
            lblmasp.Location = new Point(28, 37);
            lblmasp.Name = "lblmasp";
            lblmasp.Size = new Size(50, 20);
            lblmasp.TabIndex = 0;
            lblmasp.Text = "Mã SP";
            // 
            // lbltensp
            // 
            lbltensp.AutoSize = true;
            lbltensp.Location = new Point(26, 91);
            lbltensp.Name = "lbltensp";
            lbltensp.Size = new Size(52, 20);
            lbltensp.TabIndex = 1;
            lbltensp.Text = "Tên SP";
            // 
            // lbldongia
            // 
            lbldongia.AutoSize = true;
            lbldongia.Location = new Point(15, 139);
            lbldongia.Name = "lbldongia";
            lbldongia.Size = new Size(63, 20);
            lbldongia.TabIndex = 2;
            lbldongia.Text = "Đơn Giá";
            // 
            // lblSoluong
            // 
            lblSoluong.AutoSize = true;
            lblSoluong.Location = new Point(6, 192);
            lblSoluong.Name = "lblSoluong";
            lblSoluong.Size = new Size(72, 20);
            lblSoluong.TabIndex = 3;
            lblSoluong.Text = "Số Lượng";
            // 
            // lblDanhmuc
            // 
            lblDanhmuc.AutoSize = true;
            lblDanhmuc.Location = new Point(6, 247);
            lblDanhmuc.Name = "lblDanhmuc";
            lblDanhmuc.Size = new Size(76, 20);
            lblDanhmuc.TabIndex = 4;
            lblDanhmuc.Text = "Danh Mục";
            // 
            // txtmasp
            // 
            txtmasp.Location = new Point(100, 34);
            txtmasp.Name = "txtmasp";
            txtmasp.Size = new Size(125, 27);
            txtmasp.TabIndex = 5;
            // 
            // txtdongia
            // 
            txtdongia.Location = new Point(100, 139);
            txtdongia.Name = "txtdongia";
            txtdongia.Size = new Size(125, 27);
            txtdongia.TabIndex = 6;
            // 
            // txttensp
            // 
            txttensp.Location = new Point(100, 88);
            txttensp.Name = "txttensp";
            txttensp.Size = new Size(125, 27);
            txttensp.TabIndex = 7;
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(100, 192);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(125, 27);
            txtsoluong.TabIndex = 8;
            // 
            // txtdanhmuc
            // 
            txtdanhmuc.Location = new Point(100, 244);
            txtdanhmuc.Name = "txtdanhmuc";
            txtdanhmuc.Size = new Size(125, 27);
            txtdanhmuc.TabIndex = 9;
            // 
            // grbChucnang
            // 
            grbChucnang.Controls.Add(btnTimkiem);
            grbChucnang.Controls.Add(btnEdit);
            grbChucnang.Controls.Add(btnRemove);
            grbChucnang.Controls.Add(btnAdd);
            grbChucnang.Location = new Point(18, 349);
            grbChucnang.Name = "grbChucnang";
            grbChucnang.Size = new Size(770, 89);
            grbChucnang.TabIndex = 1;
            grbChucnang.TabStop = false;
            grbChucnang.Text = "Chức Năng";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(9, 39);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(260, 39);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Xoá";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(139, 39);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Location = new Point(383, 39);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(94, 29);
            btnTimkiem.TabIndex = 3;
            btnTimkiem.Text = "Tìm Kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            dgvProducts.BackgroundColor = SystemColors.ButtonHighlight;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.GridColor = SystemColors.InactiveBorder;
            dgvProducts.Location = new Point(295, 24);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(493, 309);
            dgvProducts.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProducts);
            Controls.Add(grbChucnang);
            Controls.Add(grbthongtinsanpham);
            Name = "Form1";
            Text = "QUẢN LÝ DANH SÁCH SẢN PHẨM";
            grbthongtinsanpham.ResumeLayout(false);
            grbthongtinsanpham.PerformLayout();
            grbChucnang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbthongtinsanpham;
        private Label lblDanhmuc;
        private Label lblSoluong;
        private Label lbldongia;
        private Label lbltensp;
        private Label lblmasp;
        private TextBox txtdanhmuc;
        private TextBox txtsoluong;
        private TextBox txttensp;
        private TextBox txtdongia;
        private TextBox txtmasp;
        private GroupBox grbChucnang;
        private Button btnTimkiem;
        private Button btnEdit;
        private Button btnRemove;
        private Button btnAdd;
        private DataGridView dgvProducts;
    }
}
