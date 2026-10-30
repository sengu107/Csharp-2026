using System.Globalization;

namespace HotelManagement.DTO
{
   
    public class DichVuDTO
    {
        public int MaDV { get; set; }
        public string TenDV { get; set; }
        public decimal DonGia { get; set; }

        
        public string HienThi
        {
            get { return TenDV + " - " + DonGia.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " đ"; }
        }
    }
}
