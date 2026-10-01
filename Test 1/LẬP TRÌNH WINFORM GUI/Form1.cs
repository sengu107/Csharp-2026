

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTest1
{
    public partial class Form1 : Form
    {
        private readonly List<Product> _all = new List<Product>();
        private readonly BindingList<Product> _view = new BindingList<Product>();
        private string _currentImagePath;

        public Form1()
        {
            InitializeComponent();
            bs.DataSource = _view;
            dgvProducts.DataSource = bs;
            InitData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            OnSelectionChanged();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportCsv();
        }

        private void mnuExportCsv_Click(object sender, EventArgs e)
        {
            ExportCsv();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InitData()
        {
            var cats = new List<Category>
        {
            new Category { Id = 1, Name = "Điện thoại" },
            new Category { Id = 2, Name = "Laptop" },
            new Category { Id = 3, Name = "Phụ kiện" }
        };
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "Id";
            cboCategory.DataSource = cats;

            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string kw = txtSearch.Text.Trim();
            var result = _all
                .Where(p => p.ProductName.IndexOf(kw, StringComparison.CurrentCultureIgnoreCase) >= 0)
                .ToList();

            _view.RaiseListChangedEvents = false;
            _view.Clear();
            foreach (var p in result) _view.Add(p);
            _view.RaiseListChangedEvents = true;
            _view.ResetBindings();

            lblStatus.Text = "Tổng số sản phẩm: " + _all.Count;
        }

        private void OnSelectionChanged()
        {
            var p = bs.Current as Product;
            if (p == null) return;

            errorProvider.Clear();
            txtProductId.Text = p.ProductId;
            txtProductName.Text = p.ProductName;
            txtUnitPrice.Text = p.UnitPrice.ToString("0.##", CultureInfo.InvariantCulture);
            txtQuantity.Text = p.Quantity.ToString();
            cboCategory.SelectedValue = p.CategoryId;
            SetPicture(p.ImagePath);
        }

        private bool ValidateInput()
        {
            errorProvider.Clear();
            bool ok = true;

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                errorProvider.SetError(txtProductName, "Tên sản phẩm không được để trống");
                ok = false;
            }

            if (cboCategory.SelectedItem == null)
            {
                errorProvider.SetError(cboCategory, "Vui lòng chọn danh mục");
                ok = false;
            }

            decimal price;
            if (!decimal.TryParse(txtUnitPrice.Text.Trim(), NumberStyles.Number,
                    CultureInfo.InvariantCulture, out price) || price <= 0)
            {
                errorProvider.SetError(txtUnitPrice, "Đơn giá phải là số lớn hơn 0");
                ok = false;
            }

            int qty;
            if (!int.TryParse(txtQuantity.Text.Trim(), out qty) || qty < 0)
            {
                errorProvider.SetError(txtQuantity, "Số lượng phải là số nguyên >= 0");
                ok = false;
            }

            return ok;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string id = txtProductId.Text.Trim();
            if (id == "") id = GenerateId();

            if (_all.Any(x => x.ProductId.Equals(id, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider.SetError(txtProductId, "Mã sản phẩm đã tồn tại");
                return;
            }

            var p = new Product { ProductId = id };
            FillFromInputs(p);
            _all.Add(p);

            txtSearch.Clear();
            ApplyFilter();
            int idx = bs.IndexOf(p);
            if (idx >= 0) bs.Position = idx;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var p = bs.Current as Product;
            if (p == null)
            {
                MessageBox.Show("Hãy chọn một sản phẩm trên bảng để cập nhật.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!ValidateInput()) return;

            FillFromInputs(p);
            dgvProducts.Refresh();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var p = bs.Current as Product;
            if (p == null)
            {
                MessageBox.Show("Hãy chọn một sản phẩm để xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var rs = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm \"" + p.ProductName + "\"?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes) return;

            _all.Remove(p);
            ApplyFilter();
            ClearInputs();
        }

        private void BtnChooseImage_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog
            {
                Title = "Chọn ảnh sản phẩm",
                Filter = "Ảnh (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    SetPicture(ofd.FileName);
            }
        }

        private void ClearInputs()
        {
            errorProvider.Clear();
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
            SetPicture(null);
            txtProductName.Focus();
        }

        private void FillFromInputs(Product p)
        {
            var cat = (Category)cboCategory.SelectedItem;
            p.ProductName = txtProductName.Text.Trim();
            p.CategoryId = cat.Id;
            p.CategoryName = cat.Name;
            p.UnitPrice = decimal.Parse(txtUnitPrice.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture);
            p.Quantity = int.Parse(txtQuantity.Text.Trim());
            p.ImagePath = _currentImagePath;
        }

        private string GenerateId()
        {
            int n = _all.Count + 1;
            while (_all.Any(x => x.ProductId == "SP" + n.ToString("000"))) n++;
            return "SP" + n.ToString("000");
        }

        private void SetPicture(string path)
        {
            var old = picAvatar.Image;
            picAvatar.Image = LoadImage(path);
            if (old != null) old.Dispose();
            _currentImagePath = path;
        }

        private static Image LoadImage(string path)
        {
            if (string.IsNullOrEmpty(path) || !File.Exists(path)) return null;
            try
            {
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                using (var img = Image.FromStream(fs))
                {
                    return new Bitmap(img);
                }
            }
            catch
            {
                return null;
            }
        }

        private void ExportCsv()
        {
            using (var sfd = new SaveFileDialog
            {
                Title = "Xuất danh sách sản phẩm",
                Filter = "CSV (*.csv)|*.csv",
                FileName = "products.csv"
            })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;

                var sb = new StringBuilder();
                sb.AppendLine("Mã SP,Tên SP,Danh mục,Đơn giá,Số lượng");
                foreach (var p in _all)
                {
                    sb.AppendLine(string.Join(",",
                        Csv(p.ProductId),
                        Csv(p.ProductName),
                        Csv(p.CategoryName),
                        p.UnitPrice.ToString("0.##", CultureInfo.InvariantCulture),
                        p.Quantity.ToString()));
                }

                try
                {
                    File.WriteAllText(sfd.FileName, sb.ToString(), new UTF8Encoding(true));
                    MessageBox.Show("Xuất file thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể ghi file: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static string Csv(string s)
        {
            if (s == null) return "";
            if (s.IndexOfAny(new[] { ',', '"', '\n', '\r' }) >= 0)
                return "\"" + s.Replace("\"", "\"\"") + "\"";
            return s;
        }
    }
}