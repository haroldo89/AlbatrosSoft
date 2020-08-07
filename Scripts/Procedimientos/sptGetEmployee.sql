IF EXISTS (select * from sysobjects where id = object_id (N'dbo.sptGetEmployee') AND OBJECTPROPERTY (id,N'isProcedure ')=1)
	DROP PROCEDURE dbo.sptGetEmployee
GO
CREATE PROCEDURE dbo.sptGetEmployee
AS
BEGIN
 select * from ViewEmployee
END


 
	
	



