IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[tblProducts]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[tblProducts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Image] [nvarchar](150) NULL,
	[Price] [money] NOT NULL,
	[Description] [nvarchar](4000) NULL,
	PRIMARY KEY (Id),
    FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[tblCatetories]([Id])
 )'