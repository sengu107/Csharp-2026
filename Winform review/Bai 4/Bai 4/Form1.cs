using System.Globalization;

namespace Bai_4
{
    public partial class Form1 : Form
    {
        private enum TrangThai { Trong, DangChon, DaDat }

        private const int SoHang = 4;
        private const int SoCot = 5;

        private static readonly Color MauTrong = Color.Gainsboro;
        private static readonly Color MauChon = Color.MediumSeaGreen;
        private static readonly Color MauDat = Color.IndianRed;

 
        private static readonly int[] GiaTheoGio = { 100000, 150000 };

        private readonly List<Button> dsViTri = new();

        public Form1()
        {
            InitializeComponent();

          
            Load += Form1_Load;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            btnXacnhan.Click += btnXacnhan_Click;
            btnHuychon.Click += btnHuychon_Click;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "Sáng - 100.000đ", "Tối - 150.000đ" });

            label2.Font = label3.Font = new Font(Font, FontStyle.Bold);
            label2.ForeColor = Color.Firebrick;

            ftblChonCho.AutoScroll = false;
            ftblChonCho.WrapContents = true;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            for (int i = 0; i < SoHang * SoCot; i++)
            {
                int hang = i / SoCot;
                int cot = i % SoCot;

                var btn = new Button
                {
                    Name = $"btnViTri{i + 1}",
                    Text = $"{(char)('A' + hang)}{cot + 1}",   
                    Size = new Size(150, 100),               
                    Margin = new Padding(5),
                    FlatStyle = FlatStyle.Flat,
                    UseVisualStyleBackColor = false,
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                    Tag = TrangThai.Trong
                };
                btn.BackColor = MauTrong;

         
                btn.Click += btnViTri_Click;

                ftblChonCho.Controls.Add(btn);
                dsViTri.Add(btn);
            }

          
       
            comboBox1.SelectedIndex = 0;
            CapNhatThongKe();
        }


        private void btnViTri_Click(object? sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            var tt = (TrangThai)btn.Tag!;

            if (tt == TrangThai.DaDat)
            {
                MessageBox.Show($"Vị trí {btn.Text} đã có người đặt.", "Không thể chọn",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

  
            DatTrangThai(btn, tt == TrangThai.Trong ? TrangThai.DangChon : TrangThai.Trong);
            CapNhatThongKe();
        }


        private void comboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            CapNhatThongKe();
        }

   
        private void btnXacnhan_Click(object? sender, EventArgs e)
        {
            var dangChon = dsViTri.Where(b => (TrangThai)b.Tag! == TrangThai.DangChon).ToList();

            if (dangChon.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn vị trí nào.", "Chưa chọn",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tong = TinhTien(dangChon.Count);
            string viTri = string.Join(", ", dangChon.Select(b => b.Text));

            var kq = MessageBox.Show(
                $"Khung giờ: {comboBox1.SelectedItem}\n" +
                $"Vị trí: {viTri}\n" +
                $"Số lượng: {dangChon.Count}\n" +
                $"Tổng tiền: {FormatTien(tong)}\n\nXác nhận đặt?",
                "Xác nhận đặt chỗ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq != DialogResult.Yes) return;

            foreach (var b in dangChon)
                DatTrangThai(b, TrangThai.DaDat);

            CapNhatThongKe();
            MessageBox.Show("Đặt chỗ thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

   
        private void btnHuychon_Click(object? sender, EventArgs e)
        {
            foreach (var b in dsViTri)
            {
                if ((TrangThai)b.Tag! == TrangThai.DangChon)
                    DatTrangThai(b, TrangThai.Trong);   
            }
            CapNhatThongKe();
        }

   

        private static void DatTrangThai(Button btn, TrangThai tt)
        {
            btn.Tag = tt;
            switch (tt)
            {
                case TrangThai.Trong:
                    btn.BackColor = MauTrong;
                    btn.ForeColor = Color.Black;
                    break;
                case TrangThai.DangChon:
                    btn.BackColor = MauChon;
                    btn.ForeColor = Color.White;
                    break;
                case TrangThai.DaDat:
                    btn.BackColor = MauDat;
                    btn.ForeColor = Color.White;
                    break;
            }
        }

  
        private void CapNhatThongKe()
        {
            int soChon = dsViTri.Count(b => (TrangThai)b.Tag! == TrangThai.DangChon);
            label3.Text = $"Số chỗ đang chọn: {soChon}";
            label2.Text = $"Tạm Tính Tiền: {FormatTien(TinhTien(soChon))}";
        }

        private decimal TinhTien(int soLuong)
        {
            int idx = Math.Max(comboBox1.SelectedIndex, 0);
            return (decimal)soLuong * GiaTheoGio[idx];
        }

        private static string FormatTien(decimal tien)
            => tien.ToString("N0", new CultureInfo("vi-VN")) + " đ";
    }
}