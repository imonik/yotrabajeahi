CREATE TABLE [dbo].[Companies]
(
	 ID int NOT NULL CONSTRAINT [PK_Companies] PRIMARY KEY
	,Name nvarchar(500) NOT NULL
	,CreatedOn datetime2 NOT NULL CONSTRAINT [DF_Companies_CreatedOn] DEFAULT (GETUTCDATE())
)
