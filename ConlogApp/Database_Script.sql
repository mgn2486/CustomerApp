USE [ConlogDb]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 2/19/2022 6:58:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NOT NULL,
	[DateOfBirth] [datetime] NOT NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[customer] ON 
GO
INSERT [dbo].[customer] ([Id], [Name], [DateOfBirth]) VALUES (1, N'John Wick', CAST(N'1985-05-24T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[customer] ([Id], [Name], [DateOfBirth]) VALUES (2, N'Ludacris', CAST(N'2005-05-24T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[customer] ([Id], [Name], [DateOfBirth]) VALUES (3, N'Chief Justice', CAST(N'1920-05-24T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[customer] OFF
GO



 -- The proc
 
USE [ConlogDb]
GO

/****** Object:  StoredProcedure [dbo].[spGetAllCustomers]    Script Date: 2/19/2022 7:00:24 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pr_GetCustomers]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * 
	FROM customer
	ORDER BY DateOfBirth
END
GO