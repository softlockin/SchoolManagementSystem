CREATE PROCEDURE [dbo].[AddAttendance]
	@isPresent BIT,
	@date date,
	@student int,
	@class int
AS
	
	DECLARE @count int = (SELECT COUNT(*) FROM Attendance g WHERE g.StudentId = @student and g.ClassId = @class and g.[Date] = @date)
	if @count > 0
	begin
		update Attendance
		set IsPresent = @isPresent
		where
		[StudentId] = @student and [ClassId] = @class and [Date] = @date
	end
	else
	begin
	INSERT INTO dbo.Attendance([IsPresent],[Date],[StudentId],[ClassId])
	VALUES(@isPresent, @date, @student, @class)
	end
RETURN 0
