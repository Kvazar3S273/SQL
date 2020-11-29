IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[tblCatetories]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[tblCatetories] (
	[Id] [int] IDENTITY(1,1) PRIMARY KEY,
	[Name] [nvarchar](250) NOT NULL,
	[Image] [nvarchar](150) NULL,
	[Description] [nvarchar](4000) NULL
)'