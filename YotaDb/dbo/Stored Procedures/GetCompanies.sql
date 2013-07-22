CREATE PROCEDURE [dbo].[GetCompanies]
AS
	SELECT id , name, CreatedOn FROM Companies 
