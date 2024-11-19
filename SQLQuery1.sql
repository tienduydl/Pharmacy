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


INSERT INTO NhanVien (Ma_NV, Ten_NV, Chuc_vu, SDT, Email, Username, Password)
VALUES ('E01', N'La', N'Quản lý', '098761427', 'la@gmail.com', 'manager', '1234')

INSERT INTO NhanVien (Ma_NV, Ten_NV, Chuc_vu, SDT, Email, Username, Password)
VALUES ('E02', N'Gio', N'Nhân viên', '098461427', 'gio@gmail.com', 'employee', '1234')

SELECT * FROM Nhanvien

DELETE FROM Nhanvien 
WHERE Ma_NV = 'NV01'

DELETE FROM Nhanvien 
WHERE Ma_NV = 'NV02'

INSERT INTO LOAI (Ma_Loai, Ten_Loai)
VALUES ('L01', 'Thuốc điều trị')

INSERT INTO LOAI (Ma_Loai, Ten_Loai)
VALUES ('L02', 'Thuốc kháng sinh')

INSERT INTO LOAI (Ma_Loai, Ten_Loai)
VALUES ('L03', 'Dược mỹ phẩm')

INSERT INTO LOAI (Ma_Loai, Ten_Loai)
VALUES ('L04', 'Thực phẩm chức năng')

SELECT * FROM LOAI


UPDATE LOAI
SET Ten_Loai = N'Thuốc kháng sinh'
WHERE Ten_Loai = 'Thuốc kháng sinh'

UPDATE LOAI
SET Ten_Loai = N'Dược mỹ phẩm'
WHERE Ten_Loai = 'Dược mỹ phẩm'

UPDATE LOAI
SET Ten_Loai = N'Thực phẩm chức năng'
WHERE Ten_Loai = 'Thực phẩm chức năng'

UPDATE LOAI
SET Ten_Loai = N'Thuốc điều trị'
WHERE Ten_Loai = 'Thuốc điều trị'

SELECT * FROM LOAI


INSERT INTO KhachHang (Ma_KH, Ten_KH, SDT, DiaChi, Email)
VALUES ('KH01', 'Alex', '012345789', N'Hà Nội', 'alex@gmail.com')

INSERT INTO KhachHang (Ma_KH, Ten_KH, SDT, DiaChi, Email)
VALUES ('KH02', 'Mike', '012345779', N'Đà Nẵng', 'mike@gmail.com')

INSERT INTO KhachHang (Ma_KH, Ten_KH, SDT, DiaChi, Email)
VALUES ('KH03', 'Anna', '012345689', N'Hà Nội', 'anna@gmail.com')

INSERT INTO KhachHang (Ma_KH, Ten_KH, SDT, DiaChi, Email)
VALUES ('KH04', 'Marry', '012245789', N'Hà Nội', 'marry@gmail.com')

INSERT INTO KhachHang (Ma_KH, Ten_KH, SDT, DiaChi, Email)
VALUES ('KH05', 'Chris', '012343789', N'Hà Nội', 'chris@gmail.com')

INSERT INTO KhachHang (Ma_KH, Ten_KH, SDT, DiaChi, Email)
VALUES ('KH06', 'Felix', '012345789', N'Hà Nội', 'alex@gmail.com')

SELECT * FROM KhachHang


INSERT INTO NhaCungCap (Ma_NCC, Ten_NCC, SDT, DiaChi, MaSoThue)
VALUES ('S01', 'Imexpharm', '023567890', N'Hưng Yên', '652876')

INSERT INTO NhaCungCap (Ma_NCC, Ten_NCC, SDT, DiaChi, MaSoThue)
VALUES ('S02', 'Mekopharm', '023564890', N'Bắc Ninh', '342876')

INSERT INTO NhaCungCap (Ma_NCC, Ten_NCC, SDT, DiaChi, MaSoThue)
VALUES ('S03', 'Sanofi', '023927890', N'Bắc Giang', '252876')

SELECT *FROM NhaCungCap

INSERT INTO DanhMucThuoc (Ma_Thuoc, Ten_Thuoc, DVT, DVT_QD, HSQD, DonGia, Mo_Ta, Ma_Loai)
VALUES ('M001', N'Dung dịch uống A.T Desloratadin', N'Hộp', N'Ống', '0.05', '187500', N'Điều trị viêm mũi dị ứng, mày đay, ngứa', 'L01')

INSERT INTO DanhMucThuoc (Ma_Thuoc, Ten_Thuoc, DVT, DVT_QD, HSQD, DonGia, Mo_Ta, Ma_Loai)
VALUES ('M002', N'Siro Lorastad SP Stella', N'Chai', N'Chai', '1', '15000', N'Điều trị dị ứng', 'L01')

INSERT INTO DanhMucThuoc (Ma_Thuoc, Ten_Thuoc, DVT, DVT_QD, HSQD, DonGia, Mo_Ta, Ma_Loai)
VALUES ('M003', N'Viên nang Fegra 120mg', N'Hộp', N'Viên', '0.01', '32000', N'Điều trị viêm mũi dị ứng, mày đay', 'L01')

INSERT INTO DanhMucThuoc (Ma_Thuoc, Ten_Thuoc, DVT, DVT_QD, HSQD, DonGia, Mo_Ta, Ma_Loai)
VALUES ('M004', N'Dung dịch Dentanlgi', N'Hộp', N'Chai', '1', '19000', N'Điều trị viêm nướu, đau răng', 'L01')

INSERT INTO DanhMucThuoc (Ma_Thuoc, Ten_Thuoc, DVT, DVT_QD, HSQD, DonGia, Mo_Ta, Ma_Loai)
VALUES ('M005', N'Viên bao tan ở ruột BROMANASE 50 UI', N'Hộp', N'Vỉ', '0.1', '390000', N'Điều trị viêm sưng, chống phù nề', 'L01')

INSERT INTO DanhMucThuoc (Ma_Thuoc, Ten_Thuoc, DVT, DVT_QD, HSQD, DonGia, Mo_Ta, Ma_Loai)
VALUES ('M006', N'Bilclamos bid 1000mg', N'Hộp', N'Vỉ', '0.5', '90000', N'Điều trị nhiễm khuẩn', 'L02')

INSERT INTO DanhMucThuoc (Ma_Thuoc, Ten_Thuoc, DVT, DVT_QD, HSQD, DonGia, Mo_Ta, Ma_Loai)
VALUES ('M007', N'Bột pha uống Augxicine 500mg', N'Hộp', N'Gói', '0.1', '120000', N'Điều trị nhiễm khuẩn', 'L02')


INSERT INTO DanhMucThuoc (Ma_Thuoc, Ten_Thuoc, DVT, DVT_QD, HSQD, DonGia, Mo_Ta, Ma_Loai)
VALUES ('M008', N'Bột đông khô pha hỗn dịch uống Toraxim 400mg', N'Hộp', N'Hộp', '1', '200000', N'Điều trị nhiễm khuẩn', 'L02')

INSERT INTO DanhMucThuoc (Ma_Thuoc, Ten_Thuoc, DVT, DVT_QD, HSQD, DonGia, Mo_Ta, Ma_Loai)
VALUES ('M009', N'Viên uống Blackmores Cholestetol Health', N'Hộp', N'Hộp', '1', '548100', N'Hỗ trợ giảm mỡ máu', 'L04')

INSERT INTO DanhMucThuoc (Ma_Thuoc, Ten_Thuoc, DVT, DVT_QD, HSQD, DonGia, Mo_Ta, Ma_Loai)
VALUES ('M010', N'Viên uống Golex Ocavill ', N'Hộp', N'Hộp', '1', '560000', N'hỗ trợ chống lại sự phình to của tuyến tiền liệt, cải thiện các rối loạn tiểu tiện', 'L04')


INSERT INTO DanhMucThuoc (Ma_Thuoc, Ten_Thuoc, DVT, DVT_QD, HSQD, DonGia, Mo_Ta, Ma_Loai)
VALUES ('M011', N'Thực phẩm bảo vệ sức khỏe KID GROW Kenko', N'Hộp', N'Hộp', '1', '480000', N'tăng cường sức đề kháng và chiều cao cho trẻ', 'L04')


INSERT INTO DanhMucThuoc (Ma_Thuoc, Ten_Thuoc, DVT, DVT_QD, HSQD, DonGia, Mo_Ta, Ma_Loai)
VALUES ('M022', N'Viên nhai Borne Mineral New Nordic', N'Hộp', N'Hộp', '1', '635000', N'hỗ trợ phát triển xương, giúp tăng chiều cao, tăng đề kháng', 'L04')

INSERT INTO DanhMucThuoc (Ma_Thuoc, Ten_Thuoc, DVT, DVT_QD, HSQD, DonGia, Mo_Ta, Ma_Loai)
VALUES ('M012', N'Viên uống SkillMax Ocavill', N'Hộp', N'Vỉ', '0.5', '536000', N'hỗ trợ tăng cường thị lực, cải thiện các triệu chứng khô mắt, mỏi mắt', 'L04')

INSERT INTO DanhMucThuoc (Ma_Thuoc, Ten_Thuoc, DVT, DVT_QD, HSQD, DonGia, Mo_Ta, Ma_Loai)
VALUES ('M013', N'Viên sủi Kudos Kids Multivitamins Plus Calcium & D3 hương dưa hấu', N'Tuýp', N'Tuýp', '1', '116800', N'bổ sung calci và vitamin cho cơ thể', 'L04')

INSERT INTO DanhMucThuoc (Ma_Thuoc, Ten_Thuoc, DVT, DVT_QD, HSQD, DonGia, Mo_Ta, Ma_Loai)
VALUES ('M014', N'Viên uống Natto Gold 3000FU Royal Care ', N'Hộp', N'Hộp', '1', '295000', N'hỗ trợ hoạt huyết, tăng cường tuần hoàn não', 'L04')

INSERT INTO DanhMucThuoc (Ma_Thuoc, Ten_Thuoc, DVT, DVT_QD, HSQD, DonGia, Mo_Ta, Ma_Loai)
VALUES ('M015', N'Viên uống Triple Strength Glucosamine 1500mg Pharmekal ', N'Hộp', N'Hộp', '1', '296000', N'bổ sung dưỡng chất cho khớp', 'L04')

INSERT INTO DanhMucThuoc (Ma_Thuoc, Ten_Thuoc, DVT, DVT_QD, HSQD, DonGia, Mo_Ta, Ma_Loai)
VALUES ('M016', N'Sữa rửa mặt Cetaphil Oily Skin Cleanser 125ml Cetaphil', N'Chai', N'Chai', '1', '148000', N'dành cho da dầu nhạy cảm', 'L03')

INSERT INTO DanhMucThuoc (Ma_Thuoc, Ten_Thuoc, DVT, DVT_QD, HSQD, DonGia, Mo_Ta, Ma_Loai)
VALUES ('M017', N'Sữa Rửa Mặt Tạo Bọt CeraVe Foaming Cleanser', N'Chai', N'Chai', '1', '386000', N'dành cho da thường và nhạy cảm', 'L03')

INSERT INTO DanhMucThuoc (Ma_Thuoc, Ten_Thuoc, DVT, DVT_QD, HSQD, DonGia, Mo_Ta, Ma_Loai)
VALUES ('M018', N'Kem chống nắng SVR Sebiaclear Creme SPF50+', N'Chai', N'Chai', '1', '530000', N'dưỡng da dùng cho da hỗn hợp, da dầu và da nhạy cảm', 'L03')

INSERT INTO DanhMucThuoc (Ma_Thuoc, Ten_Thuoc, DVT, DVT_QD, HSQD, DonGia, Mo_Ta, Ma_Loai)
VALUES ('M019', N'Sữa chống nắng La Roche-Posay Anthelios Uvmune 400', N'Chai', N'Chai', '1', '392000', N'dành cho da dầu mụn', 'L03')

INSERT INTO DanhMucThuoc (Ma_Thuoc, Ten_Thuoc, DVT, DVT_QD, HSQD, DonGia, Mo_Ta, Ma_Loai)
VALUES ('M020', N'Kem Nizoral Jassen 20mg/g', N'Hộp', N'Hộp', '1', '71000', N'điều trị nhiễm nấm ngoài da', 'L01')

INSERT INTO DanhMucThuoc (Ma_Thuoc, Ten_Thuoc, DVT, DVT_QD, HSQD, DonGia, Mo_Ta, Ma_Loai)
VALUES ('M021', N'Thuốc Quinine Sulphate 250mg Mekophar', N'Hộp', N'Hộp', '1', '560000', N'điều trị sốt rét (180 viên)', 'L01')




SELECT * FROM DanhMucThuoc




INSERT INTO HoaDonNhap (Ma_CT, Ngay_CT, Ma_NV)
VALUES ('CT01', '07-11-2024', 'E01')

SELECT * FROM HoaDonNhap

INSERT INTO HoaDonBan (Ma_CT, Ngay_CT, Ma_KH, Ma_NV)
VALUES ('DB01', '10-11-2024', 'KH01', 'E01')

INSERT INTO CTHoaDonNhap (Ma_Lo, Ma_HDN, Ma_Thuoc, Ma_NCC)
VALUES ('L001', 'CT01', 'M001', 'S01')


INSERT INTO CTHoaDonBan (ID, Ma_HDB, Ma_Thuoc)
VALUES ('HD01', 'DB01', 'M001')
