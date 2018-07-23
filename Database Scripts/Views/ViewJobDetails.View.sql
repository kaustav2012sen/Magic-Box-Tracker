IF EXISTS (SELECT * FROM sys.views WHERE type = 'V' AND name = 'ViewJobDeatils')
	DROP VIEW [dbo].[ViewJobDeatils]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Kaustav Sen>
-- Create date: <16/04/2018>
-- Description:	<To Get Details of All Clients>
-- Execute: select * from ViewDigitalJobDeatils
-- 
-- =============================================

CREATE VIEW [dbo].[ViewJobDeatils]
AS

SELECT A.JobID, A.JobDescription, B.JobDescription MasterJob, A.JobRemarks
FROM Job A 
LEFT OUTER JOIN Job B ON A.MasterJobID=B.JobID

GO
