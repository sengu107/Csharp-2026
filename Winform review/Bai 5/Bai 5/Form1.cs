using System.Globalization;

namespace Bai_5
{
    public partial class Form1 : Form
    {
        private bool dangTinh;  
        public Form1()
        {
            InitializeComponent();

            cbloaivc.SelectedIndex = 0;

    
            errorProvider1.SetIconAlignment(dgvHang, ErrorIconAlignment.TopRight);
            errorProvider1.SetIconPadding(dgvHang, -24);

            CapNhatGio();
            TinhLai();
        }

  
        private void timer1_Tick(object? sender, EventArgs e) => CapNhatGio();

        private void CapNhatGio()
        {
            lblThoiGian.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

       
        private void dgvHang_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dangTinh) return;
            TinhLai();
        }

        private void dgvHang_RowsChanged(object? sender, EventArgs e)
        {
            if (!dangTinh) TinhLai();
        }

 
        private void dgvHang_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

     
        private void TinhLai()
        {
            dangTinh = true;
            try
            {
                decimal tongSL = 0, tongKL = 0, tongTien = 0;
                string? loiDauTien = null;

                foreach (DataGridViewRow row in dgvHang.Rows)
                {
                    if (row.IsNewRow) continue;
                    int dong = row.Index + 1;

                    var cSL = row.Cells[colSoLuong.Index];
                    var cKL = row.Cells[colTrongLuong.Index];
                    var cDG = row.Cells[colDonGia.Index];

                
                    bool coSL = DocSo(cSL.Value, out decimal sl, out bool trongSL);
                    bool slOk = coSL && sl > 0;
                    cSL.ErrorText = (!trongSL && !slOk) ? "Số lượng phải là số lớn hơn 0" : "";

                  
                    bool coKL = DocSo(cKL.Value, out decimal kl, out bool trongKL);
                    bool klOk = coKL && kl > 0;
                    cKL.ErrorText = (!trongKL && !klOk) ? "Trọng lượng phải là số lớn hơn 0" : "";

               
                    bool coDG = DocSo(cDG.Value, out decimal dg, out bool trongDG);
                    bool dgOk = coDG && dg >= 0;
                    cDG.ErrorText = (!trongDG && !dgOk) ? "Đơn giá phải là số không âm" : "";

                    if (loiDauTien == null)
                    {
                        if (cSL.ErrorText.Length > 0) loiDauTien = $"Dòng {dong}: {cSL.ErrorText}";
                        else if (cKL.ErrorText.Length > 0) loiDauTien = $"Dòng {dong}: {cKL.ErrorText}";
                        else if (cDG.ErrorText.Length > 0) loiDauTien = $"Dòng {dong}: {cDG.ErrorText}";
                    }

                  
                    decimal thanhTien = (slOk && dgOk) ? sl * dg : 0;
                    row.Cells[colThanhTien.Index].Value = thanhTien;

                    if (slOk) tongSL += sl;
                    if (klOk) tongKL += kl;
                    tongTien += thanhTien;
                }

              
                errorProvider1.SetError(dgvHang, loiDauTien ?? "");

                var vn = new CultureInfo("vi-VN");
                lblTongSL.Text = $"Tổng số lượng: {tongSL.ToString("N0", vn)}";
                lblTongKL.Text = $"Tổng trọng lượng: {tongKL.ToString("0.##", vn)} kg";
                lblTongTien.Text = $"Tổng tiền: {tongTien.ToString("N0", vn)} đ";
            }
            finally
            {
                dangTinh = false;
            }
        }

       
        private static bool DocSo(object? giaTri, out decimal so, out bool trong)
        {
            string s = Convert.ToString(giaTri, CultureInfo.CurrentCulture)?.Trim() ?? "";
            trong = s.Length == 0;
            so = 0;
            return !trong && decimal.TryParse(s, NumberStyles.Number, CultureInfo.CurrentCulture, out so);
        }

       
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F2)
            {
                ThemDong();
                return true;
            }

           
            if (keyData == Keys.Delete && dgvHang.ContainsFocus && !dgvHang.IsCurrentCellInEditMode)
            {
                XoaDong();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ThemDong()
        {
            dgvHang.EndEdit();
        
            int i = dgvHang.Rows.Add("", 1, "", "", 0m);

            dgvHang.Focus();
            dgvHang.CurrentCell = dgvHang.Rows[i].Cells[colTenHang.Index];
            dgvHang.BeginEdit(true);
        }

        private void XoaDong()
        {
            var cacDong = dgvHang.SelectedCells.Cast<DataGridViewCell>()
                .Select(c => c.RowIndex)
                .Distinct()
                .OrderByDescending(i => i)      
                .ToList();

            foreach (int i in cacDong)
                dgvHang.Rows.RemoveAt(i);
        }
    }
}
