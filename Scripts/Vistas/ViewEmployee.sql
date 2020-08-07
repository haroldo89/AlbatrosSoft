IF EXISTS (SELECT * FROM sysobjects where id = object_id(N'[dbo].[ViewEmployee]'))
DROP VIEW dbo.ViewEmployee
GO
CREATE VIEW dbo.ViewEmployee
AS 
	Select * From dbo.Employee
GO

