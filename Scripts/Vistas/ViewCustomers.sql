IF EXISTS (SELECT * FROM sysobjects where id = object_id(N'[dbo].[ViewCustomer]'))
DROP VIEW dbo.ViewCustomer
GO
CREATE VIEW dbo.ViewCustomer
AS 
	Select * From dbo.Customer
GO