IF EXISTS (SELECT * FROM sys.views WHERE type = 'V' AND name = 'ViewDigitalJobDeatils')
	DROP VIEW [dbo].[ViewDigitalJobDeatils]
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

CREATE VIEW [dbo].[ViewDigitalJobDeatils]
AS

SELECT TMJC.PK_intJobCardID,C1.ClientName,M1.MachineDescription,TMJC.Paper_Quantity,TMJC.Print_Quantity,J1.JobDescription,P1.PaperType
FROM tbl_mst_JobCard TMJC 
INNER JOIN Clients C1 ON TMJC.FK_intClientID=C1.clientId
INNER JOIN Machine M1 ON TMJC.FK_IntPrinterID=M1.MachineID
INNER JOIN Papers P1 ON TMJC.FK_intPaperID=P1.PaperID
INNER JOIN Job J1 ON TMJC.FK_intJobID=J1.JobID

GO
