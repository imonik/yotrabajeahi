CREATE TABLE [dbo].[Comments]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CompanyID] INT NOT NULL, 
    [Comment] NVARCHAR(150) NOT NULL, 
    [Date] NCHAR(10) NOT NULL, 
    [ResponseID] INT NOT NULL, 
    [UserID] INT NOT NULL, 
    CONSTRAINT [FK_Comments_ToCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [Companies]([id]), 
    CONSTRAINT [FK_Comments_ToUsers] FOREIGN KEY ([UserID]) REFERENCES [Users]([Id]), 
    CONSTRAINT [FK_Comments_ToComments] FOREIGN KEY ([ResponseID]) REFERENCES [Comments]([Id])
)
