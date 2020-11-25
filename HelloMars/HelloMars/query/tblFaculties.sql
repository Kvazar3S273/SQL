IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[Faculties]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[Faculties](
ID int IDENTITY NOT NULL PRIMARY KEY,
Dean nvarchar(max) NOT NULL CHECK(LEN(Dean)>0),
Name nvarchar(100) NOT NULL CHECK(LEN(Name)>0) UNIQUE
)'