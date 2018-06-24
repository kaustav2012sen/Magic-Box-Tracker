USE [erp_generic_magicbox]
GO

/****** Object:  Table [dbo].[Clients]    Script Date: 24-Jun-18 07:42:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clients](
	[clientId] [int] IDENTITY(1,1) NOT NULL,
	[clientName] [nvarchar](max) NOT NULL,
	[clientAddress] [nvarchar](max) NULL,
	[clientContact] [float] NOT NULL,
	[clientPAN] [nvarchar](max) NULL,
	[clientGST] [nvarchar](max) NULL,
	[clientRemarks] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Clients] PRIMARY KEY CLUSTERED 
(
	[clientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


