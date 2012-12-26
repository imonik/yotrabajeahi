CREATE TABLE [dbo].[Comments]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CompanyID]  INT NOT NULL, 
    [Comment]    NVARCHAR(MAX) NOT NULL, 
    [ResponseID] INT NULL, 
    [UserID]     INT NOT NULL, 
    [CreatedOn]  datetime2 NOT NULL CONSTRAINT [DF_Comments_CreatedOn] DEFAULT (GETUTCDATE()),
    CONSTRAINT [FK_Comments_ToCompanies] FOREIGN KEY ([CompanyID])  REFERENCES [Companies]([Id]), 
    CONSTRAINT [FK_Comments_ToUsers]     FOREIGN KEY ([UserID])     REFERENCES [Users]([Id]), 
    CONSTRAINT [FK_Comments_ToComments]  FOREIGN KEY ([ResponseID]) REFERENCES [Comments]([Id])
)
