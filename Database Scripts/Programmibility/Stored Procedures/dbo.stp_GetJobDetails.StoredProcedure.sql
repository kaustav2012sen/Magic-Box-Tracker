IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'stp_GetJobDetails')
	DROP PROCEDURE [dbo].[stp_GetJobDetails]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Moumita>
-- Create date: <15/03/2018>
-- Description:	<To Get Details of All Job>
-- Execute: EXEC stp_GetJobDetails
-- MenuTag: 0-View, 1-Insert, 2-Update, 3-Delete
-- =============================================
CREATE PROCEDURE [dbo].[stp_GetJobDetails]
(
	@JobID INT = 0,
	@JobDescription VARCHAR (100) = NULL,
	@MasterJobId INT = NULL,
	@MenuTag INT=0
)
	
AS
SET NOCOUNT ON;
BEGIN

DECLARE @Status INT=0;

IF @MenuTag = 0
BEGIN 
	IF @JobID>0
		BEGIN
			SELECT 
				JB.JobID AS JobID, 
				JB.JobDescription AS JobDescription,
				JB.MasterJobId AS MasterJobId
				FROM Job JB WHERE JB.JobID=@JobID;
		END
	ELSE
		BEGIN
				SELECT 
				JB.JobID AS JobID, 
				JB.JobDescription AS JobDescription,
				JB.MasterJobId AS MasterJobId
				FROM Job JB
		END
END

ELSE IF @MenuTag = 1
BEGIN
		INSERT INTO Job
		VALUES (@JobDescription, @MasterJobId)

		SET @Status=1
		SELECT @Status AS [Status]
END

ELSE IF @MenuTag = 2
BEGIN
		UPDATE Job
		SET JobDescription = @JobDescription, MasterJobId = @MasterJobId
		WHERE JobID = @JobID
END
ELSE IF @MenuTag = 3
BEGIN
		DELETE FROM Job
		WHERE JobID = @JobID
END
END