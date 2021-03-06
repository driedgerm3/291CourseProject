USE [291_Project]
GO
/****** Object:  Table [dbo].[BelongsTo]    Script Date: 2020-04-02 1:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BelongsTo](
	[Type_ID] [varchar](30) NOT NULL,
	[Car_ID] [int] NOT NULL,
 CONSTRAINT [PK_Belongs To] PRIMARY KEY CLUSTERED 
(
	[Type_ID] ASC,
	[Car_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Branch]    Script Date: 4/2/2020 2:45:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branch](
	[Branch_ID] [varchar](30) NOT NULL,
	[Street] [nvarchar](max) NULL,
	[Bld_Num] [int] NULL,
	[City] [nvarchar](max) NULL,
	[ZIP] [nchar](6) NULL,
 CONSTRAINT [PK_Branch_1] PRIMARY KEY CLUSTERED 
(
	[Branch_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[Car_ID] [int] NOT NULL,
	[Type_ID] [varchar](30) NULL,
	[Branch_ID] [varchar](30) NULL,
	[Passengers] [nchar](10) NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[Car_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Car_Type]    Script Date: 4/2/2020 2:38:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car_Type](
	[Type_ID] [varchar](30) NOT NULL,
	[Rank] [int] NULL,
	[Daily_Price] [int] NULL,
	[Weekly_Price] [int] NULL,
	[Monthly_Price] [int] NULL,
 CONSTRAINT [PK_Car_Type_1] PRIMARY KEY CLUSTERED 
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
	[Branch_ID] [varchar](30) NOT NULL,
	[Rental_ID] [int] NOT NULL,
 CONSTRAINT [PK_Drop-off] PRIMARY KEY CLUSTERED 
(
	[Branch_ID] ASC,
	[Rental_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 4/2/2020 3:05:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Employee_ID] [int] NOT NULL,
	[First_Name] [nvarchar](max) NULL,
	[Last_Name] [nvarchar](max) NULL,
	[Branch_ID] [varchar](30) NULL,
 CONSTRAINT [PK_Employee_1] PRIMARY KEY CLUSTERED 
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
	[Branch_ID] [varchar](30) NOT NULL,
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
	[Branch_ID] [varchar](30) NOT NULL,
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
CREATE TABLE [dbo].[Pickup](
	[Branch_ID] [varchar](30) NOT NULL,
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
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES ('Charger', 1)
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES ('Colorado', 2)
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES ('Corvette', 3)
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES ('Equinox', 4)
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES ('Focus', 5)
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES ('Impala', 6)
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES ('Malibu', 7)
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES ('Silverado', 8)
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES ('Spark', 9)
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES ('Tahoe', 10)
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES ('Traverse', 11)
INSERT [dbo].[BelongsTo] ([Type_ID], [Car_ID]) VALUES ('Viper', 12)
INSERT [dbo].[Branch] ([Branch_ID], [Street], [Bld_Num], [City], [ZIP]) VALUES ('Edmonton', N'100', 1, N'Edmonton', N'000001')
INSERT [dbo].[Branch] ([Branch_ID], [Street], [Bld_Num], [City], [ZIP]) VALUES ('Calgary', N'200', 2, N'Calgary', N'000002')
INSERT [dbo].[Branch] ([Branch_ID], [Street], [Bld_Num], [City], [ZIP]) VALUES ('Leduc', N'300', 3, N'Leduc', N'000003')
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (1, 'Charger', 'Edmonton', 2)
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (2, 'Colorado', 'Edmonton', 4)
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (3, 'Corvette', 'Edmonton', 6)
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (4, 'Equinox', 'Edmonton', 2)
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (5, 'Focus', 'Calgary', 4)
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (6, 'Impala', 'Calgary', 4)
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (7, 'Malibu', 'Calgary', 4)
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (8, 'Silverado', 'Calgary', 6)
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (9, 'Spark', 'Leduc', 8)
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (10, 'Tahoe', 'Leduc', 2)
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (11, 'Traverse', 'Leduc', 2)
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (12, 'Viper', 'Leduc', 6)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES ('Charger', 2, 55, 150, 450)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES ('Colorado', 4, 45, 140, 440)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES ('Corvette', 6, 35, 130, 430)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES ('Equinox', 8, 25, 120, 420)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES ('Focus', 10, 15, 110, 410)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES ('Impala', 12, 5, 100, 400)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES ('Malibu', 11, 10, 105, 405)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES ('Silverado', 9, 20, 115, 415)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES ('Spark', 7, 30, 125, 425)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES ('Tahoe', 5, 40, 135, 435)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES ('Traverse', 3, 50, 145, 445)
INSERT [dbo].[Car_Type] ([Type_ID], [Rank], [Daily_Price], [Weekly_Price], [Monthly_Price]) VALUES ('Viper', 1, 60, 155, 455)
INSERT [dbo].[Customer] ([Customer_ID], [First_Name], [Last_Name], [Num_Of_Rentals], [Membership], [Email]) VALUES (1, N'May', N'Felix', 2, 1, N'mf@email.ca')
INSERT [dbo].[Customer] ([Customer_ID], [First_Name], [Last_Name], [Num_Of_Rentals], [Membership], [Email]) VALUES (2, N'Anisha', N'Mcgrath', 5, 2, N'am@email.ca')
INSERT [dbo].[Customer] ([Customer_ID], [First_Name], [Last_Name], [Num_Of_Rentals], [Membership], [Email]) VALUES (3, N'Chloe', N'Piper', 1, 1, N'cp@email.ca')
INSERT [dbo].[Customer] ([Customer_ID], [First_Name], [Last_Name], [Num_Of_Rentals], [Membership], [Email]) VALUES (4, N'Wilbur', N'Welsh', 4, 2, N'ww@email.ca')
INSERT [dbo].[Customer] ([Customer_ID], [First_Name], [Last_Name], [Num_Of_Rentals], [Membership], [Email]) VALUES (5, N'Alisha', N'Lugo', 9, 2, N'al@gmail.ca')
INSERT [dbo].[Customer] ([Customer_ID], [First_Name], [Last_Name], [Num_Of_Rentals], [Membership], [Email]) VALUES (6, N'Hawwa', N'Randolph', 1, 1, N'hr@email.ca')
INSERT [dbo].[Customer] ([Customer_ID], [First_Name], [Last_Name], [Num_Of_Rentals], [Membership], [Email]) VALUES (7, N'Gemma', N'Ayala', 2, 1, N'ga@email.ca')
INSERT [dbo].[Customer] ([Customer_ID], [First_Name], [Last_Name], [Num_Of_Rentals], [Membership], [Email]) VALUES (8, N'Shamas', N'Rivas', 5, 2, N'sr@email.ca')
INSERT [dbo].[Dropoff] ([Branch_ID], [Rental_ID]) VALUES ('Calgary', 2)
INSERT [dbo].[Dropoff] ([Branch_ID], [Rental_ID]) VALUES ('Calgary', 3)
INSERT [dbo].[Dropoff] ([Branch_ID], [Rental_ID]) VALUES ('Leduc', 1)
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (1, N'Neil', N'Gray', 'Edmonton')
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (2, N'Alby', N'Dale', 'Edmonton')
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (3, N'Ellise', N'Hart', 'Edmonton')
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (4, N'Maxwell', N'Johnston', 'Calgary')
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (5, N'Ivie', N'Walmsley', 'Calgary')
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (6, N'Nisha', N'Mcnamara', 'Calgary')
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (7, N'Frida', N'Shields', 'Leduc')
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (8, N'Asmaa', N'Cain', 'Leduc')
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (9, N'Kohen', N'Lang', 'Leduc')
INSERT [dbo].[Employs] ([Branch_ID], [Employee_ID]) VALUES ('Edmonton', 1)
INSERT [dbo].[Employs] ([Branch_ID], [Employee_ID]) VALUES ('Edmonton', 2)
INSERT [dbo].[Employs] ([Branch_ID], [Employee_ID]) VALUES ('Edmonton', 3)
INSERT [dbo].[Employs] ([Branch_ID], [Employee_ID]) VALUES ('Calgary', 4)
INSERT [dbo].[Employs] ([Branch_ID], [Employee_ID]) VALUES ('Calgary', 5)
INSERT [dbo].[Employs] ([Branch_ID], [Employee_ID]) VALUES ('Calgary', 6)
INSERT [dbo].[Employs] ([Branch_ID], [Employee_ID]) VALUES ('Leduc', 7)
INSERT [dbo].[Employs] ([Branch_ID], [Employee_ID]) VALUES ('Leduc', 8)
INSERT [dbo].[Employs] ([Branch_ID], [Employee_ID]) VALUES ('Leduc', 9)
INSERT [dbo].[IDTracker] ([Branch_ID], [Car_ID], [Type_ID], [Customer_ID], [Employee_ID], [Rental_ID]) VALUES (4, 13, 13, 9, 10, 6)
INSERT [dbo].[OngoingTransactions] ([Customer_ID], [Rental_ID]) VALUES (1, 1)
INSERT [dbo].[OngoingTransactions] ([Customer_ID], [Rental_ID]) VALUES (4, 2)
INSERT [dbo].[OngoingTransactions] ([Customer_ID], [Rental_ID]) VALUES (5, 3)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES ('Edmonton', 1)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES ('Edmonton', 2)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES ('Edmonton', 3)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES ('Edmonton', 4)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES ('Calgary', 5)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES ('Calgary', 6)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES ('Calgary', 7)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES ('Calgary', 8)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES ('Leduc', 9)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES ('Leduc', 10)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES ('Leduc', 11)
INSERT [dbo].[Owns] ([Branch_ID], [Car_ID]) VALUES ('Leduc', 12)
INSERT [dbo].[Pickup] ([Branch_ID], [Rental_ID]) VALUES ('Edmonton', 2)
INSERT [dbo].[Pickup] ([Branch_ID], [Rental_ID]) VALUES ('Calgary', 3)
INSERT [dbo].[Pickup] ([Branch_ID], [Rental_ID]) VALUES ('Leduc', 1)
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
