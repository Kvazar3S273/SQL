IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[Departments]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[Departments](
ID int IDENTITY NOT NULL PRIMARY KEY,
Financing money NOT NULL CHECK (Financing>=0) DEFAULT 0,
Name nvarchar(100) NOT NULL CHECK(LEN(Name)>0) UNIQUE
)'