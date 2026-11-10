CREATE DATABASE IF NOT EXISTS KaraokeDB CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE KaraokeDB;

-- 1. Bang Phong hat
CREATE TABLE IF NOT EXISTS PhongHat (
    MaPhong INT AUTO_INCREMENT PRIMARY KEY,
    TenPhong VARCHAR(50) NOT NULL,
    LoaiPhong VARCHAR(30),
    GiaTheoGio DECIMAL(18,2) NOT NULL,
    TrangThai VARCHAR(20) DEFAULT 'Trong'
) ENGINE=InnoDB;

-- 2. Bang Dich vu / Do uong
CREATE TABLE IF NOT EXISTS DichVu (
    MaDV INT AUTO_INCREMENT PRIMARY KEY,
    TenDV VARCHAR(100) NOT NULL,
    DonGia DECIMAL(18,2) NOT NULL,
    TonKho INT NOT NULL CHECK (TonKho >= 0)
) ENGINE=InnoDB;

-- 3. Bang Hoa don
CREATE TABLE IF NOT EXISTS HoaDon (
    MaHD INT AUTO_INCREMENT PRIMARY KEY,
    MaPhong INT NOT NULL,
    GioVao DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    GioRa DATETIME NULL,
    TongTienPhong DECIMAL(18,2) DEFAULT 0,
    TongTienDichVu DECIMAL(18,2) DEFAULT 0,
    TrangThai TINYINT(1) DEFAULT 0, -- 0: Chua thanh toan, 1: Da thanh toan
    FOREIGN KEY (MaPhong) REFERENCES PhongHat(MaPhong) ON DELETE CASCADE
) ENGINE=InnoDB;

-- 4. Bang Chi tiet dich vu goi
CREATE TABLE IF NOT EXISTS ChiTietDichVu (
    MaHD INT NOT NULL,
    MaDV INT NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia DECIMAL(18,2) NOT NULL,
    PRIMARY KEY (MaHD, MaDV),
    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD) ON DELETE CASCADE,
    FOREIGN KEY (MaDV) REFERENCES DichVu(MaDV) ON DELETE CASCADE
) ENGINE=InnoDB;

-- Du lieu mau Phong hat
INSERT INTO PhongHat (TenPhong, LoaiPhong, GiaTheoGio, TrangThai) VALUES
('Phong VIP 01', 'VIP', 200000, 'Trong'),
('Phong VIP 02', 'VIP', 250000, 'Trong'),
('Phong Thuong 01', 'Thuong', 120000, 'Trong'),
('Phong Thuong 02', 'Thuong', 120000, 'Trong'),
('Phong Thuong 03', 'Thuong', 150000, 'Trong');

-- Du lieu mau Dich vu
INSERT INTO DichVu (TenDV, DonGia, TonKho) VALUES
('Bia Heineken', 25000, 100),
('Nuoc ngot Coca', 15000, 80),
('Trai cay dia', 150000, 30),
('Kho muc nuong', 120000, 25),
('Hat dieu', 50000, 50);