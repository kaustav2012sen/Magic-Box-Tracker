IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'stp_GetClientDetails')
	DROP PROCEDURE [dbo].[stp_GetClientDetails]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Kaustav Sen>
-- Create date: <15/03/2018>
-- Description:	<To Get Details of All Clients>
-- Execute: EXEC stp_GetClientDetails
-- =============================================
CREATE PROCEDURE [dbo].[stp_GetClientDetails]
	
AS
SET NOCOUNT ON;
BEGIN


		SELECT 
		MC.clientId AS ClientID, 
		MC.clientName AS ClientName,
		MC.clientAddress AS ClientAddress,
		MC.clientContact AS ClientContact,
		MC.clientGST AS ClientGST,
		MC.clientPAN AS ClientPAN,
		MC.clientRemarks AS ClientRemarks
		FROM Clients MC

END
GO