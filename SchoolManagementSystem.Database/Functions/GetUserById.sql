﻿CREATE FUNCTION [dbo].[GetUserById]
(
	@id int
)
RETURNS TABLE AS RETURN
	SELECT TOP 1 * FROM Users WHERE [Id] = @id
