IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'stp_GetVendorDetails')
	DROP PROCEDURE [dbo].[stp_GetVendorDetails]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Kaustav Sen>
-- Create date: <15/03/2018>
-- Description:	<To Get Details of All Vendors>
-- Execute: EXEC stp_GetVendorDetails @VendorID=3,@MenuTag=0
-- MenuTag: 0-View, 1-Insert, 2-Update, 3-Delete
-- =============================================
CREATE PROCEDURE [dbo].[stp_GetVendorDetails]
(
	@VendorID INT = 0,
	@VendorName VARCHAR (100) = NULL,
	@VendorAddress VARCHAR(500) = NULL,
	@VendorContact FLOAT = 0.0,
	@VendorEmail VARCHAR(20) = NULL,
	@VendorGST VARCHAR(20) = NULL,
	@VendorPAN VARCHAR(10) = NULL,
	@VendorRemarks VARCHAR(100) = NULL,
	@MenuTag INT=0
)
	
AS
SET NOCOUNT ON;
BEGIN

DECLARE @Status INT=0;

--SELECT @VendorID

IF @MenuTag = 0
BEGIN 
	IF @VendorID>0
		BEGIN
			SELECT 
				MC.VendorId AS VendorID, 
				MC.VendorName AS VendorName,
				MC.VendorAddress AS VendorAddress,
				MC.VendorContact AS VendorContact,
				MC.VendorEmail as VendorEmail,
				MC.VendorGST AS VendorGST,
				MC.VendorPAN AS VendorPAN,
				MC.VendorRemarks AS VendorRemarks
				FROM Vendors MC WHERE MC.VendorId=@VendorID;
		END
	ELSE
		BEGIN
				SELECT 
				MC.VendorId AS VendorID, 
				MC.VendorName AS VendorName,
				MC.VendorAddress AS VendorAddress,
				MC.VendorContact AS VendorContact,
				MC.VendorEmail as VendorEmail,
				MC.VendorGST AS VendorGST,
				MC.VendorPAN AS VendorPAN,
				MC.VendorRemarks AS VendorRemarks
				FROM Vendors MC
		END
END

ELSE IF @MenuTag = 1
BEGIN
		INSERT INTO Vendors
		VALUES (@VendorName, @VendorAddress, @VendorContact, @VendorEmail, @VendorGST, @VendorPAN, @VendorRemarks)

		SET @Status=1
		SELECT @Status AS [Status]
END

ELSE IF @MenuTag = 2
BEGIN
		UPDATE Vendors
		SET VendorName = @VendorName, VendorAddress = @VendorAddress, VendorContact = @VendorContact, VendorGST = @VendorGST, VendorPAN = @VendorPAN, VendorRemarks = @VendorRemarks
		WHERE VendorId = @VendorID
END
ELSE IF @MenuTag = 3
BEGIN
		DELETE FROM Vendors
		WHERE VendorId = @VendorID
END
END