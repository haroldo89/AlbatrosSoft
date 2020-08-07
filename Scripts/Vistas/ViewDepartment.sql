IF EXISTS (SELECT * FROM SYSOBJECTS WHERE ID = object_id(N'[dbo].[ViewDepartment]'))
	DROP VIEW dbo.ViewDepartment
GO

CREATE VIEW dbo.ViewDepartment
AS
    SELECT * FROM Department
GO