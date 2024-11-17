use master
ALTER DATABASE Pharmacy
SET SINGLE_USER
WITH ROLLBACK IMMEDIATE;
drop database Pharmacy
Create database Pharmacy
go
use Pharmacy
go
create table Nhanvien (
Ma_NV varchar(16) primary key not null,
Ten_NV nvarchar(254) null,
Chuc_vu nvarchar(50) null,
SDT nvarchar (10) null,
Email nvarchar(128) null,
Username varchar(100) null,
Password varchar(100) null,
Hinh_Anh varbinary(max) null)
go
Create table KhachHang (
Ma_KH varchar(16) primary key not null,
Ten_KH nvarchar(200) not null,
SDT varchar(10) null,
DiaChi nvarchar(200) null,
Email nvarchar(200) null)
go

Create table NhaCungCap (
Ma_NCC varchar(16) primary key not null,
Ten_NCC nvarchar(200) not null,
SDT varchar(10) null,
DiaChi nvarchar(200) null,
MaSoThue nvarchar(50) null)
go

Create table Loai (
Ma_Loai varchar(16) primary key not null,
Ten_Loai nvarchar(200) null)
go

Create table DanhMucThuoc (
Ma_Thuoc varchar(16) primary key not null,
Ten_Thuoc nvarchar(200) not null,
DVT nvarchar(16) not null,
DVT_QD nvarchar(16) null,
HSQD float null,
DonGia varchar(20) null,
Mo_ta nvarchar(200) null,
Ma_Loai varchar(16) references Loai(Ma_Loai) null,
Hinh_Anh varbinary(max) null)
go

Create table HoaDonNhap (
Ma_CT varchar(16) primary key not null,
Ngay_CT date null,
Ma_NV varchar(16) references Nhanvien(Ma_NV) not null,
Tong_tien varchar(20) null,
Dien_Giai nvarchar(200) null,
CONSTRAINT FK_HoaDonNhap_Nhanvien FOREIGN KEY (Ma_NV) 
        REFERENCES Nhanvien(Ma_NV) ON DELETE CASCADE
)
go
Create table CTHoaDonNhap (
Ma_Lo varchar(16) primary key not null,
Ma_HDN varchar(16) not null,
Ma_Thuoc varchar(16) not null,
Ma_NCC varchar(16) not null,
NSX date null,
HSD date null,
DVT nvarchar(20) null,
So_Luong int null,
Don_Gia varchar(20) null,
Thanh_Tien varchar(50) null,
CONSTRAINT FK_CTHoaDonNhap_HoaDonNhap FOREIGN KEY (Ma_HDN) 
        REFERENCES HoaDonNhap(Ma_CT) ON DELETE CASCADE,
    CONSTRAINT FK_CTHoaDonNhap_DanhMucThuoc FOREIGN KEY (Ma_Thuoc) 
        REFERENCES DanhMucThuoc(Ma_Thuoc) ON DELETE CASCADE,
    CONSTRAINT FK_CTHoaDonNhap_NhaCungCap FOREIGN KEY (Ma_NCC) 
        REFERENCES NhaCungCap(Ma_NCC) ON DELETE CASCADE)
go

Create table TonKho (
ID varchar(16) primary key not null,
Ma_Thuoc varchar(16) not null,
Ma_Lo varchar(16) not null,
So_Luong_Goc int null,
So_Luong_Ton decimal(10,2) null,
CONSTRAINT FK_TonKho_DanhMucThuoc FOREIGN KEY (Ma_Thuoc) 
        REFERENCES DanhMucThuoc(Ma_Thuoc) ON DELETE CASCADE,
    CONSTRAINT FK_TonKho_CTHoaDonNhap FOREIGN KEY (Ma_Lo) 
        REFERENCES CTHoaDonNhap(Ma_Lo) ON DELETE NO ACTION)
go
Create table HoaDonBan (
Ma_CT varchar(16) primary key not null,
Ngay_CT date null,
Ma_KH varchar(16)  not null,
Ma_NV varchar(16)  not null,
Tong_Tien varchar(20) null,
Dien_Giai nvarchar(200) null,
Trang_Thai nvarchar(200) null,
CONSTRAINT FK_HoaDonBan_KhachHang FOREIGN KEY (Ma_KH) 
        REFERENCES KhachHang(Ma_KH) ON DELETE CASCADE,
    CONSTRAINT FK_HoaDonBan_Nhanvien FOREIGN KEY (Ma_NV) 
        REFERENCES Nhanvien(Ma_NV) ON DELETE CASCADE)
go

Create table CTHoaDonBan (
ID varchar(16) primary key not null,
Ma_HDB varchar(16) not null,
Ma_Thuoc varchar(16) not null,
DVT nvarchar(20) null,
So_Luong decimal(10,2) null,
Don_Gia varchar(20) null,
Thanh_Tien varchar(50) null,
CONSTRAINT FK_CTHoaDonBan_HoaDonBan FOREIGN KEY (Ma_HDB) 
        REFERENCES HoaDonBan(Ma_CT) ON DELETE CASCADE,
    CONSTRAINT FK_CTHoaDonBan_DanhMucThuoc FOREIGN KEY (Ma_Thuoc) 
        REFERENCES DanhMucThuoc(Ma_Thuoc))
go

Create table PhieuXuat (
Ma_CT varchar(16) primary key not null,
Ngay_CT date null,
Ma_HDB varchar(16) not null,
Ma_NV varchar(16) not null,
Dien_Giai nvarchar(200) null,
CONSTRAINT FK_PhieuXuat_HoaDonBan FOREIGN KEY (Ma_HDB) 
        REFERENCES HoaDonBan(Ma_CT) ON DELETE CASCADE,
    CONSTRAINT FK_PhieuXuat_Nhanvien FOREIGN KEY (Ma_NV) 
        REFERENCES Nhanvien(Ma_NV))
go

Create table CTPhieuXuat (
ID varchar(16) primary key not null,
Ma_PX varchar(16) not null,
Ma_Thuoc varchar(16)not null,
Ma_Kho varchar(16) not null,
So_Luong decimal(10,2) null,
CONSTRAINT FK_CTPhieuXuat_PhieuXuat FOREIGN KEY (Ma_PX) 
        REFERENCES PhieuXuat(Ma_CT) ON DELETE CASCADE,
    CONSTRAINT FK_CTPhieuXuat_DanhMucThuoc FOREIGN KEY (Ma_Thuoc) 
        REFERENCES DanhMucThuoc(Ma_Thuoc),
    CONSTRAINT FK_CTPhieuXuat_TonKho FOREIGN KEY (Ma_Kho) 
        REFERENCES TonKho(ID));

SELECT * FROM Nhanvien