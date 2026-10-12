using System.ComponentModel;

namespace Bai_4._6
{
    [DesignerCategory("Code")]
    public partial class FormProduct : Form, IMdiChildForm
    {
        public event Action<string>? StatusChanged;
        private void Report(string message) => StatusChanged?.Invoke(message);

        private readonly BindingList<Product> _products = new();
        private readonly BindingSource _bs = new();
        private readonly DataGridView dgv = new();
        private readonly TextBox txtName = new() { Width = 170 };
        private readonly TextBox txtPrice = new() { Width = 90 };
        private readonly TextBox txtQty = new() { Width = 60 };
        private int _nextId = 1;

        public FormProduct()
        {
            Text = "Quản lý Sản phẩm";
            ClientSize = new Size(760, 450);

            var btnAdd = new Button { Text = "Thêm", Width = 80 };
            btnAdd.Click += BtnAdd_Click;

            var top = new FlowLayoutPanel { Dock = DockStyle.Top, Height = 48, Padding = new Padding(8, 10, 8, 0) };
            top.Controls.Add(new Label { Text = "Tên", AutoSize = true, Margin = new Padding(0, 6, 4, 0) });
            top.Controls.Add(txtName);
            top.Controls.Add(new Label { Text = "Giá", AutoSize = true, Margin = new Padding(10, 6, 4, 0) });
            top.Controls.Add(txtPrice);
            top.Controls.Add(new Label { Text = "SL", AutoSize = true, Margin = new Padding(10, 6, 4, 0) });
            top.Controls.Add(txtQty);
            top.Controls.Add(btnAdd);

            dgv.Dock = DockStyle.Fill;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Controls.Add(dgv);
            Controls.Add(top);

            Load += FormProduct_Load;
        }

        private void FormProduct_Load(object? sender, EventArgs e)
        {
            _products.Add(new Product { Id = _nextId++, Name = "Bút bi", Price = 5000, Quantity = 100 });
            _products.Add(new Product { Id = _nextId++, Name = "Vở 96 trang", Price = 12000, Quantity = 50 });

            _bs.DataSource = _products;
            dgv.DataSource = _bs;
            dgv.Columns[nameof(Product.Id)].HeaderText = "Mã";
            dgv.Columns[nameof(Product.Name)].HeaderText = "Tên sản phẩm";
            dgv.Columns[nameof(Product.Price)].HeaderText = "Đơn giá";
            dgv.Columns[nameof(Product.Price)].DefaultCellStyle.Format = "N0";
            dgv.Columns[nameof(Product.Quantity)].HeaderText = "Số lượng";

            var ctx = new ContextMenuStrip();
            ctx.Items.Add("Xóa dòng", null, (s, ev) => DeleteCurrent());
            ctx.Items.Add("Làm mới dữ liệu", null, (s, ev) => RefreshData());
            ctx.Items.Add("Xem chi tiết", null, (s, ev) => ShowDetail());
            dgv.ContextMenuStrip = ctx;

            dgv.CellMouseDown += (s, ev) =>
            {
                if (ev.Button == MouseButtons.Right && ev.RowIndex >= 0)
                    dgv.CurrentCell = dgv.Rows[ev.RowIndex].Cells[0];
            };

            Report($"Đã tải {_products.Count} sản phẩm.");
        }

        public void RefreshData()
        {
            _bs.ResetBindings(false);
            Report($"Đã làm mới danh sách sản phẩm ({_products.Count} dòng).");
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            if (!decimal.TryParse(txtPrice.Text, out var price) || price <= 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }
            if (!int.TryParse(txtQty.Text, out var qty) || qty < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQty.Focus();
                return;
            }

            _products.Add(new Product { Id = _nextId++, Name = txtName.Text.Trim(), Price = price, Quantity = qty });
            Report($"Đã thêm sản phẩm {txtName.Text.Trim()} thành công.");
            txtName.Clear(); txtPrice.Clear(); txtQty.Clear();
            txtName.Focus();
        }

        private void DeleteCurrent()
        {
            if (_bs.Current is not Product p) return;
            if (MessageBox.Show($"Xoá sản phẩm {p.Name}?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            _bs.RemoveCurrent();
            Report($"Đã xóa sản phẩm {p.Name}.");
        }

        private void ShowDetail()
        {
            if (_bs.Current is not Product p) return;
            MessageBox.Show($"Mã: {p.Id}\nTên: {p.Name}\nĐơn giá: {p.Price:N0}\nSố lượng: {p.Quantity}",
                "Chi tiết sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Report($"Đã xem chi tiết sản phẩm {p.Name}.");
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}