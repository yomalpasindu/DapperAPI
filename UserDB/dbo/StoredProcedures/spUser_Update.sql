CREATE PROCEDURE [dbo].[spUser_Update]

	@ID INT,
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50)
AS
BEGIN
	UPDATE DBO.[USERS]
	SET FirstName=@FirstName,LastName=@LastName
	WHERE ID=@ID;
END