IF EXISTS (SELECT * FROM sysobjects where id = object_id(N'[dbo].[ViewAppUser]'))
DROP VIEW dbo.ViewAppUser
GO
CREATE VIEW dbo.ViewAppUser
AS 
	Select * From dbo.AppUser
GO

