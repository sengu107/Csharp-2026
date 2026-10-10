namespace Bai_5._3
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
    }

    public partial class Form1 : Form
    {
        private readonly List<Product> dsSanPham = new List<Product>();
        private readonly BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            dsSanPham.Add(new Product { ProductId = "SP01", ProductName = "Bút bi", UnitPrice = 5000, Quantity = 100, Category = "Văn phòng phẩm" });
            dsSanPham.Add(new Product { ProductId = "SP02", ProductName = "Vở 200 trang", UnitPrice = 18000, Quantity = 50, Category = "Văn phòng phẩm" });
            dsSanPham.Add(new Product { ProductId = "SP03", ProductName = "Chuột không dây", UnitPrice = 150000, Quantity = 20, Category = "Phụ kiện" });

            bs.DataSource = dsSanPham;
            dgvProducts.DataSource = bs;

            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvProducts.Columns["ProductId"].HeaderText = "Mã SP";
            dgvProducts.Columns["ProductName"].HeaderText = "Tên SP";
            dgvProducts.Columns["UnitPrice"].HeaderText = "Đơn giá";
            dgvProducts.Columns["UnitPrice"].DefaultCellStyle.Format = "N0";
            dgvProducts.Columns["Quantity"].HeaderText = "Số lượng";
            dgvProducts.Columns["Category"].HeaderText = "Danh mục";

            dgvProducts.CellClick += dgvProducts_CellClick;
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnRemove.Click += btnRemove_Click;
            btnTimkiem.Click += btnTimkiem_Click;
        }

        private void HienThiTatCa()
        {
            bs.DataSource = dsSanPham;
            bs.ResetBindings(false);
        }

        private void XoaTrangOGhi()
        {
            txtmasp.Clear();
            txttensp.Clear();
            txtdongia.Clear();
            txtsoluong.Clear();
            txtdanhmuc.Clear();
            txtmasp.Focus();
        }

        private Product DocDuLieuTuForm()
        {
            string ma = txtmasp.Text.Trim();
            string ten = txttensp.Text.Trim();
            string danhMuc = txtdanhmuc.Text.Trim();

            if (ma == "" || ten == "" || danhMuc == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SP, Tên SP và Danh mục!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (!decimal.TryParse(txtdongia.Text, out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là số không âm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdongia.Focus();
                return null;
            }

            if (!int.TryParse(txtsoluong.Text, out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên không âm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoluong.Focus();
                return null;
            }

            return new Product
            {
                ProductId = ma,
                ProductName = ten,
                UnitPrice = donGia,
                Quantity = soLuong,
                Category = danhMuc
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product sp = DocDuLieuTuForm();
            if (sp == null) return;

            if (dsSanPham.Any(p => p.ProductId == sp.ProductId))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmasp.Focus();
                return;
            }

            dsSanPham.Add(sp);
            HienThiTatCa();
            XoaTrangOGhi();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvProducts.Rows[e.RowIndex].DataBoundItem is Product sp)
            {
                txtmasp.Text = sp.ProductId;
                txttensp.Text = sp.ProductName;
                txtdongia.Text = sp.UnitPrice.ToString();
                txtsoluong.Text = sp.Quantity.ToString();
                txtdanhmuc.Text = sp.Category;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow?.DataBoundItem is not Product hienTai)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Product moi = DocDuLieuTuForm();
            if (moi == null) return;

            if (dsSanPham.Any(p => p != hienTai && p.ProductId == moi.ProductId))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmasp.Focus();
                return;
            }

            hienTai.ProductId = moi.ProductId;
            hienTai.ProductName = moi.ProductName;
            hienTai.UnitPrice = moi.UnitPrice;
            hienTai.Quantity = moi.Quantity;
            hienTai.Category = moi.Category;

            HienThiTatCa();
            XoaTrangOGhi();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow?.DataBoundItem is not Product sp)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult kq = MessageBox.Show(
                $"Bạn có chắc muốn xóa sản phẩm \"{sp.ProductName}\"?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                dsSanPham.Remove(sp);
                HienThiTatCa();
                XoaTrangOGhi();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtmasp.Text.Trim();

            if (tuKhoa == "")
            {
                HienThiTatCa();
                return;
            }

            List<Product> ketQua = dsSanPham
                .Where(p => p.ProductName.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase))
                .ToList();

            bs.DataSource = ketQua;
            bs.ResetBindings(false);

            if (ketQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}