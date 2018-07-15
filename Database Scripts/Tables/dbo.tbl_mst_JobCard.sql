IF NOT EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'tbl_mst_JobCard')
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_mst_JobCard](
	[PK_intJobCardID] [int] IDENTITY(100,1) NOT NULL,
	[FK_intClientID] [int] NOT NULL,
	[FK_IntPrinterID] [int] NOT NULL,
	[Paper_Quantity] [int] NULL,
	[Print_Quantity] [int] NULL,
	[dt_Created] [datetime] NOT NULL,
	[dt_LastModified] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
	[JobDescription] [nvarchar](max) NULL,
	[FK_intJobID] [int] NULL,
 CONSTRAINT [PK_tbl_mst_JobCard] PRIMARY KEY CLUSTERED 
(
	[PK_intJobCardID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO




