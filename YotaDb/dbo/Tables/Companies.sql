CREATE TABLE [dbo].[Companies]
(
	 Id int NOT NULL CONSTRAINT [PK_Companies] PRIMARY KEY identity(1,1)
	,Name nvarchar(500) NOT NULL
	,CreatedOn datetime2 NOT NULL CONSTRAINT [DF_Companies_CreatedOn] DEFAULT (GETUTCDATE())
)
