CREATE FUNCTION [dbo].[GetGradesByClass]
(
	@class int
)
RETURNS TABLE AS
RETURN
	SELECT * FROM dbo.Grades where [ClassId] = @class