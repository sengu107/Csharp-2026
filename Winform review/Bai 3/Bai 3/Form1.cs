using System.Globalization;

namespace Bai_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbdonvitinh.SelectedIndex = 0;
            ActiveControl = txtmavt;
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            if (!DocForm(out string ma, out string ten, out string dvt, out decimal gia)) return;

       
            if (TimTheoMa(ma, null) != null)
            {
                Canh($"Mã vật tư \"{ma}\" đã tồn tại trong danh sách.", txtmavt);
                return;
            }

            var item = new ListViewItem(ma);
            item.SubItems.Add(ten);
            item.SubItems.Add(dvt);
            item.SubItems.Add(FormatGia(gia));
            item.Tag = gia;                      
            lvvattu.Items.Add(item);

            XoaOnhap();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (lvvattu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng trong danh sách để cập nhật.",
                    "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!DocForm(out string ma, out string ten, out string dvt, out decimal gia)) return;

            var item = lvvattu.SelectedItems[0];

       
            if (TimTheoMa(ma, item) != null)
            {
                Canh($"Mã vật tư \"{ma}\" đã tồn tại ở dòng khác.", txtmavt);
                return;
            }

            item.Text = ma;
            item.SubItems[1].Text = ten;
            item.SubItems[2].Text = dvt;
            item.SubItems[3].Text = FormatGia(gia);
            item.Tag = gia;
        }

   
        private void btnXoadong_Click(object sender, EventArgs e)
        {
            if (lvvattu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.",
                    "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var item = lvvattu.SelectedItems[0];
            var kq = MessageBox.Show(
                $"Bạn có chắc muốn xóa vật tư \"{item.Text} - {item.SubItems[1].Text}\" không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                lvvattu.Items.Remove(item);
                XoaOnhap();
            }
        }

        private void btnXoatatca_Click(object sender, EventArgs e)
        {
            if (lvvattu.Items.Count == 0) return;

            var kq = MessageBox.Show("Bạn có chắc muốn xóa toàn bộ danh sách không?",
                "Xác nhận xóa toàn bộ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (kq == DialogResult.Yes)
            {
                lvvattu.Items.Clear();
                XoaOnhap();
            }
        }

    
        private void lvvattu_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lvvattu.SelectedItems.Count == 0) return;

            var item = lvvattu.SelectedItems[0];
            txtmavt.Text = item.Text;
            txttenvt.Text = item.SubItems[1].Text;
            cbdonvitinh.SelectedItem = item.SubItems[2].Text;
            txtdongia.Text = ((decimal)item.Tag!).ToString(CultureInfo.CurrentCulture);
        }

        
        private bool DocForm(out string ma, out string ten, out string dvt, out decimal gia)
        {
            ma = txtmavt.Text.Trim();
            ten = txttenvt.Text.Trim();
            dvt = cbdonvitinh.SelectedItem?.ToString() ?? "";
            gia = 0;

            if (ma.Length == 0) { Canh("Vui lòng nhập Mã vật tư.", txtmavt); return false; }
            if (ten.Length == 0) { Canh("Vui lòng nhập Tên vật tư.", txttenvt); return false; }
            if (dvt.Length == 0) { Canh("Vui lòng chọn Đơn vị tính.", cbdonvitinh); return false; }

            if (txtdongia.Text.Trim().Length == 0)
            {
                Canh("Vui lòng nhập Đơn giá nhập.", txtdongia); return false;
            }
            if (!decimal.TryParse(txtdongia.Text.Trim(), NumberStyles.Number,
                    CultureInfo.CurrentCulture, out gia))
            {
                Canh("Đơn giá phải là một số hợp lệ.", txtdongia); return false;
            }
            if (gia < 0)
            {
                Canh("Đơn giá không được âm.", txtdongia); return false;
            }
            return true;
        }
        private ListViewItem? TimTheoMa(string ma, ListViewItem? boQua)
        {
            foreach (ListViewItem it in lvvattu.Items)
            {
                if (it != boQua &&
                    string.Equals(it.Text, ma, StringComparison.OrdinalIgnoreCase))
                    return it;
            }
            return null;
        }

        private void XoaOnhap()
        {
            txtmavt.Clear();
            txttenvt.Clear();
            txtdongia.Clear();
            cbdonvitinh.SelectedIndex = 0;
            lvvattu.SelectedItems.Clear();
            txtmavt.Focus();
        }

        private static string FormatGia(decimal gia)
            => gia.ToString("N0", new CultureInfo("vi-VN"));

        private static void Canh(string msg, Control focusTo)
        {
            MessageBox.Show(msg, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            focusTo.Focus();
        }
    }
}