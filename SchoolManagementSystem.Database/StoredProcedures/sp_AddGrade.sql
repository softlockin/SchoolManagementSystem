CREATE PROCEDURE [dbo].[AddGrade]
	@result NCHAR(10),
	@student int,
	@class int
AS
	
	DECLARE @count int = (SELECT COUNT(*) FROM Grades g WHERE g.StudentId = @student and g.ClassId = @class)
	
	if @count > 0
	BEGIN
		UPDATE Grades
		set Result = @result
		where [StudentId] = @student
		and [ClassId] = @class
	END
	else
	begin
	INSERT INTO dbo.Grades([Result], [StudentId], [ClassId])
	VALUES(@result, @student, @class)
	end
RETURN 0
