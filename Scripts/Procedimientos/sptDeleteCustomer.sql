IF EXISTS (select * from sysobjects where id = object_id (N'dbo.sptDeleteCustomer') AND OBJECTPROPERTY (id,N'isProcedure ')=1)
	DROP PROCEDURE dbo.sptDeleteCustomer
GO
CREATE PROCEDURE dbo.sptDeleteCustomer 
(
	@document INT,
	@resultMessage VARCHAR(200) OUTPUT
)
AS
BEGIN
	SET NOCOUNT ON;
	SET @resultMessage = '';
	IF NOT EXISTS (SELECT document FROM Customer WHERE document = @document )
		BEGIN
			SET @resultMessage = 'No es posible eliminar el Cliente, porque el cliente con el documento no existe en el sistema';
		END
	ELSE
		BEGIN
			DELETE Customer WHERE Document = @document
	END
END