USE [BANK]
GO
/****** Object:  Table [dbo].[PAYMENTS]    Script Date: 11/24/2021 11:42:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAYMENTS](
	[CUSTOMER_NUMBER] [varchar](10) NULL,
	[CHECK_NUMBER] [varchar](10) NOT NULL,
	[PAYMENTDATE] [date] NULL,
	[AMOUNT] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CHECK_NUMBER] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PAYMENTS] ([CUSTOMER_NUMBER], [CHECK_NUMBER], [PAYMENTDATE], [AMOUNT]) VALUES (N'CM001', N'CH001', CAST(N'2021-11-20' AS Date), 151400000)
INSERT [dbo].[PAYMENTS] ([CUSTOMER_NUMBER], [CHECK_NUMBER], [PAYMENTDATE], [AMOUNT]) VALUES (N'CM002', N'CH002', CAST(N'2021-11-21' AS Date), 151400000)
INSERT [dbo].[PAYMENTS] ([CUSTOMER_NUMBER], [CHECK_NUMBER], [PAYMENTDATE], [AMOUNT]) VALUES (N'CM003', N'CH003', CAST(N'2021-11-22' AS Date), 191400000)
INSERT [dbo].[PAYMENTS] ([CUSTOMER_NUMBER], [CHECK_NUMBER], [PAYMENTDATE], [AMOUNT]) VALUES (N'CM001', N'CH004', CAST(N'2021-11-23' AS Date), 251400000)
INSERT [dbo].[PAYMENTS] ([CUSTOMER_NUMBER], [CHECK_NUMBER], [PAYMENTDATE], [AMOUNT]) VALUES (N'CM005', N'CH005', CAST(N'2021-11-24' AS Date), 261400000)
INSERT [dbo].[PAYMENTS] ([CUSTOMER_NUMBER], [CHECK_NUMBER], [PAYMENTDATE], [AMOUNT]) VALUES (N'CM006', N'CH006', CAST(N'2021-11-25' AS Date), 351400000)
INSERT [dbo].[PAYMENTS] ([CUSTOMER_NUMBER], [CHECK_NUMBER], [PAYMENTDATE], [AMOUNT]) VALUES (N'CM002', N'CH007', CAST(N'2021-11-26' AS Date), 281400000)
INSERT [dbo].[PAYMENTS] ([CUSTOMER_NUMBER], [CHECK_NUMBER], [PAYMENTDATE], [AMOUNT]) VALUES (N'CM006', N'CH008', CAST(N'2021-11-27' AS Date), 451400000)
INSERT [dbo].[PAYMENTS] ([CUSTOMER_NUMBER], [CHECK_NUMBER], [PAYMENTDATE], [AMOUNT]) VALUES (N'CM009', N'CH009', CAST(N'2021-11-28' AS Date), 461400000)
INSERT [dbo].[PAYMENTS] ([CUSTOMER_NUMBER], [CHECK_NUMBER], [PAYMENTDATE], [AMOUNT]) VALUES (N'CM009', N'CH010', CAST(N'2021-11-29' AS Date), 1151400000)
GO
ALTER TABLE [dbo].[PAYMENTS]  WITH CHECK ADD  CONSTRAINT [FK_PAYMENTS_CUSTOMERS] FOREIGN KEY([CUSTOMER_NUMBER])
REFERENCES [dbo].[CUSTOMERS] ([CUSTOMER_NUMBER])
GO
ALTER TABLE [dbo].[PAYMENTS] CHECK CONSTRAINT [FK_PAYMENTS_CUSTOMERS]
GO
