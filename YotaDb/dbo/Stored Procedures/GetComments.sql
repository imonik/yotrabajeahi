CREATE PROCEDURE [dbo].[GetComments]
(
	@companyID int
)
AS
BEGIN
	SELECT ID, [Description], ResponseID, UserID, CreatedOn 
	FROM Comments WHERE CompanyID = @companyID
END