USE [291_Project]
GO
/****** Object:  Table [dbo].[BelongsTo]    Script Date: 2020-04-02 1:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BelongsTo](
	[Type_ID] [int] NOT NULL,
	[Car_ID] [int] NOT NULL,
 CONSTRAINT [PK_Belongs To] PRIMARY KEY CLUSTERED 
(
	[Type_ID] ASC,
	[Car_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Branch]    Script Date: 2020-04-02 1:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branch](
	[Branch_ID] [int] NOT NULL,
	[Street] [nvarchar](max) NULL,
	[Bld_Num] [int] NULL,
	[City] [nvarchar](max) NULL,
	[ZIP] [nchar](6) NULL,
 CONSTRAINT [PK_Branch] PRIMARY KEY CLUSTERED 
(
	[Branch_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Car]    Script Date: 2020-04-02 1:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[Car_ID] [int] NOT NULL,
	[Type_ID] [int] NULL,
	[Branch_ID] [int] NULL,
	[Passengers] [int] NULL,
	[Model] [nvarchar](max) NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[Car_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Car_Type]    Script Date: 2020-04-02 1:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car_Type](
	[Type_ID] [int] NOT NULL,
	[Rank] [int] NULL,
	[Daily_Price] [int] NULL,
	[Weekly_Price] [int] NULL,
	[Monthly_Price] [int] NULL,
 CONSTRAINT [PK_Car_Type] PRIMARY KEY CLUSTERED 
(
	[Type_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2020-04-02 1:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Customer_ID] [int] NOT NULL,
	[First_Name] [nvarchar](max) NULL,
	[Last_Name] [nvarchar](max) NULL,
	[Num_Of_Rentals] [int] NULL,
	[Membership] [int] NULL,
	[Email] [varchar](max) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Customer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dropoff]    Script Date: 2020-04-02 1:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dropoff](
	[Branch_ID] [int] NOT NULL,
	[Rental_ID] [int] NOT NULL,
 CONSTRAINT [PK_Drop-off] PRIMARY KEY CLUSTERED 
(
	[Branch_ID] ASC,
	[Rental_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 2020-04-02 1:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Employee_ID] [int] NOT NULL,
	[First_Name] [nvarchar](max) NULL,
	[Last_Name] [nvarchar](max) NULL,
	[Branch_ID] [int] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Employee_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employs]    Script Date: 2020-04-02 1:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employs](
	[Branch_ID] [int] NOT NULL,
	[Employee_ID] [int] NOT NULL,
 CONSTRAINT [PK_Employs] PRIMARY KEY CLUSTERED 
(
	[Branch_ID] ASC,
	[Employee_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IDTracker]    Script Date: 2020-04-02 1:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IDTracker](
	[Branch_ID] [int] NOT NULL,
	[Car_ID] [int] NOT NULL,
	[Type_ID] [int] NOT NULL,
	[Customer_ID] [int] NOT NULL,
	[Employee_ID] [int] NOT NULL,
	[Rental_ID] [int] NOT NULL,
 CONSTRAINT [PK_IDTracker] PRIMARY KEY CLUSTERED 
(
	[Branch_ID] ASC,
	[Car_ID] ASC,
	[Type_ID] ASC,
	[Customer_ID] ASC,
	[Employee_ID] ASC,
	[Rental_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OngoingTransactions]    Script Date: 2020-04-02 1:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OngoingTransactions](
	[Customer_ID] [int] NOT NULL,
	[Rental_ID] [int] NOT NULL,
 CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED 
(
	[Customer_ID] ASC,
	[Rental_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Owns]    Script Date: 2020-04-02 1:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Owns](
	[Branch_ID] [int] NOT NULL,
	[Car_ID] [int] NOT NULL,
 CONSTRAINT [PK_Owns] PRIMARY KEY CLUSTERED 
(
	[Branch_ID] ASC,
	[Car_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PickUp]    Script Date: 2020-04-02 1:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PickUp](
	[Branch_ID] [int] NOT NULL,
	[Rental_ID] [int] NOT NULL,
 CONSTRAINT [PK_Pick-Up] PRIMARY KEY CLUSTERED 
(
	[Branch_ID] ASC,
	[Rental_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProcessedTransactions]    Script Date: 2020-04-02 1:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProcessedTransactions](
	[Customer_ID] [int] NOT NULL,
	[Rental_ID] [int] NOT NULL,
 CONSTRAINT [PK_ProcessedTransactions] PRIMARY KEY CLUSTERED 
(
	[Customer_ID] ASC,
	[Rental_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rental]    Script Date: 2020-04-02 1:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rental](
	[Rental_ID] [int] NOT NULL,
	[Rental_Type] [int] NULL,
	[Pickup_Date] [date] NULL,
	[Pickup_time] [time](7) NULL,
	[Return_Date] [date] NULL,
	[Return_Time] [time](7) NULL,
 CONSTRAINT [PK_Rental] PRIMARY KEY CLUSTERED 
(
	[Rental_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rented]    Script Date: 2020-04-02 1:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rented](
	[Rental_ID] [int] NOT NULL,
	[Car_ID] [int] NOT NULL,
 CONSTRAINT [PK_Rented] PRIMARY KEY CLUSTERED 
(
	[Rental_ID] ASC,
	[Car_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES (1, 1)
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES (2, 2)
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES (3, 3)
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES (4, 4)
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES (5, 5)
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES (6, 6)
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES (7, 7)
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES (8, 8)
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES (9, 9)
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES (10, 10)
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES (11, 11)
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES (12, 12)
INSERT [dbo].[Branch] ([Branch_ID], [Street], [Bld_Num], [City], [ZIP]) VALUES (1, N'100', 1, N'Edmonton', N'000001')
INSERT [dbo].[Branch] ([Branch_ID], [Street], [Bld_Num], [City], [ZIP]) VALUES (2, N'200', 2, N'Calgary', N'000002')
INSERT [dbo].[Branch] ([Branch_ID], [Street], [Bld_Num], [City], [ZIP]) VALUES (3, N'300', 3, N'Leduc', N'000003')
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers], [Model]) VALUES (1, 1, 1, 2, N'Ford')
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers], [Model]) VALUES (2, 2, 1, 4, N'Mazda')
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers], [Model]) VALUES (3, 3, 1, 6, N'Mazda')
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers], [Model]) VALUES (4, 4, 1, 2, N'Chevrolet')
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers], [Model]) VALUES (5, 5, 2, 4, N'Chevrolet')
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers], [Model]) VALUES (6, 6, 2, 4, N'Audi')
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers], [Model]) VALUES (7, 7, 2, 4, N'BMW')
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers], [Model]) VALUES (8, 8, 2, 6, N'BMW')
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers], [Model]) VALUES (9, 9, 3, 8, N'Toyota')
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers], [Model]) VALUES (10, 10, 3, 2, N'Volkswagen')
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers], [Model]) VALUES (11, 11, 3, 2, N'Volkswagen')
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers], [Model]) VALUES (12, 12, 3, 6, N'Toyota')
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES (1, 2, 55, 150, 450)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES (2, 4, 45, 140, 440)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES (3, 6, 35, 130, 430)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES (4, 8, 25, 120, 420)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES (5, 10, 15, 110, 410)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES (6, 12, 5, 100, 400)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES (7, 11, 10, 105, 405)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES (8, 9, 20, 115, 415)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES (9, 7, 30, 125, 425)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES (10, 5, 40, 135, 435)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES (11, 3, 50, 145, 445)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES (12, 1, 60, 155, 455)
INSERT [dbo].[Customer] ([Customer_ID], [First_Name], [Last_Name], [Num_Of_Rentals], [Membership], [Email]) VALUES (1, N'May', N'Felix', 2, 1, N'mf@email.ca')
INSERT [dbo].[Customer] ([Customer_ID], [First_Name], [Last_Name], [Num_Of_Rentals], [Membership], [Email]) VALUES (2, N'Anisha', N'Mcgrath', 5, 2, N'am@email.ca')
INSERT [dbo].[Customer] ([Customer_ID], [First_Name], [Last_Name], [Num_Of_Rentals], [Membership], [Email]) VALUES (3, N'Chloe', N'Piper', 1, 1, N'cp@email.ca')
INSERT [dbo].[Customer] ([Customer_ID], [First_Name], [Last_Name], [Num_Of_Rentals], [Membership], [Email]) VALUES (4, N'Wilbur', N'Welsh', 4, 2, N'ww@email.ca')
INSERT [dbo].[Customer] ([Customer_ID], [First_Name], [Last_Name], [Num_Of_Rentals], [Membership], [Email]) VALUES (5, N'Alisha', N'Lugo', 9, 2, N'al@gmail.ca')
INSERT [dbo].[Customer] ([Customer_ID], [First_Name], [Last_Name], [Num_Of_Rentals], [Membership], [Email]) VALUES (6, N'Hawwa', N'Randolph', 1, 1, N'hr@email.ca')
INSERT [dbo].[Customer] ([Customer_ID], [First_Name], [Last_Name], [Num_Of_Rentals], [Membership], [Email]) VALUES (7, N'Gemma', N'Ayala', 2, 1, N'ga@email.ca')
INSERT [dbo].[Customer] ([Customer_ID], [First_Name], [Last_Name], [Num_Of_Rentals], [Membership], [Email]) VALUES (8, N'Shamas', N'Rivas', 5, 2, N'sr@email.ca')
INSERT [dbo].[Dropoff] ([Branch_ID], [Rental_ID]) VALUES (2, 2)
INSERT [dbo].[Dropoff] ([Branch_ID], [Rental_ID]) VALUES (2, 3)
INSERT [dbo].[Dropoff] ([Branch_ID], [Rental_ID]) VALUES (3, 1)
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (1, N'Neil', N'Gray', 1)
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (2, N'Alby', N'Dale', 1)
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (3, N'Ellise', N'Hart', 1)
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (4, N'Maxwell', N'Johnston', 2)
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (5, N'Ivie', N'Walmsley', 2)
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (6, N'Nisha', N'Mcnamara', 2)
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (7, N'Frida', N'Shields', 3)
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (8, N'Asmaa', N'Cain', 3)
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (9, N'Kohen', N'Lang', 3)
INSERT [dbo].[Employs] ([Branch_ID], [Employee_ID]) VALUES (1, 1)
INSERT [dbo].[Employs] ([Branch_ID], [Employee_ID]) VALUES (1, 2)
INSERT [dbo].[Employs] ([Branch_ID], [Employee_ID]) VALUES (1, 3)
INSERT [dbo].[Employs] ([Branch_ID], [Employee_ID]) VALUES (2, 4)
INSERT [dbo].[Employs] ([Branch_ID], [Employee_ID]) VALUES (2, 5)
INSERT [dbo].[Employs] ([Branch_ID], [Employee_ID]) VALUES (2, 6)
INSERT [dbo].[Employs] ([Branch_ID], [Employee_ID]) VALUES (3, 7)
INSERT [dbo].[Employs] ([Branch_ID], [Employee_ID]) VALUES (3, 8)
INSERT [dbo].[Employs] ([Branch_ID], [Employee_ID]) VALUES (3, 9)
INSERT [dbo].[IDTracker] ([Branch_ID], [Car_ID], [Type_ID], [Customer_ID], [Employee_ID], [Rental_ID]) VALUES (4, 13, 13, 9, 10, 4)
INSERT [dbo].[OngoingTransactions] ([Customer_ID], [Rental_ID]) VALUES (1, 1)
INSERT [dbo].[OngoingTransactions] ([Customer_ID], [Rental_ID]) VALUES (4, 2)
INSERT [dbo].[OngoingTransactions] ([Customer_ID], [Rental_ID]) VALUES (5, 3)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES (1, 1)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES (1, 2)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES (1, 3)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES (1, 4)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES (2, 5)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES (2, 6)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES (2, 7)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES (2, 8)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES (3, 9)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES (3, 10)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES (3, 11)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES (3, 12)
INSERT [dbo].[PickUp] ([Branch_ID], [Rental_ID]) VALUES (1, 2)
INSERT [dbo].[PickUp] ([Branch_ID], [Rental_ID]) VALUES (2, 3)
INSERT [dbo].[PickUp] ([Branch_ID], [Rental_ID]) VALUES (3, 1)
INSERT [dbo].[ProcessedTransactions] ([Customer_ID], [Rental_ID]) VALUES (2, 4)
INSERT [dbo].[ProcessedTransactions] ([Customer_ID], [Rental_ID]) VALUES (8, 5)
INSERT [dbo].[Rental] ([Rental_ID], [Rental_Type], [Pickup_Date], [Pickup_time], [Return_Date], [Return_Time]) VALUES (1, 1, CAST(N'2020-01-01' AS Date), CAST(N'08:00:00' AS Time), CAST(N'2020-01-05' AS Date), CAST(N'12:00:00' AS Time))
INSERT [dbo].[Rental] ([Rental_ID], [Rental_Type], [Pickup_Date], [Pickup_time], [Return_Date], [Return_Time]) VALUES (2, 2, CAST(N'2020-03-15' AS Date), CAST(N'15:00:00' AS Time), CAST(N'2020-03-30' AS Date), CAST(N'18:00:00' AS Time))
INSERT [dbo].[Rental] ([Rental_ID], [Rental_Type], [Pickup_Date], [Pickup_time], [Return_Date], [Return_Time]) VALUES (3, 3, CAST(N'2020-02-04' AS Date), CAST(N'09:00:00' AS Time), CAST(N'2020-08-04' AS Date), CAST(N'06:00:00' AS Time))
INSERT [dbo].[Rental] ([Rental_ID], [Rental_Type], [Pickup_Date], [Pickup_time], [Return_Date], [Return_Time]) VALUES (4, 1, CAST(N'2020-04-03' AS Date), CAST(N'08:00:00' AS Time), CAST(N'2020-04-08' AS Date), CAST(N'12:00:00' AS Time))
INSERT [dbo].[Rental] ([Rental_ID], [Rental_Type], [Pickup_Date], [Pickup_time], [Return_Date], [Return_Time]) VALUES (5, 2, CAST(N'2020-05-20' AS Date), CAST(N'11:00:00' AS Time), CAST(N'2020-05-30' AS Date), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Rented] ([Rental_ID], [Car_ID]) VALUES (1, 2)
INSERT [dbo].[Rented] ([Rental_ID], [Car_ID]) VALUES (2, 5)
INSERT [dbo].[Rented] ([Rental_ID], [Car_ID]) VALUES (3, 10)
