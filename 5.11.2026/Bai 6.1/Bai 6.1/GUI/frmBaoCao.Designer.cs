namespace Market.GUI
{
    partial class frmBaoCao
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblHomNay = new System.Windows.Forms.Label();
            this.lblDoanhThuHomNay = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.lblDoanhThuThangNay = new System.Windows.Forms.Label();
            this.lblTu = new System.Windows.Forms.Label();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.btnXemDoanhThu = new System.Windows.Forms.Button();
            this.lblDoanhThuKhoang = new System.Windows.Forms.Label();
            this.lblTop5 = new System.Windows.Forms.Label();
            this.dgvTop5 = new System.Windows.Forms.DataGridView();
            this.btnLamMoiBaoCao = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvTop5)).BeginInit();
            this.SuspendLayout();

            //
            // lblHomNay
            //
            this.lblHomNay.Text = "Doanh thu hom nay:";
            this.lblHomNay.Location = new System.Drawing.Point(10, 15);
            this.lblHomNay.Size = new System.Drawing.Size(150, 23);
            //
            // lblDoanhThuHomNay
            //
            this.lblDoanhThuHomNay.Location = new System.Drawing.Point(170, 15);
            this.lblDoanhThuHomNay.Size = new System.Drawing.Size(200, 23);
            this.lblDoanhThuHomNay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            //
            // lblThang
            //
            this.lblThang.Text = "Doanh thu thang nay:";
            this.lblThang.Location = new System.Drawing.Point(10, 45);
            this.lblThang.Size = new System.Drawing.Size(150, 23);
            //
            // lblDoanhThuThangNay
            //
            this.lblDoanhThuThangNay.Location = new System.Drawing.Point(170, 45);
            this.lblDoanhThuThangNay.Size = new System.Drawing.Size(200, 23);
            this.lblDoanhThuThangNay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            //
            // lblTu
            //
            this.lblTu.Text = "Tu ngay:";
            this.lblTu.Location = new System.Drawing.Point(10, 85);
            this.lblTu.Size = new System.Drawing.Size(60, 23);
            //
            // dtpTu
            //
            this.dtpTu.Location = new System.Drawing.Point(75, 82);
            this.dtpTu.Size = new System.Drawing.Size(150, 23);
            //
            // lblDen
            //
            this.lblDen.Text = "Den ngay:";
            this.lblDen.Location = new System.Drawing.Point(240, 85);
            this.lblDen.Size = new System.Drawing.Size(65, 23);
            //
            // dtpDen
            //
            this.dtpDen.Location = new System.Drawing.Point(310, 82);
            this.dtpDen.Size = new System.Drawing.Size(150, 23);
            //
            // btnXemDoanhThu
            //
            this.btnXemDoanhThu.Text = "Xem doanh thu";
            this.btnXemDoanhThu.Location = new System.Drawing.Point(470, 81);
            this.btnXemDoanhThu.Size = new System.Drawing.Size(130, 25);
            this.btnXemDoanhThu.Click += new System.EventHandler(this.btnXemDoanhThu_Click);
            //
            // lblDoanhThuKhoang
            //
            this.lblDoanhThuKhoang.Location = new System.Drawing.Point(10, 120);
            this.lblDoanhThuKhoang.Size = new System.Drawing.Size(500, 23);
            this.lblDoanhThuKhoang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            //
            // lblTop5
            //
            this.lblTop5.Text = "Top 5 san pham ban chay nhat:";
            this.lblTop5.Location = new System.Drawing.Point(10, 160);
            this.lblTop5.Size = new System.Drawing.Size(250, 23);
            //
            // dgvTop5
            //
            this.dgvTop5.Location = new System.Drawing.Point(10, 185);
            this.dgvTop5.Size = new System.Drawing.Size(850, 300);
            this.dgvTop5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTop5.ReadOnly = true;
            this.dgvTop5.AllowUserToAddRows = false;
            //
            // btnLamMoiBaoCao
            //
            this.btnLamMoiBaoCao.Text = "Lam moi bao cao";
            this.btnLamMoiBaoCao.Location = new System.Drawing.Point(10, 500);
            this.btnLamMoiBaoCao.Size = new System.Drawing.Size(150, 30);
            this.btnLamMoiBaoCao.Click += new System.EventHandler(this.btnLamMoiBaoCao_Click);

            //
            // frmBaoCao
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lblHomNay);
            this.Controls.Add(this.lblDoanhThuHomNay);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.lblDoanhThuThangNay);
            this.Controls.Add(this.lblTu);
            this.Controls.Add(this.dtpTu);
            this.Controls.Add(this.lblDen);
            this.Controls.Add(this.dtpDen);
            this.Controls.Add(this.btnXemDoanhThu);
            this.Controls.Add(this.lblDoanhThuKhoang);
            this.Controls.Add(this.lblTop5);
            this.Controls.Add(this.dgvTop5);
            this.Controls.Add(this.btnLamMoiBaoCao);
            this.Name = "frmBaoCao";
            this.Text = "Bao cao - Thong ke";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop5)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblHomNay;
        private System.Windows.Forms.Label lblDoanhThuHomNay;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblDoanhThuThangNay;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtpTu;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.DateTimePicker dtpDen;
        private System.Windows.Forms.Button btnXemDoanhThu;
        private System.Windows.Forms.Label lblDoanhThuKhoang;
        private System.Windows.Forms.Label lblTop5;
        private System.Windows.Forms.DataGridView dgvTop5;
        private System.Windows.Forms.Button btnLamMoiBaoCao;
    }
}
