IF EXISTS (select * from sysobjects where id = object_id (N'dbo.sptGetAppUser') AND OBJECTPROPERTY (id,N'isProcedure ')=1)
	DROP PROCEDURE dbo.sptGetAppUser
GO
CREATE PROCEDURE dbo.sptGetAppUser
AS
BEGIN
 select * from dbo.ViewAppUser
END


 