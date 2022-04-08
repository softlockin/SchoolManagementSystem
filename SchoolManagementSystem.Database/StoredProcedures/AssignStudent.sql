CREATE PROCEDURE [dbo].[AssignStudent]
	@student int,
	@class nvarchar(24)
AS
	DECLARE @id INT = (SELECT TOP 1 [Id] FROM Classes WHERE [Name] = @class)

	INSERT INTO dbo.ClassStudents([ClassId], [StudentId])
	VALUES (@id, @student)
RETURN 0