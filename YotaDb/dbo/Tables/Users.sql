﻿CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL CONSTRAINT [PK_Users] PRIMARY KEY IDENTITY, 
    [UserName]  VARCHAR(50) NOT NULL CONSTRAINT [UN_Username] UNIQUE, 
    [Email]     VARCHAR(50) NOT NULL, 
    [Password]  VARCHAR(50) NOT NULL,
    [CreatedOn] datetime2 NOT NULL CONSTRAINT [DF_Users_CreatedOn] DEFAULT (GETUTCDATE())
)
