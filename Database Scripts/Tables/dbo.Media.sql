USE [erp_generic_magicbox]
GO

/****** Object:  Table [dbo].[Media]    Script Date: 24-Jun-18 22:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Media](
	[MediaID] [int] IDENTITY(1,1) NOT NULL,
	[MediaType] [nvarchar](max) NOT NULL,
	[Remarks] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Media] PRIMARY KEY CLUSTERED 
(
	[MediaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


