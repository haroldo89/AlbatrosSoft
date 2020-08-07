IF EXISTS (select * from sysobjects where id = object_id(N'[dbo].[spGetDepartment]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[spGetDepartment]
GO
CREATE PROCEDURE dbo.spGetDepartment 
AS
BEGIN
    SELECT * FROM ViewDepartment 
END


