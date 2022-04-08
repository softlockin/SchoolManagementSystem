CREATE FUNCTION [dbo].[GetAttendance]
(
	@student int,
	@class int
)
RETURNS TABLE AS RETURN
	SELECT * from Attendance a
	where a.ClassId = @class and a.StudentId = @student
