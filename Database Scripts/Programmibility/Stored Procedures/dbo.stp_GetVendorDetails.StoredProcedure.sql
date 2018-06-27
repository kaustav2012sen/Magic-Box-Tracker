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
-- Description:	<To Get Details of All Clients>
-- Execute: EXEC stp_GetVendorDetails 1,'Rahul Das Naskar','',9831214339,'','','',0
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

IF @MenuTag = 0
		SELECT 
		MC.VendorId AS VendorID, 
		MC.VendorName AS VendorName,
		MC.VendorAddress AS VendorAddress,
		MC.VendorContact AS VendorContact,
		MC.VendorEmail AS VendorEmail,
		MC.VendorGST AS VendorGST,
		MC.VendorPAN AS VendorPAN,
		MC.VendorRemarks AS VendorRemarks
		FROM Vendors MC

ELSE IF @MenuTag = 1
		INSERT INTO Vendors
		VALUES (@VendorName, @VendorAddress, @VendorContact, @VendorEmail, @VendorGST, @VendorPAN, @VendorRemarks)

ELSE IF @MenuTag = 2
		UPDATE Vendors
		SET VendorName = @VendorName, VendorAddress = @VendorAddress, VendorContact = @VendorContact, VendorEmail = @VendorEmail ,VendorGST = @VendorGST, VendorPAN = @VendorPAN, VendorRemarks = @VendorRemarks
		WHERE VendorId = @VendorID

ELSE IF @MenuTag = 3
		DELETE FROM Vendors
		WHERE VendorId = @VendorID
END
GO