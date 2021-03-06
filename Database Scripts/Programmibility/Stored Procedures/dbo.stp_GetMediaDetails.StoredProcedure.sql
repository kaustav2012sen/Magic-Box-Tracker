IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'stp_GetMediaDetails')
	DROP PROCEDURE [dbo].[stp_GetMediaDetails]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Kaustav Sen>
-- Create date: <15/03/2018>
-- Description:	<To Get Details of All Clients>
-- Execute: EXEC stp_GetMediaDetails 1,'Rahul Das Naskar','',0
-- MenuTag: 0-View, 1-Insert, 2-Update, 3-Delete
-- =============================================
CREATE PROCEDURE [dbo].[stp_GetMediaDetails]
(
	@MediaID INT = 0,
	@MediaType VARCHAR (100) = NULL,
	@MediaRemarks VARCHAR(100) = NULL,
	@MenuTag INT=0
)
	
AS
SET NOCOUNT ON;
BEGIN

IF @MenuTag = 0
		SELECT 
		MC.MediaId AS MediaID, 
		MC.MediaType AS MediaType,
		MC.Remarks AS MediaRemarks
		FROM Media MC

ELSE IF @MenuTag = 1
		INSERT INTO Media
		VALUES (@MediaType, @MediaRemarks)

ELSE IF @MenuTag = 2
		UPDATE Media
		SET MediaType = @MediaType, Remarks = @MediaRemarks
		WHERE MediaId = @MediaID

ELSE IF @MenuTag = 3
		DELETE FROM Media
		WHERE MediaId = @MediaID
END
GO
