namespace Bai_5._4
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public string MaNode { get; set; }
    }

    public partial class Form1 : Form
    {
        private readonly List<NhanVien> dsNhanVien = new List<NhanVien>
        {
            new NhanVien { MaNV = "NV01", HoTen = "Nguyễn Văn An", ChucVu = "Trưởng nhóm", NgayVaoLam = new DateTime(2019, 3, 15), MaNode = "backend" },
            new NhanVien { MaNV = "NV02", HoTen = "Trần Thị Bình", ChucVu = "Lập trình viên", NgayVaoLam = new DateTime(2021, 7, 1), MaNode = "backend" },
            new NhanVien { MaNV = "NV03", HoTen = "Lê Minh Cường", ChucVu = "Lập trình viên", NgayVaoLam = new DateTime(2022, 1, 10), MaNode = "backend" },
            new NhanVien { MaNV = "NV04", HoTen = "Phạm Thu Dung", ChucVu = "Trưởng nhóm", NgayVaoLam = new DateTime(2020, 5, 20), MaNode = "frontend" },
            new NhanVien { MaNV = "NV05", HoTen = "Hoàng Quốc Huy", ChucVu = "Lập trình viên", NgayVaoLam = new DateTime(2023, 2, 6), MaNode = "frontend" },
            new NhanVien { MaNV = "NV06", HoTen = "Vũ Ngọc Lan", ChucVu = "Trưởng phòng", NgayVaoLam = new DateTime(2018, 9, 3), MaNode = "nhansu" },
            new NhanVien { MaNV = "NV07", HoTen = "Đặng Thanh Mai", ChucVu = "Chuyên viên tuyển dụng", NgayVaoLam = new DateTime(2022, 11, 14), MaNode = "tuyendung" },
            new NhanVien { MaNV = "NV08", HoTen = "Bùi Đức Nam", ChucVu = "Chuyên viên tuyển dụng", NgayVaoLam = new DateTime(2023, 6, 19), MaNode = "tuyendung" },
            new NhanVien { MaNV = "NV09", HoTen = "Ngô Phương Oanh", ChucVu = "Trưởng phòng", NgayVaoLam = new DateTime(2017, 4, 2), MaNode = "kinhdoanh" },
            new NhanVien { MaNV = "NV10", HoTen = "Đỗ Hải Phong", ChucVu = "Nhân viên kinh doanh", NgayVaoLam = new DateTime(2021, 12, 8), MaNode = "kinhdoanh" },
        };

        private readonly ImageList largeImages = new ImageList();

        public Form1()
        {
            InitializeComponent();

            Text = "QUẢN LÝ NHÂN VIÊN THEO PHÒNG BAN";
            tvDepartments.Size = new Size(320, 400);
            lsvEmployees.Dock = DockStyle.Fill;

            TaoImageList();
            CauHinhListView();
            CauHinhComboBox();
            XayDungCay();

            tvDepartments.AfterSelect += tvDepartments_AfterSelect;
            cbchedoxem.SelectedIndexChanged += cbchedoxem_SelectedIndexChanged;

            tvDepartments.ExpandAll();
            tvDepartments.SelectedNode = tvDepartments.Nodes[0];
            cbchedoxem.SelectedIndex = 0;
        }

        private static Bitmap VeIcon(int size, Color mau, bool hinhTron)
        {
            Bitmap bmp = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(bmp))
            using (SolidBrush brush = new SolidBrush(mau))
            using (Pen pen = new Pen(Color.FromArgb(70, 70, 70), 1))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Rectangle r = new Rectangle(1, 1, size - 3, size - 3);
                if (hinhTron)
                {
                    g.FillEllipse(brush, r);
                    g.DrawEllipse(pen, r);
                }
                else
                {
                    g.FillRectangle(brush, r);
                    g.DrawRectangle(pen, r);
                }
            }
            return bmp;
        }

        private void TaoImageList()
        {
            Color[] mau = { Color.SteelBlue, Color.Goldenrod, Color.SeaGreen, Color.IndianRed };
            bool[] tron = { false, false, false, true };

            imageList1.Images.Clear();
            largeImages.ColorDepth = ColorDepth.Depth32Bit;
            largeImages.ImageSize = new Size(32, 32);

            for (int i = 0; i < mau.Length; i++)
            {
                imageList1.Images.Add(VeIcon(16, mau[i], tron[i]));
                largeImages.Images.Add(VeIcon(32, mau[i], tron[i]));
            }

            tvDepartments.ImageList = imageList1;
            lsvEmployees.SmallImageList = imageList1;
            lsvEmployees.LargeImageList = largeImages;
        }

        private void CauHinhListView()
        {
            lsvEmployees.View = View.Details;
            lsvEmployees.FullRowSelect = true;
            lsvEmployees.GridLines = true;
            lsvEmployees.MultiSelect = false;

            lsvEmployees.Columns.Clear();
            lsvEmployees.Columns.Add("Mã NV", 80);
            lsvEmployees.Columns.Add("Họ Tên", 170);
            lsvEmployees.Columns.Add("Chức vụ", 150);
            lsvEmployees.Columns.Add("Ngày vào làm", 110);
        }

        private void CauHinhComboBox()
        {
            cbchedoxem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbchedoxem.Items.Clear();
            cbchedoxem.Items.AddRange(new object[] { "Details", "SmallIcon", "LargeIcon", "List", "Tile" });
        }

        private TreeNode TaoNode(string ma, string ten, int chiSoIcon)
        {
            TreeNode node = new TreeNode(ten)
            {
                Name = ma,
                ImageIndex = chiSoIcon,
                SelectedImageIndex = chiSoIcon
            };
            return node;
        }

        private void XayDungCay()
        {
            tvDepartments.Nodes.Clear();

            TreeNode congTy = TaoNode("congty", "Công ty ABC", 0);

            TreeNode phongKT = TaoNode("kythuat", "Phòng Kỹ thuật", 1);
            phongKT.Nodes.Add(TaoNode("backend", "Nhóm Backend", 2));
            phongKT.Nodes.Add(TaoNode("frontend", "Nhóm Frontend", 2));

            TreeNode phongNS = TaoNode("nhansu", "Phòng Nhân sự", 1);
            phongNS.Nodes.Add(TaoNode("tuyendung", "Nhóm Tuyển dụng", 2));

            TreeNode phongKD = TaoNode("kinhdoanh", "Phòng Kinh doanh", 1);

            congTy.Nodes.Add(phongKT);
            congTy.Nodes.Add(phongNS);
            congTy.Nodes.Add(phongKD);

            tvDepartments.Nodes.Add(congTy);
        }

        private void ThuThapMaNode(TreeNode node, HashSet<string> tap)
        {
            tap.Add(node.Name);
            foreach (TreeNode con in node.Nodes)
                ThuThapMaNode(con, tap);
        }

        private void tvDepartments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            HashSet<string> cacMa = new HashSet<string>();
            ThuThapMaNode(e.Node, cacMa);

            lsvEmployees.BeginUpdate();
            lsvEmployees.Items.Clear();

            foreach (NhanVien nv in dsNhanVien.Where(x => cacMa.Contains(x.MaNode)))
            {
                ListViewItem item = new ListViewItem(nv.MaNV) { ImageIndex = 3 };
                item.SubItems.Add(nv.HoTen);
                item.SubItems.Add(nv.ChucVu);
                item.SubItems.Add(nv.NgayVaoLam.ToString("dd/MM/yyyy"));
                lsvEmployees.Items.Add(item);
            }

            lsvEmployees.EndUpdate();
        }

        private void cbchedoxem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbchedoxem.SelectedItem != null)
                lsvEmployees.View = Enum.Parse<View>(cbchedoxem.SelectedItem.ToString());
        }
    }
}