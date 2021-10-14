SET IDENTITY_INSERT [dbo].[Products] ON
INSERT INTO [dbo].[Products] ([ProductId], [ProductName], [UnitPrice], [StockAmount]) VALUES (1, N'Cips', CAST(12.40 AS Decimal(18, 2)), 45)
INSERT INTO [dbo].[Products] ([ProductId], [ProductName], [UnitPrice], [StockAmount]) VALUES (2, N'Bardak', CAST(5.00 AS Decimal(18, 2)), 24)
INSERT INTO [dbo].[Products] ([ProductId], [ProductName], [UnitPrice], [StockAmount]) VALUES (1004, N'Limonata', CAST(12.50 AS Decimal(18, 2)), 15)
INSERT INTO [dbo].[Products] ([ProductId], [ProductName], [UnitPrice], [StockAmount]) VALUES (1005, N'Çekirdek', CAST(15.99 AS Decimal(18, 2)), 15)
SET IDENTITY_INSERT [dbo].[Products] OFF
