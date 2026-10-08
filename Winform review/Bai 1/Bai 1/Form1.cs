using System.Globalization;

namespace Bai1
{
    public partial class Form1 : Form
    {
        private const string NhanTongTien = "Tổng Tiền Thanh Toán : ";

        public Form1()
        {
            InitializeComponent();
            lbltongtien.Text = NhanTongTien + "0";
            AcceptButton = btnTinhtien;

  
            txtSoluongKhach.TextChanged += textBox1_TextChanged;
            txtGiamGia.TextChanged += textBox1_TextChanged;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (TinhTien(false, out decimal tong))
                lbltongtien.Text = NhanTongTien + FormatTien(tong);
            else
                lbltongtien.Text = NhanTongTien + "0";
        }

        private void btnTinhtien_Click(object sender, EventArgs e)
        {
            if (TinhTien(true, out decimal tong))
                lbltongtien.Text = NhanTongTien + FormatTien(tong);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDongiadichvu.Clear();
            txtSoluongKhach.Clear();
            txtGiamGia.Clear();
            lbltongtien.Text = NhanTongTien + "0";
            txtDongiadichvu.Focus();
        }

        private bool TinhTien(bool baoLoi, out decimal tong)
        {
            tong = 0;

            if (!DocSo(txtDongiadichvu, "Đơn giá dịch vụ", baoLoi, out decimal donGia)) return false;
            if (!DocSo(txtSoluongKhach, "Số lượng khách", baoLoi, out decimal soLuong)) return false;
            if (!DocSo(txtGiamGia, "Mã giảm giá (%)", baoLoi, out decimal giamGia)) return false;

            if (donGia < 0)
                return Loi(baoLoi, "Đơn giá không được âm.", txtDongiadichvu);
            if (soLuong <= 0 || soLuong != Math.Floor(soLuong))
                return Loi(baoLoi, "Số lượng khách phải là số nguyên dương.", txtSoluongKhach);
            if (giamGia < 0 || giamGia > 100)
                return Loi(baoLoi, "Phần trăm giảm giá phải nằm trong khoảng 0 - 100.", txtGiamGia);

            tong = donGia * soLuong * (100 - giamGia) / 100;
            return true;
        }

        private bool DocSo(TextBox txt, string tenTruong, bool baoLoi, out decimal value)
        {
            value = 0;
            string s = txt.Text.Trim();

            if (s.Length == 0)
                return Loi(baoLoi, $"Vui lòng nhập \"{tenTruong}\".", txt);

            if (!decimal.TryParse(s, NumberStyles.Number, CultureInfo.CurrentCulture, out value))
                return Loi(baoLoi, $"\"{tenTruong}\" phải là một số hợp lệ.", txt);

            return true;
        }

        private bool Loi(bool baoLoi, string message, TextBox focusTo)
        {
            if (baoLoi)
            {
                MessageBox.Show(message, "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                focusTo.Focus();
                focusTo.SelectAll();
            }
            return false;
        }

        private static string FormatTien(decimal tong)
            => tong.ToString("N0", new CultureInfo("vi-VN")) + " VNĐ";

 
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
    }
}