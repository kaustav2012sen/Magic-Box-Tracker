IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'stp_GetDigitalJobDetailsByID')
	DROP PROCEDURE [dbo].[stp_GetDigitalJobDetailsByID]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Kaustav Sen>
-- Create date: <15/03/2018>
-- Description:	<To Get Details of Job Details by ID>
-- Execute: EXEC stp_GetDigitalJobDetailsByID @JobCardID=103
-- 
-- =============================================
CREATE PROCEDURE [dbo].[stp_GetDigitalJobDetailsByID]
(
@JobCardID INT=0
)
AS
BEGIN
SET NOCOUNT ON;

			SELECT PK_intJobCardID,
			FK_intClientID AS ClientID,
			FK_IntPrinterID AS PrinterID,
			FK_intPaperID AS PaperID,
			Paper_Quantity,
			Print_Quantity,
			JobDescription 
			FROM tbl_mst_JobCard WHERE PK_intJobCardID=@JobCardID;
END