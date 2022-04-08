CREATE FUNCTION [dbo].[GetGradesByStudent]
(
	@student int
)
RETURNS TABLE AS
RETURN
	SELECT * FROM dbo.Grades where [StudentId] = @student