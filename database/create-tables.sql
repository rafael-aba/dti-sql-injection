USE [MAIN_DATABASE]
GO

CREATE TABLE [dbo].[users](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[permission] [varchar](10) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[userHash] [varchar](255) NOT NULL,
	[cpf] [varchar](14) NOT NULL,
	[address] [varchar](255) NOT NULL,
	[insertDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[products](
	[productId] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NOT NULL,
	[productName] [varchar](255) NOT NULL,
	[price] [decimal](16,2) NOT NULL,
	[sold] [bit] NOT NULL,
	[insertDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED
(
	[productId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO

CREATE TABLE [dbo].[sales](
	[salesId] [int] IDENTITY(1,1) NOT NULL,
	[productId] [int] NOT NULL,
	[userIdSeller] [int] NOT NULL,
	[userIdBuyer] [int] NOT NULL,
	[price] [decimal] NOT NULL,
	[insertDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED
(
	[salesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO




