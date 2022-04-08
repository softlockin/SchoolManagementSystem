CREATE PROCEDURE [dbo].[AssignTeacher]
	@teacher int,
	@class nvarchar(24)
AS
	UPDATE [Classes]
	SET
	[TeacherId] = @teacher
	WHERE
	[Name] = @class
RETURN 0
