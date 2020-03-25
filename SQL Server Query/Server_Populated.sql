USE [291_Project]
GO
/****** Object:  Table [dbo].[Branch]    Script Date: 2020-03-25 3:33:23 PM ******/
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
/****** Object:  Table [dbo].[Car]    Script Date: 2020-03-25 3:33:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[Car_ID] [int] NOT NULL,
	[Type_ID] [int] NULL,
	[Branch_ID] [int] NULL,
	[Passengers] [int] NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[Car_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Car_Type]    Script Date: 2020-03-25 3:33:23 PM ******/
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
/****** Object:  Table [dbo].[Customer]    Script Date: 2020-03-25 3:33:23 PM ******/
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
/****** Object:  Table [dbo].[Employee]    Script Date: 2020-03-25 3:33:23 PM ******/
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
/****** Object:  Table [dbo].[Rental]    Script Date: 2020-03-25 3:33:23 PM ******/
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
INSERT [dbo].[Branch] ([Branch_ID], [Street], [Bld_Num], [City], [ZIP]) VALUES (1, N'100', 1, N'Calgary', N'000001')
INSERT [dbo].[Branch] ([Branch_ID], [Street], [Bld_Num], [City], [ZIP]) VALUES (2, N'200', 2, N'Edmonton', N'000002')
INSERT [dbo].[Branch] ([Branch_ID], [Street], [Bld_Num], [City], [ZIP]) VALUES (3, N'300', 3, N'Leduc', N'000003')
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (1, 1, 1, 2)
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (2, 2, 1, 4)
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (3, 3, 1, 6)
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (4, 4, 1, 2)
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (5, 5, 2, 4)
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (6, 6, 2, 4)
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (7, 7, 2, 4)
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (8, 8, 2, 6)
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (9, 9, 3, 8)
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (10, 10, 3, 2)
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (11, 11, 3, 2)
INSERT [dbo].[Car] ([Car_ID], [Type_ID], [Branch_ID], [Passengers]) VALUES (12, 12, 3, 6)
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
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (1, N'Neil', N'Gray', 1)
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (2, N'Alby', N'Dale', 1)
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (3, N'Ellise', N'Hart', 1)
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (4, N'Maxwell', N'Johnston', 2)
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (5, N'Ivie', N'Walmsley', 2)
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (6, N'Nisha', N'Mcnamara', 2)
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (7, N'Frida', N'Shields', 3)
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (8, N'Asmaa', N'Cain', 3)
INSERT [dbo].[Employee] ([Employee_ID], [First_Name], [Last_Name], [Branch_ID]) VALUES (9, N'Kohen', N'Lang', 3)
INSERT [dbo].[Rental] ([Rental_ID], [Rental_Type], [Pickup_Date], [Pickup_time], [Return_Date], [Return_Time]) VALUES (1, 1, CAST(N'2020-01-01' AS Date), CAST(N'08:00:00' AS Time), CAST(N'2020-01-28' AS Date), CAST(N'12:00:00' AS Time))
INSERT [dbo].[Rental] ([Rental_ID], [Rental_Type], [Pickup_Date], [Pickup_time], [Return_Date], [Return_Time]) VALUES (2, 2, CAST(N'2020-03-15' AS Date), CAST(N'15:00:00' AS Time), CAST(N'2020-05-12' AS Date), CAST(N'18:00:00' AS Time))
INSERT [dbo].[Rental] ([Rental_ID], [Rental_Type], [Pickup_Date], [Pickup_time], [Return_Date], [Return_Time]) VALUES (3, 3, CAST(N'2020-02-04' AS Date), CAST(N'09:00:00' AS Time), CAST(N'2020-08-20' AS Date), CAST(N'06:00:00' AS Time))
