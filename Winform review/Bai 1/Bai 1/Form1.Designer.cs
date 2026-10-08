namespace Bai1
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            txtDongiadichvu = new TextBox();
            label3 = new Label();
            txtSoluongKhach = new TextBox();
            label4 = new Label();
            txtGiamGia = new TextBox();
            lbltongtien = new Label();
            flowButtons = new FlowLayoutPanel();
            btnTinhtien = new Button();
            btnLamMoi = new Button();
            tableLayoutPanel1.SuspendLayout();
            flowButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtDongiadichvu, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(txtSoluongKhach, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(txtGiamGia, 1, 2);
            tableLayoutPanel1.Controls.Add(lbltongtien, 0, 3);
            tableLayoutPanel1.Controls.Add(flowButtons, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(30, 25, 30, 20);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(640, 330);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(33, 40);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Đơn Giá Dịch Vụ";
            label1.Click += label1_Click;
            // 
            // txtDongiadichvu
            // 
            txtDongiadichvu.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDongiadichvu.Location = new Point(253, 36);
            txtDongiadichvu.Name = "txtDongiadichvu";
            txtDongiadichvu.Size = new Size(354, 27);
            txtDongiadichvu.TabIndex = 0;
            txtDongiadichvu.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(33, 90);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 2;
            label3.Text = "Số Lượng Khách";
            // 
            // txtSoluongKhach
            // 
            txtSoluongKhach.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSoluongKhach.Location = new Point(253, 86);
            txtSoluongKhach.Name = "txtSoluongKhach";
            txtSoluongKhach.Size = new Size(354, 27);
            txtSoluongKhach.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(33, 140);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 4;
            label4.Text = "Mã Giảm Giá (%)";
            // 
            // txtGiamGia
            // 
            txtGiamGia.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtGiamGia.Location = new Point(253, 136);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(354, 27);
            txtGiamGia.TabIndex = 2;
            // 
            // lbltongtien
            // 
            lbltongtien.Anchor = AnchorStyles.Left;
            lbltongtien.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lbltongtien, 2);
            lbltongtien.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbltongtien.ForeColor = Color.Black;
            lbltongtien.Location = new Point(33, 188);
            lbltongtien.Name = "lbltongtien";
            lbltongtien.Size = new Size(240, 28);
            lbltongtien.TabIndex = 6;
            lbltongtien.Text = "Tổng Tiền Thanh Toán : ";
            lbltongtien.Click += label2_Click;
            // 
            // flowButtons
            // 
            flowButtons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowButtons.Controls.Add(btnTinhtien);
            flowButtons.Controls.Add(btnLamMoi);
            flowButtons.Location = new Point(253, 233);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(354, 74);
            flowButtons.TabIndex = 3;
            // 
            // btnTinhtien
            // 
            btnTinhtien.Location = new Point(3, 3);
            btnTinhtien.Name = "btnTinhtien";
            btnTinhtien.Size = new Size(120, 34);
            btnTinhtien.TabIndex = 0;
            btnTinhtien.Text = "Tính Tiền";
            btnTinhtien.UseVisualStyleBackColor = true;
            btnTinhtien.Click += btnTinhtien_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(226, 3);
            btnLamMoi.Margin = new Padding(100, 3, 0, 0);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(120, 34);
            btnLamMoi.TabIndex = 1;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 330);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Máy tính tính cước dịch vụ & Giảm giá";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowButtons;
        private TextBox txtDongiadichvu;
        private TextBox txtSoluongKhach;
        private Label label1;
        private Label lbltongtien;
        private TextBox txtGiamGia;
        private Button btnTinhtien;
        private Button btnLamMoi;
        private Label label3;
        private Label label4;
    }
}