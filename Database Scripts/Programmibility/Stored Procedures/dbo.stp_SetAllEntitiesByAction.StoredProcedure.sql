IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'stp_SetAllEntitiesByAction')
	DROP PROCEDURE [dbo].[stp_SetAllEntitiesByAction]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Kaustav Sen>
-- Create date: <15/03/2018>
-- Description:	<To Get Details of All Clients>
-- Execute: EXEC stp_SetAllEntitiesByAction 
-- =============================================
CREATE PROCEDURE [dbo].[stp_SetAllEntitiesByAction]
(
	@Attr_Integer1 INT = 0,
	@Attr_Integer2 INT = 0,
	@Attr_Integer3 INT = 0,
	@Attr_Integer4 INT = 0,
	@Attr_Integer5 INT = 0,
	@Attr_NVarchar1 NVARCHAR(800)=NULL,
	@Attr_NVarchar2 NVARCHAR(800)=NULL,
	@Attr_NVarchar3 NVARCHAR(800)=NULL,
	@Attr_NVarchar4 NVARCHAR(800)=NULL,
	@Attr_NVarchar5 NVARCHAR(MAX)=NULL,
	@Attr_NVarchar6 NVARCHAR(400)=NULL,
	@Attr_NVarchar7 NVARCHAR(400)=NULL,
	@Attr_NVarchar8 NVARCHAR(800)=NULL,
	@Attr_NVarchar9 NVARCHAR(800)=NULL,
	@Attr_NVarchar10 NVARCHAR(MAX)=NULL,
	@Attr_Bit1 BIT =0,
	@Attr_Bit2 BIT=1,
	@Attr_Bit3 BIT=1,
	@Attr_Bit4 BIT=1,
	@Attr_Bit5 BIT=1,
	@Attr_Float1 FLOAT=0.0,
	@Attr_Float2 FLOAT=0.0,
	@Attr_Float3 FLOAT=0.0,
	@Attr_Float4 FLOAT=0.0,
	@Attr_Float5 FLOAT=0.0,
	@ActionTag INT =0, -- 0: Insert; 1: Update; 
	@MenuTag INT=0 -- 0: Client; 1: Vendor; 2: Media; 3: Paper; 4: Ink
)


AS
SET NOCOUNT ON;
BEGIN
/**********************************************General Declared Variables********************************************/

DECLARE @Status INT=0;
/**********************************************Operation For Clients*************************************************/
IF @MenuTag =0
	BEGIN
		IF @ActionTag=0
			BEGIN
				INSERT INTO Clients
				VALUES (@Attr_NVarchar1, @Attr_NVarchar2, @Attr_Float1, @Attr_NVarchar3, @Attr_NVarchar4, @Attr_NVarchar5)

				SET @Status=1
				SELECT @Status AS [Status]
			END
		ELSE
			BEGIN
				UPDATE Clients
				SET clientName = @Attr_NVarchar1, 
					clientAddress = @Attr_NVarchar2, 
					clientContact = @Attr_Float1, 
					clientGST = @Attr_NVarchar3, 
					clientPAN = @Attr_NVarchar4, 
					clientRemarks = @Attr_NVarchar5
				WHERE clientId = @Attr_Integer1
			END
	END

/********************************************Operation For Vendor*******************************************************/

IF @MenuTag =1
	BEGIN
		IF @ActionTag=0
			BEGIN
				INSERT INTO Vendors
				VALUES (@Attr_NVarchar1, @Attr_NVarchar2, @Attr_Float1, @Attr_NVarchar3, @Attr_NVarchar4, @Attr_NVarchar5, @Attr_NVarchar6)

				SET @Status=1
				SELECT @Status AS [Status]
			END
		ELSE
			BEGIN
				UPDATE Vendors
				SET VendorName = @Attr_NVarchar1, 
					VendorAddress = @Attr_NVarchar2, 
					VendorContact = @Attr_Float1, 
					VendorEmail = @Attr_NVarchar3,
					VendorGST = @Attr_NVarchar4, 
					VendorPAN = @Attr_NVarchar5, 
					VendorRemarks = @Attr_NVarchar6
				WHERE VendorId = @Attr_Integer1
			END
	END
/********************************************Operation For Media*******************************************************/

IF @MenuTag =2
	BEGIN
		IF @ActionTag=0
			BEGIN
				INSERT INTO Media
				VALUES (@Attr_NVarchar1, @Attr_NVarchar2)

				SET @Status=1
				SELECT @Status AS [Status]
			END
		ELSE
			BEGIN
				UPDATE Media
				SET MediaType = @Attr_NVarchar1, 
					Remarks = @Attr_NVarchar2
				WHERE MediaId = @Attr_Integer1
			END
	END
/********************************************Operation For Paper*******************************************************/

IF @MenuTag =3
	BEGIN
		IF @ActionTag=0
			BEGIN
				INSERT INTO Papers
				VALUES (@Attr_NVarchar1, @Attr_NVarchar2)

				SET @Status=1
				SELECT @Status AS [Status]
			END
		ELSE
			BEGIN
				UPDATE Papers
				SET PaperType = @Attr_NVarchar1, 
					PaperRemarks = @Attr_NVarchar2
				WHERE PaperId = @Attr_Integer1
			END
	END
END
GO