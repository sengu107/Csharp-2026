using System.Collections.Generic;
using HotelManagement.DAL;
using HotelManagement.DTO;

namespace HotelManagement.BUS
{
    public class DichVuBUS
    {
        private readonly DichVuDAL _dal = new DichVuDAL();

        public List<DichVuDTO> GetAll()
        {
            return _dal.GetAll();
        }
    }
}
