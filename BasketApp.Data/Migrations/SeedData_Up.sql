
SET IDENTITY_INSERT [dbo].[TB_Basket] ON 

INSERT [dbo].[TB_Basket] ([Id], [ProductVariantId], [CustomerId], [Count], [CreateDate]) VALUES (1, 5, 1, 1, CAST(N'2021-05-12T22:17:45.420' AS DateTime))
INSERT [dbo].[TB_Basket] ([Id], [ProductVariantId], [CustomerId], [Count], [CreateDate]) VALUES (2, 10, 1, 2, CAST(N'2021-05-12T22:17:52.397' AS DateTime))
INSERT [dbo].[TB_Basket] ([Id], [ProductVariantId], [CustomerId], [Count], [CreateDate]) VALUES (3, 2, 2, 1, CAST(N'2021-05-12T22:18:22.517' AS DateTime))
INSERT [dbo].[TB_Basket] ([Id], [ProductVariantId], [CustomerId], [Count], [CreateDate]) VALUES (4, 8, 2, 3, CAST(N'2021-05-12T22:18:29.093' AS DateTime))
INSERT [dbo].[TB_Basket] ([Id], [ProductVariantId], [CustomerId], [Count], [CreateDate]) VALUES (5, 1, 3, 1, CAST(N'2021-05-12T22:18:43.800' AS DateTime))
INSERT [dbo].[TB_Basket] ([Id], [ProductVariantId], [CustomerId], [Count], [CreateDate]) VALUES (6, 7, 3, 1, CAST(N'2021-05-12T22:18:58.823' AS DateTime))
INSERT [dbo].[TB_Basket] ([Id], [ProductVariantId], [CustomerId], [Count], [CreateDate]) VALUES (7, 9, 3, 2, CAST(N'2021-05-12T22:19:25.640' AS DateTime))
SET IDENTITY_INSERT [dbo].[TB_Basket] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_Customer] ON 

INSERT [dbo].[TB_Customer] ([Id], [Name], [Surname], [Email], [Address], [PhoneNumber]) VALUES (1, N'Pınar', N'Eser', N'pinarreser@hotmail.com', N'Melikgazi/Kayseri', N'05558522524')
INSERT [dbo].[TB_Customer] ([Id], [Name], [Surname], [Email], [Address], [PhoneNumber]) VALUES (2, N'Hayal ', N'Özsöz', N'hayal@gmail.com', N'Bornova/İzmir', N'05548651206')
INSERT [dbo].[TB_Customer] ([Id], [Name], [Surname], [Email], [Address], [PhoneNumber]) VALUES (3, N'Asaf', N'Taşkın', N'asaf@hotmail.com', N'Şişli/İstanbul', N'05321244204')
SET IDENTITY_INSERT [dbo].[TB_Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_Option] ON 

INSERT [dbo].[TB_Option] ([Id], [OptionGroupId], [Name]) VALUES (1, 1, N'Kırmızı')
INSERT [dbo].[TB_Option] ([Id], [OptionGroupId], [Name]) VALUES (2, 1, N'Pembe')
INSERT [dbo].[TB_Option] ([Id], [OptionGroupId], [Name]) VALUES (3, 1, N'Beyaz')
INSERT [dbo].[TB_Option] ([Id], [OptionGroupId], [Name]) VALUES (4, 1, N'Gri')
INSERT [dbo].[TB_Option] ([Id], [OptionGroupId], [Name]) VALUES (5, 2, N'XS')
INSERT [dbo].[TB_Option] ([Id], [OptionGroupId], [Name]) VALUES (6, 2, N'S')
INSERT [dbo].[TB_Option] ([Id], [OptionGroupId], [Name]) VALUES (7, 2, N'M')
INSERT [dbo].[TB_Option] ([Id], [OptionGroupId], [Name]) VALUES (8, 2, N'L')
SET IDENTITY_INSERT [dbo].[TB_Option] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_OptionGroup] ON 

INSERT [dbo].[TB_OptionGroup] ([Id], [Name]) VALUES (1, N'Renk')
INSERT [dbo].[TB_OptionGroup] ([Id], [Name]) VALUES (2, N'Beden')
SET IDENTITY_INSERT [dbo].[TB_OptionGroup] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_Product] ON 

INSERT [dbo].[TB_Product] ([Id], [Name], [CreateDate]) VALUES (1, N'Samsung Galaxy Z Fold2', CAST(N'2021-05-12T21:50:15.197' AS DateTime))
INSERT [dbo].[TB_Product] ([Id], [Name], [CreateDate]) VALUES (2, N'Samsung Galaxy Watch 3', CAST(N'2021-05-12T21:51:07.197' AS DateTime))
INSERT [dbo].[TB_Product] ([Id], [Name], [CreateDate]) VALUES (3, N'Apple iPhone 12 Pro Max', CAST(N'2021-05-12T21:51:57.197' AS DateTime))
INSERT [dbo].[TB_Product] ([Id], [Name], [CreateDate]) VALUES (4, N'Kuşaklı Düğmeli Elbise', CAST(N'2021-05-12T21:52:00.197' AS DateTime))
INSERT [dbo].[TB_Product] ([Id], [Name], [CreateDate]) VALUES (5, N'Kapüşonlu Fermuar Kapamalı Mont', CAST(N'2021-05-12T21:52:07.197' AS DateTime))
INSERT [dbo].[TB_Product] ([Id], [Name], [CreateDate]) VALUES (6, N'Kolsuz Basic T-Shirt', CAST(N'2021-05-12T21:53:07.197' AS DateTime))
INSERT [dbo].[TB_Product] ([Id], [Name], [CreateDate]) VALUES (7, N'Mozaik Desenli Püsküllü Vual Gömlek', CAST(N'2021-05-12T21:54:07.197' AS DateTime))
SET IDENTITY_INSERT [dbo].[TB_Product] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_ProductOption] ON 

INSERT [dbo].[TB_ProductOption] ([Id], [ProductVariantId], [OptionId]) VALUES (1, 1, 4)
INSERT [dbo].[TB_ProductOption] ([Id], [ProductVariantId], [OptionId]) VALUES (2, 2, 2)
INSERT [dbo].[TB_ProductOption] ([Id], [ProductVariantId], [OptionId]) VALUES (3, 3, 3)
INSERT [dbo].[TB_ProductOption] ([Id], [ProductVariantId], [OptionId]) VALUES (4, 4, 1)
INSERT [dbo].[TB_ProductOption] ([Id], [ProductVariantId], [OptionId]) VALUES (5, 5, 4)
INSERT [dbo].[TB_ProductOption] ([Id], [ProductVariantId], [OptionId]) VALUES (6, 6, 7)
INSERT [dbo].[TB_ProductOption] ([Id], [ProductVariantId], [OptionId]) VALUES (7, 7, 5)
INSERT [dbo].[TB_ProductOption] ([Id], [ProductVariantId], [OptionId]) VALUES (8, 8, 6)
INSERT [dbo].[TB_ProductOption] ([Id], [ProductVariantId], [OptionId]) VALUES (9, 9, 8)
INSERT [dbo].[TB_ProductOption] ([Id], [ProductVariantId], [OptionId]) VALUES (10, 10, 7)
INSERT [dbo].[TB_ProductOption] ([Id], [ProductVariantId], [OptionId]) VALUES (11, 10, 4)
INSERT [dbo].[TB_ProductOption] ([Id], [ProductVariantId], [OptionId]) VALUES (12, 6, 2)
SET IDENTITY_INSERT [dbo].[TB_ProductOption] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_ProductVariant] ON 

INSERT [dbo].[TB_ProductVariant] ([Id], [ProductId], [Name], [Description], [Price], [Stock], [CreateDate]) VALUES (1, 1, N'Samsung Galaxy Z Fold2 Gri', NULL, CAST(17799.00 AS Decimal(18, 2)), 150, CAST(N'2021-05-12T21:55:00.197' AS DateTime))
INSERT [dbo].[TB_ProductVariant] ([Id], [ProductId], [Name], [Description], [Price], [Stock], [CreateDate]) VALUES (2, 2, N'Samsung Galaxy Watch 3 Pembe Kordonlu', NULL, CAST(2215.00 AS Decimal(18, 2)), 250, CAST(N'2021-05-12T22:03:21.530' AS DateTime))
INSERT [dbo].[TB_ProductVariant] ([Id], [ProductId], [Name], [Description], [Price], [Stock], [CreateDate]) VALUES (3, 2, N'Samsung Galaxy Watch 3 Beyaz Kordon', NULL, CAST(2225.25 AS Decimal(18, 2)), 300, CAST(N'2021-05-12T22:04:08.033' AS DateTime))
INSERT [dbo].[TB_ProductVariant] ([Id], [ProductId], [Name], [Description], [Price], [Stock], [CreateDate]) VALUES (4, 3, N'Apple iPhone 12 Pro Max Kırmızı', NULL, CAST(19990.00 AS Decimal(18, 2)), 100, CAST(N'2021-05-12T22:05:02.927' AS DateTime))
INSERT [dbo].[TB_ProductVariant] ([Id], [ProductId], [Name], [Description], [Price], [Stock], [CreateDate]) VALUES (5, 3, N'Apple iPhone 12 Pro Max Gri', NULL, CAST(19980.80 AS Decimal(18, 2)), 150, CAST(N'2021-05-12T22:06:05.650' AS DateTime))
INSERT [dbo].[TB_ProductVariant] ([Id], [ProductId], [Name], [Description], [Price], [Stock], [CreateDate]) VALUES (6, 4, N'Kuşaklı Düğmeli Elbise', NULL, CAST(125.25 AS Decimal(18, 2)), 250, CAST(N'2021-05-12T22:06:55.580' AS DateTime))
INSERT [dbo].[TB_ProductVariant] ([Id], [ProductId], [Name], [Description], [Price], [Stock], [CreateDate]) VALUES (7, 5, N'Kapüşonlu Fermuar Kapamalı Mont', NULL, CAST(420.00 AS Decimal(18, 2)), 400, CAST(N'2021-05-12T22:08:30.300' AS DateTime))
INSERT [dbo].[TB_ProductVariant] ([Id], [ProductId], [Name], [Description], [Price], [Stock], [CreateDate]) VALUES (8, 6, N'Kolsuz Basic T-Shirt', NULL, CAST(35.50 AS Decimal(18, 2)), 600, CAST(N'2021-05-12T22:08:46.120' AS DateTime))
INSERT [dbo].[TB_ProductVariant] ([Id], [ProductId], [Name], [Description], [Price], [Stock], [CreateDate]) VALUES (9, 7, N'Mozaik Desenli Püsküllü Vual Gömlek', NULL, CAST(75.00 AS Decimal(18, 2)), 150, CAST(N'2021-05-12T22:09:06.727' AS DateTime))
INSERT [dbo].[TB_ProductVariant] ([Id], [ProductId], [Name], [Description], [Price], [Stock], [CreateDate]) VALUES (10, 7, N'Mozaik Desenli Püsküllü Vual Gömlek', NULL, CAST(75.00 AS Decimal(18, 2)), 250, CAST(N'2021-05-12T22:09:25.780' AS DateTime))
SET IDENTITY_INSERT [dbo].[TB_ProductVariant] OFF
GO