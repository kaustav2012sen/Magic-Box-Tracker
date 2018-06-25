USE [erp_generic_magicbox]
GO

/****** Object:  Table [dbo].[Papers]    Script Date: 24-Jun-18 22:52:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Papers](
	[PaperID] [int] IDENTITY(1,1) NOT NULL,
	[PaperType] [nvarchar](max) NOT NULL,
	[PaperRemarks] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Papers] PRIMARY KEY CLUSTERED 
(
	[PaperID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


