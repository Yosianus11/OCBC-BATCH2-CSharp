USE [BANK]
GO
/****** Object:  Table [dbo].[OFFICES]    Script Date: 11/24/2021 11:29:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OFFICES](
	[OFFICE_CODE] [varchar](10) NOT NULL,
	[CITY] [varchar](50) NULL,
	[PHONE] [varchar](15) NULL,
	[ADDERESS_LINE1] [varchar](25) NULL,
	[ADDERESS_LINE2] [varchar](25) NULL,
	[STATE] [varchar](25) NULL,
	[COUNTRY] [varchar](25) NULL,
	[POSTAL_CODE] [varchar](10) NULL,
	[TERRITORY] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[OFFICE_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[OFFICES] ([OFFICE_CODE], [CITY], [PHONE], [ADDERESS_LINE1], [ADDERESS_LINE2], [STATE], [COUNTRY], [POSTAL_CODE], [TERRITORY]) VALUES (N'OC001', N'Bandar Lampung', N'888', N'Bandar Lampung1', N'Bandar Lampung2', N'Bandar Lampung3', N'Indonesia', N'3456', N'abc')
INSERT [dbo].[OFFICES] ([OFFICE_CODE], [CITY], [PHONE], [ADDERESS_LINE1], [ADDERESS_LINE2], [STATE], [COUNTRY], [POSTAL_CODE], [TERRITORY]) VALUES (N'OC002', N'Jakarta', N'889', N'Jakarta', N'Jakarta2', N'Jakarta3', N'Indonesia', N'3457', N'abs')
INSERT [dbo].[OFFICES] ([OFFICE_CODE], [CITY], [PHONE], [ADDERESS_LINE1], [ADDERESS_LINE2], [STATE], [COUNTRY], [POSTAL_CODE], [TERRITORY]) VALUES (N'OC003', N'Bogor', N'890', N'Bogor', N'Bogor2', N'Bogor3', N'Indonesia', N'3458', N'abc')
INSERT [dbo].[OFFICES] ([OFFICE_CODE], [CITY], [PHONE], [ADDERESS_LINE1], [ADDERESS_LINE2], [STATE], [COUNTRY], [POSTAL_CODE], [TERRITORY]) VALUES (N'OC004', N'Tebet', N'891', N'Tebet', N'Tebet2', N'Tebet3', N'Indonesia', N'3459', N'abs')
INSERT [dbo].[OFFICES] ([OFFICE_CODE], [CITY], [PHONE], [ADDERESS_LINE1], [ADDERESS_LINE2], [STATE], [COUNTRY], [POSTAL_CODE], [TERRITORY]) VALUES (N'OC005', N'Bandung', N'892', N'Bandung', N'Bandung2', N'Bandung3', N'Indonesia', N'3460', N'abc')
INSERT [dbo].[OFFICES] ([OFFICE_CODE], [CITY], [PHONE], [ADDERESS_LINE1], [ADDERESS_LINE2], [STATE], [COUNTRY], [POSTAL_CODE], [TERRITORY]) VALUES (N'OC006', N'Yogyakarta', N'893', N'Yogyakarta', N'Yogyakarta2', N'Yogyakarta3', N'Indonesia', N'3461', N'abs')
INSERT [dbo].[OFFICES] ([OFFICE_CODE], [CITY], [PHONE], [ADDERESS_LINE1], [ADDERESS_LINE2], [STATE], [COUNTRY], [POSTAL_CODE], [TERRITORY]) VALUES (N'OC007', N'Bekasi', N'894', N'Bekasi', N'Bekasi2', N'Bekasi3', N'Indonesia', N'3462', N'abc')
INSERT [dbo].[OFFICES] ([OFFICE_CODE], [CITY], [PHONE], [ADDERESS_LINE1], [ADDERESS_LINE2], [STATE], [COUNTRY], [POSTAL_CODE], [TERRITORY]) VALUES (N'OC008', N'Tasik', N'895', N'Tasik', N'Tasik2', N'Tasik3', N'Indonesia', N'3463', N'abs')
INSERT [dbo].[OFFICES] ([OFFICE_CODE], [CITY], [PHONE], [ADDERESS_LINE1], [ADDERESS_LINE2], [STATE], [COUNTRY], [POSTAL_CODE], [TERRITORY]) VALUES (N'OC009', N'Jakarta Selatan', N'896', N'Jakarta Selatan', N'Jakarta Selatan2', N'Jakarta Selatan3', N'Indonesia', N'3464', N'abc')
INSERT [dbo].[OFFICES] ([OFFICE_CODE], [CITY], [PHONE], [ADDERESS_LINE1], [ADDERESS_LINE2], [STATE], [COUNTRY], [POSTAL_CODE], [TERRITORY]) VALUES (N'OC010', N'Jakarta Barat', N'897', N'Jakarta Barat', N'Jakarta Barat2', N'Jakarta Barat2', N'Indonesia', N'3465', N'abs')
GO
