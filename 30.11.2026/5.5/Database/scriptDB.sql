
CREATE DATABASE IF NOT EXISTS InventoryDB
CHARACTER SET utf8mb4
COLLATE utf8mb4_unicode_ci;

USE InventoryDB;
-- Xoa bang cu
SET FOREIGN_KEY_CHECKS = 0;
DROP TABLE IF EXISTS ChiTietPhieuKho;
DROP TABLE IF EXISTS PhieuKho;
DROP TABLE IF EXISTS VatTu;
DROP TABLE IF EXISTS NhaCungCap;
SET FOREIGN_KEY_CHECKS = 1;

-- 1. Nha cung cap
CREATE TABLE NhaCungCap (
    MaNCC INT AUTO_INCREMENT PRIMARY KEY,
    TenNCC VARCHAR(150) NOT NULL,
    DiaChi VARCHAR(255),
    SoDienThoai VARCHAR(20),
    Email VARCHAR(150)
) ENGINE=InnoDB;

-- 2. Vat tu
CREATE TABLE VatTu (
    MaVatTu VARCHAR(20) PRIMARY KEY,
    TenVatTu VARCHAR(150) NOT NULL,
    DonViTinh VARCHAR(30) NOT NULL DEFAULT 'Cai',
    SoLuongTon DECIMAL(18,2) NOT NULL DEFAULT 0,
    MoTa VARCHAR(500)
) ENGINE=InnoDB;

-- 3. Phieu kho
CREATE TABLE PhieuKho (
    MaPhieu INT AUTO_INCREMENT PRIMARY KEY,
    LoaiPhieu ENUM('NHAP','XUAT') NOT NULL,
    NgayLap DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    MaNCC INT NULL,
    TongTien DECIMAL(18,2) NOT NULL DEFAULT 0,

    FOREIGN KEY (MaNCC)
        REFERENCES NhaCungCap(MaNCC)
        ON UPDATE CASCADE
        ON DELETE SET NULL
) ENGINE=InnoDB;

-- 4. Chi tiet phieu kho
CREATE TABLE ChiTietPhieuKho (
    MaPhieu INT NOT NULL,
    MaVatTu VARCHAR(20) NOT NULL,
    SoLuong DECIMAL(18,2) NOT NULL,
    DonGia DECIMAL(18,2) NOT NULL,

    ThanhTien DECIMAL(20,2)
        GENERATED ALWAYS AS (SoLuong * DonGia) STORED,

    PRIMARY KEY (MaPhieu, MaVatTu),

    FOREIGN KEY (MaPhieu)
        REFERENCES PhieuKho(MaPhieu)
        ON UPDATE CASCADE
        ON DELETE CASCADE,

    FOREIGN KEY (MaVatTu)
        REFERENCES VatTu(MaVatTu)
        ON UPDATE CASCADE
        ON DELETE RESTRICT
) ENGINE=InnoDB;

-- 5. Du lieu mau
INSERT INTO NhaCungCap
(TenNCC, DiaChi, SoDienThoai, Email)
VALUES
('Cong ty An Phat', 'Ha Noi', '0901234567', 'anphat@gmail.com'),
('Cong ty Minh Long', 'Hai Phong', '0912345678', 'minhlong@gmail.com');

INSERT INTO VatTu
(MaVatTu, TenVatTu, DonViTinh, SoLuongTon, MoTa)
VALUES
('VT001', 'Xi mang', 'Bao', 100, 'Xi mang PCB40'),
('VT002', 'Sat thep phi 10', 'Kg', 250, 'Thep xay dung'),
('VT003', 'Cat xay dung', 'm3', 30, 'Cat vang'),
('VT004', 'Gach do', 'Vien', 500, 'Gach xay tuong'),
('VT005', 'Son nuoc', 'Thung', 12, 'Son noi that');

-- 6. Kiem tra
SELECT * FROM VatTu;
SELECT * FROM NhaCungCap;

SELECT *
FROM VatTu
WHERE SoLuongTon <= 20;
