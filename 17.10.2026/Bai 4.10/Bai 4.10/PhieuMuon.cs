namespace Bai_4._10
{
    public class PhieuMuon
    {
        public string MaPhieu { get; set; } = "";
        public string MaSinhVien { get; set; } = "";
        public string HoTenSinhVien { get; set; } = "";
        public string ThietBi { get; set; } = "";
        public int SoLuong { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        public DateTime? NgayTraThucTe { get; set; }

        public static string TinhTinhTrang(DateTime hanTra, DateTime? ngayTra)
        {
            if (ngayTra.HasValue)
                return ngayTra.Value.Date > hanTra.Date ? "Quá hạn" : "Đã trả";

            return hanTra.Date < DateTime.Today ? "Quá hạn" : "Đang mượn";
        }

        public string TinhTrang => TinhTinhTrang(HanTra, NgayTraThucTe);
    }
}