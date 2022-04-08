CREATE PROCEDURE [dbo].[AssignFee]
	@student int,
	@amount decimal(18,2)
AS
	UPDATE [Users]
	SET [Fee] = @amount
	WHERE [Id] = @student
RETURN 0