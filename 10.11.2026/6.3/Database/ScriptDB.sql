
CREATE DATABASE IF NOT EXISTS ProjectTaskDB;
USE ProjectTaskDB;

-- Xoa bang cu neu ton tai
DROP TABLE IF EXISTS PhanCong;
DROP TABLE IF EXISTS CongViec;
DROP TABLE IF EXISTS ThanhVien;
DROP TABLE IF EXISTS DuAn;


-- 1. Bang Du an
CREATE TABLE DuAn (
    MaDuAn INT AUTO_INCREMENT PRIMARY KEY,
    TenDuAn VARCHAR(150) NOT NULL,
    NgayBatDau DATETIME,
    NgayKetThuc DATETIME,
    TrangThai VARCHAR(50) DEFAULT 'Dang chay'
);

-- 2. Bang Thanh vien nhom
CREATE TABLE ThanhVien (
    MaThanhVien INT AUTO_INCREMENT PRIMARY KEY,
    HoTen VARCHAR(100) NOT NULL,
    Email VARCHAR(100) UNIQUE,
    ChuyenMon VARCHAR(100)
);

-- 3. Bang Cong viec (Task)
CREATE TABLE CongViec (
    MaTask INT AUTO_INCREMENT PRIMARY KEY,
    MaDuAn INT,
    TenTask VARCHAR(200) NOT NULL,
    MoTa TEXT,
    HanNop DATETIME,
    DoUuTien VARCHAR(20) DEFAULT 'Trung binh',   -- "Cao", "Trung binh", "Thap"
    TrangThai VARCHAR(50) DEFAULT 'To Do',      -- "To Do", "In Progress", "Review", "Done"
    FOREIGN KEY (MaDuAn) REFERENCES DuAn(MaDuAn) ON DELETE CASCADE
);

-- 4. Bang Phan cong cong viec (Quan he N-N giua Task va Thanh vien)
CREATE TABLE PhanCong (
    MaTask INT,
    MaThanhVien INT,
    NgayGiao DATETIME DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY (MaTask, MaThanhVien),
    FOREIGN KEY (MaTask) REFERENCES CongViec(MaTask) ON DELETE CASCADE,
    FOREIGN KEY (MaThanhVien) REFERENCES ThanhVien(MaThanhVien) ON DELETE CASCADE
);


-- Sample data

-- 1. Du lieu mau bang DuAn
INSERT INTO DuAn (TenDuAn, NgayBatDau, NgayKetThuc, TrangThai) VALUES 
('Xay dung Website Thuong mai Dien tu', '2026-11-01 00:00:00', '2026-12-31 23:59:59', 'Dang chay'),
('Phan mem Quan ly Nhan su', '2026-10-15 00:00:00', '2026-11-30 23:59:59', 'Dang chay'),
('Ung dung Dat ve Xem phim', '2026-09-01 00:00:00', '2026-10-01 23:59:59', 'Hoan thanh');

-- 2. Du lieu mau bang ThanhVien
INSERT INTO ThanhVien (HoTen, Email, ChuyenMon) VALUES 
('Nguyen Van An', 'an.nguyen@email.com', 'Backend Developer'),
('Tran Thi Binh', 'binh.tran@email.com', 'Frontend Developer'),
('Le Hoang Cuong', 'cuong.le@email.com', 'Database Administrator'),
('Pham Thi Dung', 'dung.pham@email.com', 'Tester');

-- 3. Du lieu mau bang CongViec (Task)
INSERT INTO CongViec (MaDuAn, TenTask, MoTa, HanNop, DoUuTien, TrangThai) VALUES 
(1, 'Thiet ke co so du lieu gio hang', 'Thiet ke cac bang Cart va CartItem chi tiet', '2026-11-15 23:59:59', 'Cao', 'Done'),
(1, 'Lap trinh API Thanh toan', 'Tich hop cong thanh toan VNPay va Momo', '2026-11-25 23:59:59', 'Cao', 'In Progress'),
(1, 'Viet Unit Test cho Module san pham', 'Su dung xUnit viet test cho API san pham', '2026-11-05 23:59:59', 'Trung binh', 'To Do'),
(2, 'Xay dung giao dien cham cong', 'Lam form WinForms quan ly cham cong nhan vien', '2026-11-20 23:59:59', 'Cao', 'In Progress'),
(2, 'Tinh luong tu dong', 'Viet ham thuat toan tu dong tinh bao hiem va thue', '2026-11-08 23:59:59', 'Cao', 'To Do');

-- 4. Du lieu mau bang PhanCong (Phan cong thanh vien)
INSERT INTO PhanCong (MaTask, MaThanhVien, NgayGiao) VALUES 
(1, 3, NOW()), -- Cuong lam Task 1
(2, 1, NOW()), -- An lam Task 2
(3, 4, NOW()), -- Dung lam Task 3
(4, 2, NOW()), -- Binh lam Task 4
(5, 1, NOW()); -- An lam Task 5