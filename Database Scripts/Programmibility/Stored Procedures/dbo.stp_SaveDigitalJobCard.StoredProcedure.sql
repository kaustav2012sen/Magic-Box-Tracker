IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'stp_SaveDigitalJobCard')
	DROP PROCEDURE [dbo].[stp_SaveDigitalJobCard]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Kaustav Sen>
-- Create date: <15/04/2018>
-- Description:	<To Save Details of the Job Card>
-- Execute: EXEC stp_SaveDigitalJobCard
-- 
-- =============================================
CREATE PROCEDURE [dbo].[stp_SaveDigitalJobCard]
(
	@JobCardID INT=0,
	@ClientID INT=0,
	@PrinterID INT=0,
	@PaperID INT=1,
	@PaperQuantity INT=0,
	@PrintQuantity INT=0,
	@DigitalRemarks NVARCHAR(MAX),	
	@Status INT=0 OUTPUT
)

AS
BEGIN
SET NOCOUNT ON;
DECLARE @JobID INT=0;

SELECT @JobID=(SELECT JobCategory FROM Machine WHERE MachineID=@PrinterID);

	IF @JobCardID=0
	BEGIN
		INSERT INTO tbl_mst_JobCard
		(FK_intClientID,
		FK_IntPrinterID,
		FK_intPaperID,
		Paper_Quantity,
		Print_Quantity,
		JobDescription,
		dt_Created,
		FK_intJobID)
		VALUES
		(@ClientID,
		@PrinterID,
		@PaperID,
		@PaperQuantity,
		@PrintQuantity,
		@DigitalRemarks,
		GETUTCDATE(),
		@JobID)
	
	SET @Status=SCOPE_IDENTITY();

	END
	ELSE
	BEGIN
		UPDATE tbl_mst_JobCard SET
		FK_intClientID=@ClientID,
		FK_IntPrinterID=@PrinterID,
		FK_intPaperID=@PaperID,
		Paper_Quantity=@PaperQuantity,
		Print_Quantity=@PrintQuantity,
		JobDescription=@DigitalRemarks,
		dt_Created=GETUTCDATE(),
		FK_intJobID=@JobID
		WHERE PK_intJobCardID=@JobCardID

		SET @Status=-3;
	END


END
GO