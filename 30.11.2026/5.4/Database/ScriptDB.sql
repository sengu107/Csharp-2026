-- 1. tao va chon co so du lieu
drop database if exists hoteldb;
create database hoteldb character set utf8mb4 collate utf8mb4_unicode_ci;
use hoteldb;

-- 2. bang phong
create table phong (
    sophong     varchar(10)   not null,
    loaiphong   varchar(50)   not null,
    giatheogio  decimal(18,2) not null,
    trangthai   varchar(30)   not null default 'trong',
    constraint pk_phong primary key (sophong),
    constraint ck_phong_gia check (giatheogio >= 0)
);

-- 3. bang khachhang
create table khachhang (
    makh        int auto_increment not null,
    hoten       varchar(100)       not null,
    cccd        varchar(20)        not null,
    sodienthoai varchar(15)        null,
    constraint pk_khachhang primary key (makh),
    constraint uq_khachhang_cccd unique (cccd)
);

-- 4. bang dichvu
create table dichvu (
    madv    int auto_increment not null,
    tendv   varchar(100)       not null,
    dongia  decimal(18,2)      not null,
    constraint pk_dichvu primary key (madv),
    constraint ck_dichvu_dongia check (dongia >= 0)
);

-- 5. bang phieudatphong
create table phieudatphong (
    maphieu           int auto_increment not null,
    sophong           varchar(10)        not null,
    makh              int                not null,
    ngaynhanphong     datetime           not null default current_timestamp,
    ngaytraphong      datetime           null,
    tongtienthanhtoan decimal(18,2)      null,
    constraint pk_phieudatphong primary key (maphieu),
    constraint fk_phieu_phong foreign key (sophong) references phong(sophong),
    constraint fk_phieu_khachhang foreign key (makh) references khachhang(makh),
    constraint ck_phieu_ngaytra check (ngaytraphong is null or ngaytraphong >= ngaynhanphong)
);

-- 6. bang sudungdichvu
create table sudungdichvu (
    masd     int auto_increment not null,
    maphieu  int                not null,
    madv     int                not null,
    soluong  int                not null,
    thoigian datetime           not null default current_timestamp,
    constraint pk_sudungdichvu primary key (masd),
    constraint fk_sudung_phieu foreign key (maphieu) references phieudatphong(maphieu),
    constraint fk_sudung_dichvu foreign key (madv) references dichvu(madv),
    constraint ck_sudung_soluong check (soluong > 0)
);

-- ============================================================
-- du lieu mau (khong dau hoan toan, dung chu thuong)
-- ============================================================

insert into phong (sophong, loaiphong, giatheogio, trangthai) values
('p101', 'don', 50000,  'trong'),
('p102', 'don', 50000,  'trong'),
('p103', 'don', 50000,  'dang don dep'),
('p201', 'doi', 80000,  'trong'),
('p202', 'doi', 80000,  'dang o'),
('p203', 'doi', 80000,  'trong'),
('p301', 'vip', 150000, 'trong'),
('p302', 'vip', 150000, 'trong');

insert into khachhang (hoten, cccd, sodienthoai) values
('nguyen van an',  '079201001234', '0901234567'),
('tran thi binh',  '001301005678', '0912345678'),
('le minh cuong',  '048200009999', '0987654321');

insert into dichvu (tendv, dongia) values
('nuoc suoi',   10000),
('nuoc ngot',   15000),
('bia lon',     25000),
('giat la',     30000),
('mi ly',       20000),
('com phan',    60000);

-- khach an dang o p202
insert into phieudatphong (sophong, makh, ngaynhanphong)
values ('p202', 1, date_sub(now(), interval 5 hour));

-- lich su - khach binh da tra phong p101
insert into phieudatphong (sophong, makh, ngaynhanphong, ngaytraphong, tongtienthanhtoan)
values ('p101', 2, date_sub(now(), interval 48 hour), date_sub(now(), interval 45 hour), 150000);

insert into sudungdichvu (maphieu, madv, soluong, thoigian) values
(1, 1, 2, date_sub(now(), interval 3 hour)),
(1, 4, 1, date_sub(now(), interval 2 hour));