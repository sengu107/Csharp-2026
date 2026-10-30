using System.Globalization;

namespace HotelManagement.DTO
{
    public class PhongDTO
    {
        public string SoPhong { get; set; }
        public string LoaiPhong { get; set; }
        public decimal GiaTheoGio { get; set; }
        public string TrangThai { get; set; }

       
        public string HienThi
        {
            get
            {
                return SoPhong + " - " + LoaiPhong + " - "
                    + GiaTheoGio.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " đ/giờ";
            }
        }
    }
}
