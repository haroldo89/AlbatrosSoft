IF EXISTS (select * from sysobjects where id = object_id (N'dbo.sptGetCustomer') AND OBJECTPROPERTY (id,N'isProcedure ')=1)
	DROP PROCEDURE dbo.sptGetCustomer
GO
CREATE PROCEDURE dbo.sptGetCustomer
AS
BEGIN
 select * from dbo.ViewCustomer
END

 
	
	



