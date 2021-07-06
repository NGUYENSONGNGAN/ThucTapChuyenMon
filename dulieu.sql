USE [master]
GO
/****** Object:  Database [DOANCHUYENMON7]    Script Date: 3/7/2021 1:31:15 AM ******/
CREATE DATABASE [DOANCHUYENMON7]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DOANCHUYENMON7', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DOANCHUYENMON7.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DOANCHUYENMON7_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DOANCHUYENMON7_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DOANCHUYENMON7] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DOANCHUYENMON7].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DOANCHUYENMON7] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DOANCHUYENMON7] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DOANCHUYENMON7] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DOANCHUYENMON7] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DOANCHUYENMON7] SET ARITHABORT OFF 
GO
ALTER DATABASE [DOANCHUYENMON7] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DOANCHUYENMON7] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DOANCHUYENMON7] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DOANCHUYENMON7] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DOANCHUYENMON7] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DOANCHUYENMON7] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DOANCHUYENMON7] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DOANCHUYENMON7] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DOANCHUYENMON7] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DOANCHUYENMON7] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DOANCHUYENMON7] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DOANCHUYENMON7] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DOANCHUYENMON7] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DOANCHUYENMON7] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DOANCHUYENMON7] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DOANCHUYENMON7] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DOANCHUYENMON7] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DOANCHUYENMON7] SET RECOVERY FULL 
GO
ALTER DATABASE [DOANCHUYENMON7] SET  MULTI_USER 
GO
ALTER DATABASE [DOANCHUYENMON7] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DOANCHUYENMON7] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DOANCHUYENMON7] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DOANCHUYENMON7] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DOANCHUYENMON7] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DOANCHUYENMON7] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DOANCHUYENMON7] SET QUERY_STORE = OFF
GO
USE [DOANCHUYENMON7]
GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) 
AS
BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput 
END
 
GO
/****** Object:  Table [dbo].[ad]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ad](
	[Ma] [int] IDENTITY(1,1) NOT NULL,
	[TaiKhoan] [nchar](1000) NULL,
	[MatKhau] [nchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaCV] [int] NOT NULL,
	[TenCV] [nvarchar](100) NOT NULL,
	[MucLuong] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTSanPham]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTSanPham](
	[MaSP] [int] NOT NULL,
	[MaMau] [int] NOT NULL,
	[MaCauHinh] [int] NOT NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC,
	[MaMau] ASC,
	[MaCauHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Email]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Email](
	[Ma] [int] NOT NULL,
	[TaiKhoan] [nvarchar](1000) NULL,
	[MatKhau] [nvarchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HDBH_SP]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HDBH_SP](
	[MaHD] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[MaCauHinh] [int] NOT NULL,
	[MaMau] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC,
	[MaCauHinh] ASC,
	[MaMau] ASC,
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HDNH_SP]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HDNH_SP](
	[MaHDN] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[MaCauHinh] [int] NOT NULL,
	[MaMau] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[ThanhTien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC,
	[MaCauHinh] ASC,
	[MaMau] ASC,
	[MaHDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HDNhapHang]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HDNhapHang](
	[MaHDN] [int] NOT NULL,
	[NgayNhap] [date] NULL,
	[SLNhap] [int] NULL,
	[TongTien] [float] NULL,
	[MaNCC] [int] NULL,
	[MaNV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonBanHang]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonBanHang](
	[MaHD] [int] NOT NULL,
	[NgayXuat] [date] NULL,
	[TongTien] [float] NULL,
	[GhiChu] [nvarchar](1000) NULL,
	[TrangThai] [bit] NULL,
	[MaQR] [image] NULL,
	[MaKH] [int] NULL,
	[MaNV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] NOT NULL,
	[TenKH] [nvarchar](100) NOT NULL,
	[DiemTichLuy] [int] NULL,
	[DiaChi] [nvarchar](1000) NULL,
	[SoDienThoai] [int] NULL,
	[Gmail] [nchar](100) NULL,
	[MaLKH] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiKH]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiKH](
	[MaLKH] [int] NOT NULL,
	[TenLKH] [nvarchar](100) NOT NULL,
	[PhanTramChietKhau] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSP]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSP](
	[MaLSP] [int] NOT NULL,
	[TenLoaiSP] [nvarchar](1000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungcap]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungcap](
	[MaNCC] [int] NOT NULL,
	[TenNCC] [nvarchar](1000) NOT NULL,
	[DiaChi] [nvarchar](1000) NOT NULL,
	[SoDienThoai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] NOT NULL,
	[TenNV] [nvarchar](1000) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[NgaySinh] [date] NULL,
	[Gmail] [nchar](1000) NULL,
	[DiaChi] [nvarchar](1000) NULL,
	[NgayVaoLam] [date] NULL,
	[SoDienThoai] [int] NULL,
	[TaiKhoan] [nchar](100) NULL,
	[MatKhau] [nchar](100) NULL,
	[MaCV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [int] NOT NULL,
	[TenSp] [nvarchar](1000) NOT NULL,
	[DonGia] [float] NULL,
	[ThoiGianBH] [int] NULL,
	[MoTa] [nvarchar](1000) NOT NULL,
	[HinhAnh] [image] NULL,
	[MaLSP] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SP_CauHinh]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SP_CauHinh](
	[MaLSP] [int] NULL,
	[MaCauHinh] [int] NOT NULL,
	[TenCauHinh] [nvarchar](1000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCauHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SP_Mau]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SP_Mau](
	[MaMau] [int] NOT NULL,
	[TenMau] [nvarchar](1000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TGBHconlai]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TGBHconlai](
	[MaHDBH] [int] NOT NULL,
	[masp] [int] NOT NULL,
	[mach] [int] NULL,
	[mamau] [int] NOT NULL,
	[thoigianconlai] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHDBH] ASC,
	[masp] ASC,
	[mamau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TKTGBH]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TKTGBH](
	[MaHDBH] [int] NOT NULL,
	[masp] [int] NOT NULL,
	[mach] [int] NOT NULL,
	[mamau] [int] NOT NULL,
	[thoigianconlai] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHDBH] ASC,
	[masp] ASC,
	[mamau] ASC,
	[mach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CTSanPham]  WITH CHECK ADD FOREIGN KEY([MaCauHinh])
REFERENCES [dbo].[SP_CauHinh] ([MaCauHinh])
GO
ALTER TABLE [dbo].[CTSanPham]  WITH CHECK ADD FOREIGN KEY([MaCauHinh])
REFERENCES [dbo].[SP_CauHinh] ([MaCauHinh])
GO
ALTER TABLE [dbo].[CTSanPham]  WITH CHECK ADD FOREIGN KEY([MaCauHinh])
REFERENCES [dbo].[SP_CauHinh] ([MaCauHinh])
GO
ALTER TABLE [dbo].[CTSanPham]  WITH CHECK ADD FOREIGN KEY([MaCauHinh])
REFERENCES [dbo].[SP_CauHinh] ([MaCauHinh])
GO
ALTER TABLE [dbo].[CTSanPham]  WITH CHECK ADD FOREIGN KEY([MaCauHinh])
REFERENCES [dbo].[SP_CauHinh] ([MaCauHinh])
GO
ALTER TABLE [dbo].[CTSanPham]  WITH CHECK ADD FOREIGN KEY([MaMau])
REFERENCES [dbo].[SP_Mau] ([MaMau])
GO
ALTER TABLE [dbo].[CTSanPham]  WITH CHECK ADD FOREIGN KEY([MaMau])
REFERENCES [dbo].[SP_Mau] ([MaMau])
GO
ALTER TABLE [dbo].[CTSanPham]  WITH CHECK ADD FOREIGN KEY([MaMau])
REFERENCES [dbo].[SP_Mau] ([MaMau])
GO
ALTER TABLE [dbo].[CTSanPham]  WITH CHECK ADD FOREIGN KEY([MaMau])
REFERENCES [dbo].[SP_Mau] ([MaMau])
GO
ALTER TABLE [dbo].[CTSanPham]  WITH CHECK ADD FOREIGN KEY([MaMau])
REFERENCES [dbo].[SP_Mau] ([MaMau])
GO
ALTER TABLE [dbo].[CTSanPham]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTSanPham]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTSanPham]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTSanPham]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTSanPham]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[HDBH_SP]  WITH CHECK ADD FOREIGN KEY([MaCauHinh])
REFERENCES [dbo].[SP_CauHinh] ([MaCauHinh])
GO
ALTER TABLE [dbo].[HDBH_SP]  WITH CHECK ADD FOREIGN KEY([MaCauHinh])
REFERENCES [dbo].[SP_CauHinh] ([MaCauHinh])
GO
ALTER TABLE [dbo].[HDBH_SP]  WITH CHECK ADD FOREIGN KEY([MaCauHinh])
REFERENCES [dbo].[SP_CauHinh] ([MaCauHinh])
GO
ALTER TABLE [dbo].[HDBH_SP]  WITH CHECK ADD FOREIGN KEY([MaCauHinh])
REFERENCES [dbo].[SP_CauHinh] ([MaCauHinh])
GO
ALTER TABLE [dbo].[HDBH_SP]  WITH CHECK ADD FOREIGN KEY([MaCauHinh])
REFERENCES [dbo].[SP_CauHinh] ([MaCauHinh])
GO
ALTER TABLE [dbo].[HDBH_SP]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDonBanHang] ([MaHD])
GO
ALTER TABLE [dbo].[HDBH_SP]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDonBanHang] ([MaHD])
GO
ALTER TABLE [dbo].[HDBH_SP]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDonBanHang] ([MaHD])
GO
ALTER TABLE [dbo].[HDBH_SP]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDonBanHang] ([MaHD])
GO
ALTER TABLE [dbo].[HDBH_SP]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDonBanHang] ([MaHD])
GO
ALTER TABLE [dbo].[HDBH_SP]  WITH CHECK ADD FOREIGN KEY([MaMau])
REFERENCES [dbo].[SP_Mau] ([MaMau])
GO
ALTER TABLE [dbo].[HDBH_SP]  WITH CHECK ADD FOREIGN KEY([MaMau])
REFERENCES [dbo].[SP_Mau] ([MaMau])
GO
ALTER TABLE [dbo].[HDBH_SP]  WITH CHECK ADD FOREIGN KEY([MaMau])
REFERENCES [dbo].[SP_Mau] ([MaMau])
GO
ALTER TABLE [dbo].[HDBH_SP]  WITH CHECK ADD FOREIGN KEY([MaMau])
REFERENCES [dbo].[SP_Mau] ([MaMau])
GO
ALTER TABLE [dbo].[HDBH_SP]  WITH CHECK ADD FOREIGN KEY([MaMau])
REFERENCES [dbo].[SP_Mau] ([MaMau])
GO
ALTER TABLE [dbo].[HDBH_SP]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[HDBH_SP]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[HDBH_SP]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[HDBH_SP]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[HDBH_SP]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[HDNH_SP]  WITH CHECK ADD FOREIGN KEY([MaCauHinh])
REFERENCES [dbo].[SP_CauHinh] ([MaCauHinh])
GO
ALTER TABLE [dbo].[HDNH_SP]  WITH CHECK ADD FOREIGN KEY([MaCauHinh])
REFERENCES [dbo].[SP_CauHinh] ([MaCauHinh])
GO
ALTER TABLE [dbo].[HDNH_SP]  WITH CHECK ADD FOREIGN KEY([MaCauHinh])
REFERENCES [dbo].[SP_CauHinh] ([MaCauHinh])
GO
ALTER TABLE [dbo].[HDNH_SP]  WITH CHECK ADD FOREIGN KEY([MaCauHinh])
REFERENCES [dbo].[SP_CauHinh] ([MaCauHinh])
GO
ALTER TABLE [dbo].[HDNH_SP]  WITH CHECK ADD FOREIGN KEY([MaCauHinh])
REFERENCES [dbo].[SP_CauHinh] ([MaCauHinh])
GO
ALTER TABLE [dbo].[HDNH_SP]  WITH CHECK ADD FOREIGN KEY([MaHDN])
REFERENCES [dbo].[HDNhapHang] ([MaHDN])
GO
ALTER TABLE [dbo].[HDNH_SP]  WITH CHECK ADD FOREIGN KEY([MaHDN])
REFERENCES [dbo].[HDNhapHang] ([MaHDN])
GO
ALTER TABLE [dbo].[HDNH_SP]  WITH CHECK ADD FOREIGN KEY([MaHDN])
REFERENCES [dbo].[HDNhapHang] ([MaHDN])
GO
ALTER TABLE [dbo].[HDNH_SP]  WITH CHECK ADD FOREIGN KEY([MaHDN])
REFERENCES [dbo].[HDNhapHang] ([MaHDN])
GO
ALTER TABLE [dbo].[HDNH_SP]  WITH CHECK ADD FOREIGN KEY([MaHDN])
REFERENCES [dbo].[HDNhapHang] ([MaHDN])
GO
ALTER TABLE [dbo].[HDNH_SP]  WITH CHECK ADD FOREIGN KEY([MaMau])
REFERENCES [dbo].[SP_Mau] ([MaMau])
GO
ALTER TABLE [dbo].[HDNH_SP]  WITH CHECK ADD FOREIGN KEY([MaMau])
REFERENCES [dbo].[SP_Mau] ([MaMau])
GO
ALTER TABLE [dbo].[HDNH_SP]  WITH CHECK ADD FOREIGN KEY([MaMau])
REFERENCES [dbo].[SP_Mau] ([MaMau])
GO
ALTER TABLE [dbo].[HDNH_SP]  WITH CHECK ADD FOREIGN KEY([MaMau])
REFERENCES [dbo].[SP_Mau] ([MaMau])
GO
ALTER TABLE [dbo].[HDNH_SP]  WITH CHECK ADD FOREIGN KEY([MaMau])
REFERENCES [dbo].[SP_Mau] ([MaMau])
GO
ALTER TABLE [dbo].[HDNH_SP]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[HDNH_SP]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[HDNH_SP]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[HDNH_SP]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[HDNH_SP]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[HDNhapHang]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungcap] ([MaNCC])
GO
ALTER TABLE [dbo].[HDNhapHang]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungcap] ([MaNCC])
GO
ALTER TABLE [dbo].[HDNhapHang]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungcap] ([MaNCC])
GO
ALTER TABLE [dbo].[HDNhapHang]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungcap] ([MaNCC])
GO
ALTER TABLE [dbo].[HDNhapHang]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungcap] ([MaNCC])
GO
ALTER TABLE [dbo].[HDNhapHang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HDNhapHang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HDNhapHang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HDNhapHang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HDNhapHang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD FOREIGN KEY([MaLKH])
REFERENCES [dbo].[LoaiKH] ([MaLKH])
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD FOREIGN KEY([MaLKH])
REFERENCES [dbo].[LoaiKH] ([MaLKH])
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD FOREIGN KEY([MaLKH])
REFERENCES [dbo].[LoaiKH] ([MaLKH])
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD FOREIGN KEY([MaLKH])
REFERENCES [dbo].[LoaiKH] ([MaLKH])
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD FOREIGN KEY([MaLKH])
REFERENCES [dbo].[LoaiKH] ([MaLKH])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaLSP])
REFERENCES [dbo].[LoaiSP] ([MaLSP])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaLSP])
REFERENCES [dbo].[LoaiSP] ([MaLSP])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaLSP])
REFERENCES [dbo].[LoaiSP] ([MaLSP])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaLSP])
REFERENCES [dbo].[LoaiSP] ([MaLSP])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaLSP])
REFERENCES [dbo].[LoaiSP] ([MaLSP])
GO
ALTER TABLE [dbo].[SP_CauHinh]  WITH CHECK ADD FOREIGN KEY([MaLSP])
REFERENCES [dbo].[LoaiSP] ([MaLSP])
GO
ALTER TABLE [dbo].[SP_CauHinh]  WITH CHECK ADD FOREIGN KEY([MaLSP])
REFERENCES [dbo].[LoaiSP] ([MaLSP])
GO
ALTER TABLE [dbo].[SP_CauHinh]  WITH CHECK ADD FOREIGN KEY([MaLSP])
REFERENCES [dbo].[LoaiSP] ([MaLSP])
GO
ALTER TABLE [dbo].[SP_CauHinh]  WITH CHECK ADD FOREIGN KEY([MaLSP])
REFERENCES [dbo].[LoaiSP] ([MaLSP])
GO
ALTER TABLE [dbo].[SP_CauHinh]  WITH CHECK ADD FOREIGN KEY([MaLSP])
REFERENCES [dbo].[LoaiSP] ([MaLSP])
GO
ALTER TABLE [dbo].[TKTGBH]  WITH CHECK ADD FOREIGN KEY([mach])
REFERENCES [dbo].[SP_CauHinh] ([MaCauHinh])
GO
ALTER TABLE [dbo].[TKTGBH]  WITH CHECK ADD FOREIGN KEY([mach])
REFERENCES [dbo].[SP_CauHinh] ([MaCauHinh])
GO
ALTER TABLE [dbo].[TKTGBH]  WITH CHECK ADD FOREIGN KEY([MaHDBH])
REFERENCES [dbo].[HoaDonBanHang] ([MaHD])
GO
ALTER TABLE [dbo].[TKTGBH]  WITH CHECK ADD FOREIGN KEY([MaHDBH])
REFERENCES [dbo].[HoaDonBanHang] ([MaHD])
GO
ALTER TABLE [dbo].[TKTGBH]  WITH CHECK ADD FOREIGN KEY([mamau])
REFERENCES [dbo].[SP_Mau] ([MaMau])
GO
ALTER TABLE [dbo].[TKTGBH]  WITH CHECK ADD FOREIGN KEY([mamau])
REFERENCES [dbo].[SP_Mau] ([MaMau])
GO
ALTER TABLE [dbo].[TKTGBH]  WITH CHECK ADD FOREIGN KEY([masp])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[TKTGBH]  WITH CHECK ADD FOREIGN KEY([masp])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
/****** Object:  StoredProcedure [dbo].[areporthdx]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[areporthdx] (@mahd int)
as begin
select * from dbo.HoaDonBanHang, dbo.KhachHang, dbo.NhanVien
where HoaDonBanHang.MaKH = KhachHang.MaKH and HoaDonBanHang.MaNV = NhanVien.MaNV and MaHD = @mahd
end
GO
/****** Object:  StoredProcedure [dbo].[BangBH]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BangBH]
as
begin
select * from HoaDonBanHang , HDBH_SP,SanPham where HoaDonBanHang.MaHD = HDBH_SP.MaHD and HDBH_SP.MaSP = SanPham.MaSP
end
GO
/****** Object:  StoredProcedure [dbo].[CH6]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[CH6] (@ma int  )
 as
 begin
	select Distinct TenCauHinh ,SP_CauHinh.MaCauHinh N'MaCauHinh'
	from CTSanPham,SanPham,SP_CauHinh
	Where   SanPham.MaSP = @ma and SanPham.MaSP = CTSanPham.MaSP and CTSanPham.MaCauHinh= SP_CauHinh.MaCauHinh
 end


GO
/****** Object:  StoredProcedure [dbo].[CTHDN]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[CTHDN] (@ma int)
as
select MaHDN N'Mã Hóa Đơn' ,SanPham.TenSp N'Tên Sản Phẩm',TenCauHinh N'Tên Cấu Hình' , TenMau N'Tên Màu',HDNH_SP.SoLuong N'Số Lượng',HDNH_SP.DonGia N'Đơn Giá',HDNH_SP.ThanhTien N'Thành Tiền'
From HDNH_SP,SP_CauHinh,SP_Mau,SanPham
where MaHDN = @ma and HDNH_SP.MaSP = SanPham.MaSP and HDNH_SP.MaCauHinh = SP_CauHinh.MaCauHinh and HDNH_SP.MaMau=SP_Mau.MaMau
GO
/****** Object:  StoredProcedure [dbo].[CTSanpham1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[CTSanpham1] (@masp int , @macauhinh int,@mamau int)
 as
 begin
 select SoLuong from CTSanPham where MaSP = @masp and MaCauHinh = @macauhinh and MaMau = @mamau
 end


GO
/****** Object:  StoredProcedure [dbo].[CTSP]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CTSP] (@masp int , @macauhinh int, @mamau int)
as
select * from CTSanPham where MaSP = @masp and MaCauHinh = @macauhinh and MaMau = @mamau 
GO
/****** Object:  StoredProcedure [dbo].[DanhSachHDNTrongNam]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DanhSachHDNTrongNam]  (@nam int)
as
select HDNhapHang.MaHDN N'Mã Hóa Đơn ',  HDNhapHang.NgayNhap N'Ngày Nhập',HDNhapHang.SLNhap N'Số Lượng Nhập', HDNhapHang.TongTien N'Tổng Tiền', NhaCungcap.TenNCC N'Tên Nhà Cung Cấp' ,NhanVien.TenNV N'Tên Nhân Viên'
from HDNhapHang , NhanVien , NhaCungCap 
where DATEPART (YY, NgayNhap) = @nam and HDNhapHang.MaNCC = NhaCungcap.MaNCC and HDNhapHang.MaNV = NhanVien.MaNV;
GO
/****** Object:  StoredProcedure [dbo].[DanhSachHDXtTrongNam]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DanhSachHDXtTrongNam] (@nam int)
as
select HoaDonBanHang.MaHD N'Mã Hóa Đơn' , HoaDonBanHang.NgayXuat N'ngày Xuất', HoaDonBanHang.TongTien N'Tổng Tiền', HoaDonBanHang.GhiChu N'Ghi Chú', KhachHang.TenKH N'Tên Khách Hàng', NhanVien.TenNV N'Tên Nhân Viên'
from HoaDonBanHang , KhachHang , NhanVien 
where DATEPART (YY, NgayXuat ) = @nam and HoaDonBanHang.MaKH = KhachHang.MaKH and HoaDonBanHang.MaNV = NhanVien.MaNV and TrangThai = 'True'
GO
/****** Object:  StoredProcedure [dbo].[deletegiohang]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deletegiohang] (@mahd int , @masp int , @macauhinh int , @mamau int)
as
begin
delete from HDBH_SP where MaHD = @mahd and MaSP = @masp and MaCauHinh = @macauhinh and MaMau = @mamau
end
--select SoLuong from CTSanPham where MaSP =  and MaCauHinh = and MaMau = 

GO
/****** Object:  StoredProcedure [dbo].[deletegiohang1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deletegiohang1] (@mahd int , @masp nvarchar , @macauhinh nvarchar , @mamau nvarchar)
as
begin
delete from HDBH_SP where MaHD = @mahd and MaSP = @masp and MaCauHinh = @macauhinh and MaMau = @mamau
end
GO
/****** Object:  StoredProcedure [dbo].[deletegiohang2]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deletegiohang2] (@mahd int , @masp nvarchar , @macauhinh nvarchar , @mamau nvarchar)
as
begin
delete from HDNH_SP where MaHDN = @mahd and MaSP = @masp and MaCauHinh = @macauhinh and MaMau = @mamau
end
GO
/****** Object:  StoredProcedure [dbo].[deletegiohangban]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deletegiohangban] (@mahd int , @masp int , @macauhinh int , @mamau int)
as
begin
delete from HDBH_SP where MaHD = @mahd and MaSP = @masp and MaCauHinh = @macauhinh and MaMau = @mamau
end
GO
/****** Object:  StoredProcedure [dbo].[deletegiohangnhap]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deletegiohangnhap] ( @masp int , @macauhinh int , @mamau int)
as
begin
delete from HDNH_SP where MaSP = @masp and MaCauHinh = @macauhinh and MaMau = @mamau
end
 ---------main

GO
/****** Object:  StoredProcedure [dbo].[deletegiohangnhap1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deletegiohangnhap1] ( @mahd int , @masp int , @macauhinh int , @mamau int)
as
begin
delete from HDNH_SP where MaHDN =@mahd and MaSP = @masp and MaCauHinh = @macauhinh and MaMau = @mamau
end
GO
/****** Object:  StoredProcedure [dbo].[deleteNCC2]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteNCC2] (@ma int )
as
begin
 delete from NhaCungcap where MaNCC = @ma
end

GO
/****** Object:  StoredProcedure [dbo].[demsokh]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[demsokh] (@ma int)
as
begin 
	Select MaKH from KhachHang ,LoaiKH where KhachHang.MaLKH = LoaiKH.MaLKH and LoaiKH.MaLKH = @ma
end
GO
/****** Object:  StoredProcedure [dbo].[DiaChiNV]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[DiaChiNV](@maNV int)
 as
 begin 
 select DiaChi from NhanVien where MaNV = @maNV
 end 


GO
/****** Object:  StoredProcedure [dbo].[DoanhThuNamHienTai]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DoanhThuNamHienTai] 
as
select Sum (TongTien) as N'TongTien' from HoaDonBanHang where DATEPART(YY, NgayXuat) = DATEPART(YY, getdate())
GO
/****** Object:  StoredProcedure [dbo].[GmailNV]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   create proc [dbo].[GmailNV](@maNV int)
 as
 begin 
 select Gmail from NhanVien where MaNV = @maNV
 end 


GO
/****** Object:  StoredProcedure [dbo].[GTNV]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[GTNV](@maNV int)
 as
 begin 
 select GioiTinh from NhanVien where MaNV = @maNV
 end 

GO
/****** Object:  StoredProcedure [dbo].[gvgiohang1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[gvgiohang1] (@ma int)
as
begin
	select TenSp N'Tên Sản Phẩm' , TenCauHinh N'Cấu Hình' , TenMau N'Màu Sắc' , SoLuong N'Số lượng' , ThanhTien N'Đơn giá '
	from HDBH_SP , SP_CauHinh,SP_Mau,SanPham
	where HDBH_SP.MaHD=@ma and HDBH_SP.MaCauHinh = SP_CauHinh.MaCauHinh and HDBH_SP.MaMau = SP_Mau.MaMau and HDBH_SP.MaSP = SanPham.MaSP
	
end
GO
/****** Object:  StoredProcedure [dbo].[gvgiohang5]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[gvgiohang5] (@ma int)
as
begin
	select TenSp  , TenCauHinh  , TenMau , SoLuong , ThanhTien 
	from HDBH_SP , SP_CauHinh,SP_Mau,SanPham
	where HDBH_SP.MaHD=@ma and HDBH_SP.MaCauHinh = SP_CauHinh.MaCauHinh and HDBH_SP.MaMau = SP_Mau.MaMau and HDBH_SP.MaSP = SanPham.MaSP
end
GO
/****** Object:  StoredProcedure [dbo].[gvgiohang6]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[gvgiohang6] (@ma int)
as
begin
	select *
	from HDBH_SP , SP_CauHinh,SP_Mau,SanPham,KhachHang,NhanVien,LoaiKH,HoaDonBanHang
	where HoaDonBanHang.MaHD=@ma and HoaDonBanHang.MaNV = NhanVien.MaNV and HoaDonBanHang.MaKH = KhachHang.MaKH and KhachHang.MaLKH = LoaiKH.MaLKH
	and HDBH_SP.MaHD =HoaDonBanHang.MaHD and HDBH_SP.MaSP = SanPham.MaSP
	and HDBH_SP.MaCauHinh = SP_CauHinh.MaCauHinh and HDBH_SP.MaMau = SP_Mau.MaMau 
end
GO
/****** Object:  StoredProcedure [dbo].[gvgiohangnhap1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[gvgiohangnhap1] (@ma int)
as
begin
	select TenSp N'Tên Sản Phẩm' , TenCauHinh N'Cấu Hình' , TenMau N'Màu Sắc' , SoLuong N'Số lượng' , HDNH_SP.DonGia N'Đơn giá '
	from HDNH_SP , SP_CauHinh,SP_Mau,SanPham
	where HDNH_SP.MaHDN=@ma and HDNH_SP.MaCauHinh = SP_CauHinh.MaCauHinh and HDNH_SP.MaMau = SP_Mau.MaMau and HDNH_SP.MaSP = SanPham.MaSP	
end
GO
/****** Object:  StoredProcedure [dbo].[HDBTT]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HDBTT] (@mahd int)
as
begin
select * from HDBH_SP
where MaHD= @mahd
end
GO
/****** Object:  StoredProcedure [dbo].[IMG]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[IMG] (@ma int)
as
begin
select HinhAnh from SanPham where MaSP=@ma
end

GO
/****** Object:  StoredProcedure [dbo].[IMG2]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[IMG2] (@ma int)
as
begin
select * from SanPham where MaSP=@ma
end



GO
/****** Object:  StoredProcedure [dbo].[IMG3]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[IMG3] (@ma int)
as
begin
select HinhAnh from SanPham where MaSP=@ma
end
GO
/****** Object:  StoredProcedure [dbo].[insertCTSP1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertCTSP1] ( @mansp int, @macauhinh int, @mamau int, @soluong int )
as
insert into CTSanPham values ( @mansp , @macauhinh , @mamau , @soluong )
GO
/****** Object:  StoredProcedure [dbo].[insertHDBH_SP]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[insertHDBH_SP] (@mahd int ,@masp int , @mamau int , @macauhinh int , @soluong int ,@thanhtien float )
as
begin
 insert into HDBH_SP values (@mahd , @masp , @mamau , @macauhinh , @soluong ,@thanhtien)
end

GO
/****** Object:  StoredProcedure [dbo].[insertHDBH_SP1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertHDBH_SP1] (@mahd int ,@masp int , @macauhinh int  , @mamau int, @soluong int ,@thanhtien float )
as
begin
 insert into HDBH_SP values (@mahd , @masp  , @macauhinh , @mamau , @soluong ,@thanhtien)
end
GO
/****** Object:  StoredProcedure [dbo].[insertHDN]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertHDN] (@ma int, @mancc int, @manv int, @ngaynhap date, @tongtien int,@Soluongnhap int)
as
insert into HDNhapHang values (@ma, @ngaynhap,@Soluongnhap,@tongtien, @mancc, @manv)

GO
/****** Object:  StoredProcedure [dbo].[insertHDN_SP]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertHDN_SP] (@ma int, @mansp int, @macauhinh int, @mamau int, @soluong int , @dongia float)
as
insert into HDNH_SP values (@ma , @mansp , @macauhinh , @mamau , @soluong  , @dongia )
GO
/****** Object:  StoredProcedure [dbo].[insertHDN_SP1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertHDN_SP1] (@ma int, @mansp int, @macauhinh int, @mamau int, @soluong int , @dongia float ,@thanhtien float)
as
insert into HDNH_SP values (@ma , @mansp , @macauhinh , @mamau , @soluong  , @dongia ,@thanhtien)
GO
/****** Object:  StoredProcedure [dbo].[insertHoDonBH]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertHoDonBH] (@mahd int , @ngayxuat date ,@maqr image, @makh int , @manv int )
as
begin
 insert into HoaDonBanHang values (@mahd , @ngayxuat ,null,null,null, @maqr , @makh , @manv)
end
GO
/****** Object:  StoredProcedure [dbo].[insertKH]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create proc [dbo].[insertKH] (@ma int, @ten nvarchar (1000),@DiemTichLuy int, @DiaChi nvarchar(1000),@SoDienThoai int ,@gmail nchar (100) )
as
begin
insert into KhachHang values (@ma, @ten, @DiemTichLuy,@DiaChi,@SoDienThoai,@gmail,1)
end

GO
/****** Object:  StoredProcedure [dbo].[insertKHADD]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[insertKHADD] (@ma int, @ten nvarchar (1000), @DiaChi nvarchar(1000),@SoDienThoai int ,@gmail nchar (100) )
as
begin
insert into KhachHang values (@ma, @ten, 0,@DiaChi,@SoDienThoai,@gmail,1)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertNCC]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----NCC


create proc [dbo].[InsertNCC] (@ma int , @ten nvarchar (1000) , @diachi nvarchar (1000) , @sodienthoai int)
as
begin
 insert into NhaCungcap values (@ma, @ten, @diachi,@sodienthoai)
end


GO
/****** Object:  StoredProcedure [dbo].[InsertNV1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertNV1] (@ma int , @ten nvarchar (1000) ,@gioitinh nvarchar (1000) , @ngaysinh date ,@gmail nchar(100),@diachi nvarchar(1000), @ngayvaolam date ,@sodienthoai int,@taikhoan nchar(100),@matkhau nchar(100),@macv int )
as
begin
 insert into NhanVien values (@ma , @ten ,@gioitinh , @ngaysinh ,@gmail ,@diachi, @ngayvaolam ,@sodienthoai ,@taikhoan ,@matkhau ,@macv )
end

GO
/****** Object:  StoredProcedure [dbo].[Insertsp1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insertsp1] (@ma int , @ten nvarchar (1000) , @dongia float , @thoigianbaohanh int,@mota nvarchar (1000),@maLSP int )
as
begin
 insert into SanPham values (@ma, @ten, @dongia,@thoigianbaohanh,@mota,null,@maLSP)
end


GO
/****** Object:  StoredProcedure [dbo].[InsertspIMG]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[InsertspIMG] (@ma int , @ten nvarchar (1000) , @dongia float , @thoigianbaohanh int,@mota nvarchar (1000),@img image,@maLSP int )
as
begin
 insert into SanPham values (@ma, @ten, @dongia,@thoigianbaohanh,@mota,@img,@maLSP)
end

---
GO
/****** Object:  StoredProcedure [dbo].[MCV]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   create proc [dbo].[MCV](@maNV int)
 as
 begin 
 select MaCV from NhanVien where MaNV = @maNV
 end 
  
GO
/****** Object:  StoredProcedure [dbo].[NamBanHang]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NamBanHang]
as
select DATEPART(YY, NgayXuat) as N'Nam' from HoaDonBanHang 
group  by  DATEPART(YY, NgayXuat)
GO
/****** Object:  StoredProcedure [dbo].[namelogin1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[namelogin1] (@taikhoan nvarchar (1000),@matkhau nvarchar(1000))
 as
 begin
	select TenNV from NhanVien where TaiKhoan = @taikhoan and MatKhau = @matkhau
 end

GO
/****** Object:  StoredProcedure [dbo].[NamNhapHang]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NamNhapHang] 
as
select DATEPART(YY, NgayNhap) as N'Nam' from HDNhapHang
group  by  DATEPART(YY, NgayNhap)
GO
/****** Object:  StoredProcedure [dbo].[NSNV1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  
  create proc [dbo].[NSNV1](@maNV int)
 as
 begin 
 select NgaySinh from NhanVien where MaNV = @maNV
 end 

GO
/****** Object:  StoredProcedure [dbo].[NVLNV]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[NVLNV](@maNV int)
 as
 begin 
 select NgayVaoLam from NhanVien where MaNV = @maNV
 end 

GO
/****** Object:  StoredProcedure [dbo].[PhanLoaiSP1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PhanLoaiSP1] (@ten nvarchar (1000))
as
begin 
select MaSP N'Mã Sản Phẩm' , TenSP N'Tên Sản Phẩm'   ,Dongia N'Đơn giá',ThoiGianBH N'Thời gian bảo hành' ,Mota N'Mô tả',TenLoaiSP N'Tên loại sản phẩm' 
from SanPham , LoaiSP 
where TenLoaiSP = @ten and SanPham.MaLSP = LoaiSP.MaLSP 
end



GO
/****** Object:  StoredProcedure [dbo].[PhanLoaiSP10]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PhanLoaiSP10] (@mota nvarchar (1000),@ten nvarchar (1000))
as
begin 
select MaSP N'Mã Sản Phẩm' , TenSP N'Tên Sản Phẩm'   ,Dongia N'Đơn giá',ThoiGianBH N'Thời gian bảo hành' ,Mota N'Mô tả',TenLoaiSP N'Tên loại sản phẩm'
from SanPham ,LoaiSP 
where  SanPham.MaLSP = LoaiSP.MaLSP and ( (MoTa = @mota and TenLoaiSP = @ten ) or (MoTa = @mota or TenLoaiSP = @ten) )
end


GO
/****** Object:  StoredProcedure [dbo].[PhanLoaiSP8]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PhanLoaiSP8] (@mota nvarchar (1000))
as
begin 
select MaSP N'Mã Sản Phẩm' , TenSP N'Tên Sản Phẩm'   ,Dongia N'Đơn giá',ThoiGianBH N'Thời gian bảo hành' ,Mota N'Mô tả',TenLoaiSP N'Tên loại sản phẩm'
from SanPham , LoaiSP 
where  MoTa = @mota and SanPham.MaLSP = LoaiSP.MaLSP 
end

---
GO
/****** Object:  StoredProcedure [dbo].[QLHDB]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[QLHDB]
as
select MaHD N'Mã Hóa Đơn', NgayXuat N'Ngày Xuất',TongTien N'Tổng Tiền',GhiChu N'Ghi Chú', TrangThai N'Trạng thái',TenKH N'Tên Khách Hàng',TenNV N'Tên Nhân Viên'
from HoaDonBanHang , KhachHang , NhanVien
where HoaDonBanHang.MaKH = KhachHang.MaKH and HoaDonBanHang.MaNV = NhanVien.MaNV
GO
/****** Object:  StoredProcedure [dbo].[QLHDB1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[QLHDB1]
as
select MaHD N'Mã Hóa Đơn', NgayXuat N'Ngày Xuất',TongTien N'Tổng Tiền',GhiChu N'Ghi Chú', TrangThai N'Đã Thanh Toán',TenKH N'Tên Khách Hàng',TenNV N'Tên Nhân Viên'
from HoaDonBanHang , KhachHang , NhanVien
where HoaDonBanHang.MaKH = KhachHang.MaKH and HoaDonBanHang.MaNV = NhanVien.MaNV
GO
/****** Object:  StoredProcedure [dbo].[QLHDM]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[QLHDM]
as
select MaHDN N'Mã Hóa Đơn', NgayNhap N'Ngày Nhập',SLNhap N'Số lượng Nhập',TongTien N'Tổng Tiền',NhaCungcap.TenNCC N'Tên Nhà Cung Cấp',NhanVien.TenNV N'Tên Nhân Viên'
from HDNhapHang , NhaCungcap,NhanVien
where HDNhapHang.MaNCC = NhaCungcap.MaNCC and HDNhapHang.MaNV = NhanVien.MaNV
GO
/****** Object:  StoredProcedure [dbo].[reporthdx]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[reporthdx] (@mahd int)
as begin
select * from dbo.HoaDonBanHang, dbo.KhachHang, dbo.NhanVien
where HoaDonBanHang.MaKH = KhachHang.MaKH and HoaDonBanHang.MaNV = NhanVien.MaNV
end
GO
/****** Object:  StoredProcedure [dbo].[SĐT]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   create proc [dbo].[SĐT](@maNV int)
 as
 begin 
 select SoDienThoai from NhanVien where MaNV = @maNV
 end 
GO
/****** Object:  StoredProcedure [dbo].[SeachHDB]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SeachHDB] (@Tenma nvarchar (1000))
 as
 begin
 SELECT MaHD N'Mã Hóa Đơn', NgayXuat N'Ngày Xuất',TongTien N'Tổng Tiền',GhiChu N'Ghi Chú', TrangThai N'Trạng thái',TenKH N'Tên Khách Hàng',TenNV N'Tên Nhân Viên'
 FROM HoaDonBanHang , KhachHang , NhanVien
 WHERE HoaDonBanHang.MaKH = KhachHang.MaKH and HoaDonBanHang.MaNV = NhanVien.MaNV and 
 (dbo.fuConvertToUnsign1(MaHD) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%' or dbo.fuConvertToUnsign1(TrangThai) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%'
 or dbo.fuConvertToUnsign1(KhachHang.TenKH) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%'or dbo.fuConvertToUnsign1(NhanVien.TenNV) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%'
 or dbo.fuConvertToUnsign1(TongTien) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%' or dbo.fuConvertToUnsign1(NgayXuat) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%')
 end
GO
/****** Object:  StoredProcedure [dbo].[SeachHDN]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SeachHDN] (@Tenma nvarchar (1000))
 as
 begin
 SELECT MaHDN N'Mã Hóa Đơn', NgayNhap N'Ngày Nhập',SLNhap N'Số lượng Nhập',TongTien N'Tổng Tiền',NhaCungcap.TenNCC N'Tên Nhà Cung Cấp',NhanVien.TenNV N'Tên Nhân Viên'
 FROM HDNhapHang , NhaCungcap,NhanVien
 WHERE HDNhapHang.MaNCC = NhaCungcap.MaNCC and HDNhapHang.MaNV = NhanVien.MaNV and 
 dbo.fuConvertToUnsign1(MaHDN) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%' or dbo.fuConvertToUnsign1(NhaCungcap.TenNCC) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%'
 or dbo.fuConvertToUnsign1(NhanVien.TenNV) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%'
 end
GO
/****** Object:  StoredProcedure [dbo].[SeachHDN1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SeachHDN1] (@Tenma nvarchar (1000))
 as
 begin
 SELECT MaHDN N'Mã Hóa Đơn', NgayNhap N'Ngày Nhập',SLNhap N'Số lượng Nhập',TongTien N'Tổng Tiền',NhaCungcap.TenNCC N'Tên Nhà Cung Cấp',NhanVien.TenNV N'Tên Nhân Viên'
 FROM HDNhapHang , NhaCungcap,NhanVien
 WHERE HDNhapHang.MaNCC = NhaCungcap.MaNCC and HDNhapHang.MaNV = NhanVien.MaNV and 
 (dbo.fuConvertToUnsign1(MaHDN) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%' or dbo.fuConvertToUnsign1(NhaCungcap.TenNCC) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%'
 or dbo.fuConvertToUnsign1(NhanVien.TenNV) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%')
 end
GO
/****** Object:  StoredProcedure [dbo].[SeachNCC]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[SeachNCC] (@Ten nvarchar (1000))
 as
 begin
 SELECT * FROM NhaCungcap WHERE dbo.fuConvertToUnsign1(TenNCC) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' or dbo.fuConvertToUnsign1(DiaChi) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' or dbo.fuConvertToUnsign1(MaNCC) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' or dbo.fuConvertToUnsign1(SoDienThoai) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%'
 end


----sanPham


GO
/****** Object:  StoredProcedure [dbo].[SeachNV]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SeachNV] (@Ten nvarchar (1000))
 as
 begin
 SELECT  MaNV N'Mã nhân viên' , TenNV N'Tên nhân viên'   ,GioiTinh N'Giới tính',NgaySinh N'Ngày sinh' ,Gmail,DiaChi N'Địa chỉ',NgayVaoLam N'Ngày vào làm',SoDienThoai N'Số điện thoại',TaiKhoan N'Tài khoản',MatKhau N'Mật khẩu',TenCV N'Tên chức vụ'
 FROM NhanVien ,ChucVu 
 WHERE  NhanVien.MaCV = ChucVu.MaCV and (dbo.fuConvertToUnsign1(TenNV) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' or dbo.fuConvertToUnsign1(SoDienThoai) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' or dbo.fuConvertToUnsign1(TenCV) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' or dbo.fuConvertToUnsign1(TaiKhoan) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%')
 end


GO
/****** Object:  StoredProcedure [dbo].[SeachSP]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SeachSP] (@Ten nvarchar (1000))
 as
 begin
 SELECT  MaSP N'Mã Sản Phẩm' , TenSP N'Tên Sản Phẩm'   ,Dongia N'Đơn giá',ThoiGianBH N'Thời gian bảo hành' ,Mota N'Mô tả',TenLoaiSP N'Tên loại sản phẩm'
 FROM SanPham , LoaiSP  
 WHERE SanPham.MaLSP = LoaiSP.MaLSP  and (dbo.fuConvertToUnsign1(TenSp) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' or dbo.fuConvertToUnsign1(MaSP) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' or dbo.fuConvertToUnsign1(MoTa) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' or dbo.fuConvertToUnsign1(TenLoaiSP) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%' or dbo.fuConvertToUnsign1(ThoiGianBH) LIKE N'%' + dbo.fuConvertToUnsign1(@Ten) + '%')
 end


GO
/****** Object:  StoredProcedure [dbo].[SeachSP1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SeachSP1] (@Tenma nvarchar (1000))
 as
 begin
 SELECT  MaSP N'Mã SP', TenSp N'Sản Phẩm'
 FROM SanPham
 WHERE dbo.fuConvertToUnsign1(TenSP) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%' or dbo.fuConvertToUnsign1(MaSP) LIKE N'%' + dbo.fuConvertToUnsign1(@Tenma) + '%'
 end

GO
/****** Object:  StoredProcedure [dbo].[selecHDBHSP]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selecHDBHSP] (@masp int ,@macauhinh int, @mamau int ,@mahd int)
as
begin
		select * from HDBH_SP where MaHD = @mahd and MaSP = @masp and MaCauHinh =@macauhinh and MaMau =@mamau
end
GO
/****** Object:  StoredProcedure [dbo].[selectcbxmau]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[selectcbxmau](@maSP int , @maCH int)
as
begin
		select SP_Mau.TenMau , SP_Mau.MaMau from CTSanPham,SP_Mau where CTSanPham.MaMau = SP_Mau.MaMau and CTSanPham.MaSP = @maSP and CTSanPham.MaCauHinh = @maCH
end 
GO
/****** Object:  StoredProcedure [dbo].[selectCTSP]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selectCTSP] (@masp int ,@macauhinh int, @mamau int ,@mahd int)
as
begin
		select * from HDBH_SP where MaHD = @mahd and MaSP = @masp and MaCauHinh =@macauhinh and MaMau =@mamau
end

GO
/****** Object:  StoredProcedure [dbo].[selectHDBH_SP]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

----thống kê thu chi

----hóa đơn bán hàng
create proc [dbo].[selectHDBH_SP] (@ma int)
as
select * from HDBH_SP where MaHD = @ma
GO
/****** Object:  StoredProcedure [dbo].[selectHDBH_SP1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





----hóa đơn bán hàng
create proc [dbo].[selectHDBH_SP1] (@ma int)
as
select * from HDBH_SP where MaHD = @ma
GO
/****** Object:  StoredProcedure [dbo].[selectHDBHSP]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selectHDBHSP] (@mahdn int, @masp int, @macauhinh int, @mamau int)
as
select * from HDBH_SP where MaHD = @mahdn and MaSP = @masp and MaCauHinh = @macauhinh and MaMau = @mamau
GO
/****** Object:  StoredProcedure [dbo].[selectKH1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[selectKH1]
as
select * from KhachHang
GO
/****** Object:  StoredProcedure [dbo].[selectKhachhang]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[selectKhachhang]
as
select MaKH N'Mã KH' , TenKH N'Tên KH' ,DiemTichLuy N'Điểm tích lũy' ,DiaChi N'Địa chỉ',SoDienThoai N'Số điện thoại',Gmail , TenLKH N'Loại Khách Hàng'
from KhachHang ,LoaiKH where KhachHang.MaLKH = LoaiKH.MaLKH
GO
/****** Object:  StoredProcedure [dbo].[selectKHHD1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selectKHHD1] (@ma int)
as
begin
 select TenKH
 from KhachHang 
 where MaKH = @ma
end


GO
/****** Object:  StoredProcedure [dbo].[selectKHHD2]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selectKHHD2] (@ma int)
as
begin
 select DiemTichLuy
 from KhachHang 
 where MaKH = @ma
end
GO
/****** Object:  StoredProcedure [dbo].[selectKHHD3]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selectKHHD3] (@ma int)
as
begin
 select TenLKH
 from KhachHang ,LoaiKH  
 where MaKH = @ma and KhachHang.MaLKH = LoaiKH.MaLKH 
end
GO
/****** Object:  StoredProcedure [dbo].[SoLuongHDXDaBan]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



--SoluongHD đã bán trong năm
create proc [dbo].[SoLuongHDXDaBan]
as
select Count (MaHD ) as 'SoLuong' From HoaDonBanHang where DATEPART(YY, NgayXuat) = DATEPART(YY, getdate()) and TrangThai = 'True'
GO
/****** Object:  StoredProcedure [dbo].[soluongton]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[soluongton]
as
begin
	select TenSp N'Tên Sản Phẩm' , TenCauHinh N'Cấu Hình' , TenMau N'Màu Sắc' 
	from  CTSanPham,SanPham,SP_CauHinh,SP_Mau
	where CTSanPham.SoLuong = 0 and CTSanPham.MaSP = SanPham.MaSP and CTSanPham.MaCauHinh = SP_CauHinh.MaCauHinh and CTSanPham.MaMau = SP_Mau.MaMau 
end	 
GO
/****** Object:  StoredProcedure [dbo].[SPLUU]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPLUU] (@ten nvarchar (100))
as
begin 
select TenSP from SanPham where TenSp = @ten
end

GO
/****** Object:  StoredProcedure [dbo].[TGBHConLai1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TGBHConLai1] (@mahd int, @masp int, @mach int,@mamau int )
as
insert into TKTGBH values (@mahd, @masp,@mach,@mamau ,'2000-01-01')

GO
/****** Object:  StoredProcedure [dbo].[thongkehangton2]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---Thống kê số hàng tồn
create proc [dbo].[thongkehangton2] (@maloai int)
as
begin
select SanPham.MaSP N'Mã Sản Phẩm', SanPham.TenSp N'Tên Sản Phẩm',LoaiSP.TenLoaiSP as N'Loại Sản Phẩm' , SP_Mau.TenMau N'Màu Sắc',SP_CauHinh.TenCauHinh N'Cấu Hình', CTSanPham.SoLuong N'Số lượng' 
from CTSanPham , SanPham ,SP_Mau,SP_CauHinh, LoaiSP 
where  SanPham.MaLSP = LoaiSP.MaLSP and CTSanPham.MaSP = SanPham.MaSP and CTSanPham.MaMau = SP_Mau.MaMau and CTSanPham.MaCauHinh = SP_CauHinh.MaCauHinh and LoaiSP.MaLSP = @maloai 
order by  SanPham.TenSp asc 
end
GO
/****** Object:  StoredProcedure [dbo].[TienBanTheoThangCuaNam]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TienBanTheoThangCuaNam] (@nam int)
as
begin
declare @sothang int =0;
declare @tongtien int =0;
Delete from TempThu
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
GO
/****** Object:  StoredProcedure [dbo].[TienNhapTheoThangCuaNam]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


---số tiền nhập theo tháng của năm
create proc [dbo].[TienNhapTheoThangCuaNam] (@nam int)
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
GO
/****** Object:  StoredProcedure [dbo].[timma1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[timma1](@tensanpham nvarchar ,@cauhinh nvarchar , @mausac nvarchar)
as
begin
	select HDBH_SP.MaSP , HDBH_SP.MaCauHinh ,HDBH_SP.MaMau,SoLuong
	from HDBH_SP ,SanPham,SP_CauHinh,SP_Mau 
	where HDBH_SP.MaSP = SanPham.MaSP and HDBH_SP.MaCauHinh = SP_CauHinh.MaCauHinh and HDBH_SP.MaMau = SP_Mau.MaMau and TenSp = @tensanpham and TenCauHinh = @cauhinh and TenMau = @mausac
end

GO
/****** Object:  StoredProcedure [dbo].[timma2]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[timma2] (@tensanpham nvarchar ,@cauhinh nvarchar , @mausac nvarchar)
as
begin
	select HDNH_SP.MaSP , HDNH_SP.MaCauHinh ,HDNH_SP.MaMau
	from HDNH_SP ,SanPham,SP_CauHinh,SP_Mau 
	where HDNH_SP.MaSP = SanPham.MaSP and HDNH_SP.MaCauHinh = SP_CauHinh.MaCauHinh and HDNH_SP.MaMau = SP_Mau.MaMau and TenSp = @tensanpham and TenCauHinh = @cauhinh and TenMau = @mausac
end
GO
/****** Object:  StoredProcedure [dbo].[timma3]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[timma3] (@tensanpham nvarchar ,@cauhinh nvarchar , @mausac nvarchar)
as
begin
	select SanPham.MaSP , SP_CauHinh.MaCauHinh ,SP_Mau.MaMau
	from HDNH_SP ,SanPham,SP_CauHinh,SP_Mau 
	where HDNH_SP.MaSP = SanPham.MaSP and HDNH_SP.MaCauHinh = SP_CauHinh.MaCauHinh and HDNH_SP.MaMau = SP_Mau.MaMau and TenSp = @tensanpham and TenCauHinh = @cauhinh and TenMau = @mausac
end
GO
/****** Object:  StoredProcedure [dbo].[TKKH]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 -----Thống kê khách hàng 
 create proc [dbo].[TKKH]
as
begin
select HoaDonBanHang.MaHD N'Mã Hóa Đơn ', KhachHang.TenKH  N'Tên Khách Hàng',  SanPham.TenSp  N'Tên Sản Phẩm' , SP_Mau.TenMau N'Tên Màu', SP_CauHinh.TenCauHinh N'Tên Cấu Hình ',HDBH_SP.SoLuong N'Số lượng'
from HoaDonBanHang , HDBH_SP , KhachHang , SanPham , SP_Mau , SP_CauHinh
where HoaDonBanHang.MaHD = HDBH_SP.MaHD and HoaDonBanHang.MaKH = KhachHang.MaKH  and HDBH_SP.MaSP= SanPham.MaSP
and HDBH_SP.MaCauHinh = SP_CauHinh.MaCauHinh and HDBH_SP.MaMau = SP_Mau.MaMau and HoaDonBanHang.TrangThai = 'True'
end

GO
/****** Object:  StoredProcedure [dbo].[TKKHmuagi]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[TKKHmuagi] 
as
select HDX.Ma, KH.Ten as N'TKH',  SP.Ten as N'SP' , MS.TenMau, SZ.TenSize, CTHDX.SoLuong
from HDXuat HDX, CTHDXuat CTHDX, KhachHang KH, SanPham SP, MauSac MS, Size SZ
where HDX.Ma = CTHDX.Ma_HDX and HDX.Ma_KH = KH.Ma  and CTHDX.Ma_SP = SP.Ma and CTHDX.Ma_Size = SZ.Ma and CTHDX.Ma_MauSac = MS.Ma and HDX.TrangThai = 'True'
GO
/****** Object:  StoredProcedure [dbo].[TKTGBHGV]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TKTGBHGV]
as
select MaHDBH N'Mã Hóa Đơn' , TenSp N'Tên Sản Phẩm', TenCauHinh N'Tên Cấu Hình' , TenMau N'Tên Màu' , thoigianconlai N'Thời Hạn Bảo Hành'
from TKTGBH,SanPham , SP_CauHinh,SP_Mau
where TKTGBH.masp = SanPham.MaSP and TKTGBH.mach = SP_CauHinh.MaCauHinh and TKTGBH.mamau = SP_Mau.MaMau
GO
/****** Object:  StoredProcedure [dbo].[TNV]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[TNV](@maNV int)
 as
 begin 
 select TenNV from NhanVien where MaNV = @maNV
 end 

GO
/****** Object:  StoredProcedure [dbo].[udtgbh]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[udtgbh] (@mahd int, @masp int, @mach int,@mamau int ,@tg date)
as
update TKTGBH set thoigianconlai = @tg where MaHDBH =  @mahd  and masp = @masp and mach = @mach and mamau = @mamau
GO
/****** Object:  StoredProcedure [dbo].[UpdateHDBHTT]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[UpdateHDBHTT] (@ma int ,@tongtien float)
as
begin
 Update HoaDonBanHang set TongTien =@tongtien where MaHD =  @ma 
end
GO
/****** Object:  StoredProcedure [dbo].[updateKH2]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateKH2] (@ma int, @ten nvarchar (1000), @DiaChi nvarchar (1000), @SDT int, @Gmail nvarchar (100) )
as
begin
update KhachHang set TenKH = @ten, DiaChi = @DiaChi, SoDienThoai = @SDT, Gmail = @Gmail where MaKH = @ma
end

GO
/****** Object:  StoredProcedure [dbo].[updateNCC]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[updateNCC] (@ma int, @ten nvarchar (1000), @DiaChi nvarchar (1000), @SDT int  )
as
begin
update NhaCungcap set TenNCC = @ten, DiaChi = @DiaChi, SoDienThoai = @SDT where MaNCC = @ma
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateNV1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create proc [dbo].[UpdateNV1] (@ma int , @ten nvarchar (1000) ,@gioitinh nvarchar (1000) , @ngaysinh date ,@gmail nchar(100),@diachi nvarchar(1000), @ngayvaolam date ,@sodienthoai int,@macv int )
as
begin
 Update NhanVien set TenNV= @ten , GioiTinh = @gioitinh ,NgaySinh= @ngaysinh ,Gmail= @gmail ,DiaChi= @diachi,NgayVaoLam= @ngayvaolam ,SoDienThoai= @sodienthoai ,MaCV= @macv where MaNV =  @ma 
end
------HD bán hàng ,Nhập hàng


GO
/****** Object:  StoredProcedure [dbo].[updateSLT]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[updateSLT] (@maSP int, @macauhinh int, @maMau int, @soluong int)
as
update CTSanPham set Soluong = @soluong where MaSP = @maSP and MaCauHinh = @macauhinh and MaMau = @maMau
GO
/****** Object:  StoredProcedure [dbo].[UpdateSLTCTSP1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[UpdateSLTCTSP1] (@masp int ,@macauhinh int, @mamau int ,@soluong int)
as
begin
 Update CTSanPham set SoLuong =@soluong where MaSP =  @masp and MaCauHinh = @macauhinh and MaMau = @mamau 
end
GO
/****** Object:  StoredProcedure [dbo].[updatesoluong3]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updatesoluong3] (@mahdx int)
as
begin
update HDNhapHang set  SLNhap = (select SUM(SoLuong) from HDNH_SP where MaHDN = @mahdx) where MaHDN = @mahdx
end
GO
/****** Object:  StoredProcedure [dbo].[updatesoluongHDN]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updatesoluongHDN] (@mahdn int , @soluong int)
as
update HDNhapHang set SLNhap = @soluong where MaHDN = @mahdn
GO
/****** Object:  StoredProcedure [dbo].[updateSoLuongTTCTHDX]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateSoLuongTTCTHDX] (@mahdx int, @masp int, @macauhinh int, @mamau int, @soluong int, @thanhtien float)
as
begin
update HDBH_SP set SoLuong = @soluong , ThanhTien = @thanhtien where MaHD = @mahdx and MaSP = @masp and MaCauHinh = @macauhinh and MaMau = @mamau 
end
GO
/****** Object:  StoredProcedure [dbo].[updateSoLuongTTCTHDX1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateSoLuongTTCTHDX1] (@mahdx int, @masp int, @macauhinh int, @mamau int, @soluong int, @thanhtien float)
as
begin
update HDBH_SP set SoLuong = SoLuong+ @soluong , ThanhTien = ThanhTien + @thanhtien where MaHD = @mahdx and MaSP = @masp and MaCauHinh = @macauhinh and MaMau = @mamau 
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateSP1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateSP1] (@ma int , @ten nvarchar (1000) , @dongia float , @thoigianbaohanh int,@mota nvarchar (1000) ,@LSP int )
as
begin
 Update SanPham set MaSP =  @ma,TenSp =  @ten, DonGia= @dongia,ThoiGianBH= @thoigianbaohanh,MoTa= @mota,HinhAnh= null,MaLSP = @LSP where MaSP=@ma
end

GO
/****** Object:  StoredProcedure [dbo].[UpdateSP2]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateSP2] (@ma int , @ten nvarchar (1000) , @dongia float , @thoigianbaohanh int,@mota nvarchar (1000) ,@img image,@LSP int )
as
begin
 Update SanPham set MaSP =  @ma,TenSp =  @ten, DonGia= @dongia,ThoiGianBH= @thoigianbaohanh,MoTa= @mota,HinhAnh= @img,MaLSP = @LSP where MaSP=@ma
end


-----Nhan vien


GO
/****** Object:  StoredProcedure [dbo].[updatetien2]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updatetien2] (@mahdx int)
as
begin
update HoaDonBanHang set  TongTien = (select SUM(ThanhTien) from HDBH_SP where MaHD = @mahdx) where MaHD = @mahdx
end
GO
/****** Object:  StoredProcedure [dbo].[updatetien3]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updatetien3] (@mahdx int)
as
begin
update HDNhapHang set  TongTien = (select SUM(ThanhTien) from HDNH_SP where MaHDN = @mahdx) where MaHDN = @mahdx
end
GO
/****** Object:  StoredProcedure [dbo].[updatetongtienHDN]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updatetongtienHDN] (@mahdn int , @tongtien int)
as
update HDNhapHang set TongTien = @tongtien where MaHDN = @mahdn
GO
/****** Object:  StoredProcedure [dbo].[updatetongtienHDNSP]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updatetongtienHDNSP] (@mahdn int , @tongtien int)
as
update HDNH_SP set DonGia = @tongtien where MaHDN = @mahdn
GO
/****** Object:  StoredProcedure [dbo].[Userlogin1]    Script Date: 3/7/2021 1:31:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[Userlogin1] (@taikhoan nvarchar (1000),@matkhau nvarchar(1000))
 as
 begin
	select MaCV from NhanVien where TaiKhoan = @taikhoan and MatKhau = @matkhau
 end



GO
USE [master]
GO
ALTER DATABASE [DOANCHUYENMON7] SET  READ_WRITE 
GO
