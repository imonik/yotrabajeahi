CREATE TABLE [dbo].[Companies]
(
	 ID int NOT NULL CONSTRAINT [PK_Companies] PRIMARY KEY identity(1,1)
	,Name nvarchar(500) NOT NULL
	,CreatedOn  datetime2 NOT NULL CONSTRAINT [DF_Companies_CreatedOn]  DEFAULT (GETUTCDATE())
	,ModifiedOn datetime2 NOT NULL CONSTRAINT [DF_Companies_ModifiedOn] DEFAULT (GETUTCDATE())
	,CreatedByID  int NOT NULL CONSTRAINT [Companies_FK_CreatedBy]  FOREIGN KEY REFERENCES dbo.[Users](ID)
	,ModifiedByID int NOT NULL CONSTRAINT [Companies_FK_ModifiedBy] FOREIGN KEY REFERENCES dbo.[Users](ID)
)
