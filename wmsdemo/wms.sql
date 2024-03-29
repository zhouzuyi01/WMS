CREATE DATABASE WMS

USE [WMS]
GO
/****** Object:  Table [dbo].[tb_area]    Script Date: 2019/07/09 14:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_area](
	[AreaCode] [nvarchar](max) NOT NULL,
	[AreaName] [nvarchar](max) NOT NULL,
	[WareCode] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_area_materiel]    Script Date: 2019/07/09 14:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_area_materiel](
	[AreaCode] [nvarchar](max) NOT NULL,
	[MaterielCode] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_area_point]    Script Date: 2019/07/09 14:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_area_point](
	[AreaCode] [nvarchar](max) NOT NULL,
	[PointCode] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_container]    Script Date: 2019/07/09 14:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_container](
	[ContainerCode] [nvarchar](max) NOT NULL,
	[MaterielCode] [nvarchar](max) NOT NULL,
	[Capacity] [numeric](18, 4) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_materiel]    Script Date: 2019/07/09 14:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_materiel](
	[MaterielCode] [nvarchar](max) NOT NULL,
	[MaterielName] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_materiel_property]    Script Date: 2019/07/09 14:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_materiel_property](
	[MaterielCode] [nvarchar](max) NOT NULL,
	[PropertyName] [nvarchar](max) NOT NULL,
	[PropertyValue] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_point]    Script Date: 2019/07/09 14:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_point](
	[PointCode] [nvarchar](max) NOT NULL,
	[WareCode] [nvarchar](max) NOT NULL,
	[PointState] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_point_container]    Script Date: 2019/07/09 14:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_point_container](
	[PointCode] [nvarchar](max) NOT NULL,
	[ContainerCode] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_ware]    Script Date: 2019/07/09 14:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_ware](
	[WareCode] [nvarchar](max) NOT NULL,
	[WareName] [nvarchar](max) NOT NULL,
	[Enable] [bit] NOT NULL,
	[RowCount] [int] NOT NULL,
	[ColumnCount] [int] NOT NULL,
	[LayerCount] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tb_ware] ADD  DEFAULT ((1)) FOR [Enable]
GO
