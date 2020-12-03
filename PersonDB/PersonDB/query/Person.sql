IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[Person]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[Person](
ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
Surname nvarchar(100),
Age int CHECK (Age>=20 AND Age<=50),
Phone nvarchar(15) CHECK (LEN(Phone)>0)
)'