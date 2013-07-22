CREATE PROCEDURE [dbo].[GetCompanies]
AS
BEGIN
	SELECT Id , Name, CreatedOn FROM Companies 
END