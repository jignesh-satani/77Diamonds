USE [77DiamondsTest]
GO
/****** Object:  Table [dbo].[ColorMaster]    Script Date: 17-01-2022 07:25:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ColorMaster](
	[ColorId] [tinyint] IDENTITY(1,1) NOT NULL,
	[ColorName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ColorMaster] PRIMARY KEY CLUSTERED 
(
	[ColorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FabricMaster]    Script Date: 17-01-2022 07:25:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FabricMaster](
	[FabricId] [tinyint] IDENTITY(1,1) NOT NULL,
	[FabricName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_FabricMaster] PRIMARY KEY CLUSTERED 
(
	[FabricId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemDetail]    Script Date: 17-01-2022 07:25:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemDetail](
	[ItemDetailId] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NOT NULL,
	[FabricId] [tinyint] NOT NULL,
	[ColorId] [tinyint] NOT NULL,
 CONSTRAINT [PK_ItemDetail] PRIMARY KEY CLUSTERED 
(
	[ItemDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemMaster]    Script Date: 17-01-2022 07:25:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemMaster](
	[ItemId] [int] IDENTITY(1,1) NOT NULL,
	[ItemCode] [varchar](10) NOT NULL,
	[ItemName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ItemMaster] PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemPicture]    Script Date: 17-01-2022 07:25:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemPicture](
	[ItemPictureId] [int] IDENTITY(1,1) NOT NULL,
	[ItemDetailId] [int] NOT NULL,
	[PictureFile] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ItemPicture] PRIMARY KEY CLUSTERED 
(
	[ItemPictureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ColorMaster] ON 
GO
INSERT [dbo].[ColorMaster] ([ColorId], [ColorName]) VALUES (1, N'White')
GO
INSERT [dbo].[ColorMaster] ([ColorId], [ColorName]) VALUES (2, N'Yellow')
GO
INSERT [dbo].[ColorMaster] ([ColorId], [ColorName]) VALUES (3, N'Green')
GO
SET IDENTITY_INSERT [dbo].[ColorMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[FabricMaster] ON 
GO
INSERT [dbo].[FabricMaster] ([FabricId], [FabricName]) VALUES (1, N'Cotton')
GO
INSERT [dbo].[FabricMaster] ([FabricId], [FabricName]) VALUES (2, N'Linen')
GO
INSERT [dbo].[FabricMaster] ([FabricId], [FabricName]) VALUES (3, N'Silk')
GO
SET IDENTITY_INSERT [dbo].[FabricMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[ItemDetail] ON 
GO
INSERT [dbo].[ItemDetail] ([ItemDetailId], [ItemId], [FabricId], [ColorId]) VALUES (1, 1, 1, 1)
GO
INSERT [dbo].[ItemDetail] ([ItemDetailId], [ItemId], [FabricId], [ColorId]) VALUES (2, 1, 2, 2)
GO
INSERT [dbo].[ItemDetail] ([ItemDetailId], [ItemId], [FabricId], [ColorId]) VALUES (3, 2, 1, 1)
GO
INSERT [dbo].[ItemDetail] ([ItemDetailId], [ItemId], [FabricId], [ColorId]) VALUES (5, 1, 1, 3)
GO
INSERT [dbo].[ItemDetail] ([ItemDetailId], [ItemId], [FabricId], [ColorId]) VALUES (6, 1, 3, 3)
GO
INSERT [dbo].[ItemDetail] ([ItemDetailId], [ItemId], [FabricId], [ColorId]) VALUES (7, 2, 3, 3)
GO
INSERT [dbo].[ItemDetail] ([ItemDetailId], [ItemId], [FabricId], [ColorId]) VALUES (8, 2, 3, 2)
GO
INSERT [dbo].[ItemDetail] ([ItemDetailId], [ItemId], [FabricId], [ColorId]) VALUES (9, 1, 2, 1)
GO
INSERT [dbo].[ItemDetail] ([ItemDetailId], [ItemId], [FabricId], [ColorId]) VALUES (10, 1, 3, 1)
GO
INSERT [dbo].[ItemDetail] ([ItemDetailId], [ItemId], [FabricId], [ColorId]) VALUES (12, 2, 2, 3)
GO
INSERT [dbo].[ItemDetail] ([ItemDetailId], [ItemId], [FabricId], [ColorId]) VALUES (13, 1, 1, 2)
GO
INSERT [dbo].[ItemDetail] ([ItemDetailId], [ItemId], [FabricId], [ColorId]) VALUES (14, 1, 3, 2)
GO
SET IDENTITY_INSERT [dbo].[ItemDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[ItemMaster] ON 
GO
INSERT [dbo].[ItemMaster] ([ItemId], [ItemCode], [ItemName]) VALUES (1, N'001', N'Skeleton T-Shirt')
GO
INSERT [dbo].[ItemMaster] ([ItemId], [ItemCode], [ItemName]) VALUES (2, N'002', N'Unicorn T-Shirt')
GO
INSERT [dbo].[ItemMaster] ([ItemId], [ItemCode], [ItemName]) VALUES (5, N'003', N'Star Wars T-shirt')
GO
SET IDENTITY_INSERT [dbo].[ItemMaster] OFF
GO
ALTER TABLE [dbo].[ItemDetail]  WITH CHECK ADD  CONSTRAINT [FK_ItemDetail_ColorMaster] FOREIGN KEY([ColorId])
REFERENCES [dbo].[ColorMaster] ([ColorId])
GO
ALTER TABLE [dbo].[ItemDetail] CHECK CONSTRAINT [FK_ItemDetail_ColorMaster]
GO
ALTER TABLE [dbo].[ItemDetail]  WITH CHECK ADD  CONSTRAINT [FK_ItemDetail_FabricMaster] FOREIGN KEY([FabricId])
REFERENCES [dbo].[FabricMaster] ([FabricId])
GO
ALTER TABLE [dbo].[ItemDetail] CHECK CONSTRAINT [FK_ItemDetail_FabricMaster]
GO
ALTER TABLE [dbo].[ItemDetail]  WITH CHECK ADD  CONSTRAINT [FK_ItemDetail_ItemMaster] FOREIGN KEY([ItemId])
REFERENCES [dbo].[ItemMaster] ([ItemId])
GO
ALTER TABLE [dbo].[ItemDetail] CHECK CONSTRAINT [FK_ItemDetail_ItemMaster]
GO
ALTER TABLE [dbo].[ItemPicture]  WITH CHECK ADD  CONSTRAINT [FK_ItemPicture_ItemDetail] FOREIGN KEY([ItemDetailId])
REFERENCES [dbo].[ItemDetail] ([ItemDetailId])
GO
ALTER TABLE [dbo].[ItemPicture] CHECK CONSTRAINT [FK_ItemPicture_ItemDetail]
GO
/****** Object:  StoredProcedure [dbo].[GetItemDetails]    Script Date: 17-01-2022 07:25:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetItemDetails]
@ItemId As Int = 1
As
Begin
	
	If (@ItemId > 0)
	Begin
		Select A.ColorId,A.FabricId
		,A.ColorName,A.FabricName
		,IsNull(D.ItemId, 0) ItemId
		,IsNull(D.ItemDetailId,0) ItemDetailId
		,IsNull(I.ItemCode,'') ItemCode
		,IsNull(I.ItemName, '') ItemName
		,IsNull(P.PictureFile, '') PictureFile
		From
		(
			Select  C.ColorId,C.ColorName, F.FabricId,F.FabricName
			From ColorMaster C, FabricMaster F
		) A
		Left Join ItemDetail D On A.ColorId = D.ColorId And A.FabricId = D.FabricId And D.ItemId = @ItemId
		Left Join ItemMaster I On D.ItemId = I.ItemId
		Left Join ItemPicture P On D.ItemDetailId = P.ItemDetailId
End
Else
Begin
		Select A.ColorId,A.FabricId
		,A.ColorName,A.FabricName
		,IsNull(D.ItemId, 0) ItemId
		,IsNull(D.ItemDetailId,0) ItemDetailId
		,IsNull(I.ItemCode,'') ItemCode
		,IsNull(I.ItemName, '') ItemName
		,IsNull(P.PictureFile, '') PictureFile
		From
		(
			Select  C.ColorId,C.ColorName, F.FabricId,F.FabricName
			From ColorMaster C, FabricMaster F
		) A
		Left Join ItemDetail D On A.ColorId = D.ColorId And A.FabricId = D.FabricId
		Left Join ItemMaster I On D.ItemId = I.ItemId
		Left Join ItemPicture P On D.ItemDetailId = P.ItemDetailId
End
End
GO
