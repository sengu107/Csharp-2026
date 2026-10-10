namespace Bài_5._2
{
   public class DichVu
    {
        public string Ten { get; set; }
        public decimal Gia { get; set; }

        public override string ToString() => $"{Ten} - {Gia:N0}";
    }

    public partial class Form1 : Form
    {
        private readonly Dictionary<string, List<DichVu>> dsDichVu = new()
        {
            ["Khám bệnh"] = new List<DichVu>
            {
                new DichVu { Ten = "Khám tổng quát", Gia = 150000 },
                new DichVu { Ten = "Khám nội", Gia = 200000 },
                new DichVu { Ten = "Khám tai mũi họng", Gia = 180000 },
            },
            ["Xét nghiệm"] = new List<DichVu>
            {
                new DichVu { Ten = "Xét nghiệm máu", Gia = 250000 },
                new DichVu { Ten = "Xét nghiệm nước tiểu", Gia = 120000 },
                new DichVu { Ten = "Xét nghiệm đường huyết", Gia = 80000 },
            },
            ["Chụp X-Quang"] = new List<DichVu>
            {
                new DichVu { Ten = "X-Quang ngực", Gia = 300000 },
                new DichVu { Ten = "X-Quang cột sống", Gia = 350000 },
                new DichVu { Ten = "X-Quang răng", Gia = 200000 },
            },
            ["Vắc-xin"] = new List<DichVu>
            {
                new DichVu { Ten = "Vắc-xin cúm", Gia = 350000 },
                new DichVu { Ten = "Vắc-xin viêm gan B", Gia = 280000 },
                new DichVu { Ten = "Vắc-xin uốn ván", Gia = 150000 },
            },
        };

        public Form1()
        {
            InitializeComponent();

            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            lstAvailableServices.DoubleClick += lstAvailableServices_DoubleClick;
            btnSelect.Click += btnSelect_Click;
            btnRemove.Click += btnRemove_Click;
            btnClearAll.Click += btnClearAll_Click;

            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Items.AddRange(dsDichVu.Keys.ToArray());
            cboCategory.SelectedIndex = 0;

            TinhTien();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAvailableServices.Items.Clear();
            string loai = cboCategory.SelectedItem?.ToString();
            if (loai != null && dsDichVu.ContainsKey(loai))
            {
                foreach (DichVu dv in dsDichVu[loai])
                    lstAvailableServices.Items.Add(dv);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ChonDichVu();
        }

        private void lstAvailableServices_DoubleClick(object sender, EventArgs e)
        {
            ChonDichVu();
        }

        private void ChonDichVu()
        {
            if (lstAvailableServices.SelectedItem is DichVu dv)
            {
                lstSelectedServices.Items.Add(dv);
                TinhTien();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelectedServices.SelectedIndex >= 0)
            {
                lstSelectedServices.Items.RemoveAt(lstSelectedServices.SelectedIndex);
                TinhTien();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();
            TinhTien();
        }

        private void TinhTien()
        {
            decimal tong = 0;
            foreach (DichVu dv in lstSelectedServices.Items)
                tong += dv.Gia;

            int tyLe = 0;
            if (tong >= 1000000) tyLe = 10;
            else if (tong >= 500000) tyLe = 5;

            decimal thanhTien = tong * (100 - tyLe) / 100;

            lbltongtienchuagiam.Text = "Tổng tiền chưa giảm: " + tong.ToString("N0");
            lbltylechietkhau.Text = "Tỷ lệ chiết khấu (%): " + tyLe;
            lblthanhtienthanhtoan.Text = "Thành tiền thanh toán: " + thanhTien.ToString("N0");
        }
    }
}