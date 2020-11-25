IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[Teachers]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[Teachers](
ID int IDENTITY NOT NULL PRIMARY KEY,
EmploymentDate date NOT NULL,
IsAssistant bit NOT NULL DEFAULT 0,
IsProfessor bit NOT NULL DEFAULT 0,
Name nvarchar(max) NOT NULL CHECK(LEN(Name)>0),
Position nvarchar(max) NOT NULL CHECK(LEN(Position)>0),
Premium money NOT NULL CHECK (Premium>=0) DEFAULT 0,
Salary money NOT NULL CHECK (Salary>0),
Surname nvarchar(max) NOT NULL CHECK(LEN(Surname)>0)
)'