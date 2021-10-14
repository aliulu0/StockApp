SET IDENTITY_INSERT [dbo].[Historys] ON
INSERT INTO [dbo].[Historys] ([HistoryId], [ProductId], [ProductName], [StockAmount], [SumPrice], [Date]) VALUES (1, 1004, N'Limonata', 6, CAST(75.00 AS Decimal(18, 2)), N'2.02.2021 03:23:45')
INSERT INTO [dbo].[Historys] ([HistoryId], [ProductId], [ProductName], [StockAmount], [SumPrice], [Date]) VALUES (2, 1005, N'Çekirdek', 13, CAST(207.87 AS Decimal(18, 2)), N'2.02.2021 03:24:20')
INSERT INTO [dbo].[Historys] ([HistoryId], [ProductId], [ProductName], [StockAmount], [SumPrice], [Date]) VALUES (3, 1004, N'Limonata', 4, CAST(50.00 AS Decimal(18, 2)), N'2.02.2021 03:27:59')
INSERT INTO [dbo].[Historys] ([HistoryId], [ProductId], [ProductName], [StockAmount], [SumPrice], [Date]) VALUES (1002, 1, N'Cips', 1, CAST(12.40 AS Decimal(18, 2)), N'2.02.2021 03:34:45')
INSERT INTO [dbo].[Historys] ([HistoryId], [ProductId], [ProductName], [StockAmount], [SumPrice], [Date]) VALUES (1003, 1004, N'Limonata', 1, CAST(12.50 AS Decimal(18, 2)), N'2.02.2021 03:34:49')
INSERT INTO [dbo].[Historys] ([HistoryId], [ProductId], [ProductName], [StockAmount], [SumPrice], [Date]) VALUES (1004, 2, N'Bardak', 1, CAST(5.00 AS Decimal(18, 2)), N'2.02.2021 03:58:06')
SET IDENTITY_INSERT [dbo].[Historys] OFF
