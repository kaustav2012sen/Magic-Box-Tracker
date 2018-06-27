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
-- Execute: EXEC stp_GetClientDetails 1,'Rahul Das Naskar','',9831214339,'','','',0
-- MenuTag: 0-View, 1-Insert, 2-Update, 3-Delete
-- =============================================
CREATE PROCEDURE [dbo].[stp_GetClientDetails]
(
	@ClientID INT = 0,
	@ClientName VARCHAR (100) = NULL,
	@ClientAddress VARCHAR(500) = NULL,
	@ClientContact FLOAT = 0.0,
	@ClientGST VARCHAR(20) = NULL,
	@ClientPAN VARCHAR(10) = NULL,
	@ClientRemarks VARCHAR(100) = NULL,
	@MenuTag INT=0
)
	
AS
SET NOCOUNT ON;
BEGIN

DECLARE @Status INT=0;

IF @MenuTag = 0
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

ELSE IF @MenuTag = 1
BEGIN
		INSERT INTO Clients
		VALUES (@ClientName, @ClientAddress, @ClientContact, @ClientGST, @ClientPAN, @ClientRemarks)

		SET @Status=1
		SELECT @Status AS [Status]
END

ELSE IF @MenuTag = 2
BEGIN
		UPDATE Clients
		SET clientName = @ClientName, ClientAddress = @ClientAddress, ClientContact = @ClientContact, ClientGST = @ClientGST, ClientPAN = @ClientPAN, ClientRemarks = @ClientRemarks
		WHERE clientId = @ClientID
END
ELSE IF @MenuTag = 3
BEGIN
		DELETE FROM Clients
		WHERE clientId = @ClientID
END
END
GO