using System;
using System.Data;
using HotelManagement.DAL;
using HotelManagement.DTO;

namespace HotelManagement.BUS
{
   
    public class LuuTruBUS
    {
        private readonly KhachHangDAL _khDal = new KhachHangDAL();
        private readonly PhongDAL _phongDal = new PhongDAL();
        private readonly PhieuDatPhongDAL _phieuDal = new PhieuDatPhongDAL();
        private readonly DichVuDAL _dvDal = new DichVuDAL();
        private readonly SuDungDichVuDAL _suDungDal = new SuDungDichVuDAL();

        public int CheckIn(string cccd, string hoTen, string soDienThoai, string soPhong)
        {
            cccd = KhachHangBUS.ChuanHoaCCCD(cccd);
            if (string.IsNullOrWhiteSpace(soPhong))
                throw new BusinessException("Vui lòng chọn phòng trống.");

            using (var uow = new UnitOfWork())
            {
                int maKH;
                var kh = _khDal.GetByCCCD(cccd, uow);
                if (kh != null)
                {
                    maKH = kh.MaKH;
                }
                else
                {
                    hoTen = (hoTen ?? "").Trim();
                    if (hoTen.Length == 0)
                        throw new BusinessException("Khách mới: vui lòng nhập họ tên.");

                    maKH = _khDal.Insert(new KhachHangDTO
                    {
                        HoTen = hoTen,
                        CCCD = cccd,
                        SoDienThoai = KhachHangBUS.ChuanHoaSoDienThoai(soDienThoai)
                    }, uow);
                }

                int rows = _phongDal.CapNhatTrangThai(soPhong, TrangThaiPhong.DangO, TrangThaiPhong.Trong, uow);
                if (rows != 1)
                    throw new BusinessException("Phòng " + soPhong + " không còn trống.");

                int maPhieu = _phieuDal.Insert(new PhieuDatPhongDTO
                {
                    SoPhong = soPhong,
                    MaKH = maKH,
                    NgayNhanPhong = DateTime.Now
                }, uow);

                uow.Commit();
                return maPhieu;
            }
        }

     
        public void GoiDichVu(SuDungDichVuDTO sd)
        {
            if (sd == null) throw new ArgumentNullException("sd");
            if (sd.SoLuong <= 0)
                throw new BusinessException("Số lượng phải lớn hơn 0.");

            using (var uow = new UnitOfWork())
            {
                var phieu = _phieuDal.GetById(sd.MaPhieu, uow);
                if (phieu == null)
                    throw new BusinessException("Không tìm thấy phiếu nhận phòng.");
                if (phieu.NgayTraPhong.HasValue)
                    throw new BusinessException("Phòng này đã trả, không thể gọi thêm dịch vụ.");
                if (_dvDal.GetById(sd.MaDV, uow) == null)
                    throw new BusinessException("Dịch vụ không tồn tại.");

                sd.ThoiGian = DateTime.Now;
                _suDungDal.Insert(sd, uow);
                uow.Commit();
            }
        }

        public DataTable GetDichVuDaDung(int maPhieu)
        {
            return _suDungDal.GetChiTietByPhieu(maPhieu);
        }

        public decimal GetTongTienDichVu(int maPhieu)
        {
            return _suDungDal.TinhTongTien(maPhieu);
        }

    
        public DataTable GetDanhSachDangO()
        {
            return _phieuDal.GetDanhSachDangO();
        }

       
        public static int TinhSoGio(DateTime nhan, DateTime tra)
        {
            double gio = (tra - nhan).TotalHours;
            if (gio <= 0) return 1;
            return (int)Math.Ceiling(gio);
        }


        public HoaDonDTO TinhHoaDonTamThoi(int maPhieu)
        {
            return LapHoaDon(maPhieu, DateTime.Now, null);
        }


        public HoaDonDTO CheckOut(int maPhieu)
        {
            using (var uow = new UnitOfWork())
            {
                DateTime ngayTra = DateTime.Now;
                HoaDonDTO hd = LapHoaDon(maPhieu, ngayTra, uow);

                int rows = _phieuDal.CapNhatThanhToan(maPhieu, ngayTra, hd.TongTien, uow);
                if (rows != 1)
                    throw new BusinessException("Phiếu này đã được thanh toán trước đó.");

                rows = _phongDal.CapNhatTrangThai(hd.SoPhong, TrangThaiPhong.DangDon, TrangThaiPhong.DangO, uow);
                if (rows != 1)
                    throw new BusinessException("Phòng " + hd.SoPhong + " không ở trạng thái \"Đang ở\" - đã hủy thanh toán.");

                uow.Commit();
                return hd;
            }
        }

        private HoaDonDTO LapHoaDon(int maPhieu, DateTime ngayTra, UnitOfWork uow)
        {
            var phieu = _phieuDal.GetById(maPhieu, uow);
            if (phieu == null)
                throw new BusinessException("Không tìm thấy phiếu nhận phòng.");
            if (phieu.NgayTraPhong.HasValue)
                throw new BusinessException("Phiếu này đã được thanh toán.");

            var phong = _phongDal.GetBySoPhong(phieu.SoPhong, uow);
            var kh = _khDal.GetById(phieu.MaKH, uow);
            if (phong == null || kh == null)
                throw new BusinessException("Dữ liệu phiếu không hợp lệ (thiếu phòng hoặc khách hàng).");

            int soGio = TinhSoGio(phieu.NgayNhanPhong, ngayTra);

            return new HoaDonDTO
            {
                MaPhieu = phieu.MaPhieu,
                SoPhong = phong.SoPhong,
                LoaiPhong = phong.LoaiPhong,
                HoTen = kh.HoTen,
                CCCD = kh.CCCD,
                NgayNhanPhong = phieu.NgayNhanPhong,
                NgayTraPhong = ngayTra,
                SoGio = soGio,
                GiaTheoGio = phong.GiaTheoGio,
                TienPhong = soGio * phong.GiaTheoGio,
                TienDichVu = _suDungDal.TinhTongTien(maPhieu, uow)
            };
        }
    }
}
