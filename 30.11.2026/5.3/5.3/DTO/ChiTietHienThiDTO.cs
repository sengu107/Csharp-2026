namespace CafePOS.DTO
{
   
    public class ChiTietHienThiDTO
    {
        public int MaMon { get; set; }
        public string TenMon { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien => SoLuong * DonGia;
    }
}
