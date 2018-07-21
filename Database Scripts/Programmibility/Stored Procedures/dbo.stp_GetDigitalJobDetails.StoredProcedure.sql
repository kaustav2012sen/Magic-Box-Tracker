IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'stp_GetDigitalJobDetails')
	DROP PROCEDURE [dbo].[stp_GetDigitalJobDetails]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Kaustav Sen>
-- Create date: <15/03/2018>
-- Description:	<To Get Details of All Vendors>
-- Execute: EXEC stp_GetDigitalJobDetails 
-- 
-- =============================================
CREATE PROCEDURE [dbo].[stp_GetDigitalJobDetails]
(
@JobHead INT=1
)
AS
BEGIN
SET NOCOUNT ON;

---------------------------------------Declare Generic Tables-------------------------------
DECLARE @JOBID TABLE
(JobID INT)


/***************************************SECTION FOR CLIENTS********************************/

	SELECT [ClientID],[ClientName] FROM Clients

/***************************************SECTION FOR PAPERS********************************/

	SELECT PaperID,PaperType FROM Papers

/***************************************SECTION FOR MACHINE WITH RESPECTIVE JOBS********************************/

	INSERT INTO @JOBID 
	SELECT JobID FROM  Job WHERE MasterJobID =1 OR JobID=1

	--SELECT * FROM @JOBID

	SELECT TM1.MachineID,TM1.MachineDescription,
	TJ1.JobDescription
	  FROM Machine TM1
	 INNER JOIN Job TJ1 ON TJ1.JobID=TM1.JobCategory	 
	 Where TM1.JobCategory IN (SELECT J1.JobID FROM @JOBID J1)

/***************************************SECTION FOR FETCHING DIGITAL JOBS********************************/

	 SELECT 
	 PK_intJobCardID AS JobCardID,
	 ClientName,
	 PaperType,
	 MachineDescription,
	 Paper_Quantity,
	 Print_Quantity,
	 JobDescription 
	 FROM ViewDigitalJobDeatils
END
GO