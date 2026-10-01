public abstract class Phuongtien
{
    private string _maPT = "PT000";
    private string _tenHang;
    private int _namSanXuat;
    private decimal _giaGoc;

    public string maPT
    {
        get => _maPT;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("ma phuong tien khong duoc de trong.");
            }
            _maPT = value.Trim();
        }
    }

    public string tenHang
    {
        get => _tenHang;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("ten hang khong duoc de trong.");
            }
            _tenHang = value.Trim();
        }
    }

    public int namSanXuat
    {
        get => _namSanXuat;
        set
        {
            if (value < 1900 || value > DateTime.Now.Year)
            {
                throw new ArgumentException("Nam san xuat khong hop le!");
            }
            _namSanXuat = value;
        }
    }

    public decimal giaGoc
    {
        get => _giaGoc;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("giaGoc", "gia goc phai lon hon 0.");
            }
            _giaGoc = value;
        }
    }

    protected Phuongtien(string maPT, string tenHang, int namSanXuat, decimal giaGoc)
    {
        this.maPT = maPT;
        this.tenHang = tenHang;
        this.namSanXuat = namSanXuat;
        this.giaGoc = giaGoc;
    }

    public abstract decimal TinhGiaLanBanh();

    public virtual string GetInfo()
    {
        return $"ma phuong tien: {maPT}, ten hang: {tenHang}, nam san xuat: {namSanXuat}, gia goc: {giaGoc:N0}";
    }
}

public class Oto : Phuongtien
{
    private int _soChoNgoi;
    private double _dungtichDongCo;

    public int soChoNgoi
    {
        get => _soChoNgoi;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("soChoNgoi", "so cho ngoi phai lon hon 0.");
            }
            _soChoNgoi = value;
        }
    }

    public double dungtichDongCo
    {
        get => _dungtichDongCo;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(dungtichDongCo), "dung tich dong co phai lon hon 0.");
            }
            _dungtichDongCo = value;
        }
    }

    public Oto(string maPT, string tenHang, int namSanXuat, decimal giaGoc, int soChoNgoi, double dungtichDongCo)
        : base(maPT, tenHang, namSanXuat, giaGoc)
    {
        this.soChoNgoi = soChoNgoi;
        this.dungtichDongCo = dungtichDongCo;
    }

    public override decimal TinhGiaLanBanh()
    {
        decimal thueTruocBa;
        decimal thueTieuThuDacBiet;
        if (soChoNgoi <= 9)
        {
            thueTruocBa = giaGoc * 0.12m;
            thueTieuThuDacBiet = giaGoc * 0.30m;
        }
        else
        {
            thueTruocBa = giaGoc * 0.10m;
            thueTieuThuDacBiet = giaGoc * 0m;
        }
        return giaGoc + thueTruocBa + thueTieuThuDacBiet;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $", so cho ngoi: {soChoNgoi}, dung tich dong co: {dungtichDongCo}, gia lan banh: {TinhGiaLanBanh():N0}";
    }
}

public class Xemay : Phuongtien
{
    private int _dungTichXylanh;

    public int dungTichXylanh
    {
        get => _dungTichXylanh;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(dungTichXylanh), "dung tich xy lanh phai lon hon 0.");
            }
            _dungTichXylanh = value;
        }
    }

    public Xemay(string maPT, string tenHang, int namSanXuat, decimal giaGoc, int dungTichXylanh)
        : base(maPT, tenHang, namSanXuat, giaGoc)
    {
        this.dungTichXylanh = dungTichXylanh;
    }

    public override decimal TinhGiaLanBanh()
    {
        decimal thueTruocBa = dungTichXylanh < 175
            ? giaGoc * 0.02m
            : giaGoc * 0.05m;
        return giaGoc + thueTruocBa;
    }
}

public class QuanlyPhuongTien
{
    private readonly List<Phuongtien> _danhSach = new List<Phuongtien>();

    public void addPhuongtien(Phuongtien pt)
    {
        if (pt == null)
            throw new ArgumentNullException(nameof(pt), "phuong tien khong duoc de trong.");

        _danhSach.Add(pt);
    }
    public void hienthi()
    {
        if(_danhSach.Count == 0)
        {
            Console.WriteLine("Danh sach phuong tien rong.");
            return;
        }
        foreach(Phuongtien pt in _danhSach)
        {
            Console.WriteLine(pt.GetInfo());
            Console.WriteLine($"Gia Lan Banh:{pt.TinhGiaLanBanh():N0}");
        }
    }
    public Phuongtien maxgialanhbanh()
    {
        if (_danhSach.Count == 0) return null;


        Phuongtien max = _danhSach[0];
        decimal maxGia = max.TinhGiaLanBanh();

        for (int i = 1; i < _danhSach.Count; i++)
        {
            decimal gia = _danhSach[i].TinhGiaLanBanh();
            if (gia > maxGia)
            {
                max = _danhSach[i];
                maxGia = gia;
            }
        }

        return max;
    }
    public List<Phuongtien> SearchByName(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
            return new List<Phuongtien>();

        return _danhSach
            .Where(pt => pt.tenHang.Contains(keyword.Trim(), StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}


    class Program
    {
        static void Report(string id, string ten, bool pass, string chiTiet = "")
        {
            Console.WriteLine($"[{(pass ? "PASS" : "FAIL")}] {id} - {ten} {chiTiet}");
        }

        static void Main()
        {
            const string MSG_NAM = "Nam san xuat khong hop le!";

            // ===== 5 san pham =====
            var oto1 = new Oto("OT001", "Toyota", 2022, 1_000_000_000m, 5, 2.0);
            var oto2 = new Oto("OT002", "Ford", 2021, 1_200_000_000m, 16, 2.3);
            var oto3 = new Oto("OT003", "Mazda", 2023, 700_000_000m, 7, 2.5);
            var xe1 = new Xemay("XM001", "Honda", 2023, 50_000_000m, 150);
            var xe2 = new Xemay("XM002", "Yamaha", 2022, 100_000_000m, 175);

            var ql = new QuanlyPhuongTien();
            ql.addPhuongtien(oto1);
            ql.addPhuongtien(oto2);
            ql.addPhuongtien(oto3);
            ql.addPhuongtien(xe1);
            ql.addPhuongtien(xe2);

            Console.WriteLine("=== DANH SACH 5 PHUONG TIEN ===");
            ql.hienthi();
            Console.WriteLine("\n=== KET QUA KIEM THU ===");

            // TC01: nam san xuat = 1850 phai nem ArgumentException
            try
            {
                var loi = new Oto("OT000", "Toyota", 1850, 1_000_000_000m, 5, 2.0);
                Report("TC01", "Validation nam san xuat", false, "(khong nem ngoai le)");
            }
            catch (ArgumentException ex)
            {
                Report("TC01", "Validation nam san xuat", ex.Message == MSG_NAM,
                       $"(message: \"{ex.Message}\")");
            }

            // TC02: Oto 5 cho, gia goc 1 ty => 1.420.000.000
            decimal giaOto = oto1.TinhGiaLanBanh();
            Report("TC02", "Gia lan banh Oto", giaOto == 1_420_000_000m, $"(thuc te: {giaOto:N0})");

            // TC03: Xe may 150cc, gia goc 50 trieu => 51.000.000
            decimal giaXe = xe1.TinhGiaLanBanh();
            Report("TC03", "Gia lan banh Xe may", giaXe == 51_000_000m, $"(thuc te: {giaXe:N0})");

            // TC04: da hinh - vong lap tren List<Phuongtien> gom ca Oto va Xemay
            var ds = new List<Phuongtien> { oto1, oto2, oto3, xe1, xe2 };
            decimal[] kyVong =
            {
            1_420_000_000m,   // oto1
            1_320_000_000m,   // oto2
              994_000_000m,   // oto3
               51_000_000m,   // xe1
              105_000_000m    // xe2
        };

            bool daHinh = true;
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].TinhGiaLanBanh() != kyVong[i])
                    daHinh = false;
            }
            Report("TC04", "Da hinh List<Phuongtien>", daHinh, $"({ds.Count} phuong tien)");

            // TC05: phuong tien co gia lan banh cao nhat phai la oto1
            Phuongtien max = ql.maxgialanhbanh();
            bool dung = max != null && ReferenceEquals(max, oto1) && max.TinhGiaLanBanh() == 1_420_000_000m;
            Report("TC05", "Tim gia lan banh max", dung,
                   $"(tra ve: {max?.maPT}, {max?.TinhGiaLanBanh():N0})");
        }
    }