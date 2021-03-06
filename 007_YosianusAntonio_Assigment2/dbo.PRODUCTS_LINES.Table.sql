USE [BANK]
GO
/****** Object:  Table [dbo].[PRODUCTS_LINES]    Script Date: 11/24/2021 11:29:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTS_LINES](
	[PRODUCT_LINE] [varchar](10) NOT NULL,
	[TEXT_DESCRIPTION] [text] NULL,
	[HTML_DESCRIPTION] [varchar](10) NULL,
	[IMAGE] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[PRODUCT_LINE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[PRODUCTS_LINES] ([PRODUCT_LINE], [TEXT_DESCRIPTION], [HTML_DESCRIPTION], [IMAGE]) VALUES (N'Bisnis', N'Product untuk investasi Buseines', N'', N'OCBC_Procduct.jpg')
INSERT [dbo].[PRODUCTS_LINES] ([PRODUCT_LINE], [TEXT_DESCRIPTION], [HTML_DESCRIPTION], [IMAGE]) VALUES (N'Electronic', N'Product Electronic', N'', N'.jpg')
INSERT [dbo].[PRODUCTS_LINES] ([PRODUCT_LINE], [TEXT_DESCRIPTION], [HTML_DESCRIPTION], [IMAGE]) VALUES (N'Mobil', N'Product untuk kendaraan', N'honda', N'Honda_lampung.jpg')
INSERT [dbo].[PRODUCTS_LINES] ([PRODUCT_LINE], [TEXT_DESCRIPTION], [HTML_DESCRIPTION], [IMAGE]) VALUES (N'Mobil1', N'Product untuk kendaraan', N'Toyota', N'Toyota_Indonesia.jpg')
INSERT [dbo].[PRODUCTS_LINES] ([PRODUCT_LINE], [TEXT_DESCRIPTION], [HTML_DESCRIPTION], [IMAGE]) VALUES (N'Mobil2', N'Product untuk kendaraan', N'Suzuki', N'Suzuki_Indonesia.jpg')
INSERT [dbo].[PRODUCTS_LINES] ([PRODUCT_LINE], [TEXT_DESCRIPTION], [HTML_DESCRIPTION], [IMAGE]) VALUES (N'Motor', N'Product untuk kendaraan', N'honda', N'Honda_Indonesia.jpg')
INSERT [dbo].[PRODUCTS_LINES] ([PRODUCT_LINE], [TEXT_DESCRIPTION], [HTML_DESCRIPTION], [IMAGE]) VALUES (N'Motor1', N'Product untuk kendaraan', N'Yamaha', N'Yamaha_Indonesia.jpg')
INSERT [dbo].[PRODUCTS_LINES] ([PRODUCT_LINE], [TEXT_DESCRIPTION], [HTML_DESCRIPTION], [IMAGE]) VALUES (N'Motor2', N'Product untuk kendaraan', N'Apche', N'Apache_Indonesia.jpg')
INSERT [dbo].[PRODUCTS_LINES] ([PRODUCT_LINE], [TEXT_DESCRIPTION], [HTML_DESCRIPTION], [IMAGE]) VALUES (N'Motor3', N'Product untuk kendaraan', N'Kawasaki', N'Kawasaki_Indonesia.jpg')
INSERT [dbo].[PRODUCTS_LINES] ([PRODUCT_LINE], [TEXT_DESCRIPTION], [HTML_DESCRIPTION], [IMAGE]) VALUES (N'Rumah', N'Product Hunian', N'KPR', N'OCBC_Product.jpg')
GO
