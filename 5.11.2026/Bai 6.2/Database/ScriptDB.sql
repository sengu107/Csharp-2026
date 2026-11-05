
CREATE DATABASE HRMDB
CHARACTER SET utf8mb4
COLLATE utf8mb4_unicode_ci;

USE HRMDB;

-- 1. Phòng ban
CREATE TABLE PhongBan (
    MaPB INT AUTO_INCREMENT PRIMARY KEY,
    TenPB VARCHAR(100) NOT NULL,
    Mota VARCHAR(255)
) ENGINE=InnoDB;

-- 2. Nhân viên
CREATE TABLE NhanVien (
    MaNV INT AUTO_INCREMENT PRIMARY KEY,
    HoTen VARCHAR(100) NOT NULL,
    NgaySinh DATETIME,
    CCCD VARCHAR(20) UNIQUE,
    MaPB INT,
    LuongCoBan DECIMAL(18,2) NOT NULL,
    HeSoLuong DOUBLE DEFAULT 1.0,

    CHECK (LuongCoBan > 0),

    FOREIGN KEY (MaPB)
        REFERENCES PhongBan(MaPB)
) ENGINE=InnoDB;

-- 3. Bảng chấm công
CREATE TABLE BangChamCong (
    MaCong INT AUTO_INCREMENT PRIMARY KEY,
    MaNV INT NOT NULL,
    ThangNam VARCHAR(7) NOT NULL,
    SoNgayCong FLOAT NOT NULL DEFAULT 0,
    SoGioOT FLOAT DEFAULT 0,
    DaChot BOOLEAN DEFAULT FALSE,

    CHECK (SoNgayCong >= 0 AND SoNgayCong <= 31),
    CHECK (SoGioOT >= 0),

    UNIQUE (MaNV, ThangNam),

    FOREIGN KEY (MaNV)
        REFERENCES NhanVien(MaNV)
) ENGINE=InnoDB;

-- 4. Bảng lương
CREATE TABLE BangLuong (
    MaNV INT NOT NULL,
    ThangNam VARCHAR(7) NOT NULL,
    ThucLinh DECIMAL(18,2) NOT NULL,

    PRIMARY KEY (MaNV, ThangNam),

    FOREIGN KEY (MaNV)
        REFERENCES NhanVien(MaNV)
) ENGINE=InnoDB;

-- Dữ liệu phòng ban
INSERT INTO PhongBan (TenPB, Mota) VALUES
('Ke toan', 'Phong ke toan'),
('Nhan su', 'Phong nhan su'),
('Ky thuat', 'Phong ky thuat'),
('Kinh doanh', 'Phong kinh doanh');

-- Dữ liệu nhân viên
INSERT INTO NhanVien
(HoTen, NgaySinh, CCCD, MaPB, LuongCoBan, HeSoLuong)
VALUES
('Nguyen Van An', '2000-05-10', '001200000001', 1, 8000000, 1.5),
('Tran Thi Binh', '2001-08-20', '001200000002', 2, 9000000, 1.8),
('Le Van Cuong', '1999-03-15', '001200000003', 3, 10000000, 2.0),
('Pham Thi Dung', '2002-12-01', '001200000004', 4, 7500000, 1.3);
