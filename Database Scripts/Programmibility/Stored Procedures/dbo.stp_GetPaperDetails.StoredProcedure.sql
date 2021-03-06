IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'stp_GetPaperDetails')
	DROP PROCEDURE [dbo].[stp_GetPaperDetails]
GO
/****** Object:  StoredProcedure [dbo].[stp_GetPaperDetails]    Script Date: 26-06-2018 01:27:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Kaustav Sen>
-- Create date: <15/03/2018>
-- Description:	<To Get Details of All Clients>
-- Execute: EXEC stp_GetPaperDetails 1,'Rahul Das Naskar','',0
-- MenuTag: 0-View, 1-Insert, 2-Update, 3-Delete
-- =============================================
CREATE PROCEDURE [dbo].[stp_GetPaperDetails]
(
	@PaperID INT = 0,
	@PaperType VARCHAR (100) = NULL,
	@PaperRemarks VARCHAR(100) = NULL,
	@MenuTag INT=0
)
	
AS
SET NOCOUNT ON;
BEGIN

IF @MenuTag = 0
		SELECT 
		MC.PaperId AS PaperID, 
		MC.PaperType AS PaperType,
		MC.PaperRemarks AS PaperRemarks
		FROM Papers MC

ELSE IF @MenuTag = 1
		INSERT INTO Papers
		VALUES (@PaperType, @PaperRemarks)

ELSE IF @MenuTag = 2
		UPDATE Papers
		SET PaperType = @PaperType, PaperRemarks = @PaperRemarks
		WHERE PaperId = @PaperID

ELSE IF @MenuTag = 3
		DELETE FROM Papers
		WHERE PaperId = @PaperID
END
GO
