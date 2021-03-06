USE [master]
GO
/****** Object:  Database [WebXe]    Script Date: 14/11/2020 1:12:33 SA ******/
CREATE DATABASE [WebXe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WebXe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\WebXe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WebXe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\WebXe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [WebXe] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WebXe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WebXe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WebXe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WebXe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WebXe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WebXe] SET ARITHABORT OFF 
GO
ALTER DATABASE [WebXe] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [WebXe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WebXe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WebXe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WebXe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WebXe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WebXe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WebXe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WebXe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WebXe] SET  ENABLE_BROKER 
GO
ALTER DATABASE [WebXe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WebXe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WebXe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WebXe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WebXe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WebXe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WebXe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WebXe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WebXe] SET  MULTI_USER 
GO
ALTER DATABASE [WebXe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WebXe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WebXe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WebXe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WebXe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WebXe] SET QUERY_STORE = OFF
GO
USE [WebXe]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](200) NOT NULL,
	[displayname] [nvarchar](200) NOT NULL,
	[password] [nvarchar](200) NOT NULL,
	[phone] [char](10) NULL,
	[address] [nvarchar](200) NULL,
	[email] [nvarchar](200) NULL,
	[thunbar] [nvarchar](200) NULL,
	[type_account] [nvarchar](200) NOT NULL,
	[date_created] [date] NOT NULL,
	[date_update] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarManufacturer]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarManufacturer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](200) NOT NULL,
	[thunbar] [nvarchar](200) NOT NULL,
	[date_created] [date] NOT NULL,
	[date_update] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](200) NOT NULL,
	[date_created] [date] NOT NULL,
	[date_update] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Color]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Color](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](200) NOT NULL,
	[date_created] [date] NOT NULL,
	[date_update] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](200) NOT NULL,
	[email] [nvarchar](200) NOT NULL,
	[phone] [char](10) NULL,
	[note] [nvarchar](max) NULL,
	[date_created] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CylinderCapacity]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CylinderCapacity](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](200) NOT NULL,
	[date_created] [date] NOT NULL,
	[date_update] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feedback]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedback](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_User] [int] NOT NULL,
	[id_Product] [int] NOT NULL,
	[star] [int] NOT NULL,
	[note] [nvarchar](max) NULL,
	[date_created] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[News]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[News](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](200) NOT NULL,
	[content] [nvarchar](max) NULL,
	[thunbar] [nvarchar](200) NULL,
	[date_created] [date] NOT NULL,
	[date_update] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_User] [int] NOT NULL,
	[status] [int] NULL,
	[amount] [float] NOT NULL,
	[note] [nvarchar](max) NULL,
	[date_created] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdersDetails]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersDetails](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Bill] [int] NOT NULL,
	[id_Product] [int] NOT NULL,
	[price] [float] NOT NULL,
	[qty] [int] NOT NULL,
	[date_created] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](200) NOT NULL,
	[price] [float] NOT NULL,
	[sale] [float] NULL,
	[number] [int] NOT NULL,
	[information] [nvarchar](max) NOT NULL,
	[viewproduct] [int] NULL,
	[imagemain] [nvarchar](200) NOT NULL,
	[imagechild1] [nvarchar](200) NULL,
	[imagechild2] [nvarchar](200) NULL,
	[imagechild3] [nvarchar](200) NULL,
	[id_CarManufacturer] [int] NOT NULL,
	[id_Category] [int] NOT NULL,
	[id_CylinderCapacity] [int] NOT NULL,
	[id_Color] [int] NOT NULL,
	[date_created] [date] NOT NULL,
	[date_update] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaticPage]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaticPage](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](200) NOT NULL,
	[content] [nvarchar](max) NOT NULL,
	[thunbar] [nvarchar](200) NULL,
	[date_created] [date] NOT NULL,
	[date_update] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](200) NOT NULL,
	[displayname] [nvarchar](max) NOT NULL,
	[thunbar] [nvarchar](200) NULL,
	[email] [nvarchar](200) NOT NULL,
	[address] [nvarchar](200) NULL,
	[date_created] [date] NOT NULL,
	[date_update] [date] NULL,
	[phone] [char](10) NULL,
	[password] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([id], [name], [displayname], [password], [phone], [address], [email], [thunbar], [type_account], [date_created], [date_update]) VALUES (1, N'admin', N'Nguyễn Bình', N'21232f297a57a5a743894a0e4a801fc3', N'0334679170', N'Cầu Giấy - Hà Nội ', N'nguyenbinhltv@gmail.com', N'/Data/images/Admin/avatar.png', N'ADMIN', CAST(N'2020-10-31' AS Date), CAST(N'2020-11-04' AS Date))
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[CarManufacturer] ON 

INSERT [dbo].[CarManufacturer] ([id], [name], [thunbar], [date_created], [date_update]) VALUES (1, N'KTM', N'/Data/images/HangXe/img9.png', CAST(N'2020-11-01' AS Date), CAST(N'2020-11-01' AS Date))
INSERT [dbo].[CarManufacturer] ([id], [name], [thunbar], [date_created], [date_update]) VALUES (2, N'BENTLEY', N'/Data/images/HangXe/img6.jpg', CAST(N'2020-11-01' AS Date), NULL)
INSERT [dbo].[CarManufacturer] ([id], [name], [thunbar], [date_created], [date_update]) VALUES (3, N'SUZUKI', N'/Data/images/HangXe/img3.jpg', CAST(N'2020-11-01' AS Date), NULL)
INSERT [dbo].[CarManufacturer] ([id], [name], [thunbar], [date_created], [date_update]) VALUES (4, N'HONDA', N'/Data/images/HangXe/img2.jpg', CAST(N'2020-11-01' AS Date), NULL)
INSERT [dbo].[CarManufacturer] ([id], [name], [thunbar], [date_created], [date_update]) VALUES (5, N'KAWASAKI', N'/Data/images/HangXe/img4.jpg', CAST(N'2020-11-01' AS Date), NULL)
INSERT [dbo].[CarManufacturer] ([id], [name], [thunbar], [date_created], [date_update]) VALUES (6, N'BMW', N'/Data/images/HangXe/img8.jpg', CAST(N'2020-11-01' AS Date), NULL)
INSERT [dbo].[CarManufacturer] ([id], [name], [thunbar], [date_created], [date_update]) VALUES (7, N'DUCATI', N'/Data/images/HangXe/img5.jpg', CAST(N'2020-11-01' AS Date), NULL)
INSERT [dbo].[CarManufacturer] ([id], [name], [thunbar], [date_created], [date_update]) VALUES (8, N'YAMAHA', N'/Data/images/HangXe/img7.jpg', CAST(N'2020-11-01' AS Date), NULL)
INSERT [dbo].[CarManufacturer] ([id], [name], [thunbar], [date_created], [date_update]) VALUES (9, N'PHOENIX', N'/Data/images/HangXe/img.jpg', CAST(N'2020-11-01' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[CarManufacturer] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([id], [name], [date_created], [date_update]) VALUES (1, N'Xe ga', CAST(N'2020-11-01' AS Date), CAST(N'2020-11-04' AS Date))
INSERT [dbo].[Category] ([id], [name], [date_created], [date_update]) VALUES (2, N'Xe số', CAST(N'2020-11-01' AS Date), NULL)
INSERT [dbo].[Category] ([id], [name], [date_created], [date_update]) VALUES (4, N'Xe sport ', CAST(N'2020-11-01' AS Date), NULL)
INSERT [dbo].[Category] ([id], [name], [date_created], [date_update]) VALUES (5, N'Xe thể thao', CAST(N'2020-11-12' AS Date), NULL)
INSERT [dbo].[Category] ([id], [name], [date_created], [date_update]) VALUES (6, N'Xe superbike', CAST(N'2020-11-12' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Color] ON 

INSERT [dbo].[Color] ([id], [name], [date_created], [date_update]) VALUES (2, N'Đen nhám', CAST(N'2020-11-01' AS Date), NULL)
INSERT [dbo].[Color] ([id], [name], [date_created], [date_update]) VALUES (3, N'Trắng xanh', CAST(N'2020-11-01' AS Date), CAST(N'2020-11-12' AS Date))
INSERT [dbo].[Color] ([id], [name], [date_created], [date_update]) VALUES (4, N'Đỏ Grand Fix', CAST(N'2020-11-01' AS Date), NULL)
INSERT [dbo].[Color] ([id], [name], [date_created], [date_update]) VALUES (6, N'Đỏ đe', CAST(N'2020-11-01' AS Date), CAST(N'2020-11-04' AS Date))
INSERT [dbo].[Color] ([id], [name], [date_created], [date_update]) VALUES (7, N'Đen bóng', CAST(N'2020-11-12' AS Date), NULL)
INSERT [dbo].[Color] ([id], [name], [date_created], [date_update]) VALUES (8, N'Xanh nước biển', CAST(N'2020-11-12' AS Date), NULL)
INSERT [dbo].[Color] ([id], [name], [date_created], [date_update]) VALUES (9, N'Trắng cam', CAST(N'2020-11-12' AS Date), NULL)
INSERT [dbo].[Color] ([id], [name], [date_created], [date_update]) VALUES (10, N'Trắng', CAST(N'2020-11-13' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[Color] OFF
GO
SET IDENTITY_INSERT [dbo].[Contact] ON 

INSERT [dbo].[Contact] ([id], [name], [email], [phone], [note], [date_created]) VALUES (1, N'Nguyễn Khắc Bình', N'admin@gmail.com', N'0123456789', N'aaaaa', CAST(N'2020-11-01' AS Date))
SET IDENTITY_INSERT [dbo].[Contact] OFF
GO
SET IDENTITY_INSERT [dbo].[CylinderCapacity] ON 

INSERT [dbo].[CylinderCapacity] ([id], [name], [date_created], [date_update]) VALUES (1, N'120cc ', CAST(N'2020-11-01' AS Date), CAST(N'2020-11-04' AS Date))
INSERT [dbo].[CylinderCapacity] ([id], [name], [date_created], [date_update]) VALUES (2, N'650cc', CAST(N'2020-11-01' AS Date), NULL)
INSERT [dbo].[CylinderCapacity] ([id], [name], [date_created], [date_update]) VALUES (3, N'1000cc', CAST(N'2020-11-01' AS Date), NULL)
INSERT [dbo].[CylinderCapacity] ([id], [name], [date_created], [date_update]) VALUES (4, N'300cc', CAST(N'2020-11-13' AS Date), NULL)
INSERT [dbo].[CylinderCapacity] ([id], [name], [date_created], [date_update]) VALUES (5, N'1334cm3', CAST(N'2020-11-13' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[CylinderCapacity] OFF
GO
SET IDENTITY_INSERT [dbo].[News] ON 

INSERT [dbo].[News] ([id], [name], [content], [thunbar], [date_created], [date_update]) VALUES (1, N'Chính sách bảo hành', N'<p>Ch&iacute;nh s&aacute;ch đ&atilde; c&oacute; sự phang nhau </p>
', N'/Data/images/Chinhsach/Screenshot%20(33).png', CAST(N'2020-11-05' AS Date), NULL)
INSERT [dbo].[News] ([id], [name], [content], [thunbar], [date_created], [date_update]) VALUES (2, N'Macbook', N'<p>&aacute;dasdadsas</p>
', N'/Data/images/Chinhsach/Screenshot%20(33).png', CAST(N'2020-11-05' AS Date), NULL)
INSERT [dbo].[News] ([id], [name], [content], [thunbar], [date_created], [date_update]) VALUES (3, N'XE CÔN TAY', N'<p>sdfghjkl</p>
', N'/Data/images/Chinhsach/Screenshot%20(33).png', CAST(N'2020-11-05' AS Date), NULL)
INSERT [dbo].[News] ([id], [name], [content], [thunbar], [date_created], [date_update]) VALUES (4, N'DUCATI', N'<p>sadfghgjhkjewretyuiopouiyuytrfdxzxcvcbnbmnnbvxsaewretrytuyiu</p>
', N'/Data/images/Chinhsach/Screenshot%20(33).png', CAST(N'2020-11-05' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[News] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([id], [name], [price], [sale], [number], [information], [viewproduct], [imagemain], [imagechild1], [imagechild2], [imagechild3], [id_CarManufacturer], [id_Category], [id_CylinderCapacity], [id_Color], [date_created], [date_update]) VALUES (1, N'CBR 1000RR SP2', 790000000, NULL, 5, N'<table border="0" cellpadding="1" cellspacing="0" style="width:880px">
	<tbody>
		<tr>
			<td colspan="2"><span style="font-size:18px"><span style="font-family:arial,helvetica,sans-serif"><span style="color:#FF0000"><strong>ĐỘNG CƠ</strong></span></span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Động cơ</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">4 xi lanh thẳng h&agrave;ng, 16 van (DOHC) l&agrave;m m&aacute;t bằng chất lỏng, Euro4</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Dung t&iacute;ch xi lanh</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">999 cc</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Đường k&iacute;nh x h&agrave;nh tr&igrave;nh piston</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">76 x 55 mm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Tỷ lệ n&eacute;n</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">13:1</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>C&ocirc;ng suất cực đại</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">NĐ</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>M&ocirc;-men xoắn cực đại</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">NĐ</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Hệ thống nhi&ecirc;n liệu</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Thiết bị phun nhi&ecirc;n liệu điều khiển điện tử PGM-DSFI</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Đ&aacute;nh lửa</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Đ&aacute;nh lửa điện</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Truyền tải</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">6 tốc độ, trở lại ca</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Ổ đĩa cuối c&ugrave;ng</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Chuỗi k&iacute;n</span></span></td>
		</tr>
		<tr>
			<td colspan="2"><span style="font-size:18px"><span style="font-family:arial,helvetica,sans-serif"><span style="color:#FF0000"><strong>HIỆU SUẤT</strong></span></span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Hệ thống treo trước / b&aacute;nh</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">&Ouml;hlins loại ng&atilde; ba lộn ngược 43 mm NIX30 với Điều khiển điện tử b&aacute;n chủ động (S-EC) để tải trước, điều chỉnh n&eacute;n v&agrave; mở rộng, h&agrave;nh tr&igrave;nh 120 mm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Hệ thống treo sau / b&aacute;nh</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">&Ouml;hlins TTX36 với kiến ​​tr&uacute;c Pro-Link v&agrave; Semi-Active Electronic Control (S-EC) để điều chỉnh tải trước, n&eacute;n, mở rộng, h&agrave;nh tr&igrave;nh 60 mm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Lốp trước</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">120 / 70ZR17 58W</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Lốp sau</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">190 / 50ZR17 73W</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Phanh trước</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Đĩa Đĩa đ&ocirc;i 320 x 4,5 mm với bộ c&acirc;n bằng 4 piston Brembo v&agrave; miếng đệm đặc biệt, ABS</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Phanh sau</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Đĩa 220 x 5 mm với caliper piston đơn v&agrave; miếng đệm kim loại thi&ecirc;u kết, ABS</span></span></td>
		</tr>
		<tr>
			<td colspan="2"><span style="font-size:18px"><span style="font-family:arial,helvetica,sans-serif"><span style="color:#FF0000"><strong>CHI TIẾT</strong></span></span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Loại khung</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Một vi&ecirc;n kim cương; với dầm nh&ocirc;m đ&ocirc;i</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Treo khung</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">23 ° 30 &#39; mm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Tổng chiều d&agrave;i</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">2.065 mm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Chiều rộng tổng thể</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">715 mm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Chiều cao tổng thể</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">1.125 mm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>&Aacute;nh s&aacute;ng gầm</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">129 mm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Chiều cao y&ecirc;n ngồi</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">820 mm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Khối lượng kh&ocirc;</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">NĐ</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Lượng nhi&ecirc;n liệu</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">16 l&iacute;t</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Chiều d&agrave;i cơ sở</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">1.404 mm mm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Lựa chọn m&agrave;u sắc</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Đỏ Grand Fix</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Bảo h&agrave;nh</strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">12 th&aacute;ng</span></span></td>
		</tr>
	</tbody>
</table>

<p> </p>
', NULL, N'/Data/images/Xe/cbr1000rr-sp.jpg', N'/Data/images/anhcon1/cbr1000rr-sp1.jpg', N'/Data/images/anhcon2/cbr1000rr-sp2.jpg', N'/Data/images/anhcon3/cbr1000rr-sp22746(1).jpg', 4, 4, 3, 4, CAST(N'2020-11-01' AS Date), CAST(N'2020-11-04' AS Date))
INSERT [dbo].[Product] ([id], [name], [price], [sale], [number], [information], [viewproduct], [imagemain], [imagechild1], [imagechild2], [imagechild3], [id_CarManufacturer], [id_Category], [id_CylinderCapacity], [id_Color], [date_created], [date_update]) VALUES (2, N'DUCATI 1299 PANIGALE', 1265000000, NULL, 10, N'<table border="0" cellpadding="0" cellspacing="0" style="width:800px">
	<tbody>
		<tr>
			<td><strong><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">D&agrave;i x Rộng x Cao:</span></span></strong></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">2075 x 810 x 1100 (mm)</span></span></td>
		</tr>
		<tr>
			<td><strong><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Dung t&iacute;ch xy-lanh:</span></span></strong></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">1285cc</span></span></td>
		</tr>
		<tr>
			<td><strong><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Hộp số:</span></span></strong></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">6 Cấp</span></span></td>
		</tr>
		<tr>
			<td><strong><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Độ cao y&ecirc;n:</span></span></strong></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">825mm</span></span></td>
		</tr>
		<tr>
			<td><strong><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Loại động cơ:</span></span></strong></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Superquadro L-Twin, 4 Desmodromically actuated valves per cylinder, liquid cooled</span></span></td>
		</tr>
		<tr>
			<td><strong><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Cỡ lốp trước/sau:</span></span></strong></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">120/70 ZR17 Pirelli Diablo Supercorsa SP / 200/55 ZR17 Pirelli Diablo Supercorsa SP</span></span></td>
		</tr>
		<tr>
			<td><strong><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">C&ocirc;ng suất tối đa:</span></span></strong></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">150,8 kW (205 hp) @ 10,500 rpm</span></span></td>
		</tr>
		<tr>
			<td><strong><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Tỷ số n&eacute;n:</span></span></strong></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">12.6:1</span></span></td>
		</tr>
		<tr>
			<td><strong><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Phuộc trước:</span></span></strong></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">USD fork 50 mm</span></span></td>
		</tr>
		<tr>
			<td><strong><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Trọng lượng bản th&acirc;n:</span></span></strong></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">166.5 Kg</span></span></td>
		</tr>
	</tbody>
</table>

<p> </p>
', NULL, N'/Data/images/Xe/DUCATI%201299%20PANIGALE.jpg', NULL, NULL, NULL, 7, 5, 3, 6, CAST(N'2020-11-09' AS Date), CAST(N'2020-11-12' AS Date))
INSERT [dbo].[Product] ([id], [name], [price], [sale], [number], [information], [viewproduct], [imagemain], [imagechild1], [imagechild2], [imagechild3], [id_CarManufacturer], [id_Category], [id_CylinderCapacity], [id_Color], [date_created], [date_update]) VALUES (3, N'KAWASAKI NINJA H2', 1050000000, NULL, 10, N'<table border="0" cellpadding="0" cellspacing="0" style="width:800px">
	<tbody>
		<tr>
			<td><span style="font-family:arial,helvetica,sans-serif"><span style="font-size:14px"><strong>Hệ thống cung cấp nhi&ecirc;n liệu:</strong></span></span></td>
			<td><span style="font-family:arial,helvetica,sans-serif"><span style="font-size:14px">Phun xăng điện tử</span></span></td>
		</tr>
		<tr>
			<td><span style="font-family:arial,helvetica,sans-serif"><span style="font-size:14px"><strong>Dung t&iacute;ch xy-lanh:</strong></span></span></td>
			<td><span style="font-family:arial,helvetica,sans-serif"><span style="font-size:14px">998 cm<sup>3</sup></span></span></td>
		</tr>
		<tr>
			<td><span style="font-family:arial,helvetica,sans-serif"><span style="font-size:14px"><strong>D&agrave;i x Rộng x Cao:</strong></span></span></td>
			<td><span style="font-family:arial,helvetica,sans-serif"><span style="font-size:14px">2085mm x 770mm x1125mm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-family:arial,helvetica,sans-serif"><span style="font-size:14px"><strong>Loại động cơ:</strong></span></span></td>
			<td><span style="font-family:arial,helvetica,sans-serif"><span style="font-size:14px">Si&ecirc;u tăng &aacute;p, dung t&iacute;ch 998 cc, sản sinh 203 m&atilde; lực tại tốc độ tua m&aacute;y 11.000 v&ograve;ng/ph&uacute;t</span></span></td>
		</tr>
		<tr>
			<td><span style="font-family:arial,helvetica,sans-serif"><span style="font-size:14px"><strong>Độ cao y&ecirc;n:</strong></span></span></td>
			<td><span style="font-family:arial,helvetica,sans-serif"><span style="font-size:14px">830mm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-family:arial,helvetica,sans-serif"><span style="font-size:14px"><strong>C&ocirc;ng suất tối đa:</strong></span></span></td>
			<td><span style="font-family:arial,helvetica,sans-serif"><span style="font-size:14px">207 hp c&oacute; Ram Air v&agrave; 197 ko c&oacute; Ram Air</span></span></td>
		</tr>
		<tr>
			<td><span style="font-family:arial,helvetica,sans-serif"><span style="font-size:14px"><strong>Cỡ lốp trước/sau:</strong></span></span></td>
			<td><span style="font-family:arial,helvetica,sans-serif"><span style="font-size:14px">120/70 ZR 17 / 200/55 ZR17</span></span></td>
		</tr>
		<tr>
			<td><span style="font-family:arial,helvetica,sans-serif"><span style="font-size:14px"><strong>Phanh trước/sau:</strong></span></span></td>
			<td>
			<p><span style="font-family:arial,helvetica,sans-serif"><span style="font-size:14px">Phanh đĩa đ&ocirc;i trước 330mm phanh Brembo</span></span></p>

			<p><span style="font-family:arial,helvetica,sans-serif"><span style="font-size:14px">Sau đường k&iacute;nh 230 c&ugrave;ng kẹp phanh hiệu Brembo</span></span></p>
			</td>
		</tr>
		<tr>
			<td><span style="font-family:arial,helvetica,sans-serif"><span style="font-size:14px"><strong>Dung t&iacute;ch b&igrave;nh xăng:</strong></span></span></td>
			<td><span style="font-family:arial,helvetica,sans-serif"><span style="font-size:14px">17 l&iacute;t</span></span></td>
		</tr>
	</tbody>
</table>

<p> </p>
', NULL, N'/Data/images/Xe/NINJA%20H2.png', NULL, NULL, NULL, 5, 4, 3, 2, CAST(N'2020-11-12' AS Date), CAST(N'2020-11-13' AS Date))
INSERT [dbo].[Product] ([id], [name], [price], [sale], [number], [information], [viewproduct], [imagemain], [imagechild1], [imagechild2], [imagechild3], [id_CarManufacturer], [id_Category], [id_CylinderCapacity], [id_Color], [date_created], [date_update]) VALUES (4, N'BMW S1000RR 2020', 1000516000, NULL, 10, N'<table border="0" cellpadding="0" cellspacing="0" style="width:800px">
	<tbody>
		<tr>
			<td><strong><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">D&agrave;i x Rộng x Cao :</span></span></strong></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">2073mm x 848mm x 1151mm</span></span></td>
		</tr>
		<tr>
			<td><strong><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Độ cao y&ecirc;n :</span></span></strong></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">824 mm</span></span></td>
		</tr>
		<tr>
			<td><strong><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Cỡ lốp trước/sau :</span></span></strong></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">120/70 ZR 17 ; 190/55 ZR 17</span></span></td>
		</tr>
		<tr>
			<td><strong><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Loại động cơ :</span></span></strong></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">BMW ShiftCam 4 th&igrave;, 4 xilanh, dung t&iacute;ch 999cc</span></span></td>
		</tr>
		<tr>
			<td><strong><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Dung t&iacute;ch xy-lanh :</span></span></strong></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">999 cc</span></span></td>
		</tr>
		<tr>
			<td><strong><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">C&ocirc;ng suất tối đa :</span></span></strong></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">207 m&atilde; lực tại 13.500 v&ograve;ng/ph&uacute;t</span></span></td>
		</tr>
		<tr>
			<td><strong><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Hộp số :</span></span></strong></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">6 cấp</span></span></td>
		</tr>
		<tr>
			<td><strong><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Hệ thống cung cấp nhi&ecirc;n liệu:</span></span></strong></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Phun xăng điện tử</span></span></td>
		</tr>
		<tr>
			<td><strong><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Phanh trước/sau:</span></span></strong></td>
			<td>
			<p><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Twin disc brake, floating brake calipers, 4-piston fixed caliper, diameter 320 mm </span></span></p>

			<p><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Single disc brake, single piston floating caliper, diameter 220 mm</span></span></p>
			</td>
		</tr>
	</tbody>
</table>

<p> </p>
', NULL, N'/Data/images/Xe/S1000RR%2020201.jpg', NULL, NULL, NULL, 6, 4, 3, 3, CAST(N'2020-11-12' AS Date), CAST(N'2020-11-12' AS Date))
INSERT [dbo].[Product] ([id], [name], [price], [sale], [number], [information], [viewproduct], [imagemain], [imagechild1], [imagechild2], [imagechild3], [id_CarManufacturer], [id_Category], [id_CylinderCapacity], [id_Color], [date_created], [date_update]) VALUES (5, N'YAMAHA R1 2020', 769516000, NULL, 10, N'<table border="0" cellpadding="0" cellspacing="0" style="width:800px">
	<tbody>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Hộp số : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">6 Cấp</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Dung t&iacute;ch xy-lanh : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">988cc</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Độ cao y&ecirc;n : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">855 mm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Loại động cơ : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">4 th&igrave;, DOHC, 4 xy-lanh</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>C&ocirc;ng suất tối đa :</strong> </span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">147,1 m&atilde; lực (200Ps) @ 13,500 v&ograve;ng/ ph&uacute;t</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Cỡ lốp trước/sau : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">120/70 ZR17M / C (58W) - 190/55 ZR17M / C (75W)</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>D&agrave;i x Rộng x Cao : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">2.055 x 690 x 1.150 mm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Phanh trước/sau: </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Đĩa thủy lực k&eacute;p, &Oslash; 320 mm;Đĩa đơn thủy lực, &Oslash; 220 mm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Tỷ số n&eacute;n : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">13:1</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Dung t&iacute;ch b&igrave;nh xăng : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">17 L&iacute;t</span></span></td>
		</tr>
	</tbody>
</table>

<p> </p>
', NULL, N'/Data/images/Xe/yamaha-r1-1.jpg', NULL, NULL, NULL, 8, 5, 3, 8, CAST(N'2020-11-12' AS Date), NULL)
INSERT [dbo].[Product] ([id], [name], [price], [sale], [number], [information], [viewproduct], [imagemain], [imagechild1], [imagechild2], [imagechild3], [id_CarManufacturer], [id_Category], [id_CylinderCapacity], [id_Color], [date_created], [date_update]) VALUES (6, N'KTM 1190 RC8R', 624000000, NULL, 10, N'<table border="0" cellpadding="0" cellspacing="0" style="width:800px">
	<tbody>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Dung t&iacute;ch xy-lanh : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">1,195 cm³</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Độ cao y&ecirc;n : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">805</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>C&ocirc;ng suất tối đa : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">129 kW (173 hp)</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Loại động cơ :</strong> </span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">2-cylinder, 4-stroke, spark-ignition engine, 75° V arrangement, liquid-cooled</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Phanh trước/sau: </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">320 mm, Phanh đĩa đ&ocirc;i, bốn piston;220 mm, Phanh đĩa đơn với hai piston</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Phuộc sau : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">WP Suspension Monoshock</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Trọng lượng bản th&acirc;n : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">184 kg</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Phuộc trước : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">WP Suspension Up Side Down</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Khoảng c&aacute;ch trục b&aacute;nh xe : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">1425 mm</span></span></td>
		</tr>
	</tbody>
</table>

<p> </p>
', NULL, N'/Data/images/Xe/KTM%201190%20RC8R.jpg', NULL, NULL, NULL, 1, 6, 1, 9, CAST(N'2020-11-12' AS Date), NULL)
INSERT [dbo].[Product] ([id], [name], [price], [sale], [number], [information], [viewproduct], [imagemain], [imagechild1], [imagechild2], [imagechild3], [id_CarManufacturer], [id_Category], [id_CylinderCapacity], [id_Color], [date_created], [date_update]) VALUES (7, N'BENELLI 302R 2017', 118306000, NULL, 10, N'<table border="0" cellpadding="0" cellspacing="0" style="width:800px">
	<tbody>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Loại động cơ : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">2 xylanh thẳng h&agrave;ng , 4 th&igrave; l&agrave;m m&aacute;t bằng chất lỏng, 4 van/xylanh, cam đ&ocirc;i DOHC, EFI</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Độ cao y&ecirc;n : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">790 mm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Cỡ lốp trước/sau : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">110/70-ZR17 150/60/17-ZR17</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>C&ocirc;ng suất tối đa : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">28kW @ 11000rpm (38hp)</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>D&agrave;i x Rộng x Cao : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">2.150mm * 745mm * 1.115mm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Hộp số : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">6 Cấp</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Dung t&iacute;ch xy-lanh : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">300cc</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Tỷ số n&eacute;n : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">12:1</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Phuộc trước : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Upsite-Down 41mm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Trọng lượng bản th&acirc;n : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">180 Kg</span></span></td>
		</tr>
	</tbody>
</table>

<p> </p>
', NULL, N'/Data/images/Xe/BENELLI%20302R.jpg', NULL, NULL, NULL, 2, 4, 4, 10, CAST(N'2020-11-13' AS Date), NULL)
INSERT [dbo].[Product] ([id], [name], [price], [sale], [number], [information], [viewproduct], [imagemain], [imagechild1], [imagechild2], [imagechild3], [id_CarManufacturer], [id_Category], [id_CylinderCapacity], [id_Color], [date_created], [date_update]) VALUES (8, N'HAYABUSA 1300', 644566000, NULL, 10, N'<table border="0" cellpadding="0" cellspacing="0" style="width:800px">
	<tbody>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Loại động cơ : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">4 thì, 4 xylanh, làm mát bằng dung dịch, DOHC</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Cỡ lốp trước/sau : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Trước: 120/70ZR-17M/C (58W), kh&ocirc;ng săm. Sau: 190/50ZR-17M/C (73W), kh&ocirc;ng săm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>D&agrave;i x Rộng x Cao : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">2190 x 735 x 1165 mm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Độ cao y&ecirc;n : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">805 mm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Dung t&iacute;ch xy-lanh : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">1340 cm<sup>3</sup></span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Phanh trước/sau: </strong></span></span></td>
			<td>
			<p><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Đĩa đ&ocirc;i </span></span></p>

			<p><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Đĩa</span></span></p>
			</td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Khoảng s&aacute;ng gầm xe :</strong> </span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">120mm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Đường k&iacute;nh x h&agrave;nh tr&igrave;nh p&iacute;t t&ocirc;ng :</strong> </span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">81 x 65 mm</span></span></td>
		</tr>
		<tr>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif"><strong>Phuộc sau : </strong></span></span></td>
			<td><span style="font-size:14px"><span style="font-family:arial,helvetica,sans-serif">Ki&ecirc;̉u li&ecirc;n k&ecirc;́t, lò xo trụ, giảm ch&acirc;́n d&acirc;̀u</span></span></td>
		</tr>
	</tbody>
</table>

<p> </p>
', NULL, N'/Data/images/Xe/Suzuki-GSX1300RHayabusaa.jpg', NULL, NULL, NULL, 3, 6, 5, 10, CAST(N'2020-11-13' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [name], [displayname], [thunbar], [email], [address], [date_created], [date_update], [phone], [password]) VALUES (3, N'admin', N'Nguyễn Bình', N'/UserImg/images/nhim.jpg', N'nguyenbinhdev@gmail.com', N'Hà Nội', CAST(N'2020-11-13' AS Date), CAST(N'2020-11-13' AS Date), N'0334679170', N'21232f297a57a5a743894a0e4a801fc3')
INSERT [dbo].[Users] ([id], [name], [displayname], [thunbar], [email], [address], [date_created], [date_update], [phone], [password]) VALUES (7, N'nguyenkhacbinh', N'Bình  Nguyễn', N'/UserImg/images/nhim.jpg', N'nguyenkhacbinh08032001@gmail.com', N'Hà Nội', CAST(N'2020-11-13' AS Date), CAST(N'2020-11-13' AS Date), N'0948563263', N'fa069380b993f2c7e4571ffd3d326f44')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (getdate()) FOR [date_update]
GO
ALTER TABLE [dbo].[CarManufacturer] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[CarManufacturer] ADD  DEFAULT (getdate()) FOR [date_update]
GO
ALTER TABLE [dbo].[Category] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[Category] ADD  DEFAULT (getdate()) FOR [date_update]
GO
ALTER TABLE [dbo].[Color] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[Color] ADD  DEFAULT (getdate()) FOR [date_update]
GO
ALTER TABLE [dbo].[Contact] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[CylinderCapacity] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[CylinderCapacity] ADD  DEFAULT (getdate()) FOR [date_update]
GO
ALTER TABLE [dbo].[Feedback] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[News] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[News] ADD  DEFAULT (getdate()) FOR [date_update]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[OrdersDetails] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[OrdersDetails] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[Product] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[Product] ADD  DEFAULT ((0)) FOR [sale]
GO
ALTER TABLE [dbo].[Product] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[Product] ADD  DEFAULT (getdate()) FOR [date_update]
GO
ALTER TABLE [dbo].[StaticPage] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[StaticPage] ADD  DEFAULT (getdate()) FOR [date_update]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (getdate()) FOR [date_update]
GO
ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD FOREIGN KEY([id_User])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD FOREIGN KEY([id_Product])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([id_User])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[OrdersDetails]  WITH CHECK ADD FOREIGN KEY([id_Bill])
REFERENCES [dbo].[Orders] ([id])
GO
ALTER TABLE [dbo].[OrdersDetails]  WITH CHECK ADD FOREIGN KEY([id_Product])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([id_CarManufacturer])
REFERENCES [dbo].[CarManufacturer] ([id])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([id_Category])
REFERENCES [dbo].[Category] ([id])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([id_Color])
REFERENCES [dbo].[Color] ([id])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([id_CylinderCapacity])
REFERENCES [dbo].[CylinderCapacity] ([id])
GO
/****** Object:  StoredProcedure [dbo].[Account_ListAll]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[Account_ListAll]
AS 
SELECT TOP(5) * FROM dbo.Account ORDER BY id DESC 

GO
/****** Object:  StoredProcedure [dbo].[Account_Login]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[Account_Login]
@username NVARCHAR(200), @password NVARCHAR(200)
AS
BEGIN
	DECLARE @count int 
	DECLARE @res bit 
	SELECT @count = COUNT(*) FROM dbo.Account WHERE name = @username and password = @password
	IF @count > 0
		SET @res = 1
	ELSE
		SET @res = 0

	SELECT @res
END

GO
/****** Object:  StoredProcedure [dbo].[CarManufacturer_ListAll]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[CarManufacturer_ListAll]
AS
	SELECT * FROM dbo.CarManufacturer ORDER BY id ASC

GO
/****** Object:  StoredProcedure [dbo].[Contact_ListAll]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Contact_ListAll]
AS 
	SELECT TOP(5) * FROM dbo.Contact ORDER BY id DESC

GO
/****** Object:  StoredProcedure [dbo].[Feedback_ListNew]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Feedback_ListNew]
AS
	SELECT TOP(5) * FROM dbo.Product ORDER BY id DESC

GO
/****** Object:  StoredProcedure [dbo].[FeedbackAdmin_List]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FeedbackAdmin_List]
AS
	SELECT TOP(5) * FROM dbo.Feedback ORDER BY id DESC

GO
/****** Object:  StoredProcedure [dbo].[News_ListAll]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[News_ListAll]
AS 
	SELECT TOP(8) * FROM dbo.News ORDER BY id DESC

GO
/****** Object:  StoredProcedure [dbo].[NewsAdmin_ListAll]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[NewsAdmin_ListAll]
AS 
	SELECT TOP(3) * FROM dbo.News ORDER BY id DESC

GO
/****** Object:  StoredProcedure [dbo].[Product_ListAll]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Product_ListAll]
AS 
	SELECT TOP(8) * FROM dbo.Product ORDER BY id ASC

GO
/****** Object:  StoredProcedure [dbo].[Product_ListNew]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Product_ListNew]
AS 
	SELECT TOP(7) * FROM dbo.Product ORDER BY id DESC

GO
/****** Object:  StoredProcedure [dbo].[Product_ListNewAd]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Product_ListNewAd]
AS 
	SELECT TOP(3) * FROM dbo.Product ORDER BY id DESC

GO
/****** Object:  StoredProcedure [dbo].[User_ListAll]    Script Date: 14/11/2020 1:12:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[User_ListAll]
AS 
	SELECT TOP(5) * FROM dbo.Users ORDER BY id DESC

GO
USE [master]
GO
ALTER DATABASE [WebXe] SET  READ_WRITE 
GO
