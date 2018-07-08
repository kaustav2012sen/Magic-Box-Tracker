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

	SELECT [ClientID],[ClientName] FROM Clients

	SELECT PaperID,PaperType FROM Papers

	SELECT MachineID,MachineDescription,JobCategory FROM Machine
END
GO