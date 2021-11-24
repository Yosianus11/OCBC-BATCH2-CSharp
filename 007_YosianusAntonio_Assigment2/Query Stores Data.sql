INSERT INTO dbo.CUSTOMERS
(CUSTOMER_NUMBER,CUSTOMER_NAME,CONTACT_LAST_NAME,CONTACT_FIRST_NAME,ADDRESS_LINE1,
 ADDRESS_LINE2,CITY,[STATE],POSTAL_CODE,COUNTRY,SALES_REP_EMPLOYEE_NUMBER,CREDIT_LIMIT)
VALUES
('CM002','Albert Salim','Albert Salim','Antonio','Kel Wayhalim',
'Kec jagabaya III','Lampung','Bandar Lampung','34241','Indonesia','SR005', '50000000'),
('CM003','Yeftanus Antonio','Yeftanus','Antonio','Kel Baros',
'Kec Kotaagung','Lampung','Tanggamus','33782','Indonesia','SR001', '100000000'),
('CM004','Riska Andani','Riska','Andani','Kel teluk betung',
'Kec teluk betung','Lampung','tanjung karang','34241','Indonesia','SR005', '80000000'),
('CM005','Riska Antonio','Riska','Antonio','Kel bandar jaya',
'Kec bandar jaya','Lampung','Tanggamus','34345','Indonesia','SR001', '20000000'),
('CM006','Agung Hermansyah','Agung','Hermansyah','Kel kedaton',
'Kec kedaton','Lampung','bandar lampung','33453','Indonesia','SR12', '150000000'),
('CM007','Indah Ayu','Indah','Ayu','Kel kedaton',
'Kec Kedaton','Lampung','bandar lampung','34453','Indonesia','SR005', '50000000'),
('CM008','Arif Wicaksono','Arif','Wicaksono','Kel aceh selatan',
'Kec Aceh Selatan','Aceh','Aceh','34241','Indonesia','SR009', '250000000'),
('CM009','Supriyono Loekito','Supriyono','Loekito','Kel peringsewu',
'Kec peringsewu','Lampung','peringsewu','34241','Indonesia','SR003', '30000000'),
('CM010','Antonio','Antonio','','Kel Baros',
'Kec Kotaagung','Lampung','Tanggamus','34241','Indonesia','SR001', '250000000');

INSERT INTO dbo.PRODUCTS_MBL
(PRODUCT_CODE,PRODUCT_NAME,PRODUCT_LINE,PRODUCT_SCALE,PRODUCT_VENDOR,
 PRODUCT_DESCRIPTION,QUANTITY_IN_STOCK,BUY_PRICE,MSRP)
VALUES
('PC002','Honda Brio','Mobil','5','Honda','Mobil CUV','6','151400000','150000000'),
('PC003','Honda Mobilio','Mobil','8','Honda','Mobil SUV','4','191400000','180000000'),
('PC004','Honda BR-V','Mobil','8','Honda','Mobil SUV','6','251400000','200000000'),
('PC005','Honda Jazz','Mobil','8','Honda','Mobil CUV','3','261400000','220000000'),
('PC006','Honda All New City','Mobil','10','Honda','Mobil Sedan','12','351400000','330000000'),
('PC007','Honda HR-V','Mobil','8','Honda','Mobil SUV','6','281400000','250000000'),
('PC008','Honda Civic Hatchback','Mobil','10','Honda','Mobil Hatchback','5','451400000','400000000'),
('PC009','Honda All New Civic Turbo','Mobil','10','Honda','Mobil Sedan','6','461400000','450000000'),
('PC010','Honda Civic type R','Mobil','1-','Honda','Mobil Super Car','2','1151400000','1000000000');

INSERT INTO dbo.PRODUCTS_LINES
(PRODUCT_LINE,TEXT_DESCRIPTION,HTML_DESCRIPTION,[IMAGE])
VALUES
('Motor','Product untuk kendaraan','honda','Honda_Indonesia.jpg'),
('Mobil1','Product untuk kendaraan','Toyota','Toyota_Indonesia.jpg'),
('Motor1','Product untuk kendaraan','Yamaha','Yamaha_Indonesia.jpg'),
('Mobil2','Product untuk kendaraan','Suzuki','Suzuki_Indonesia.jpg'),
('Motor2','Product untuk kendaraan','Apche','Apache_Indonesia.jpg'),
('Motor3','Product untuk kendaraan','Kawasaki','Kawasaki_Indonesia.jpg'),
('Rumah','Product Hunian','KPR','OCBC_Product.jpg'),
('Electronic','Product Electronic','','.jpg'),
('Bisnis','Product untuk investasi Buseines','','OCBC_Procduct.jpg');




INSERT [dbo].[ORDERS] ([ORDER_NUMBER], [ORDER_DATE], [REQUIRED_DATE], [SHIPPED_DATE], [STATUS], [COMMETS], [COSTUMER_NUMBER]) 
VALUES 
(N'ON001', CAST(N'2021-11-01' AS Date), CAST(N'2021-11-02' AS Date), CAST(N'2021-11-03' AS Date), N'GR', N'NOPE', N'CM001');
(N'ON002', CAST(N'2021-11-02' AS Date), CAST(N'2021-11-03' AS Date), CAST(N'2021-11-04' AS Date), N'GR', N'NOPE', N'CM002'),
(N'ON003', CAST(N'2021-11-03' AS Date), CAST(N'2021-11-04' AS Date), CAST(N'2021-11-05' AS Date), N'GR', N'NOPE', N'CM003');
(N'ON004', CAST(N'2021-11-04' AS Date), CAST(N'2021-11-05' AS Date), CAST(N'2021-11-06' AS Date), N'GR', N'NOPE', N'CM001'),
(N'ON005', CAST(N'2021-11-05' AS Date), CAST(N'2021-11-06' AS Date), CAST(N'2021-11-07' AS Date), N'GR', N'NOPE', N'CM005'),
(N'ON006', CAST(N'2021-11-06' AS Date), CAST(N'2021-11-07' AS Date), CAST(N'2021-11-08' AS Date), N'GR', N'NOPE', N'CM006'),
(N'ON007', CAST(N'2021-11-07' AS Date), CAST(N'2021-11-08' AS Date), CAST(N'2021-11-09' AS Date), N'GR', N'NOPE', N'CM002'),
(N'ON008', CAST(N'2021-11-08' AS Date), CAST(N'2021-11-09' AS Date), CAST(N'2021-11-10' AS Date), N'GR', N'NOPE', N'CM006'),
(N'ON009', CAST(N'2021-11-09' AS Date), CAST(N'2021-11-10' AS Date), CAST(N'2021-11-11' AS Date), N'GR', N'NOPE', N'CM009'),
(N'ON010', CAST(N'2021-11-10' AS Date), CAST(N'2021-11-11' AS Date), CAST(N'2021-11-12' AS Date), N'GR', N'NOPE', N'CM009');



INSERT [dbo].[ORDER_DETAILS] ([ORDER_NUMBER], [PRODUCT_CODE], [QUANTITY_ORDERED], [PRICE_EACH], [ORDER_LINE_NUMBER]) 
VALUES 
(N'ON001', N'PC001', 1, 151400000, N'2'),
(N'ON002', N'PC002', 1, 151400000, N'2'),
(N'ON003', N'PC003', 1, 191400000, N'2'),
(N'ON005', N'PC005', 1, 261400000, N'2'),
(N'ON006', N'PC006', 1, 351400000, N'2'),
(N'ON007', N'PC007', 1, 281400000, N'2'),
(N'ON008', N'PC008', 1, 451400000, N'2'),
(N'ON009', N'PC009', 1, 461400000, N'2'),
(N'ON010', N'PC010', 1, 1151400000, N'2');

INSERT [dbo].[PAYMENTS] ([CUSTOMER_NUMBER], [CHECK_NUMBER], [PAYMENTDATE], [AMOUNT]) 
VALUES 
(N'CM001', N'CH001', CAST(N'2021-11-20' AS Date), 151400000),
(N'CM002', N'CH002', CAST(N'2021-11-21' AS Date), 151400000),
(N'CM003', N'CH003', CAST(N'2021-11-22' AS Date), 191400000),
(N'CM001', N'CH004', CAST(N'2021-11-23' AS Date), 251400000),
(N'CM005', N'CH005', CAST(N'2021-11-24' AS Date), 261400000),
(N'CM006', N'CH006', CAST(N'2021-11-25' AS Date), 351400000),
(N'CM002', N'CH007', CAST(N'2021-11-26' AS Date), 281400000),
(N'CM006', N'CH008', CAST(N'2021-11-27' AS Date), 451400000),
(N'CM009', N'CH009', CAST(N'2021-11-28' AS Date), 461400000),
(N'CM009', N'CH010', CAST(N'2021-11-29' AS Date), 1151400000);

INSERT [dbo].[EMPLOYEES] ([EMPLOYEE_NUMBER], [LAST_NAME], [FIRST_NAME], [EXTENSION], [EMAIL], [OFFICE_CODE], [REPORTS_TO], [JOB_TITLE]) 
VALUES 
(N'EM820001', N'Yosianus', N'Antonio', N'789', N'@ocbc.com', N'OC001', N'IT MANAGEMENT', N'Software Engineer'),
(N'EM820002', N'Yeftanus ', N'Antonio', N'789', N'@ocbc.com', N'OC002', N'IT MANAGEMENT', N'Software Engineer'),
(N'EM820003', N'Riska', N'Antonio', N'789', N'@ocbc.com', N'OC001', N'IT MANAGEMENT', N'Software Engineer'),
(N'EM820004', N'Indah ', N'Ayu', N'789', N'@ocbc.com', N'OC001', N'IT MANAGEMENT', N'Software Engineer'),
(N'EM820005', N'Joko', N'Pinilih', N'789', N'@ocbc.com', N'OC002', N'IT MANAGEMENT', N'Software Engineer'),
(N'EM820006', N'Mayang', N'Indah', N'789', N'@ocbc.com', N'OC003', N'IT MANAGEMENT', N'Software Engineer'),
(N'EM820007', N'Arif ', N'Wiicak', N'789', N'@ocbc.com', N'OC001', N'IT MANAGEMENT', N'Data Engineer'),
(N'EM820008', N'Adi', N'Luhung', N'789', N'@ocbc.com', N'OC002', N'IT MANAGEMENT', N'Data Engineer'),
(N'EM820009', N'Marsha', N'aditya', N'789', N'@ocbc.com', N'OC003', N'IT MANAGEMENT', N'Data Engineer'),
(N'EM820010', N'tandaditaya', NULL, N'789', N'@ocbc.com', N'OC001', N'IT MANAGEMENT', N'Data Engineer');

INSERT [dbo].[OFFICES] ([OFFICE_CODE], [CITY], [PHONE], [ADDERESS_LINE1], [ADDERESS_LINE2], [STATE], [COUNTRY], [POSTAL_CODE], [TERRITORY]) 
VALUES 
(N'OC001', N'Bandar Lampung', N'888', N'Bandar Lampung1', N'Bandar Lampung2', N'Bandar Lampung3', N'Indonesia', N'3456', N'abc'),
 (N'OC002', N'Jakarta', N'889', N'Jakarta', N'Jakarta2', N'Jakarta3', N'Indonesia', N'3457', N'abs'),
 (N'OC003', N'Bogor', N'890', N'Bogor', N'Bogor2', N'Bogor3', N'Indonesia', N'3458', N'abc'),
 (N'OC004', N'Tebet', N'891', N'Tebet', N'Tebet2', N'Tebet3', N'Indonesia', N'3459', N'abs'),
 (N'OC005', N'Bandung', N'892', N'Bandung', N'Bandung2', N'Bandung3', N'Indonesia', N'3460', N'abc'),
 (N'OC006', N'Yogyakarta', N'893', N'Yogyakarta', N'Yogyakarta2', N'Yogyakarta3', N'Indonesia', N'3461', N'abs'),
 (N'OC007', N'Bekasi', N'894', N'Bekasi', N'Bekasi2', N'Bekasi3', N'Indonesia', N'3462', N'abc'),
 (N'OC008', N'Tasik', N'895', N'Tasik', N'Tasik2', N'Tasik3', N'Indonesia', N'3463', N'abs'),
 (N'OC009', N'Jakarta Selatan', N'896', N'Jakarta Selatan', N'Jakarta Selatan2', N'Jakarta Selatan3', N'Indonesia', N'3464', N'abc'),
 (N'OC010', N'Jakarta Barat', N'897', N'Jakarta Barat', N'Jakarta Barat2', N'Jakarta Barat2', N'Indonesia', N'3465', N'abs');



