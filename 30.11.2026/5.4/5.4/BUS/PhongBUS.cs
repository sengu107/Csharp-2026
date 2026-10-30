using System.Collections.Generic;
using System.Data;
using HotelManagement.DAL;
using HotelManagement.DTO;

namespace HotelManagement.BUS
{
    public class PhongBUS
    {
        private readonly PhongDAL _dal = new PhongDAL();


        public DataTable GetAll()
        {
            return _dal.GetAll();
        }

        public List<PhongDTO> GetPhongTrong()
        {
            return _dal.GetByTrangThai(TrangThaiPhong.Trong);
        }

  
        public void HoanTatDonDep(string soPhong)
        {
            if (string.IsNullOrWhiteSpace(soPhong))
                throw new BusinessException("Vui lòng chọn một phòng.");

            int rows = _dal.CapNhatTrangThai(soPhong, TrangThaiPhong.Trong, TrangThaiPhong.DangDon);
            if (rows != 1)
                throw new BusinessException("Phòng " + soPhong + " không ở trạng thái \"Đang dọn dẹp\".");
        }
    }
}
