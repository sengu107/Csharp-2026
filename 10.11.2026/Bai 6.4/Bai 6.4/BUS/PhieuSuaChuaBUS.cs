using Bai_6_4.DAL;
using Bai_6_4.DTO;
using System.Collections.Generic;
using System.Data;

namespace Bai_6_4.BUS
{
    public class PhieuSuaChuaBUS
    {
        private PhieuSuaChuaDAL dal = new PhieuSuaChuaDAL();

        public bool LapPhieuMoi(PhieuSuaChuaDTO phieu, List<ChiTietSuaChuaDTO> chiTietList, out string error)
        {
            if (string.IsNullOrWhiteSpace(phieu.BienSo))
            {
                error = "Bien so xe khong duoc de trong!";
                return false;
            }
            if (chiTietList == null || chiTietList.Count == 0)
            {
                error = "Phieu sua chua phai co it nhat mot phu tung hoac dich vu!";
                return false;
            }

            return dal.LapPhieuSuaChua(phieu, chiTietList, out error);
        }

        public bool ThanhToan(int maPhieu)
        {
            return dal.ThanhToanPhieu(maPhieu);
        }
        public DataTable LayDanhSachPhieu()
        {
            return dal.LayDanhSachPhieuSuaChua();
        }
    }
}