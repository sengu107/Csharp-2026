using System;
using System.Drawing;
using System.Windows.Forms;
using CafePOS.BUS;
using CafePOS.DTO;

namespace CafePOS.GUI
{
    public partial class frmThucDon : Form
    {
        private readonly DanhMucBUS danhMucBUS = new DanhMucBUS();
        private readonly MonAnBUS monAnBUS = new MonAnBUS();

        private int? maMonDangSua = null;

        private System.ComponentModel.IContainer components = null;

        private DataGridView dgvMon;
        private Label lblTen;
        private TextBox txtTenMon;
        private Label lblDanhMuc;
        private ComboBox cboDanhMuc;
        private Label lblGia;
        private TextBox txtDonGia;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;

        public frmThucDon()
        {
            InitializeComponent();
            this.Load += frmThucDon_Load;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvMon = new DataGridView();
            this.lblTen = new Label();
            this.txtTenMon = new TextBox();
            this.lblDanhMuc = new Label();
            this.cboDanhMuc = new ComboBox();
            this.lblGia = new Label();
            this.txtDonGia = new TextBox();
            this.btnThem = new Button();
            this.btnSua = new Button();
            this.btnXoa = new Button();
            this.btnLamMoi = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).BeginInit();
            this.SuspendLayout();
            //
            // dgvMon
            //
            this.dgvMon.AllowUserToAddRows = false;
            this.dgvMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMon.ColumnHeadersHeight = 29;
            this.dgvMon.Location = new Point(15, 15);
            this.dgvMon.Name = "dgvMon";
            this.dgvMon.ReadOnly = true;
            this.dgvMon.RowHeadersWidth = 51;
            this.dgvMon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvMon.Size = new Size(600, 260);
            this.dgvMon.TabIndex = 0;
            this.dgvMon.CellClick += new DataGridViewCellEventHandler(this.dgvMon_CellClick);
            //
            // lblTen
            //
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new Point(15, 290);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new Size(90, 20);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Ten mon:";
            //
            // txtTenMon
            //
            this.txtTenMon.Location = new Point(110, 287);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new Size(250, 27);
            this.txtTenMon.TabIndex = 2;
            //
            // lblDanhMuc
            //
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Location = new Point(15, 325);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new Size(90, 20);
            this.lblDanhMuc.TabIndex = 3;
            this.lblDanhMuc.Text = "Danh muc:";
            //
            // cboDanhMuc
            //
            this.cboDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboDanhMuc.Location = new Point(110, 322);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new Size(250, 28);
            this.cboDanhMuc.TabIndex = 4;
            //
            // lblGia
            //
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new Point(15, 360);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new Size(90, 20);
            this.lblGia.TabIndex = 5;
            this.lblGia.Text = "Don gia:";
            //
            // txtDonGia
            //
            this.txtDonGia.Location = new Point(110, 357);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new Size(250, 27);
            this.txtDonGia.TabIndex = 6;
            //
            // btnThem
            //
            this.btnThem.Location = new Point(400, 287);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new Size(90, 30);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new EventHandler(this.btnThem_Click);
            //
            // btnSua
            //
            this.btnSua.Location = new Point(400, 322);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new Size(90, 30);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new EventHandler(this.btnSua_Click);
            //
            // btnXoa
            //
            this.btnXoa.Location = new Point(400, 357);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new Size(90, 30);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new EventHandler(this.btnXoa_Click);
            //
            // btnLamMoi
            //
            this.btnLamMoi.Location = new Point(400, 392);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new Size(90, 30);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Lam moi";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new EventHandler(this.btnLamMoi_Click);
            //
            // frmThucDon
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(650, 500);
            this.Controls.Add(this.dgvMon);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.lblDanhMuc);
            this.Controls.Add(this.cboDanhMuc);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Name = "frmThucDon";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Quan ly thuc don";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void frmThucDon_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
            LoadMonAn();
        }

        private void LoadDanhMuc()
        {
            var ds = danhMucBUS.GetAll();
            cboDanhMuc.DisplayMember = "TenDanhMuc";
            cboDanhMuc.ValueMember = "MaDanhMuc";
            cboDanhMuc.DataSource = ds;
        }

        private void LoadMonAn()
        {
            dgvMon.DataSource = null;
            dgvMon.DataSource = monAnBUS.GetAll();
        }

        private void dgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvMon.Rows[e.RowIndex];
            maMonDangSua = (int)row.Cells["MaMon"].Value;
            txtTenMon.Text = row.Cells["TenMon"].Value.ToString();
            cboDanhMuc.SelectedValue = row.Cells["MaDanhMuc"].Value;
            txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
        }

      
        private bool TryGetInput(out MonAnDTO mon)
        {
            mon = null;

            if (!decimal.TryParse(txtDonGia.Text, out decimal gia))
            {
                MessageBox.Show("Don gia khong hop le.", "Loi nhap lieu");
                return false;
            }

            mon = new MonAnDTO
            {
                MaMon = maMonDangSua ?? 0,
                TenMon = txtTenMon.Text.Trim(),
                MaDanhMuc = cboDanhMuc.SelectedValue != null ? (int)cboDanhMuc.SelectedValue : 0,
                DonGia = gia
            };
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!TryGetInput(out var mon)) return;
            try
            {
                monAnBUS.Them(mon);
                LoadMonAn();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maMonDangSua == null)
            {
                MessageBox.Show("Chon 1 mon trong danh sach de sua.", "Thong bao");
                return;
            }
            if (!TryGetInput(out var mon)) return;

            try
            {
                monAnBUS.Sua(mon);
                LoadMonAn();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maMonDangSua == null)
            {
                MessageBox.Show("Chon 1 mon trong danh sach de xoa.", "Thong bao");
                return;
            }

            var xacNhan = MessageBox.Show("Xac nhan xoa mon nay?", "Xac nhan",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacNhan != DialogResult.Yes) return;

            try
            {
                monAnBUS.Xoa(maMonDangSua.Value);
                LoadMonAn();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            maMonDangSua = null;
            txtTenMon.Text = "";
            txtDonGia.Text = "";
            if (cboDanhMuc.Items.Count > 0) cboDanhMuc.SelectedIndex = 0;
        }
    }
}