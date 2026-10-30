using System;

namespace HotelManagement.DTO
{
    
    public class HoaDonDTO
    {
        public int MaPhieu { get; set; }
        public string SoPhong { get; set; }
        public string LoaiPhong { get; set; }
        public string HoTen { get; set; }
        public string CCCD { get; set; }
        public DateTime NgayNhanPhong { get; set; }
        public DateTime NgayTraPhong { get; set; }
        public int SoGio { get; set; }
        public decimal GiaTheoGio { get; set; }
        public decimal TienPhong { get; set; }
        public decimal TienDichVu { get; set; }

        public decimal TongTien
        {
            get { return TienPhong + TienDichVu; }
        }
    }
}
