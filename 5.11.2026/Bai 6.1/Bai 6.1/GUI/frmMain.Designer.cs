namespace Market.GUI
{
    partial class frmMain
    {
        /// <summary>Bien designer can thiet.</summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.miDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.miBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.miBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.miThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            //
            // menuStrip
            //
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDanhMuc,
            this.miBanHang,
            this.miBaoCao,
            this.miThoat});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(984, 24);
            this.menuStrip.TabIndex = 0;
            //
            // miDanhMuc
            //
            this.miDanhMuc.Name = "miDanhMuc";
            this.miDanhMuc.Size = new System.Drawing.Size(76, 20);
            this.miDanhMuc.Text = "Danh muc";
            this.miDanhMuc.Click += new System.EventHandler(this.miDanhMuc_Click);
            //
            // miBanHang
            //
            this.miBanHang.Name = "miBanHang";
            this.miBanHang.Size = new System.Drawing.Size(76, 20);
            this.miBanHang.Text = "Ban hang";
            this.miBanHang.Click += new System.EventHandler(this.miBanHang_Click);
            //
            // miBaoCao
            //
            this.miBaoCao.Name = "miBaoCao";
            this.miBaoCao.Size = new System.Drawing.Size(70, 20);
            this.miBaoCao.Text = "Bao cao";
            this.miBaoCao.Click += new System.EventHandler(this.miBaoCao_Click);
            //
            // miThoat
            //
            this.miThoat.Name = "miThoat";
            this.miThoat.Size = new System.Drawing.Size(55, 20);
            this.miThoat.Text = "Thoat";
            this.miThoat.Click += new System.EventHandler(this.miThoat_Click);
            //
            // frmMain
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesApp - He thong quan ly ban hang";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem miDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem miBanHang;
        private System.Windows.Forms.ToolStripMenuItem miBaoCao;
        private System.Windows.Forms.ToolStripMenuItem miThoat;
    }
}
