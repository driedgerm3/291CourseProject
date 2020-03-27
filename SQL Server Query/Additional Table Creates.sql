USE [291_Project]
GO

/****** Object:  Table [dbo].[IDTracker]    Script Date: 3/27/2020 5:02:20 PM ******/
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

INSERT [dbo].[IDTracker] ([Branch_ID], [Car_ID], [Type_ID], [Customer_ID], [Employee_ID], [Rental_ID]) VALUES (4, 13, 13, 9, 10, 4)

/****** Object:  Table [dbo].[Rented]    Script Date: 3/27/2020 5:21:10 PM ******/
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

INSERT [dbo].[Rented] ([Rental_ID], [Car_ID]) VALUES (1, 2)
INSERT [dbo].[Rented] ([Rental_ID], [Car_ID]) VALUES (2, 5)
INSERT [dbo].[Rented] ([Rental_ID], [Car_ID]) VALUES (3, 10)