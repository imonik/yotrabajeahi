CREATE PROCEDURE [dbo].[GetComments]
(
	@companyID int
)
AS
BEGIN
	SELECT ID, Comment, ResponseID, UserID, CreatedOn 
	FROM Comments WHERE CompanyID = @companyID
END