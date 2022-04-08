CREATE PROCEDURE [dbo].[AddClass]
	@name nvarchar(24)
AS
	INSERT INTO dbo.Classes
	([Name])
	VALUES (@name)
RETURN 0
