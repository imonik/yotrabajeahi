CREATE PROCEDURE [dbo].[GetCompanies]
AS
BEGIN
	SELECT ID , Name, CreatedOn FROM Companies 
END