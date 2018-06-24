USE [erp_generic_magicbox]
GO

/****** Object:  Table [dbo].[Vendors]    Script Date: 24-Jun-18 22:53:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Vendors](
	[VendorID] [int] IDENTITY(1,1) NOT NULL,
	[VendorName] [nvarchar](max) NOT NULL,
	[VendorAddress] [nvarchar](max) NULL,
	[VendorContact] [float] NOT NULL,
	[VendorEmail] [nvarchar](max) NULL,
	[VendorPAN] [nvarchar](max) NULL,
	[VendorGST] [nvarchar](max) NULL,
	[VendorRemarks] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Vendors] PRIMARY KEY CLUSTERED 
(
	[VendorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


