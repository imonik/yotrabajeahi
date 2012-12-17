CREATE PROCEDURE [dbo].[AddCompany]
(
	@Name varchar(500)
)
AS
BEGIN
	INSERT INTO Companies (Name)
	VALUES(@Name)
END