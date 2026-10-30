-- =========================================================
-- CafePOSDB - Script tao CSDL (MySQL)
-- =========================================================
DROP DATABASE IF EXISTS CafePOSDB;
CREATE DATABASE CafePOSDB
  DEFAULT CHARACTER SET utf8mb4
  DEFAULT COLLATE utf8mb4_unicode_ci;

USE CafePOSDB;

-- 1. Ban An
CREATE TABLE BanAn (
    MaBan INT AUTO_INCREMENT PRIMARY KEY,
    TenBan VARCHAR(50) NOT NULL,
    TrangThai VARCHAR(20) NOT NULL DEFAULT 'Trong'
) ENGINE=InnoDB;

-- 2. Danh Muc
CREATE TABLE DanhMuc (
    MaDanhMuc INT AUTO_INCREMENT PRIMARY KEY,
    TenDanhMuc VARCHAR(100) NOT NULL
) ENGINE=InnoDB;

-- 3. Mon An
CREATE TABLE MonAn (
    MaMon INT AUTO_INCREMENT PRIMARY KEY,
    TenMon VARCHAR(100) NOT NULL,
    MaDanhMuc INT,
    DonGia DECIMAL(18,2) NOT NULL DEFAULT 0,
    CONSTRAINT FK_MonAn_DanhMuc FOREIGN KEY (MaDanhMuc)
        REFERENCES DanhMuc(MaDanhMuc)
        ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB;

-- 4. Hoa Don
CREATE TABLE HoaDon (
    MaHoaDon INT AUTO_INCREMENT PRIMARY KEY,
    MaBan INT NOT NULL,
    GioVao DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    GioRa DATETIME NULL,
    TongTien DECIMAL(18,2) NOT NULL DEFAULT 0,
    TrangThai TINYINT(1) NOT NULL DEFAULT 0, -- 0: Chua thanh toan, 1: Da thanh toan
    CONSTRAINT FK_HoaDon_BanAn FOREIGN KEY (MaBan)
        REFERENCES BanAn(MaBan)
        ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB;

-- 5. Chi Tiet Hoa Don
CREATE TABLE ChiTietHoaDon (
    MaHoaDon INT NOT NULL,
    MaMon INT NOT NULL,
    SoLuong INT NOT NULL DEFAULT 1,
    DonGia DECIMAL(18,2) NOT NULL,
    PRIMARY KEY (MaHoaDon, MaMon),
    CONSTRAINT FK_CTHD_HoaDon FOREIGN KEY (MaHoaDon)
        REFERENCES HoaDon(MaHoaDon)
        ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_CTHD_MonAn FOREIGN KEY (MaMon)
        REFERENCES MonAn(MaMon)
        ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB;

-- =========================================================
-- Du lieu mau
-- =========================================================
INSERT INTO BanAn (TenBan, TrangThai) VALUES
('Ban 01','Trong'), ('Ban 02','Trong'), ('Ban 03','Trong'),
('Ban 04','Trong'), ('Ban 05','Trong'), ('Ban 06','Trong');

INSERT INTO DanhMuc (TenDanhMuc) VALUES
('Ca phe'), ('Tra sua'), ('Do an nhe');

INSERT INTO MonAn (TenMon, MaDanhMuc, DonGia) VALUES
('Ca phe den', 1, 20000),
('Ca phe sua', 1, 25000),
('Bac xiu', 1, 28000),
('Tra sua tran chau', 2, 35000),
('Tra sua matcha', 2, 38000),
('Banh mi nuong', 3, 15000),
('Khoai tay chien', 3, 25000);
