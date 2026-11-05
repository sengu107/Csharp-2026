namespace Market.DTO
{
    
    public class ChiTietHoaDon
    {
        public int MaHD { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }   
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }

        public decimal ThanhTien => SoLuong * DonGia;
    }
}
