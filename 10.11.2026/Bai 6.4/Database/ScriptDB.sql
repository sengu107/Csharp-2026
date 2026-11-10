-- Tạo Cơ sở dữ liệu
CREATE DATABASE IF NOT EXISTS GarageDB CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE GarageDB;

-- 1. Bảng Khách hàng (Chủ xe)
CREATE TABLE IF NOT EXISTS KhachHang (
    MaKH INT AUTO_INCREMENT PRIMARY KEY,
    TenKH VARCHAR(100) NOT NULL,
    DienThoai VARCHAR(15) UNIQUE,
    DiaChi VARCHAR(200)
) ENGINE=InnoDB;

-- 2. Bảng Xe (Thông tin ô tô)
CREATE TABLE IF NOT EXISTS Xe (
    BienSo VARCHAR(20) PRIMARY KEY,
    MaKH INT NOT NULL,
    HieuXe VARCHAR(50),
    NamSanXuat INT,
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH) ON DELETE CASCADE
) ENGINE=InnoDB;

-- 3. Bảng PhuTung (Phụ tùng / Vật tư trong kho)
CREATE TABLE IF NOT EXISTS PhuTung (
    MaPhuTung INT AUTO_INCREMENT PRIMARY KEY,
    TenPhuTung VARCHAR(150) NOT NULL,
    DonGia DECIMAL(18,2) NOT NULL,
    SoLuongTon INT NOT NULL CHECK (SoLuongTon >= 0)
) ENGINE=InnoDB;

-- 4. Bảng PhieuSuaChua (Phiếu sửa chữa)
CREATE TABLE IF NOT EXISTS PhieuSuaChua (
    MaPhieu INT AUTO_INCREMENT PRIMARY KEY,
    BienSo VARCHAR(20) NOT NULL,
    NgayNhan DATETIME DEFAULT CURRENT_TIMESTAMP,
    NoiDungSua TEXT,
    TongTien DECIMAL(18,2),
    TrangThai VARCHAR(30) DEFAULT 'Dang sua',
    FOREIGN KEY (BienSo) REFERENCES Xe(BienSo) ON DELETE CASCADE
) ENGINE=InnoDB;

-- 5. Bảng ChiTietSuaChua (Chi tiết phụ tùng & tiền công)
CREATE TABLE IF NOT EXISTS ChiTietSuaChua (
    MaPhieu INT,
    MaPhuTung INT,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    TienCong DECIMAL(18,2),
    PRIMARY KEY (MaPhieu, MaPhuTung),
    FOREIGN KEY (MaPhieu) REFERENCES PhieuSuaChua(MaPhieu) ON DELETE CASCADE,
    FOREIGN KEY (MaPhuTung) REFERENCES PhuTung(MaPhuTung) ON DELETE CASCADE
) ENGINE=InnoDB;


-- ==========================================
-- THÊM DỮ LIỆU MẪU (TEST DATA)
-- ==========================================

-- Dữ liệu mẫu Khách hàng
INSERT INTO KhachHang (TenKH, DienThoai, DiaChi) VALUES
('Nguyen Van A', '0901122334', 'Quan 1, TP.HCM'),
('Tran Thi B', '0918877665', 'Quan 7, TP.HCM'),
('Le Van C', '0983344556', 'Thu Duc, TP.HCM');

-- Dữ liệu mẫu Xe
INSERT INTO Xe (BienSo, MaKH, HieuXe, NamSanXuat) VALUES
('51A-123.45', 1, 'Toyota', 2020),
('60B-999.88', 2, 'Honda', 2021),
('29C-555.44', 3, 'VinFast', 2022);

-- Dữ liệu mẫu Phụ tùng trong kho
INSERT INTO PhuTung (TenPhuTung, DonGia, SoLuongTon) VALUES
('Dau nhot dong co', 350000.00, 50),
('Loc gio xe', 150000.00, 30),
('Bo phanh thang (Ma phanh)', 850000.00, 20),
('Bugi danh lua', 120000.00, 100),
('Nuoc lam mat', 200000.00, 40);