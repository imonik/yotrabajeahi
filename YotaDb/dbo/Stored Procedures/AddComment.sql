CREATE PROCEDURE [dbo].[AddComment]
(
	@Comment varchar(max)
)
AS
BEGIN

	declare @companyID int
	declare @userID int

	select top 1 @companyID = Id from Companies 

	if(@companyID is null) begin
		insert into Companies (Name) Values ('Company ' + left(CAST(NEWID() as varchar(max)), 8))
		set @companyID = SCOPE_IDENTITY()
	end

	select top 1 @userID = Id from Users 

	if(@userID is null) begin
		insert into Users(UserName, Email, [Password]) Values ('User ' + left(CAST(NEWID() as varchar(max)), 8), 'sample@mail.com', 'lorem ipsum')
		set @userID = SCOPE_IDENTITY()
	end

	INSERT INTO Comments(CompanyID, Comment, UserID)
	VALUES(@companyID, @Comment, @userID)
END