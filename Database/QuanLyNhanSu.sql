USE [master]
GO
/****** Object:  Database [QuanLyNhanSu]    Script Date: 14/3/2022 12:15:12 PM ******/
CREATE DATABASE [QuanLyNhanSu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyNhanSu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyNhanSu.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyNhanSu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyNhanSu_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyNhanSu] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyNhanSu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyNhanSu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyNhanSu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyNhanSu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyNhanSu] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyNhanSu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyNhanSu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyNhanSu] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyNhanSu] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyNhanSu] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyNhanSu] SET QUERY_STORE = OFF
GO
USE [QuanLyNhanSu]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 14/3/2022 12:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[username] [nvarchar](50) NOT NULL,
	[password] [nchar](10) NULL,
	[id_NhanVien] [int] NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 14/3/2022 12:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[id_NhanVien] [int] IDENTITY(1,1) NOT NULL,
	[ten_NhanVien] [nvarchar](100) NULL,
	[gioitinh_NhanVien] [nvarchar](4) NULL,
	[ngaysinh_NhanVien] [date] NULL,
	[diachi_NhanVien] [nvarchar](200) NULL,
	[sdt_NhanVien] [nchar](10) NULL,
	[luong_NhanVien] [int] NULL,
	[id_PhongBan] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[id_NhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 14/3/2022 12:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[id_PhongBan] [int] IDENTITY(1,1) NOT NULL,
	[ten_PhongBan] [nvarchar](50) NULL,
	[sdt_PhongBan] [nchar](10) NULL,
	[mota_PhongBan] [nvarchar](200) NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[id_PhongBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Login] ([username], [password], [id_NhanVien]) VALUES (N'admin', N'123       ', 4)
INSERT [dbo].[Login] ([username], [password], [id_NhanVien]) VALUES (N'admin2', N'123456    ', 1)
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([id_NhanVien], [ten_NhanVien], [gioitinh_NhanVien], [ngaysinh_NhanVien], [diachi_NhanVien], [sdt_NhanVien], [luong_NhanVien], [id_PhongBan]) VALUES (1, N'Lê Văn B', N'Nam', CAST(N'1978-02-08' AS Date), N'Hà Nội', N'0981435674', 15000000, 1)
INSERT [dbo].[NhanVien] ([id_NhanVien], [ten_NhanVien], [gioitinh_NhanVien], [ngaysinh_NhanVien], [diachi_NhanVien], [sdt_NhanVien], [luong_NhanVien], [id_PhongBan]) VALUES (2, N'Trần Hải A', N'Nữ', CAST(N'1997-10-11' AS Date), N'Bắc Giang', N'0986464871', 15000000, 3)
INSERT [dbo].[NhanVien] ([id_NhanVien], [ten_NhanVien], [gioitinh_NhanVien], [ngaysinh_NhanVien], [diachi_NhanVien], [sdt_NhanVien], [luong_NhanVien], [id_PhongBan]) VALUES (3, N'Nguyễn Hoàng C', N'Nam', CAST(N'2000-05-09' AS Date), N'Lạng Sơn', N'0971546813', 12000000, 1)
INSERT [dbo].[NhanVien] ([id_NhanVien], [ten_NhanVien], [gioitinh_NhanVien], [ngaysinh_NhanVien], [diachi_NhanVien], [sdt_NhanVien], [luong_NhanVien], [id_PhongBan]) VALUES (4, N'Nguyễn Văn D', N'Nam', CAST(N'1998-08-07' AS Date), N'Bắc Giang', N'0975431821', 20000000, 2)
INSERT [dbo].[NhanVien] ([id_NhanVien], [ten_NhanVien], [gioitinh_NhanVien], [ngaysinh_NhanVien], [diachi_NhanVien], [sdt_NhanVien], [luong_NhanVien], [id_PhongBan]) VALUES (5, N'Nguyễn Mỹ E', N'Nữ', CAST(N'1996-11-05' AS Date), N'Bắc Giang', N'0976445214', 10000000, 3)
INSERT [dbo].[NhanVien] ([id_NhanVien], [ten_NhanVien], [gioitinh_NhanVien], [ngaysinh_NhanVien], [diachi_NhanVien], [sdt_NhanVien], [luong_NhanVien], [id_PhongBan]) VALUES (6, N'Lê Văn F', N'Nam', CAST(N'1999-10-12' AS Date), N'Cao Bằng', N'0954657461', 14000000, 2)
INSERT [dbo].[NhanVien] ([id_NhanVien], [ten_NhanVien], [gioitinh_NhanVien], [ngaysinh_NhanVien], [diachi_NhanVien], [sdt_NhanVien], [luong_NhanVien], [id_PhongBan]) VALUES (7, N'Bùi Văn G', N'Nam', CAST(N'2000-10-11' AS Date), N'Sơn La', N'0946765212', 13000000, 2)
INSERT [dbo].[NhanVien] ([id_NhanVien], [ten_NhanVien], [gioitinh_NhanVien], [ngaysinh_NhanVien], [diachi_NhanVien], [sdt_NhanVien], [luong_NhanVien], [id_PhongBan]) VALUES (8, N'Nguyễn Thanh H', N'Nam', CAST(N'1996-05-07' AS Date), N'Hưng Yên', N'0964254215', 10000000, 4)
INSERT [dbo].[NhanVien] ([id_NhanVien], [ten_NhanVien], [gioitinh_NhanVien], [ngaysinh_NhanVien], [diachi_NhanVien], [sdt_NhanVien], [luong_NhanVien], [id_PhongBan]) VALUES (9, N'Trần Thanh I', N'Nữ', CAST(N'1996-06-08' AS Date), N'Thái Bình', N'0974561231', 10000000, 2)
INSERT [dbo].[NhanVien] ([id_NhanVien], [ten_NhanVien], [gioitinh_NhanVien], [ngaysinh_NhanVien], [diachi_NhanVien], [sdt_NhanVien], [luong_NhanVien], [id_PhongBan]) VALUES (10, N'Phạm Thị K', N'Nữ', CAST(N'1997-06-08' AS Date), N'Bắc Ninh', N'0954621378', 10000000, 1)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[PhongBan] ON 

INSERT [dbo].[PhongBan] ([id_PhongBan], [ten_PhongBan], [sdt_PhongBan], [mota_PhongBan]) VALUES (1, N'Hành chính - Nhân sự', N'0298464875', N'Phòng phát triển và quản lý nhân sự')
INSERT [dbo].[PhongBan] ([id_PhongBan], [ten_PhongBan], [sdt_PhongBan], [mota_PhongBan]) VALUES (2, N'Kinh doanh', N'0235413694', N'Phòng chỉ đạo các hoạt động nghiên cứu và phát triển các loại sản phẩm của công ty')
INSERT [dbo].[PhongBan] ([id_PhongBan], [ten_PhongBan], [sdt_PhongBan], [mota_PhongBan]) VALUES (3, N'Kế toán', N'0292565566', N'Phòng quản lý, thanh toán lương nhân viên, tài sản công ty ')
INSERT [dbo].[PhongBan] ([id_PhongBan], [ten_PhongBan], [sdt_PhongBan], [mota_PhongBan]) VALUES (4, N'Kỹ Thuật', N'0298467788', N'Phòng xây dựng và duy trì các cấu trúc, máy móc, thiết bị, hệ thống công ty')
SET IDENTITY_INSERT [dbo].[PhongBan] OFF
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD  CONSTRAINT [FK_Login_NhanVien] FOREIGN KEY([id_NhanVien])
REFERENCES [dbo].[NhanVien] ([id_NhanVien])
GO
ALTER TABLE [dbo].[Login] CHECK CONSTRAINT [FK_Login_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhongBan] FOREIGN KEY([id_PhongBan])
REFERENCES [dbo].[PhongBan] ([id_PhongBan])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhongBan]
GO
/****** Object:  StoredProcedure [dbo].[delete_NhanVien]    Script Date: 14/3/2022 12:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[delete_NhanVien]
	@idNV INT
AS
BEGIN
    UPDATE dbo.Login
	SET id_NhanVien = NULL
	WHERE id_NhanVien = @idNV

	DELETE dbo.NhanVien
	WHERE id_NhanVien = @idNV
END
GO
/****** Object:  StoredProcedure [dbo].[delete_PhongBan]    Script Date: 14/3/2022 12:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[delete_PhongBan]
	@idPB INT
AS
BEGIN
    UPDATE dbo.NhanVien
	SET id_PhongBan = NULL
	WHERE id_PhongBan = @idPB

	DELETE dbo.PhongBan
	WHERE id_PhongBan = @idPB
END
GO
/****** Object:  StoredProcedure [dbo].[getNhanVien]    Script Date: 14/3/2022 12:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

---- store procedure NHANVIEN ----

CREATE PROCEDURE [dbo].[getNhanVien]
AS
BEGIN
	SELECT * FROM dbo.NhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[getPhongBan]    Script Date: 14/3/2022 12:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

---- store procedure PhongBan ----
CREATE PROCEDURE [dbo].[getPhongBan]
AS
BEGIN
	SELECT * FROM dbo.PhongBan
END
GO
/****** Object:  StoredProcedure [dbo].[getUser]    Script Date: 14/3/2022 12:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

---- store procedure Login ----
CREATE PROCEDURE [dbo].[getUser]
AS
BEGIN
    SELECT * FROM dbo.Login
END
GO
/****** Object:  StoredProcedure [dbo].[insertNhanVien]    Script Date: 14/3/2022 12:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[insertNhanVien]
	@tenNV NVARCHAR(100),
	@gioitinhNV NVARCHAR(4),
	@ngaySinhNV DATE,
	@diachiNV NVARCHAR(200),
	@sdtNV NCHAR(10),
	@luong_NV INT,
	@idPB INT
AS
BEGIN
    INSERT INTO dbo.NhanVien
	(
		ten_NhanVien, 
		gioitinh_NhanVien,
		ngaysinh_NhanVien, 
		diachi_NhanVien,
		sdt_NhanVien,
		luong_NhanVien, 
		id_PhongBan
	)
	VALUES 
	(
		@tenNV,
		@gioitinhNV,
		@ngaySinhNV,
		@diachiNV,
		@sdtNV,
		@luong_NV,
		@idPB
	)
END
GO
/****** Object:  StoredProcedure [dbo].[insertPhongBan]    Script Date: 14/3/2022 12:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[insertPhongBan]
	@tenPB NVARCHAR(50),
	@sdtPB NCHAR(10),
	@motaPB NVARCHAR(200)
AS
BEGIN
    INSERT INTO dbo.PhongBan
	(
		ten_PhongBan, 
		sdt_PhongBan,
		mota_PhongBan 
	)
	VALUES 
	(
		@tenPB,
		@sdtPB,
		@motaPB
	)
END
GO
/****** Object:  StoredProcedure [dbo].[insertUser]    Script Date: 14/3/2022 12:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertUser]
	@username NVARCHAR(50),
	@password NCHAR(10),
	@idNhanVien INT
AS
BEGIN
    INSERT INTO dbo.Login
    (
        username,
        password,
        id_NhanVien
    )
    VALUES
    (   @username,
		@password,
		@idNhanVien
    )
END
GO
/****** Object:  StoredProcedure [dbo].[search_NhanVien]    Script Date: 14/3/2022 12:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[search_NhanVien]
	@searchString NVARCHAR(200)
AS
BEGIN
    SELECT *
	FROM dbo.NhanVien
	WHERE id_NhanVien LIKE N'%' + @searchString + '%'
	   OR ten_NhanVien LIKE N'%' + @searchString + '%'
	   OR ngaysinh_NhanVien LIKE N'%' + @searchString + '%'
	   OR diachi_NhanVien LIKE N'%' + @searchString + '%'
	   OR sdt_NhanVien LIKE N'%' + @searchString + '%'
	   OR luong_NhanVien LIKE N'%' + @searchString + '%'
	   OR id_PhongBan LIKE N'%' + @searchString + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[search_PhongBan]    Script Date: 14/3/2022 12:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[search_PhongBan]
	@searchString NVARCHAR(200)
AS
BEGIN
    SELECT *
	FROM dbo.PhongBan
	WHERE id_PhongBan LIKE N'%' + @searchString + '%'
	   OR ten_PhongBan LIKE N'%' + @searchString + '%'
	   OR sdt_PhongBan LIKE N'%' + @searchString + '%'
	   OR mota_PhongBan LIKE N'%' + @searchString + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[update_NhanVien]    Script Date: 14/3/2022 12:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[update_NhanVien]
	@idNV INT,
	@gioitinhNV NVARCHAR(4),
	@tenNV NVARCHAR(100),
	@ngaysinhNV DATE,
	@diachiNV NVARCHAR(200),
	@sdtNV NCHAR(10),
	@luongNV INT,
	@idPB INT
AS
BEGIN
    UPDATE dbo.NhanVien
	SET 
		ten_NhanVien = @tenNV,
		gioitinh_NhanVien = @gioitinhNV,
		ngaysinh_NhanVien = @ngaysinhNV,
		diachi_NhanVien = @diachiNV,
		sdt_NhanVien = @sdtNV,
		luong_NhanVien = @luongNV,
		id_PhongBan = @idPB
	WHERE id_NhanVien = @idNV
END
GO
/****** Object:  StoredProcedure [dbo].[update_PhongBan]    Script Date: 14/3/2022 12:15:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[update_PhongBan]
	@idPB INT,
	@tenPB NVARCHAR(50),
	@sdtPB NCHAR(10),
	@motaPB NVARCHAR(200)
AS
BEGIN
    UPDATE dbo.PhongBan
	SET 
		ten_PhongBan = @tenPB,
		sdt_PhongBan = @sdtPB,
		mota_PhongBan = @motaPB
	WHERE id_PhongBan = @idPB
END
GO
USE [master]
GO
ALTER DATABASE [QuanLyNhanSu] SET  READ_WRITE 
GO
