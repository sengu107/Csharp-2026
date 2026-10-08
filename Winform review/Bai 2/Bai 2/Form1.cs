namespace Bai_2
{
    public partial class Form1 : Form
    {
        private string duongDanAnh = "";

        public Form1()
        {
            InitializeComponent();

     
            cbloaitiepnhan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbloaitiepnhan.Items.AddRange(new object[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });

            pbanhchuploi.SizeMode = PictureBoxSizeMode.StretchImage;
            pbanhchuploi.BorderStyle = BorderStyle.FixedSingle;

            datengaytiepnhan.Format = DateTimePickerFormat.Custom;
            datengaytiepnhan.CustomFormat = "dd/MM/yyyy";

            rbtntrungbinh.Checked = true;           

            btnTaianh.Click += btnTaianh_Click;
            btnGuiyeucau.Click += btnGuiyeucau_Click;
            btn_lamlai.Click += btn_lamlai_Click;

            AcceptButton = btnGuiyeucau;             
        }

      
        private void btnTaianh_Click(object? sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Title = "Chọn ảnh chụp lỗi",
                Filter = "Tệp hình ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
            };

            if (ofd.ShowDialog() != DialogResult.OK) return;

            try
            {
                pbanhchuploi.Image?.Dispose();
                using var tmp = Image.FromFile(ofd.FileName);
                pbanhchuploi.Image = new Bitmap(tmp);   
                duongDanAnh = ofd.FileName;
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể mở tệp ảnh này.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuiyeucau_Click(object? sender, EventArgs e)
        {
            if (txtmaphieu.Text.Trim().Length == 0)
            {
                Canh("Vui lòng nhập Mã phiếu.", txtmaphieu); return;
            }
            if (txtnguoiyeucau.Text.Trim().Length == 0)
            {
                Canh("Vui lòng nhập Người yêu cầu.", txtnguoiyeucau); return;
            }
            if (cbloaitiepnhan.SelectedIndex < 0)
            {
                Canh("Vui lòng chọn Loại sự cố.", cbloaitiepnhan); return;
            }

            string mucDo = rbtnthap.Checked ? "Thấp"
                         : rbtnkhancap.Checked ? "Khẩn cấp"
                         : "Trung bình";

            var thietBi = new List<string>();
            if (chkbMaytinhban.Checked) thietBi.Add(chkbMaytinhban.Text);
            if (chkbLaptop.Checked) thietBi.Add(chkbLaptop.Text);
            if (chkbMayin.Checked) thietBi.Add(chkbMayin.Text);
            if (chkbDienthoai.Checked) thietBi.Add(chkbDienthoai.Text);

            string tomTat =
                $"Mã phiếu: {txtmaphieu.Text.Trim()}\n" +
                $"Người yêu cầu: {txtnguoiyeucau.Text.Trim()}\n" +
                $"Ngày tiếp nhận: {datengaytiepnhan.Value:dd/MM/yyyy}\n" +
                $"Loại sự cố: {cbloaitiepnhan.SelectedItem}\n" +
                $"Mức độ: {mucDo}\n" +
                $"Thiết bị ảnh hưởng: {(thietBi.Count > 0 ? string.Join(", ", thietBi) : "(không chọn)")}\n" +
                $"Ảnh lỗi: {(duongDanAnh.Length > 0 ? Path.GetFileName(duongDanAnh) : "(chưa tải)")}";

            MessageBox.Show(tomTat, "Tóm tắt yêu cầu",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btn_lamlai_Click(object? sender, EventArgs e)
        {
            txtmaphieu.Clear();
            txtnguoiyeucau.Clear();
            datengaytiepnhan.Value = DateTime.Now;
            cbloaitiepnhan.SelectedIndex = -1;
            rbtntrungbinh.Checked = true;
            chkbMaytinhban.Checked = chkbLaptop.Checked =
                chkbMayin.Checked = chkbDienthoai.Checked = false;
            pbanhchuploi.Image?.Dispose();
            pbanhchuploi.Image = null;
            duongDanAnh = "";
            txtmaphieu.Focus();
        }

        private static void Canh(string msg, Control focusTo)
        {
            MessageBox.Show(msg, "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            focusTo.Focus();
        }

    
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
    }
}