CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserName] VARCHAR(50) NULL, 
    [Email] VARCHAR(50) NULL, 
    [CreatedDate] DATE NULL, 
    [Password] VARCHAR(50) NULL
)
