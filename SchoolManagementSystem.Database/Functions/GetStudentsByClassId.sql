CREATE FUNCTION [dbo].[GetStudentsByClassId]
(
	@id int
)
RETURNS TABLE AS RETURN
	SELECT u.Id
	FROM Users u
	INNER JOIN [ClassStudents] ON [StudentId] = u.[Id]
	WHERE [ClassId] = @id
