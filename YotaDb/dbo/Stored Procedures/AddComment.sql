CREATE PROCEDURE [dbo].[AddComment]
(
	@Comment varchar(max)
)
AS
BEGIN
	INSERT INTO Comments(Comment)
	VALUES(@Comment)
END