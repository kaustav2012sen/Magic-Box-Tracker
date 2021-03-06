USE [erp_generic_magicbox]
GO
/****** Object:  StoredProcedure [dbo].[stp_GetJobDetails]    Script Date: 23-07-2018 10:37:26 PM ******/
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
ALTER PROCEDURE [dbo].[stp_GetJobDetails]
(
	@JobID INT = 0,
	@JobDescription VARCHAR (100) = NULL,
	@MasterJobID INT = NULL,
	@JobRemarks VARCHAR(100) = NULL,
	@MenuTag INT=0
)
	
AS
SET NOCOUNT ON;
BEGIN

DECLARE @Status INT=0;
IF @MenuTag = NULL
	BEGIN
		SELECT JobID, JobDescription FROM Job
	END
IF @MenuTag = 0
BEGIN 
	IF @JobID>0
		BEGIN
			SELECT 
				JB.JobID AS JobID, 
				JB.JobDescription AS JobDescription,
				JB.MasterJobID AS MasterJobId,
				JB.JobRemarks AS JobRemarks
				FROM Job JB WHERE JB.JobID=@JobID;
		END
	ELSE
		BEGIN
				--SELECT
				--JB.JobID AS JobID, 
				--JB.JobDescription AS JobDescription,
				--JB.MasterJobID AS MasterJobId,
				--JB.JobRemarks AS JobRemarks
				--FROM Job JB

		     SELECT 
			 JobID,
			 JobDescription,
			 MasterJob,
			 JobRemarks
			 FROM ViewJobDeatils
		END
END

ELSE IF @MenuTag = 1
BEGIN
		INSERT INTO Job
		VALUES (@JobDescription, @MasterJobID,@JobRemarks)

		SET @Status=1
		SELECT @Status AS [Status]
END

ELSE IF @MenuTag = 2
BEGIN
		UPDATE Job
		SET JobDescription = @JobDescription, MasterJobID = @MasterJobID, JobRemarks = @JobRemarks
		WHERE JobID = @JobID
END
ELSE IF @MenuTag = 3
BEGIN
		DELETE FROM Job
		WHERE JobID = @JobID
END
END