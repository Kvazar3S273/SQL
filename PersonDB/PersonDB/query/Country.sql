USE PersonDB

IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[Country]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].Country(
ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
Title nvarchar(100),
VVP int CHECK (VVP>=1000 AND VVP<=130000)
)'