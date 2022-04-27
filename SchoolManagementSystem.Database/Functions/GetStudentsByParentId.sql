CREATE FUNCTION [dbo].[GetStudentsByParentId]
(
	@id int
)
RETURNS TABLE AS RETURN
	SELECT [Id] FROM [dbo].[Users] WHERE [Role] = 'student' AND [ParentId] = @id;
