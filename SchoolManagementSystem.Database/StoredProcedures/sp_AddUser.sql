CREATE PROCEDURE [dbo].[AddUser]
	@name nvarchar(50),
	@username nvarchar(24),
	@password nvarchar(24),
	@role nvarchar(10)
AS
	INSERT INTO dbo.Users([Name], [UserName], [Password], [Role])
	VALUES (@name, @username, @password, @role)
RETURN 0
