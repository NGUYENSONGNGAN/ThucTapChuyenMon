create database DOANCHUYENMON7
go
use DOANCHUYENMON7

go
create table SanPham(
MaSP int primary key,
TenSp nvarchar(1000)not null,
DonGia float ,
ThoiGianBH int,
MoTa nvarchar(1000) not null,
HinhAnh image,
MaLSP int
)
go


create table LoaiSP(
MaLSP int primary key,
TenLoaiSP nvarchar (1000)not null
)
go

create table SP_Mau(
MaMau int primary key,
TenMau nvarchar (1000) not null
)
go
 create table SP_CauHinh (
 MaLSP int,
 MaCauHinh int primary key,
 TenCauHinh nvarchar (1000) not null
 )
 go

 create table NhaCungcap (
 MaNCC int primary key ,
 TenNCC nvarchar (1000) not null,
 DiaChi nvarchar (1000)not null,
 SoDienThoai int
 )
 go

 create table NhanVien(
 MaNV int primary key ,
 TenNV nvarchar (1000) not null,
 GioiTinh nvarchar (10) not null,
 NgaySinh date,
 Gmail nchar (1000),
 DiaChi nvarchar (1000) ,
 NgayVaoLam date,
 SoDienThoai int,
 TaiKhoan nchar(100),
 MatKhau nchar(100),
 MaCV int ,

 )
 go

 create table ChucVu (
 MaCV int primary key ,
 TenCV nvarchar (100) not null,
 MucLuong float 
 )
 go

 create table HDNhapHang (
 MaHDN int primary key ,
 NgayNhap date ,
 SLNhap int,
 TongTien float,
 MaNCC int ,
 MaNV int
 )
 go 

 create table HDNH_SP(
 MaHDN int ,
 MaSP int ,
 MaCauHinh int,
 MaMau int ,
 SoLuong int,
 DonGia float
 primary key (MaSP,MaCauHinh,MaMau,MaHDN)
 )
 go
 ALTER TABLE HDNH_SP
 add ThanhTien float

 go
 create table KhachHang (
 MaKH int primary key ,
 TenKH nvarchar (100) not null,
 DiemTichLuy int ,
 DiaChi nvarchar (1000),
 SoDienThoai int,
 Gmail nchar (100),
 MaLKH int
 )
 go

 

 create table LoaiKH (
 MaLKH int primary key ,
 TenLKH nvarchar (100) not null,
 PhanTramChietKhau float
 )
 go

 create table HoaDonBanHang( 
 MaHD int primary key ,
 NgayXuat date ,
 TongTien float ,
 GhiChu nvarchar (1000),
 TrangThai bit ,
 MaQR image,
 MaKH int, 
 MaNV int
 )
 go

 create table HDBH_SP(
 MaHD int ,
 MaSP int ,
 MaCauHinh int,
 MaMau int,
 SoLuong int,
 ThanhTien float,
 primary key (MaSP, MaCauHinh,MaMau,MaHD)
 )
 go 
  create table CTSanPham(
  MaSP int ,
  MaMau int ,
  MaCauHinh int ,
  SoLuong int,
  primary key (MaSP,MaMau,MaCauHinh)
 )
 go 
 create table ad(
Ma int identity (1,1) primary key,
TaiKhoan nchar(1000),
MatKhau nchar (1000)
)
go
create table Email (
Ma int  primary key,
TaiKhoan nvarchar (1000),
MatKhau nvarchar (1000))
go
create table TGBHconlai 
(
 MaHDBH int ,
 masp int,
 mach int,
 mamau int,
 thoigianconlai date,
  primary key (MaHDBH,masp,mamau )
)
go

create table TKTGBH 
(
 MaHDBH int ,
 masp int,
 mach int,
 mamau int,
 thoigianconlai date,
  primary key (MaHDBH,masp,mamau,mach )
)
go
alter table TKTGBH add foreign key (MaHDBH) references HoaDonBanHang(MaHD)
alter table TKTGBH add foreign key (masp) references SanPham(MaSP)
alter table TKTGBH add foreign key (mach) references SP_CauHinh(MaCauHinh)
alter table TKTGBH add foreign key (mamau) references SP_Mau(MaMau)
go
 alter table SanPham add foreign key (MaLSP) references  LoaiSP(MaLSP)

 alter table SP_CauHinh add foreign key (MaLSP) references  LoaiSP(MaLSP)


 alter table NhanVien add foreign key (MaCV) references  ChucVu(MaCV)

 alter table HDNhapHang add foreign key (MaNCC) references  NhaCungCap(MaNCC)
 alter table HDNhapHang add foreign key (MaNV) references  NhanVien(MaNV)

 alter table HDNH_SP add foreign key (MaHDN) references  HDNhapHang(MaHDN)
 alter table HDNH_SP add foreign key (MaSP) references  SanPham(MaSP)
 alter table HDNH_SP add foreign key (MaMau) references  SP_Mau(MaMau)
 alter table HDNH_SP add foreign key (MaCauHinh) references  SP_CauHinh(MaCauHinh)

 alter table KhachHang add foreign key (MaLKH) references  LoaiKH(MaLKH)

 alter table HoaDonBanHang add foreign key (MaKH) references  KhachHang(MaKH)
 alter table HoaDonBanHang add foreign key (MaNV) references  NhanVien(MaNV)

 alter table HDBH_SP add foreign key (MaHD) references  HoaDonBanHang(MaHD)
 alter table HDBH_SP add foreign key (MaSP) references  SanPham(MaSP)
 alter table HDBH_SP add foreign key (MaMau) references  SP_Mau(MaMau)
 alter table HDBH_SP add foreign key (MaCauHinh) references  SP_CauHinh(MaCauHinh)


 alter table CTSanPham add foreign key (MaSP) references  SanPham(MaSP)
 alter table CTSanPham add foreign key (MaMau) references  SP_Mau(MaMau)
 alter table CTSanPham add foreign key (MaCauHinh) references  SP_CauHinh(MaCauHinh)
 go

 insert into ChucVu values(1,N'Quản lí',20000000)
 insert into ChucVu values(2,N'Kế Toán',13000000)
 insert into ChucVu values(3,N'Nhân Viên bán hàng',11000000)
 go
 insert into LoaiKH values(1,N'Đồng',0)
 insert into LoaiKH values(2,N'Bạc',0.1)
 insert into LoaiKH values(3,N'Vàng',0.25)
 insert into LoaiKH values(4,N'Kim Cương',0.35)


 go

 insert into LoaiSP values (1,N'Điện thoại')
  insert into LoaiSP values (2,N'Ti Vi')
  insert into LoaiSP values (3,N'Tablet')
  insert into LoaiSP values (4,N'LapTop')
  insert into LoaiSP values (5,N'Phụ kiện')
  go

 insert into HDBH_SP values (1,21,7,1,5,250000)
 go
 insert into HDNH_SP values(1,21,7,1,8000,250000)
 go
 insert into HoaDonBanHang values(1,'2020-1-1',20000,null,1,null,1,1)
 go
 insert into HDNhapHang values(2,'2020-1-1',20000,250000,1,1)
 go
 insert into KhachHang values(1,N'Đạt',150,N'Nghệ An',111111,null,1)
 go
 insert into NhaCungcap values(1,N'Nokia',N'Nhật Bản',0988385471)
 insert into NhaCungcap values(2,N'SamSung',N'Hàn Quốc',0988287811)
 insert into NhaCungcap values(3,N'VinFast',N'Việt Nam',0988385471)
 go

 insert into SanPham values (01, N'Điện thoại Huawei Nova3i', 7500000,12,N'Hàng mới', NULL,1)
 insert into SanPham values (02, N'Điện thoại Iphone 12', 38000000,24,N'Hàng mới', NULL,1)
 insert into SanPham values (03, N'Điện thoại Iphone 12', 21000000,15,N'Hàng cũ' ,NULL,1)
 insert into SanPham values (04, N'Điện thoại Iphone X', 12000000,18,N'Hàng mới', NULL,1)
 insert into SanPham values (05, N'Điện thoại Huawei Nova3i', 4550000,7,N'Hàng cũ', NULL,1)
 insert into SanPham values (06, N'Điện thoạii Galaxy Note 20', 32000000,24,N'Hàng mới', NULL,1)
 insert into SanPham values (07, N'Điện thoại Galaxy S21', 14999000,25,N'Hàng mới', NULL,1)
 insert into SanPham values (08, N'Điện thoại Galaxy Z Fold2', 50000000,24,N'Hàng mới', NULL,1)
 insert into SanPham values (09, N'Điện thoại huwei Nova2i', 2500000,9,N'Hàng cũ', NULL,1)
 insert into SanPham values (10, N'Điện thoại Xaomi Mi11', 15990000,10,N'Hàng cũ', NULL,1)

  insert into SanPham values (11, N'TiVi LG Smart Tv', 12000000,18,N'Hàng mới', NULL,2)
  insert into SanPham values (12, N'TiVi Casper Smart  Tv', 4500000,12,N'Hàng mới', NULL,2)
  insert into SanPham values (13, N'TiVi Samsung Smart Tv QLED', 15500000,7,N'Hàng cũ', NULL,2)
  insert into SanPham values (14, N'TiVi Sony Android Tv', 12900000,24,N'Hàng mới', NULL,2)
  insert into SanPham values (15, N'TiVi Sony Smart Tv', 18500000,18,N'Hàng mới', NULL,2)
  insert into SanPham values (16, N'TiVi TCL Smart Tv', 12000000,3,N'Hàng cũ', NULL,2)
  insert into SanPham values (17, N'TiVi Samsung Tv', 12000000,5,N'Hàng mới', NULL,2)
  insert into SanPham values (18, N'TiVi Sony Tv', 18500000,18,N'Hàng mới', NULL,2)
  insert into SanPham values (19, N'TiVi TCL Tv', 7000000,9,N'Hàng cũ', NULL,2)
  insert into SanPham values (20, N'TiVi Casper Tv', 13000000,5,N'Hàng mới', NULL,2)

  insert into SanPham values (21, N'Tablet Samsung galaxy A7 ', 7990000,12,N'Hàng mới', NULL,3)
  insert into SanPham values (22, N'Table Ipat Pro M1 ', 37900000,20,N'Hàng cũ', NULL,3)
  insert into SanPham values (23, N'Tablet Huawei MatePad ', 6900000,18,N'Hàng mới', NULL,3)
  insert into SanPham values (24, N'Tablet Lenovo Tab M10', 5400000,10,N'Hàng mới', NULL,3)
  insert into SanPham values (25, N'Tablet Ipat Air 4', 24100000,24,N'Hàng cũ', NULL,3)
  insert into SanPham values (26, N'Tablet Samsung galaxy A3 ', 4990000,12,N'Hàng mới', NULL,3)
  insert into SanPham values (27, N'Table Ipat Pro 2019 ', 27900000,20,N'Hàng cũ', NULL,3)
  insert into SanPham values (28, N'Tablet Huawei MatePad Pro', 8900000,18,N'Hàng mới', NULL,3)
  insert into SanPham values (29, N'Tablet Lenovo Think ', 3200000,10,N'Hàng mới', NULL,3)
  insert into SanPham values (30, N'Tablet Ipat Pro 2017', 21100000,24,N'Hàng cũ', NULL,3)

  insert into SanPham values (31, N'LapTop Lenovo IdeaPad 3', 11700000,24,N'Hàng mới', NULL,4)
  insert into SanPham values (32, N'LapTop HP 15S', 12900000,18,N'Hàng mới', NULL,4)
  insert into SanPham values (33, N'LapTop HP 340s', 25400000,24,N'Hàng mới', NULL,4)
  insert into SanPham values (34, N'LapTop Macbook Air', 35600000,10,N'Hàng cũ', NULL,4)
  insert into SanPham values (35, N'LapTop Macbook Pro', 56200000,36,N'Hàng mới', NULL,4)
  insert into SanPham values (36, N'LapTop Asus VivoBook', 26000000,24,N'Hàng mới', NULL,4)
  insert into SanPham values (37, N'LapTop Del XPS', 18700000,5,N'Hàng mới', NULL,4)
  insert into SanPham values (38, N'LapTop Del Pavilon', 16300000,18,N'Hàng mới', NULL,4)
  insert into SanPham values (39, N'LapTop Asus VivoBook 14', 17000000,24,N'Hàng mới', NULL,4)
  insert into SanPham values (40, N'LapTop Del XPS 13 ', 21700000,5,N'Hàng mới', NULL,4)

   insert into SanPham values (41, N'Sạc dự phòng Xaomi', 190000,18,N'Hàng mới', NULL,5)
   insert into SanPham values (42, N'Tai nghe bluetooth Sony', 800000,12,N'Hàng mới', NULL,5)
  insert into SanPham values (43, N'Loa Bluetooth True Wireless', 9300000,12,N'Hàng mới', NULL,5)
  insert into SanPham values (44, N'Tai nghe EP Awei', 5380000,18,N'Hàng cũ', NULL,5)
  insert into SanPham values (45, N'AirPod Pro', 6300000,18,N'Hàng mới', NULL,5)
  insert into SanPham values (46, N'Cáp type C', 80000,3,N'Hàng mới', NULL,5)
  insert into SanPham values (47, N'Cáp Lightning', 25000,3,N'Hàng mới', NULL,5)
  insert into SanPham values (48, N'Giá đỡ điện thoại', 1150000,5,N'Hàng mới', NULL,5)
  insert into SanPham values (49, N'USB', 80000,12,N'Hàng cũ', NULL,5)
  insert into SanPham values (50, N'Thẻ nhớ', 250000,12,N'Hàng mới', NULL,5)
  go

  insert into SP_Mau values (1,N'Đen')
  insert into SP_Mau values (2,N'Trắng')
  insert into SP_Mau values (3,N'Hồng')
  insert into SP_Mau values (4,N'Vàng')
  insert into SP_Mau values (5,N'Gord')
  insert into SP_Mau values (6,N'Đỏ')
  insert into SP_Mau values (7,N'Xanh ngọc')
  insert into SP_Mau values (8,N'Bạc')
  insert into SP_Mau values (9,N'Xanh dương')
  insert into SP_Mau values (10,N'Xám')
  go

  insert into SP_CauHinh values(1,1,N'Hệ điều hành : Android 11, RAM: 8 GB , Bộ Nhớ trong 128G ')
  insert into SP_CauHinh values(1,2,N'Hệ điều hành : Android 11, RAM: 4 GB , Bộ Nhớ trong 64G ')
  insert into SP_CauHinh values(1,3,N'Hệ điều hành : IOS 14 , RAM: 8 GB , Bộ Nhớ trong 128G ')
  insert into SP_CauHinh values(1,4,N'Hệ điều hành : IOS 14, RAM: 4 GB , Bộ Nhớ trong 64G ')

  insert into SP_CauHinh values(2,5,N'Hệ điều hành WebOS5.0, 55inch , 4k ,Ngang 124 cm - Cao 78 cm - Dày 23 cm')
  insert into SP_CauHinh values(2,6,N'Hệ điều hành TizenOS5.0, 32inch , 4k ,Ngang 72.5 cm - Cao 46.54cm - Dày 15.0 cm')

  insert into SP_CauHinh values(3,7,N'Hệ điều hành : Android 10, RAM: 6 GB , Bộ Nhớ trong 128G ')
  insert into SP_CauHinh values(3,8,N'Hệ điều hành : IOS 14 , RAM: 8 GB , Bộ Nhớ trong 256G ')

  insert into SP_CauHinh values (4,9,N' Ram 4GB DDR4 ,15.6 inch, core i3 ')
  insert into SP_CauHinh values (4,10,N' Ram 8GB DDR4 ,15.6 inch, core i5 ')
  insert into SP_CauHinh values (4,11,N' Ram 8GB  ,13.3 inch, M1')
  insert into SP_CauHinh values (4,12,N' Ram 8GB DDR3L ,15.6 inch, core i5 ')


  insert into SP_CauHinh values (5,13,N' 7500mAh ')
  insert into SP_CauHinh values (5,14,N' 10000mAh ')
  insert into SP_CauHinh values (5,15,N' Bluetooth 5.0 , cổng sạc type C ')
  insert into SP_CauHinh values (5,16,N' Công suất 30 W,Công nghệ MeridianSound Boost')
  insert into SP_CauHinh values (5,17,N' Jack 3.5 , dài 1.34m ')
  insert into SP_CauHinh values (5,18,N' Chip H1 ')
  insert into SP_CauHinh values (5,19,N' Công suất 15 W , dài 1m ')
  insert into SP_CauHinh values (5,20,N' Công suất 12 W, dài 1m ')
  insert into SP_CauHinh values (5,21,N' Dạng đế kẹp ')
  insert into SP_CauHinh values (5,22,N' Dạng iring dán ốp điện thoại ')
  insert into SP_CauHinh values (5,23,N' Bộ nhớ 128G')
  insert into SP_CauHinh values (5,24,N' Bộ nhớ 64G ')
  go

  insert into NhanVien values(1, N'Ngân' ,N'Nữ' , '2000-10-16',N'nguyensongnganthefirst@gmail.com',N'Nghệ An','2021-05-05' ,0988390845, N'NGAN' ,N'123456',1)
  insert into NhanVien values(2, N'Ngọc' ,N'Nữ' , '2000-10-16',N'nguyensongnganthefirst@gmail.com',N'Nghệ An','2021-05-05' ,0855395547, N'ADMIN' ,N'123',2)
  insert into NhanVien values(3, N'Nghiêm' ,N'Nam' , '2000-10-16',N'nguyensongnganthefirst@gmail.com',N'Nghệ An','2021-05-05' ,0344652154, N'ADMIN1' ,N'1234',2)
  insert into NhanVien values(4, N'Thanh Ngân' ,N'Nữ' , '2000-10-16',N'nguyensongnganthefirst@gmail.com',N'Nghệ An','2021-05-05' ,0988254624, N'NGAN1' ,N'12345',3)
  insert into NhanVien values(5, N'Phú' ,N'Nam' , '2000-10-16',N'nguyensongnganthefirst@gmail.com',N'Nghệ An','2021-05-05' ,0344562578, N'NGAN2' ,N'12',3)
  insert into NhanVien values(6, N'Hoài' ,N'Nữ' , '2000-10-16',N'nguyensongnganthefirst@gmail.com',N'Nghệ An','2021-05-05' , 0344168975,N'NGAN3' ,N'1234567',3)
  insert into NhanVien values(7, N'Thanh' ,N'Nữ' , '2000-10-16',N'nguyensongnganthefirst@gmail.com',N'Nghệ An','2021-05-05' ,0988245756, N'NGAN4' ,N'1234568',1)
  insert into NhanVien values(8, N'Anh' ,N'Nam' , '2000-10-16',N'nguyensongnganthefirst@gmail.com',N'Nghệ An','2021-05-05' ,0855462315,N'NGAN5' ,N'1234569',3)
  insert into NhanVien values(9, N'Hùng' ,N'Nữ' , '2000-10-16',N'nguyensongnganthefirst@gmail.com',N'Nghệ An','2021-05-05' ,0355624102, N'NGAN6' ,N'12345610',3)
  insert into NhanVien values(10, N'Hòa' ,N'Nữ' , '2000-10-16',N'nguyensongnganthefirst@gmail.com',N'Nghệ An','2021-05-05' ,0988365425, N'NGAN7' ,N'12345611',2)
  insert into NhanVien values(13, N'Hòa' ,N'Nữ' , '2000-10-16',N'nguyensongnganthefirst@gmail.com',N'Nghệ An','2021-05-05' ,0988365425, N'NGAN7' ,N'12345611',2)
  
  go

  insert into CTSanPham values (01,1,4,5)
  insert into CTSanPham values (01,2,2,2)
  insert into CTSanPham values (01,3,3,3)
  insert into CTSanPham values (01,4,4,6)
  insert into CTSanPham values (01,5,1,8)
  insert into CTSanPham values (01,6,2,7)
  insert into CTSanPham values (01,7,3,1)
  insert into CTSanPham values (01,8,4,5)
  insert into CTSanPham values (01,9,1,9)
  insert into CTSanPham values (01,10,1,546)

  insert into CTSanPham values (02,1,1,5)
  insert into CTSanPham values (02,2,2,2)
  insert into CTSanPham values (02,3,3,3)
  insert into CTSanPham values (02,4,4,6)
  insert into CTSanPham values (02,5,1,7)
  insert into CTSanPham values (02,6,2,7)
  insert into CTSanPham values (02,7,3,1)
  insert into CTSanPham values (02,8,4,6)
  insert into CTSanPham values (02,9,1,9)
  insert into CTSanPham values (02,10,1,3)

  insert into CTSanPham values (03,1,1,5)
  insert into CTSanPham values (03,2,2,2)
  insert into CTSanPham values (03,3,3,3)
  insert into CTSanPham values (03,4,4,6)
  insert into CTSanPham values (03,5,1,7)
  insert into CTSanPham values (03,6,2,7)
  insert into CTSanPham values (03,7,3,1)
  insert into CTSanPham values (03,8,4,6)
  insert into CTSanPham values (03,9,1,9)
  insert into CTSanPham values (03,10,1,3)

  insert into CTSanPham values (04,2,2,2)
  insert into CTSanPham values (04,3,3,3)
  insert into CTSanPham values (04,4,4,6)
  insert into CTSanPham values (04,5,1,7)
  insert into CTSanPham values (04,9,1,9)
  insert into CTSanPham values (04,10,1,3)
  insert into CTSanPham values (04,1,1,5457)
  insert into CTSanPham values (04,6,2,7457)
  insert into CTSanPham values (04,7,3,1455)
  insert into CTSanPham values (04,8,4,6254)

  insert into CTSanPham values (05,3,3,3)
  insert into CTSanPham values (05,4,4,6)
  insert into CTSanPham values (05,5,1,7)
  insert into CTSanPham values (05,6,2,7)
  insert into CTSanPham values (05,7,3,1)
  insert into CTSanPham values (05,8,4,6)
  insert into CTSanPham values (05,1,1,5654)
  insert into CTSanPham values (05,2,2,2654)
  insert into CTSanPham values (05,9,1,964)
  insert into CTSanPham values (05,10,1,34564)

  insert into CTSanPham values (06,1,1,5)
  insert into CTSanPham values (06,2,2,2)
  insert into CTSanPham values (06,3,3,3)
  insert into CTSanPham values (06,4,4,6)
  insert into CTSanPham values (06,5,1,7)
  insert into CTSanPham values (06,6,2,7)
  insert into CTSanPham values (06,7,3,1)
  insert into CTSanPham values (06,8,4,6)
  insert into CTSanPham values (06,9,1,9)
  insert into CTSanPham values (06,10,1,3)

  insert into CTSanPham values (07,1,1,5)
  insert into CTSanPham values (07,2,2,2)
  insert into CTSanPham values (07,3,3,3)
  insert into CTSanPham values (07,4,4,6)
  insert into CTSanPham values (07,5,1,7)
  insert into CTSanPham values (07,6,2,7)
  insert into CTSanPham values (07,7,3,1)

  insert into CTSanPham values (08,7,3,1)
  insert into CTSanPham values (08,8,4,6)
  insert into CTSanPham values (08,9,1,9)
  insert into CTSanPham values (08,10,1,3)

  insert into CTSanPham values (09,1,1,5)
  insert into CTSanPham values (09,2,2,2)
  insert into CTSanPham values (09,3,3,3)
  insert into CTSanPham values (09,4,4,6)
  insert into CTSanPham values (09,5,1,7)
  insert into CTSanPham values (09,6,2,7)
  insert into CTSanPham values (09,7,3,1)
  insert into CTSanPham values (09,8,4,6)
  insert into CTSanPham values (09,9,1,9)
  insert into CTSanPham values (09,10,1,3)

  insert into CTSanPham values (10,1,1,5)
  insert into CTSanPham values (10,3,3,3)
  insert into CTSanPham values (10,4,4,6)
  insert into CTSanPham values (10,5,1,7)
  insert into CTSanPham values (10,6,2,7)
  insert into CTSanPham values (10,10,1,3)
  go

  insert into CTSanPham values (11,1,6,5)
  insert into CTSanPham values (11,2,6,3)
  insert into CTSanPham values (11,3,5,6)
  insert into CTSanPham values (11,4,5,4)
  insert into CTSanPham values (11,5,6,7)
  insert into CTSanPham values (11,6,5,9)
  insert into CTSanPham values (11,7,5,6)
  insert into CTSanPham values (11,8,6,2)
  insert into CTSanPham values (11,9,6,8)
  insert into CTSanPham values (11,10,5,5)

  insert into CTSanPham values (12,1,6,5)
  insert into CTSanPham values (12,2,6,3)
  insert into CTSanPham values (12,3,5,6)
  insert into CTSanPham values (12,4,5,4)
  insert into CTSanPham values (12,5,6,7)

  insert into CTSanPham values (13,3,5,6)
  insert into CTSanPham values (13,4,5,4)
  insert into CTSanPham values (13,5,6,7)
  insert into CTSanPham values (13,6,5,9)
  insert into CTSanPham values (13,7,5,6)
  insert into CTSanPham values (13,8,6,2)

  insert into CTSanPham values (14,3,5,6)
  insert into CTSanPham values (14,4,5,4)
  insert into CTSanPham values (14,5,6,7)
  insert into CTSanPham values (14,6,5,9)
  insert into CTSanPham values (14,7,5,6)
  insert into CTSanPham values (14,8,6,2)
  insert into CTSanPham values (14,9,6,8)
  insert into CTSanPham values (14,10,5,5)

  insert into CTSanPham values (15,1,6,5)
  insert into CTSanPham values (15,2,6,3)
  insert into CTSanPham values (15,3,5,6)
  insert into CTSanPham values (15,4,5,4)
  insert into CTSanPham values (15,5,6,7)
  insert into CTSanPham values (15,6,5,9)
  insert into CTSanPham values (15,7,5,6)
  insert into CTSanPham values (15,8,6,2)
  insert into CTSanPham values (15,9,6,8)
  insert into CTSanPham values (15,10,5,5)

  insert into CTSanPham values (16,2,6,3)
  insert into CTSanPham values (16,3,5,6)
  insert into CTSanPham values (16,4,5,4)
  insert into CTSanPham values (16,5,6,7)
  insert into CTSanPham values (16,6,5,9)
  insert into CTSanPham values (16,7,5,6)

  insert into CTSanPham values (17,3,5,6)
  insert into CTSanPham values (17,4,5,4)
  insert into CTSanPham values (17,5,6,7)
  insert into CTSanPham values (17,6,5,9)
  insert into CTSanPham values (17,7,5,6)
  insert into CTSanPham values (17,8,6,2)
  insert into CTSanPham values (17,9,6,8)
  insert into CTSanPham values (17,10,5,5)

  insert into CTSanPham values (18,1,6,5)
  insert into CTSanPham values (18,2,6,3)
  insert into CTSanPham values (18,3,5,6)
  insert into CTSanPham values (18,4,5,4)
  insert into CTSanPham values (18,5,6,7)

  insert into CTSanPham values (19,1,6,5)
  insert into CTSanPham values (19,2,6,3)
  insert into CTSanPham values (19,3,5,6)
  insert into CTSanPham values (19,4,5,4)
  insert into CTSanPham values (19,5,6,7)
  insert into CTSanPham values (19,6,5,9)
  insert into CTSanPham values (19,7,5,6)
  insert into CTSanPham values (19,8,6,2)
  insert into CTSanPham values (19,9,6,8)
  insert into CTSanPham values (19,10,5,5)

  insert into CTSanPham values (20,8,6,2)
  insert into CTSanPham values (20,9,6,8)
  insert into CTSanPham values (20,10,5,5)
  insert into CTSanPham values (20,4,5,4)
  insert into CTSanPham values (20,5,6,7)
  insert into CTSanPham values (20,6,5,9)
  go

  insert into CTSanPham values (21,1,7,2)
  insert into CTSanPham values (21,2,8,9)
  insert into CTSanPham values (21,3,7,25)
  insert into CTSanPham values (21,4,7,4)
  insert into CTSanPham values (21,5,8,36)
  insert into CTSanPham values (21,6,7,9)
  insert into CTSanPham values (21,7,7,48)
  insert into CTSanPham values (21,8,8,4)
  insert into CTSanPham values (21,9,8,7)
  insert into CTSanPham values (21,10,8,98)

  insert into CTSanPham values (22,5,8,36)
  insert into CTSanPham values (22,6,7,9)
  insert into CTSanPham values (22,7,7,48)
  insert into CTSanPham values (22,8,8,4)
  insert into CTSanPham values (22,9,8,7)
  insert into CTSanPham values (22,10,8,98)

  insert into CTSanPham values (23,2,8,9)
  insert into CTSanPham values (23,3,7,25)
  insert into CTSanPham values (23,4,7,4)
  insert into CTSanPham values (23,5,8,36)
  insert into CTSanPham values (23,6,7,9)
  insert into CTSanPham values (23,7,7,48)

  insert into CTSanPham values (24,6,7,9)
  insert into CTSanPham values (24,7,7,48)
  insert into CTSanPham values (24,8,8,4)
  insert into CTSanPham values (24,9,8,7)
  insert into CTSanPham values (24,10,8,98)
  insert into CTSanPham values (24,1,7,2)
  insert into CTSanPham values (24,2,8,9)

  insert into CTSanPham values (25,1,7,2)
  insert into CTSanPham values (25,2,8,9)
  insert into CTSanPham values (25,3,7,25)
  insert into CTSanPham values (25,4,7,4)
  insert into CTSanPham values (25,5,8,36)
  insert into CTSanPham values (25,6,7,9)
  insert into CTSanPham values (25,7,7,48)
  insert into CTSanPham values (25,8,8,4)
  insert into CTSanPham values (25,9,8,7)
  insert into CTSanPham values (25,10,8,98)

  insert into CTSanPham values (26,1,7,2)
  insert into CTSanPham values (26,2,8,9)
  insert into CTSanPham values (26,3,7,25)
  insert into CTSanPham values (26,4,7,4)

  insert into CTSanPham values (27,3,7,25)
  insert into CTSanPham values (27,4,7,4)
  insert into CTSanPham values (27,5,8,36)
  insert into CTSanPham values (27,6,7,9)
  insert into CTSanPham values (27,7,7,48)

  insert into CTSanPham values (28,1,7,2)
  insert into CTSanPham values (28,2,8,9)
  insert into CTSanPham values (28,3,7,25)
  insert into CTSanPham values (28,4,7,4)
  insert into CTSanPham values (28,5,8,36)
  insert into CTSanPham values (28,6,7,9)
  insert into CTSanPham values (28,7,7,48)
  insert into CTSanPham values (28,8,8,4)
  insert into CTSanPham values (28,9,8,7)
  insert into CTSanPham values (28,10,8,98)

  insert into CTSanPham values (29,1,7,2)
  insert into CTSanPham values (29,2,7,9)
  insert into CTSanPham values (29,1,8,25)
  insert into CTSanPham values (29,2,8,4)

  insert into CTSanPham values (30,1,7,2)
  insert into CTSanPham values (30,2,8,9)
  insert into CTSanPham values (30,3,7,25)
  insert into CTSanPham values (30,4,7,4)
  insert into CTSanPham values (30,5,8,36)
  insert into CTSanPham values (30,6,7,9)


  go
  insert into CTSanPham values (31,1,9,5)
  insert into CTSanPham values (31,2,9,3)
  insert into CTSanPham values (31,3,10,6)
  insert into CTSanPham values (31,4,11,4)
  insert into CTSanPham values (31,5,11,7)
  insert into CTSanPham values (31,6,10,9)
  insert into CTSanPham values (31,7,12,6)
  insert into CTSanPham values (31,8,12,2)
  insert into CTSanPham values (31,9,9,8)
  insert into CTSanPham values (31,10,10,5)

  insert into CTSanPham values (32,1,10,5)
  insert into CTSanPham values (32,2,12,3)
  insert into CTSanPham values (32,3,9,6)
  insert into CTSanPham values (32,4,9,4)
  insert into CTSanPham values (32,5,11,7)
  insert into CTSanPham values (32,6,10,9)
  insert into CTSanPham values (32,7,12,6)
  insert into CTSanPham values (32,8,10,2)
  insert into CTSanPham values (32,9,11,8)
  insert into CTSanPham values (32,10,9,5)

  insert into CTSanPham values (33,1,12,5)
  insert into CTSanPham values (33,2,12,3)
  insert into CTSanPham values (33,3,10,6)
  insert into CTSanPham values (33,4,9,4)
  insert into CTSanPham values (33,5,9,7)
  insert into CTSanPham values (33,6,9,9)

  insert into CTSanPham values (34,3,12,6)
  insert into CTSanPham values (34,4,10,4)
  insert into CTSanPham values (34,5,10,7)
  insert into CTSanPham values (34,6,11,9)
  insert into CTSanPham values (34,7,12,6)
  insert into CTSanPham values (34,8,9,2)
  insert into CTSanPham values (34,9,10,8)
  insert into CTSanPham values (34,10,10,5)

  insert into CTSanPham values (35,1,11,5)
  insert into CTSanPham values (35,2,11,3)
  insert into CTSanPham values (35,3,11,6)
  insert into CTSanPham values (35,4,12,4)
  insert into CTSanPham values (35,5,12,7)
  insert into CTSanPham values (35,6,9,9)
  insert into CTSanPham values (35,7,9,6)
  insert into CTSanPham values (35,8,9,2)
  insert into CTSanPham values (35,9,9,8)
  insert into CTSanPham values (35,10,12,5)

  insert into CTSanPham values (36,6,10,9)
  insert into CTSanPham values (36,7,10,6)
  insert into CTSanPham values (36,8,10,2)

  insert into CTSanPham values (37,8,9,2)
  insert into CTSanPham values (37,9,10,8)
  insert into CTSanPham values (37,10,12,5)
  insert into CTSanPham values (37,3,9,6)
  insert into CTSanPham values (37,4,9,4)
  insert into CTSanPham values (37,5,10,7)
  insert into CTSanPham values (37,6,10,9)

  insert into CTSanPham values (38,1,11,5)
  insert into CTSanPham values (38,2,11,3)
  insert into CTSanPham values (38,3,12,6)
  insert into CTSanPham values (38,4,11,4)
  insert into CTSanPham values (38,5,12,7)

  insert into CTSanPham values (39,1,10,5)
  insert into CTSanPham values (39,2,10,3)
  insert into CTSanPham values (39,3,10,6)
  insert into CTSanPham values (39,4,10,4)
  insert into CTSanPham values (39,5,9,7)
  insert into CTSanPham values (39,6,9,9)
  insert into CTSanPham values (39,7,9,6)
  insert into CTSanPham values (39,8,12,2)
  insert into CTSanPham values (39,9,12,8)
  insert into CTSanPham values (39,10,11,5)

  insert into CTSanPham values (40,3,10,6)
  insert into CTSanPham values (40,4,12,4)
  insert into CTSanPham values (40,5,12,7)
  insert into CTSanPham values (40,6,11,9)
  insert into CTSanPham values (40,7,10,6)
  insert into CTSanPham values (40,8,10,2)
  go

  insert into CTSanPham values (41,1,13,2)
  insert into CTSanPham values (41,2,13,38)
  insert into CTSanPham values (41,3,14,2)
  insert into CTSanPham values (41,4,14,36)
  insert into CTSanPham values (41,5,14,8)

  insert into CTSanPham values (42,1,15,2)
  insert into CTSanPham values (42,5,15,52)
  insert into CTSanPham values (42,6,15,2)
  insert into CTSanPham values (42,7,15,7)
  insert into CTSanPham values (42,8,15,58)

  insert into CTSanPham values (43,4,16,2)
  insert into CTSanPham values (43,5,16,4)
  insert into CTSanPham values (43,9,16,90)
  insert into CTSanPham values (43,10,16,7)
  insert into CTSanPham values (43,6,16,30)

  insert into CTSanPham values (44,2,17,2)
  insert into CTSanPham values (44,1,17,4)
  insert into CTSanPham values (44,6,17,33)
  insert into CTSanPham values (44,3,17,7)
  insert into CTSanPham values (44,4,17,812)

  insert into CTSanPham values (45,1,18,2)
  insert into CTSanPham values (45,3,18,18)
  insert into CTSanPham values (45,5,18,20)
  insert into CTSanPham values (45,7,18,7)
  insert into CTSanPham values (45,9,18,19)

  insert into CTSanPham values (46,2,19,2)
  insert into CTSanPham values (46,5,19,5)
  insert into CTSanPham values (46,2,20,4)
  insert into CTSanPham values (46,10,19,7)
  insert into CTSanPham values (46,9,20,1)

  insert into CTSanPham values (47,1,19,2)
  insert into CTSanPham values (47,10,20,22)
  insert into CTSanPham values (47,9,19,4)
  insert into CTSanPham values (47,8,19,7)
  insert into CTSanPham values (47,7,20,4)

  insert into CTSanPham values (48,2,21,2)
  insert into CTSanPham values (48,4,21,2)
  insert into CTSanPham values (48,6,22,4)
  insert into CTSanPham values (48,8,22,7)
  insert into CTSanPham values (48,10,21,9)

  insert into CTSanPham values (49,1,23,2)
  insert into CTSanPham values (49,3,24,5)
  insert into CTSanPham values (49,5,23,12)
  insert into CTSanPham values (49,7,23,7)
  insert into CTSanPham values (49,9,24,1)

   insert into CTSanPham values (50,1,23,2)
  insert into CTSanPham values (50,2,23,5)
  insert into CTSanPham values (50,3,23,4)
  insert into CTSanPham values (50,4,23,7)
  insert into CTSanPham values (50,5,24,1)
  insert into CTSanPham values (50,6,24,2)
  insert into CTSanPham values (50,7,24,5)
  insert into CTSanPham values (50,8,23,4)
  insert into CTSanPham values (50,9,23,7)
  insert into CTSanPham values (50,10,24,1)
  go
  --insert into HoaDonBanHang values (1, 1,1,'05-20-2019', 0)
--insert into HoaDonBanHang values (2, 1,1,'05-20-2019', 0)
--go

--select * from HoaDonBanHang
--Khach hang
--insert into KhachHang values (1, N'Nam', N'hehe', N'hehe', N'0123', 0, 1 )
--go
--Hóa đơn xuất
--insert into HDNhapHang values (1, 1, 1, '2020-05-13', 0, 1, N'Khách hàng lấy muộn', null)
--go
---CTHDN
--insert into HDNH_SP values (1, 1, 1, 1, 10, 50000, 500000)
--go

  ------ KhachHang
  create proc selectKH1
as
select * from KhachHang
go

create proc selectKhachhang
as
select MaKH N'Mã KH' , TenKH N'Tên KH' ,DiemTichLuy N'Điểm tích lũy' ,DiaChi N'Địa chỉ',SoDienThoai N'Số điện thoại',Gmail , TenLKH N'Loại Khách Hàng'
from KhachHang ,LoaiKH where KhachHang.MaLKH = LoaiKH.MaLKH
go

 create proc insertKH (@ma int, @ten nvarchar (1000),@DiemTichLuy int, @DiaChi nvarchar(1000),@SoDienThoai int ,@gmail nchar (100) )
as
begin
insert into KhachHang values (@ma, @ten, @DiemTichLuy,@DiaChi,@SoDienThoai,@gmail,1)
end

go
 create proc insertKHADD (@ma int, @ten nvarchar (1000), @DiaChi nvarchar(1000),@SoDienThoai int ,@gmail nchar (100) )
as
begin
insert into KhachHang values (@ma, @ten, 0,@DiaChi,@SoDienThoai,@gmail,1)
end
go

go
create proc updateKH2 (@ma int, @ten nvarchar (1000), @DiaChi nvarchar (1000), @SDT int, @Gmail nvarchar (100) )
as
begin
update KhachHang set TenKH = @ten, DiaChi = @DiaChi, SoDienThoai = @SDT, Gmail = @Gmail where MaKH = @ma
end

go
----NCC


create proc InsertNCC (@ma int , @ten nvarchar (1000) , @diachi nvarchar (1000) , @sodienthoai int)
as
begin
 insert into NhaCungcap values (@ma, @ten, @diachi,@sodienthoai)
end


go
create proc deleteNCC2 (@ma int )
as
begin
 delete from NhaCungcap where MaNCC = @ma
end

go

create proc updateNCC (@ma int, @ten nvarchar (1000), @DiaChi nvarchar (1000), @SDT int  )
as
begin
update NhaCungcap set TenNCC = @ten, DiaChi = @DiaChi, SoDienThoai = @SDT where MaNCC = @ma
end
go


CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) 
AS
BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput 
END
 
 go
 create proc SeachNCC (@Ten nvarchar (1000))
 as
 begin
 SELECT * FROM NhaCungcap WHERE dbo.fuConvertToUnsign1(TenNCC) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' or dbo.fuConvertToUnsign1(DiaChi) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' or dbo.fuConvertToUnsign1(MaNCC) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' or dbo.fuConvertToUnsign1(SoDienThoai) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%'
 end


----sanPham


go
create proc PhanLoaiSP1 (@ten nvarchar (1000))
as
begin 
select MaSP N'Mã Sản Phẩm' , TenSP N'Tên Sản Phẩm'   ,Dongia N'Đơn giá',ThoiGianBH N'Thời gian bảo hành' ,Mota N'Mô tả',TenLoaiSP N'Tên loại sản phẩm' 
from SanPham , LoaiSP 
where TenLoaiSP = @ten and SanPham.MaLSP = LoaiSP.MaLSP 
end



go
create proc PhanLoaiSP10 (@mota nvarchar (1000),@ten nvarchar (1000))
as
begin 
select MaSP N'Mã Sản Phẩm' , TenSP N'Tên Sản Phẩm'   ,Dongia N'Đơn giá',ThoiGianBH N'Thời gian bảo hành' ,Mota N'Mô tả',TenLoaiSP N'Tên loại sản phẩm'
from SanPham ,LoaiSP 
where  SanPham.MaLSP = LoaiSP.MaLSP and ( (MoTa = @mota and TenLoaiSP = @ten ) or (MoTa = @mota or TenLoaiSP = @ten) )
end


go
create proc PhanLoaiSP8 (@mota nvarchar (1000))
as
begin 
select MaSP N'Mã Sản Phẩm' , TenSP N'Tên Sản Phẩm'   ,Dongia N'Đơn giá',ThoiGianBH N'Thời gian bảo hành' ,Mota N'Mô tả',TenLoaiSP N'Tên loại sản phẩm'
from SanPham , LoaiSP 
where  MoTa = @mota and SanPham.MaLSP = LoaiSP.MaLSP 
end

---
go 
create proc SPLUU (@ten nvarchar (100))
as
begin 
select TenSP from SanPham where TenSp = @ten
end

go
create proc Insertsp1 (@ma int , @ten nvarchar (1000) , @dongia float , @thoigianbaohanh int,@mota nvarchar (1000),@maLSP int )
as
begin
 insert into SanPham values (@ma, @ten, @dongia,@thoigianbaohanh,@mota,null,@maLSP)
end


go
create proc SeachSP (@Ten nvarchar (1000))
 as
 begin
 SELECT  MaSP N'Mã Sản Phẩm' , TenSP N'Tên Sản Phẩm'   ,Dongia N'Đơn giá',ThoiGianBH N'Thời gian bảo hành' ,Mota N'Mô tả',TenLoaiSP N'Tên loại sản phẩm'
 FROM SanPham , LoaiSP  
 WHERE SanPham.MaLSP = LoaiSP.MaLSP  and (dbo.fuConvertToUnsign1(TenSp) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' or dbo.fuConvertToUnsign1(MaSP) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' or dbo.fuConvertToUnsign1(MoTa) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' or dbo.fuConvertToUnsign1(TenLoaiSP) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' or dbo.fuConvertToUnsign1(ThoiGianBH) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%')
 end


go
create proc UpdateSP1 (@ma int , @ten nvarchar (1000) , @dongia float , @thoigianbaohanh int,@mota nvarchar (1000) ,@LSP int )
as
begin
 Update SanPham set MaSP =  @ma,TenSp =  @ten, DonGia= @dongia,ThoiGianBH= @thoigianbaohanh,MoTa= @mota,HinhAnh= null,MaLSP = @LSP where MaSP=@ma
end

go

create proc InsertspIMG (@ma int , @ten nvarchar (1000) , @dongia float , @thoigianbaohanh int,@mota nvarchar (1000),@img image,@maLSP int )
as
begin
 insert into SanPham values (@ma, @ten, @dongia,@thoigianbaohanh,@mota,@img,@maLSP)
end

---
go
create proc IMG (@ma int)
as
begin
select HinhAnh from SanPham where MaSP=@ma
end

go
create proc IMG3 (@ma int)
as
begin
select HinhAnh from SanPham where MaSP=@ma
end



go
create proc UpdateSP2 (@ma int , @ten nvarchar (1000) , @dongia float , @thoigianbaohanh int,@mota nvarchar (1000) ,@img image,@LSP int )
as
begin
 Update SanPham set MaSP =  @ma,TenSp =  @ten, DonGia= @dongia,ThoiGianBH= @thoigianbaohanh,MoTa= @mota,HinhAnh= @img,MaLSP = @LSP where MaSP=@ma
end


-----Nhan vien


go
create proc InsertNV1 (@ma int , @ten nvarchar (1000) ,@gioitinh nvarchar (1000) , @ngaysinh date ,@gmail nchar(100),@diachi nvarchar(1000), @ngayvaolam date ,@sodienthoai int,@taikhoan nchar(100),@matkhau nchar(100),@macv int )
as
begin
 insert into NhanVien values (@ma , @ten ,@gioitinh , @ngaysinh ,@gmail ,@diachi, @ngayvaolam ,@sodienthoai ,@taikhoan ,@matkhau ,@macv )
end

go

create proc SeachNV (@Ten nvarchar (1000))
 as
 begin
 SELECT  MaNV N'Mã nhân viên' , TenNV N'Tên nhân viên'   ,GioiTinh N'Giới tính',NgaySinh N'Ngày sinh' ,Gmail,DiaChi N'Địa chỉ',NgayVaoLam N'Ngày vào làm',SoDienThoai N'Số điện thoại',TaiKhoan N'Tài khoản',MatKhau N'Mật khẩu',TenCV N'Tên chức vụ'
 FROM NhanVien ,ChucVu 
 WHERE  NhanVien.MaCV = ChucVu.MaCV and (dbo.fuConvertToUnsign1(TenNV) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' or dbo.fuConvertToUnsign1(SoDienThoai) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' or dbo.fuConvertToUnsign1(TenCV) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' or dbo.fuConvertToUnsign1(TaiKhoan) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%')
 end


 go
 create proc TNV(@maNV int)
 as
 begin 
 select TenNV from NhanVien where MaNV = @maNV
 end 

 go
 create proc GTNV(@maNV int)
 as
 begin 
 select GioiTinh from NhanVien where MaNV = @maNV
 end 

  go
  
  create proc NSNV1(@maNV int)
 as
 begin 
 select NgaySinh from NhanVien where MaNV = @maNV
 end 

  go
   create proc GmailNV(@maNV int)
 as
 begin 
 select Gmail from NhanVien where MaNV = @maNV
 end 


  go 
  create proc DiaChiNV(@maNV int)
 as
 begin 
 select DiaChi from NhanVien where MaNV = @maNV
 end 


  go 
  create proc NVLNV(@maNV int)
 as
 begin 
 select NgayVaoLam from NhanVien where MaNV = @maNV
 end 

  go
   create proc MCV(@maNV int)
 as
 begin 
 select MaCV from NhanVien where MaNV = @maNV
 end 
  
  go
   create proc SĐT(@maNV int)
 as
 begin 
 select SoDienThoai from NhanVien where MaNV = @maNV
 end 
 go

 create proc UpdateNV1 (@ma int , @ten nvarchar (1000) ,@gioitinh nvarchar (1000) , @ngaysinh date ,@gmail nchar(100),@diachi nvarchar(1000), @ngayvaolam date ,@sodienthoai int,@macv int )
as
begin
 Update NhanVien set TenNV= @ten , GioiTinh = @gioitinh ,NgaySinh= @ngaysinh ,Gmail= @gmail ,DiaChi= @diachi,NgayVaoLam= @ngayvaolam ,SoDienThoai= @sodienthoai ,MaCV= @macv where MaNV =  @ma 
end
------HD bán hàng ,Nhập hàng


go
create proc selectKHHD1 (@ma int)
as
begin
 select TenKH
 from KhachHang 
 where MaKH = @ma
end


go
create proc selectKHHD2 (@ma int)
as
begin
 select DiemTichLuy
 from KhachHang 
 where MaKH = @ma
end


go
create proc selectKHHD3 (@ma int)
as
begin
 select TenLKH
 from KhachHang ,LoaiKH  
 where MaKH = @ma and KhachHang.MaLKH = LoaiKH.MaLKH 
end
go


create proc SeachSP1 (@Tenma nvarchar (1000))
 as
 begin
 SELECT  MaSP N'Mã SP', TenSp N'Sản Phẩm'
 FROM SanPham
 WHERE dbo.fuConvertToUnsign1(TenSP) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%' or dbo.fuConvertToUnsign1(MaSP) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%'
 end

 go 
 create proc CH6 (@ma int  )
 as
 begin
	select Distinct TenCauHinh ,SP_CauHinh.MaCauHinh N'MaCauHinh'
	from CTSanPham,SanPham,SP_CauHinh
	Where   SanPham.MaSP = @ma and SanPham.MaSP = CTSanPham.MaSP and CTSanPham.MaCauHinh= SP_CauHinh.MaCauHinh
 end


go
create proc gvgiohang1 (@ma int)
as
begin
	select TenSp N'Tên Sản Phẩm' , TenCauHinh N'Cấu Hình' , TenMau N'Màu Sắc' , SoLuong N'Số lượng' , ThanhTien N'Đơn giá '
	from HDBH_SP , SP_CauHinh,SP_Mau,SanPham
	where HDBH_SP.MaHD=@ma and HDBH_SP.MaCauHinh = SP_CauHinh.MaCauHinh and HDBH_SP.MaMau = SP_Mau.MaMau and HDBH_SP.MaSP = SanPham.MaSP
	
end

go
create proc insertHoDonBH (@mahd int , @ngayxuat date ,@maqr image, @makh int , @manv int )
as
begin
 insert into HoaDonBanHang values (@mahd , @ngayxuat ,null,null,null, @maqr , @makh , @manv)
end


go

create proc insertHDBH_SP1 (@mahd int ,@masp int , @macauhinh int  , @mamau int, @soluong int ,@thanhtien float )
as
begin
 insert into HDBH_SP values (@mahd , @masp  , @macauhinh , @mamau , @soluong ,@thanhtien)
end




 go
 create proc CTSanpham1 (@masp int , @macauhinh int,@mamau int)
 as
 begin
 select SoLuong from CTSanPham where MaSP = @masp and MaCauHinh = @macauhinh and MaMau = @mamau
 end


go
create proc TGBHConLai1 (@mahd int, @masp int, @mach int,@mamau int )
as
insert into TKTGBH values (@mahd, @masp,@mach,@mamau ,'2000-01-01')

go
create proc udtgbh (@mahd int, @masp int, @mach int,@mamau int ,@tg date)
as
update TKTGBH set thoigianconlai = @tg where MaHDBH =  @mahd  and masp = @masp and mach = @mach and mamau = @mamau
go
create proc UpdateHDBHTT (@ma int ,@tongtien float)
as
begin
 Update HoaDonBanHang set TongTien =@tongtien where MaHD =  @ma 
end
go

create proc UpdateSLTCTSP1 (@masp int ,@macauhinh int, @mamau int ,@soluong int)
as
begin
 Update CTSanPham set SoLuong =@soluong where MaSP =  @masp and MaCauHinh = @macauhinh and MaMau = @mamau 
end
go
create proc updateSoLuongTTCTHDX1 (@mahdx int, @masp int, @macauhinh int, @mamau int, @soluong int, @thanhtien float)
as
begin
update HDBH_SP set SoLuong = SoLuong+ @soluong , ThanhTien = ThanhTien + @thanhtien where MaHD = @mahdx and MaSP = @masp and MaCauHinh = @macauhinh and MaMau = @mamau 
end
go
--------
go
create proc updatetien2 (@mahdx int)
as
begin
update HoaDonBanHang set  TongTien = (select SUM(ThanhTien) from HDBH_SP where MaHD = @mahdx) where MaHD = @mahdx
end
go
create proc updatetien3 (@mahdx int)
as
begin
update HDNhapHang set  TongTien = (select SUM(ThanhTien) from HDNH_SP where MaHDN = @mahdx) where MaHDN = @mahdx
end
go
create proc updatesoluong3 (@mahdx int)
as
begin
update HDNhapHang set  SLNhap = (select SUM(SoLuong) from HDNH_SP where MaHDN = @mahdx) where MaHDN = @mahdx
end

-----------
go
create proc selecHDBHSP (@masp int ,@macauhinh int, @mamau int ,@mahd int)
as
begin
		select * from HDBH_SP where MaHD = @mahd and MaSP = @masp and MaCauHinh =@macauhinh and MaMau =@mamau
end
go
create proc s (@maHD int,@masp int ,@macauhinh int, @mamau int ,@mahd int)
as
begin
		select * from HDBH_SP where MaHD = @mahd and MaSP = @masp and MaCauHinh =@macauhinh and MaMau =@mamau
end

go
create proc timma1(@tensanpham nvarchar ,@cauhinh nvarchar , @mausac nvarchar)
as
begin
	select HDBH_SP.MaSP , HDBH_SP.MaCauHinh ,HDBH_SP.MaMau,SoLuong
	from HDBH_SP ,SanPham,SP_CauHinh,SP_Mau 
	where HDBH_SP.MaSP = SanPham.MaSP and HDBH_SP.MaCauHinh = SP_CauHinh.MaCauHinh and HDBH_SP.MaMau = SP_Mau.MaMau and TenSp = @tensanpham and TenCauHinh = @cauhinh and TenMau = @mausac
end

go
create proc deletegiohang (@mahd int , @masp int , @macauhinh int , @mamau int)
as
begin
delete from HDBH_SP where MaHD = @mahd and MaSP = @masp and MaCauHinh = @macauhinh and MaMau = @mamau
end
--select SoLuong from CTSanPham where MaSP =  and MaCauHinh = and MaMau = 

go
create proc  selectcbxmau(@maSP int , @maCH int)
as
begin
		select SP_Mau.TenMau , SP_Mau.MaMau from CTSanPham,SP_Mau where CTSanPham.MaMau = SP_Mau.MaMau and CTSanPham.MaSP = @maSP and CTSanPham.MaCauHinh = @maCH
end 
go
create proc gvgiohangnhap1 (@ma int)
as
begin
	select TenSp N'Tên Sản Phẩm' , TenCauHinh N'Cấu Hình' , TenMau N'Màu Sắc' , SoLuong N'Số lượng' , HDNH_SP.DonGia N'Đơn giá '
	from HDNH_SP , SP_CauHinh,SP_Mau,SanPham
	where HDNH_SP.MaHDN=@ma and HDNH_SP.MaCauHinh = SP_CauHinh.MaCauHinh and HDNH_SP.MaMau = SP_Mau.MaMau and HDNH_SP.MaSP = SanPham.MaSP	
end
go
create proc insertHDN (@ma int, @mancc int, @manv int, @ngaynhap date, @tongtien int,@Soluongnhap int)
as
insert into HDNhapHang values (@ma, @ngaynhap,@Soluongnhap,@tongtien, @mancc, @manv)

go
create proc insertHDN_SP1 (@ma int, @mansp int, @macauhinh int, @mamau int, @soluong int , @dongia float ,@thanhtien float)
as
insert into HDNH_SP values (@ma , @mansp , @macauhinh , @mamau , @soluong  , @dongia ,@thanhtien)
go
create proc updatetongtienHDN (@mahdn int , @tongtien int)
as
update HDNhapHang set TongTien = @tongtien where MaHDN = @mahdn
go
create proc updatetongtienHDNSP (@mahdn int , @tongtien int)
as
update HDNH_SP set DonGia = @tongtien where MaHDN = @mahdn
go
create proc updatesoluongHDN (@mahdn int , @soluong int)
as
update HDNhapHang set SLNhap = @soluong where MaHDN = @mahdn
go
create proc CTSP (@masp int , @macauhinh int, @mamau int)
as
select * from CTSanPham where MaSP = @masp and MaCauHinh = @macauhinh and MaMau = @mamau 
go
create proc insertCTSP1 ( @mansp int, @macauhinh int, @mamau int, @soluong int )
as
insert into CTSanPham values ( @mansp , @macauhinh , @mamau , @soluong )
go


create proc updateSLT (@maSP int, @macauhinh int, @maMau int, @soluong int)
as
update CTSanPham set Soluong = @soluong where MaSP = @maSP and MaCauHinh = @macauhinh and MaMau = @maMau
go

create proc timma3 (@tensanpham nvarchar ,@cauhinh nvarchar , @mausac nvarchar)
as
begin
	select SanPham.MaSP , SP_CauHinh.MaCauHinh ,SP_Mau.MaMau
	from HDNH_SP ,SanPham,SP_CauHinh,SP_Mau 
	where HDNH_SP.MaSP = SanPham.MaSP and HDNH_SP.MaCauHinh = SP_CauHinh.MaCauHinh and HDNH_SP.MaMau = SP_Mau.MaMau and TenSp = @tensanpham and TenCauHinh = @cauhinh and TenMau = @mausac
end


update CTSanPham set SoLuong = SoLuong + @soluong where MaSP = @ten and MaCauHinh = @cauhinh and MaMau = @tenmau
go
create proc deletegiohangnhap1 ( @mahd int , @masp int , @macauhinh int , @mamau int)
as
begin
delete from HDNH_SP where MaHDN =@mahd and MaSP = @masp and MaCauHinh = @macauhinh and MaMau = @mamau
end
go
create proc deletegiohangban (@mahd int , @masp int , @macauhinh int , @mamau int)
as
begin
delete from HDBH_SP where MaHD = @mahd and MaSP = @masp and MaCauHinh = @macauhinh and MaMau = @mamau
end




---QLHDN
create proc QLHDM
as
select MaHDN N'Mã Hóa Đơn', NgayNhap N'Ngày Nhập',SLNhap N'Số lượng Nhập',TongTien N'Tổng Tiền',NhaCungcap.TenNCC N'Tên Nhà Cung Cấp',NhanVien.TenNV N'Tên Nhân Viên'
from HDNhapHang , NhaCungcap,NhanVien
where HDNhapHang.MaNCC = NhaCungcap.MaNCC and HDNhapHang.MaNV = NhanVien.MaNV
go
create proc SeachHDN1 (@Tenma nvarchar (1000))
 as
 begin
 SELECT MaHDN N'Mã Hóa Đơn', NgayNhap N'Ngày Nhập',SLNhap N'Số lượng Nhập',TongTien N'Tổng Tiền',NhaCungcap.TenNCC N'Tên Nhà Cung Cấp',NhanVien.TenNV N'Tên Nhân Viên'
 FROM HDNhapHang , NhaCungcap,NhanVien
 WHERE HDNhapHang.MaNCC = NhaCungcap.MaNCC and HDNhapHang.MaNV = NhanVien.MaNV and 
 (dbo.fuConvertToUnsign1(MaHDN) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%' or dbo.fuConvertToUnsign1(NhaCungcap.TenNCC) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%'
 or dbo.fuConvertToUnsign1(NhanVien.TenNV) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%')
 end






create proc CTHDN (@ma int)
as
select MaHDN N'Mã Hóa Đơn' ,SanPham.TenSp N'Tên Sản Phẩm',TenCauHinh N'Tên Cấu Hình' , TenMau N'Tên Màu',HDNH_SP.SoLuong N'Số Lượng',HDNH_SP.DonGia N'Đơn Giá',HDNH_SP.ThanhTien N'Thành Tiền'
From HDNH_SP,SP_CauHinh,SP_Mau,SanPham
where MaHDN = @ma and( HDNH_SP.MaSP = SanPham.MaSP and HDNH_SP.MaCauHinh = SP_CauHinh.MaCauHinh and HDNH_SP.MaMau=SP_Mau.MaMau)
 ---------main

 go
 create proc Userlogin1 (@taikhoan nvarchar (1000),@matkhau nvarchar(1000))
 as
 begin
	select MaCV from NhanVien where TaiKhoan = @taikhoan and MatKhau = @matkhau
 end



 go
 create proc namelogin1 (@taikhoan nvarchar (1000),@matkhau nvarchar(1000))
 as
 begin
	select TenNV from NhanVien where TaiKhoan = @taikhoan and MatKhau = @matkhau
 end

 go


 create proc soluongton
as
begin
	select TenSp N'Tên Sản Phẩm' , TenCauHinh N'Cấu Hình' , TenMau N'Màu Sắc' 
	from  CTSanPham,SanPham,SP_CauHinh,SP_Mau
	where CTSanPham.SoLuong = 0 and CTSanPham.MaSP = SanPham.MaSP and CTSanPham.MaCauHinh = SP_CauHinh.MaCauHinh and CTSanPham.MaMau = SP_Mau.MaMau 
end	 

 -----Thống kê khách hàng 

 create proc TKKH
as
begin
select HoaDonBanHang.MaHD N'Mã Hóa Đơn ', KhachHang.TenKH  N'Tên Khách Hàng',  SanPham.TenSp  N'Tên Sản Phẩm' , SP_Mau.TenMau N'Tên Màu', SP_CauHinh.TenCauHinh N'Tên Cấu Hình ',HDBH_SP.SoLuong N'Số lượng'
from HoaDonBanHang , HDBH_SP , KhachHang , SanPham , SP_Mau , SP_CauHinh
where HoaDonBanHang.MaHD = HDBH_SP.MaHD and HoaDonBanHang.MaKH = KhachHang.MaKH  and HDBH_SP.MaSP= SanPham.MaSP
and HDBH_SP.MaCauHinh = SP_CauHinh.MaCauHinh and HDBH_SP.MaMau = SP_Mau.MaMau and HoaDonBanHang.TrangThai = 'True'
end
go

create proc TKKHmuagi 
as
select HDX.Ma, KH.Ten as N'TKH',  SP.Ten as N'SP' , MS.TenMau, SZ.TenSize, CTHDX.SoLuong
from HDXuat HDX, CTHDXuat CTHDX, KhachHang KH, SanPham SP, MauSac MS, Size SZ
where HDX.Ma = CTHDX.Ma_HDX and HDX.Ma_KH = KH.Ma  and CTHDX.Ma_SP = SP.Ma and CTHDX.Ma_Size = SZ.Ma and CTHDX.Ma_MauSac = MS.Ma and HDX.TrangThai = 'True'
go
go
create proc demsokh (@ma int)
as
begin 
	Select MaKH from KhachHang ,LoaiKH where KhachHang.MaLKH = LoaiKH.MaLKH and LoaiKH.MaLKH = @ma
end
go
---Thống kê số hàng tồn
create proc thongkehangton2 (@maloai int)
as
begin
select SanPham.MaSP N'Mã Sản Phẩm', SanPham.TenSp N'Tên Sản Phẩm',LoaiSP.TenLoaiSP as N'Loại Sản Phẩm' , SP_Mau.TenMau N'Màu Sắc',SP_CauHinh.TenCauHinh N'Cấu Hình', CTSanPham.SoLuong N'Số lượng' 
from CTSanPham , SanPham ,SP_Mau,SP_CauHinh, LoaiSP 
where  SanPham.MaLSP = LoaiSP.MaLSP and CTSanPham.MaSP = SanPham.MaSP and CTSanPham.MaMau = SP_Mau.MaMau and CTSanPham.MaCauHinh = SP_CauHinh.MaCauHinh and LoaiSP.MaLSP = @maloai 
order by  SanPham.TenSp asc 
end
go

----thống kê thu chi
--Năm bán hàng
create proc NamBanHang
as
select DATEPART(YY, NgayXuat) as N'Nam' from HoaDonBanHang 
group  by  DATEPART(YY, NgayXuat)
go
--Năm nhập hàng
create proc NamNhapHang 
as
select DATEPART(YY, NgayNhap) as N'Nam' from HDNhapHang
group  by  DATEPART(YY, NgayNhap)
go
--Doanh Thu năm 
create proc DoanhThuNamHienTai 
as
select Sum (TongTien) as N'TongTien' from HoaDonBanHang where DATEPART(YY, NgayXuat) = DATEPART(YY, getdate())
go





----hóa đơn bán hàng
create proc selectHDBH_SP1 (@ma int)
as
select * from HDBH_SP where MaHD = @ma
go



--SoluongHD đã bán trong năm
create proc SoLuongHDXDaBan
as
select Count (MaHD ) as 'SoLuong' From HoaDonBanHang where DATEPART(YY, NgayXuat) = DATEPART(YY, getdate()) and TrangThai = 'True'
go


---số tiền nhập theo tháng của năm
create proc TienNhapTheoThangCuaNam (@nam int)
as
begin
declare @sothang int =0;
declare @tongtien int =0;
Delete from TempChi
 create table TempChi ( Thang nvarchar (50), TongTien  int)
	while @sothang <=11
	begin
		set @tongtien = 0
		set @sothang = @sothang +1;
		 select @tongtien =  Sum(TongTien)  From HDNhapHang
						where DATEPART (YY, NgayNhap) = @nam AND DATEPART(MM, NgayNhap) = @sothang
		 if (@tongtien is null)
		 begin
			set @tongtien = 0;
		 end
		insert into TempChi values (N'Tháng ' + cast( @sothang as nvarchar), @tongtien)
	end
	select * from TempChi 
end
go
create proc TienBanTheoThangCuaNam (@nam int)
as
begin
declare @sothang int =0;
declare @tongtien int =0;
--Delete from TempThu
 create table TempThu ( Thang nvarchar (50), TongTien  int)
	while @sothang <=11
	begin
		set @tongtien = 0
		set @sothang = @sothang +1;
		 select @tongtien =  Sum(TongTien)  From HoaDonBanHang
						where DATEPART (YY, NgayXuat) = @nam AND DATEPART(MM, NgayXuat) = @sothang and TrangThai = 'True'
		 if (@tongtien is null)
		 begin
			set @tongtien = 0;
		 end
		insert into TempThu values (N'Tháng ' + cast( @sothang as nvarchar), @tongtien)
	end
	select * from TempThu 
end
go
execute TienBanTheoThangCuaNam 2021
--Danh sach HDN trong nam
create proc DanhSachHDNTrongNam  (@nam int)
as
select HDNhapHang.MaHDN N'Mã Hóa Đơn ',  HDNhapHang.NgayNhap N'Ngày Nhập',HDNhapHang.SLNhap N'Số Lượng Nhập', HDNhapHang.TongTien N'Tổng Tiền', NhaCungcap.TenNCC N'Tên Nhà Cung Cấp' ,NhanVien.TenNV N'Tên Nhân Viên'
from HDNhapHang , NhanVien , NhaCungCap 
where DATEPART (YY, NgayNhap) = @nam and HDNhapHang.MaNCC = NhaCungcap.MaNCC and HDNhapHang.MaNV = NhanVien.MaNV;
go

--Danh Sách HDX trong nam
create proc DanhSachHDXtTrongNam (@nam int)
as
select HoaDonBanHang.MaHD N'Mã Hóa Đơn' , HoaDonBanHang.NgayXuat N'ngày Xuất', HoaDonBanHang.TongTien N'Tổng Tiền', HoaDonBanHang.GhiChu N'Ghi Chú', KhachHang.TenKH N'Tên Khách Hàng', NhanVien.TenNV N'Tên Nhân Viên'
from HoaDonBanHang , KhachHang , NhanVien 
where DATEPART (YY, NgayXuat ) = @nam and HoaDonBanHang.MaKH = KhachHang.MaKH and HoaDonBanHang.MaNV = NhanVien.MaNV and TrangThai = 'True'
go
 
 go--
 create proc QLHDB1
as
select MaHD N'Mã Hóa Đơn', NgayXuat N'Ngày Xuất',TongTien N'Tổng Tiền',GhiChu N'Ghi Chú', TrangThai N'Đã Thanh Toán',TenKH N'Tên Khách Hàng',TenNV N'Tên Nhân Viên'
from HoaDonBanHang , KhachHang , NhanVien
where HoaDonBanHang.MaKH = KhachHang.MaKH and HoaDonBanHang.MaNV = NhanVien.MaNV
go
create proc SeachHDB (@Tenma nvarchar (1000))
 as
 begin
 SELECT MaHD N'Mã Hóa Đơn', NgayXuat N'Ngày Xuất',TongTien N'Tổng Tiền',GhiChu N'Ghi Chú', TrangThai N'Trạng thái',TenKH N'Tên Khách Hàng',TenNV N'Tên Nhân Viên'
 FROM HoaDonBanHang , KhachHang , NhanVien
 WHERE HoaDonBanHang.MaKH = KhachHang.MaKH and HoaDonBanHang.MaNV = NhanVien.MaNV and 
 (dbo.fuConvertToUnsign1(MaHD) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%' or dbo.fuConvertToUnsign1(TrangThai) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%'
 or dbo.fuConvertToUnsign1(KhachHang.TenKH) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%'or dbo.fuConvertToUnsign1(NhanVien.TenNV) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%'
 or dbo.fuConvertToUnsign1(TongTien) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%' or dbo.fuConvertToUnsign1(NgayXuat) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%')
 end
go
----


create proc areporthdx (@mahd int)
as begin
select * from dbo.HoaDonBanHang, dbo.KhachHang, dbo.NhanVien
where HoaDonBanHang.MaKH = KhachHang.MaKH and HoaDonBanHang.MaNV = NhanVien.MaNV and MaHD = @mahd
end

go

create proc gvgiohang5 (@ma int)
as
begin
	select TenSp  , TenCauHinh  , TenMau , SoLuong , ThanhTien 
	from HDBH_SP , SP_CauHinh,SP_Mau,SanPham
	where HDBH_SP.MaHD=@ma and HDBH_SP.MaCauHinh = SP_CauHinh.MaCauHinh and HDBH_SP.MaMau = SP_Mau.MaMau and HDBH_SP.MaSP = SanPham.MaSP
end
go
create proc gvgiohang6 (@ma int)
as
begin
	select *
	from HDBH_SP , SP_CauHinh,SP_Mau,SanPham,KhachHang,NhanVien,LoaiKH,HoaDonBanHang
	where HoaDonBanHang.MaHD=@ma and HoaDonBanHang.MaNV = NhanVien.MaNV and HoaDonBanHang.MaKH = KhachHang.MaKH and KhachHang.MaLKH = LoaiKH.MaLKH
	and HDBH_SP.MaHD =HoaDonBanHang.MaHD and HDBH_SP.MaSP = SanPham.MaSP
	and HDBH_SP.MaCauHinh = SP_CauHinh.MaCauHinh and HDBH_SP.MaMau = SP_Mau.MaMau 
end


go

create proc BangBH
as
begin
select * from HoaDonBanHang , HDBH_SP,SanPham where HoaDonBanHang.MaHD = HDBH_SP.MaHD and HDBH_SP.MaSP = SanPham.MaSP
end

go

---Thống kê thời gian bảo hành

create proc TKTGBHGV
as
select MaHDBH N'Mã Hóa Đơn' , TenSp N'Tên Sản Phẩm', TenCauHinh N'Tên Cấu Hình' , TenMau N'Tên Màu' , thoigianconlai N'Thời Hạn Bảo Hành'
from TKTGBH,SanPham , SP_CauHinh,SP_Mau
where TKTGBH.masp = SanPham.MaSP and TKTGBH.mach = SP_CauHinh.MaCauHinh and TKTGBH.mamau = SP_Mau.MaMau


create proc SeachBH (@Ten nvarchar (1000))
 as
 begin
	select MaHDBH N'Mã Hóa Đơn' , TenSp N'Tên Sản Phẩm', TenCauHinh N'Tên Cấu Hình' , TenMau N'Tên Màu' , thoigianconlai N'Thời Hạn Bảo Hành'
	from TKTGBH,SanPham , SP_CauHinh,SP_Mau
 WHERE TKTGBH.masp = SanPham.MaSP and TKTGBH.mach = SP_CauHinh.MaCauHinh and TKTGBH.mamau = SP_Mau.MaMau and (dbo.fuConvertToUnsign1(MaHDBH) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' or dbo.fuConvertToUnsign1(TenSp) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' or dbo.fuConvertToUnsign1(TenCauHinh) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' 
 or dbo.fuConvertToUnsign1(TenMau) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%'or dbo.fuConvertToUnsign1(thoigianconlai) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%')
 end
 ----khach hang
 select * from KhachHang
 go
create proc gvkh (@makh int)
as
select HDBH_SP.MaHD N'Mã Hóa Đơn' , HoaDonBanHang.NgayXuat N'Ngày Mua' ,TenSp N'Tên Sản Phẩm' , TenMau N'Tên Màu' , TenCauHinh N'Tên Cấu Hình' , SoLuong N'Số Lượng',HDBH_SP.ThanhTien N'Đơn Giá' from HoaDonBanHang,HDBH_SP ,KhachHang ,SanPham,SP_CauHinh,SP_Mau where KhachHang.MaKH = @makh and HoaDonBanHang.MaKH = KhachHang.MaKH 
and HoaDonBanHang.MaHD = HDBH_SP.MaHD and HDBH_SP.MaSP = SanPham.MaSP and HDBH_SP.MaCauHinh = SP_CauHinh.MaCauHinh and HDBH_SP.MaMau = SP_Mau.MaMau
