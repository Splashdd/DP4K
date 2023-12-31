USE [dbkurs]
GO
/****** Object:  User [User]    Script Date: 01.12.2023 0:57:40 ******/
CREATE USER [User] FOR LOGIN [User] WITH DEFAULT_SCHEMA=[guest]
GO
/****** Object:  Table [dbo].[Car]    Script Date: 01.12.2023 0:57:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CarName] [nvarchar](max) NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
	[LoadCapacity] [float] NOT NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarManager]    Script Date: 01.12.2023 0:57:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarManager](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[SecondName] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NULL,
	[Phone] [nvarchar](11) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[CarID] [int] NULL,
 CONSTRAINT [PK_CarManager] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientManager]    Script Date: 01.12.2023 0:57:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientManager](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[SecondName] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](11) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[OrderID] [int] NOT NULL,
	[TransportationOrder] [int] NOT NULL,
 CONSTRAINT [PK_ClientManager] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 01.12.2023 0:57:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[SecondName] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](11) NOT NULL,
	[DateOfBirthday] [date] NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 01.12.2023 0:57:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Weight] [float] NOT NULL,
	[DateOfOrder] [date] NOT NULL,
	[NameOfOrder] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 01.12.2023 0:57:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 01.12.2023 0:57:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[RoleID] [int] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Car] ON 

INSERT [dbo].[Car] ([ID], [CarName], [Status], [LoadCapacity]) VALUES (1, N'Volvo VNL 670, 2004', N'Занят', 9000)
INSERT [dbo].[Car] ([ID], [CarName], [Status], [LoadCapacity]) VALUES (3, N'Mercedes-Benz Actroz, 2012', N'Занят', 16000)
INSERT [dbo].[Car] ([ID], [CarName], [Status], [LoadCapacity]) VALUES (4, N'ISUZU NPR75LL, 2017', N'Свободен', 5000)
SET IDENTITY_INSERT [dbo].[Car] OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([ID], [Name], [SecondName], [MiddleName], [Phone], [DateOfBirthday]) VALUES (1, N'Александр', N'Погожев', N'Сергеевич', N'79129681962', CAST(N'2004-06-24' AS Date))
INSERT [dbo].[Customer] ([ID], [Name], [SecondName], [MiddleName], [Phone], [DateOfBirthday]) VALUES (2, N'Радик', N'Имамеев', N'Алмазович', N'79121543133', CAST(N'2004-09-30' AS Date))
INSERT [dbo].[Customer] ([ID], [Name], [SecondName], [MiddleName], [Phone], [DateOfBirthday]) VALUES (4, N'Максим', N'Сухих', N'Андреевич', N'79121435629', CAST(N'2004-08-01' AS Date))
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([ID], [Name], [Weight], [DateOfOrder], [NameOfOrder]) VALUES (1, N'Погожев А.С.', 8, CAST(N'2022-06-24' AS Date), N'Набор отверток Xiaomi')
INSERT [dbo].[Order] ([ID], [Name], [Weight], [DateOfOrder], [NameOfOrder]) VALUES (2, N'Шуметов М.С.', 16, CAST(N'2012-02-12' AS Date), N'Игровой моноблок Xiaomi')
INSERT [dbo].[Order] ([ID], [Name], [Weight], [DateOfOrder], [NameOfOrder]) VALUES (5, N'Иконников А.О.', 1, CAST(N'0002-12-29' AS Date), N'Чарончик')
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
INSERT [dbo].[Role] ([Id], [Title]) VALUES (1, N'Админ')
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Name], [Email], [Password], [RoleID], [Active]) VALUES (1, N'admin', N'admin', N'123', 1, 0)
INSERT [dbo].[Users] ([Id], [Name], [Email], [Password], [RoleID], [Active]) VALUES (2, N'1', N'1', N'1', 1, 0)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[CarManager]  WITH CHECK ADD  CONSTRAINT [FK_CarManager_Car] FOREIGN KEY([CarID])
REFERENCES [dbo].[Car] ([ID])
GO
ALTER TABLE [dbo].[CarManager] CHECK CONSTRAINT [FK_CarManager_Car]
GO
ALTER TABLE [dbo].[ClientManager]  WITH CHECK ADD  CONSTRAINT [FK_ClientManager_CarManager] FOREIGN KEY([TransportationOrder])
REFERENCES [dbo].[CarManager] ([ID])
GO
ALTER TABLE [dbo].[ClientManager] CHECK CONSTRAINT [FK_ClientManager_CarManager]
GO
ALTER TABLE [dbo].[ClientManager]  WITH CHECK ADD  CONSTRAINT [FK_ClientManager_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([ID])
GO
ALTER TABLE [dbo].[ClientManager] CHECK CONSTRAINT [FK_ClientManager_Customer]
GO
ALTER TABLE [dbo].[ClientManager]  WITH CHECK ADD  CONSTRAINT [FK_ClientManager_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([ID])
GO
ALTER TABLE [dbo].[ClientManager] CHECK CONSTRAINT [FK_ClientManager_Order]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Role]
GO
