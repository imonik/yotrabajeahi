CREATE TABLE [dbo].[Comments]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CompanyID] INT NULL, 
    [Comment] NVARCHAR(150) NULL, 
    [Date] NCHAR(10) NULL, 
    [ResponseID] INT NULL, 
    [UserID] INT NULL, 
    CONSTRAINT [FK_Comments_ToCompanies] FOREIGN KEY ([CompanyID]) REFERENCES [Companies]([id]), 
    CONSTRAINT [FK_Comments_ToUsers] FOREIGN KEY ([UserID]) REFERENCES [Users]([Id]), 
    CONSTRAINT [FK_Comments_ToComments] FOREIGN KEY ([ResponseID]) REFERENCES [Comments]([Id])
)
