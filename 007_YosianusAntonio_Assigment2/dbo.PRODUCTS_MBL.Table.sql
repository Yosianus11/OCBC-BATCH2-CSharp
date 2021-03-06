USE [BANK]
GO
/****** Object:  Table [dbo].[PRODUCTS_MBL]    Script Date: 11/24/2021 11:29:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTS_MBL](
	[PRODUCT_CODE] [varchar](10) NOT NULL,
	[PRODUCT_NAME] [varchar](50) NULL,
	[PRODUCT_LINE] [varchar](10) NULL,
	[PRODUCT_SCALE] [varchar](20) NULL,
	[PRODUCT_VENDOR] [varchar](50) NULL,
	[PRODUCT_DESCRIPTION] [text] NULL,
	[QUANTITY_IN_STOCK] [varchar](50) NULL,
	[BUY_PRICE] [int] NULL,
	[MSRP] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PRODUCT_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[PRODUCTS_MBL] ([PRODUCT_CODE], [PRODUCT_NAME], [PRODUCT_LINE], [PRODUCT_SCALE], [PRODUCT_VENDOR], [PRODUCT_DESCRIPTION], [QUANTITY_IN_STOCK], [BUY_PRICE], [MSRP]) VALUES (N'PC001', N'Honda Brio', N'Mobil', N'10', N'Honda', N'Mobil CUV', N'6', 151400000, 150000000)
INSERT [dbo].[PRODUCTS_MBL] ([PRODUCT_CODE], [PRODUCT_NAME], [PRODUCT_LINE], [PRODUCT_SCALE], [PRODUCT_VENDOR], [PRODUCT_DESCRIPTION], [QUANTITY_IN_STOCK], [BUY_PRICE], [MSRP]) VALUES (N'PC002', N'Honda Brio', N'Mobil', N'5', N'Honda', N'Mobil CUV', N'6', 151400000, 150000000)
INSERT [dbo].[PRODUCTS_MBL] ([PRODUCT_CODE], [PRODUCT_NAME], [PRODUCT_LINE], [PRODUCT_SCALE], [PRODUCT_VENDOR], [PRODUCT_DESCRIPTION], [QUANTITY_IN_STOCK], [BUY_PRICE], [MSRP]) VALUES (N'PC003', N'Honda Mobilio', N'Mobil', N'8', N'Honda', N'Mobil SUV', N'4', 191400000, 180000000)
INSERT [dbo].[PRODUCTS_MBL] ([PRODUCT_CODE], [PRODUCT_NAME], [PRODUCT_LINE], [PRODUCT_SCALE], [PRODUCT_VENDOR], [PRODUCT_DESCRIPTION], [QUANTITY_IN_STOCK], [BUY_PRICE], [MSRP]) VALUES (N'PC004', N'Honda BR-V', N'Mobil', N'8', N'Honda', N'Mobil SUV', N'6', 251400000, 200000000)
INSERT [dbo].[PRODUCTS_MBL] ([PRODUCT_CODE], [PRODUCT_NAME], [PRODUCT_LINE], [PRODUCT_SCALE], [PRODUCT_VENDOR], [PRODUCT_DESCRIPTION], [QUANTITY_IN_STOCK], [BUY_PRICE], [MSRP]) VALUES (N'PC005', N'Honda Jazz', N'Mobil', N'8', N'Honda', N'Mobil CUV', N'3', 261400000, 220000000)
INSERT [dbo].[PRODUCTS_MBL] ([PRODUCT_CODE], [PRODUCT_NAME], [PRODUCT_LINE], [PRODUCT_SCALE], [PRODUCT_VENDOR], [PRODUCT_DESCRIPTION], [QUANTITY_IN_STOCK], [BUY_PRICE], [MSRP]) VALUES (N'PC006', N'Honda All New City', N'Mobil', N'10', N'Honda', N'Mobil Sedan', N'12', 351400000, 330000000)
INSERT [dbo].[PRODUCTS_MBL] ([PRODUCT_CODE], [PRODUCT_NAME], [PRODUCT_LINE], [PRODUCT_SCALE], [PRODUCT_VENDOR], [PRODUCT_DESCRIPTION], [QUANTITY_IN_STOCK], [BUY_PRICE], [MSRP]) VALUES (N'PC007', N'Honda HR-V', N'Mobil', N'8', N'Honda', N'Mobil SUV', N'6', 281400000, 250000000)
INSERT [dbo].[PRODUCTS_MBL] ([PRODUCT_CODE], [PRODUCT_NAME], [PRODUCT_LINE], [PRODUCT_SCALE], [PRODUCT_VENDOR], [PRODUCT_DESCRIPTION], [QUANTITY_IN_STOCK], [BUY_PRICE], [MSRP]) VALUES (N'PC008', N'Honda Civic Hatchback', N'Mobil', N'10', N'Honda', N'Mobil Hatchback', N'5', 451400000, 400000000)
INSERT [dbo].[PRODUCTS_MBL] ([PRODUCT_CODE], [PRODUCT_NAME], [PRODUCT_LINE], [PRODUCT_SCALE], [PRODUCT_VENDOR], [PRODUCT_DESCRIPTION], [QUANTITY_IN_STOCK], [BUY_PRICE], [MSRP]) VALUES (N'PC009', N'Honda All New Civic Turbo', N'Mobil', N'10', N'Honda', N'Mobil Sedan', N'6', 461400000, 450000000)
INSERT [dbo].[PRODUCTS_MBL] ([PRODUCT_CODE], [PRODUCT_NAME], [PRODUCT_LINE], [PRODUCT_SCALE], [PRODUCT_VENDOR], [PRODUCT_DESCRIPTION], [QUANTITY_IN_STOCK], [BUY_PRICE], [MSRP]) VALUES (N'PC010', N'Honda Civic type R', N'Mobil', N'1-', N'Honda', N'Mobil Super Car', N'2', 1151400000, 1000000000)
GO
ALTER TABLE [dbo].[PRODUCTS_MBL]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCTS_MBL_PRODUCTS_LINES] FOREIGN KEY([PRODUCT_LINE])
REFERENCES [dbo].[PRODUCTS_LINES] ([PRODUCT_LINE])
GO
ALTER TABLE [dbo].[PRODUCTS_MBL] CHECK CONSTRAINT [FK_PRODUCTS_MBL_PRODUCTS_LINES]
GO
