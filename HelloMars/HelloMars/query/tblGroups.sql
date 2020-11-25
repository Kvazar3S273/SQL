IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[Groups]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[Groups](
ID int IDENTITY NOT NULL PRIMARY KEY,
Name nvarchar(10) NOT NULL CHECK(LEN(Name)>0) UNIQUE,
Rating int NOT NULL CHECK (Rating>=0 AND Rating<=5),
Year int NOT NULL CHECK (Year>0 AND Year<=5)
)'