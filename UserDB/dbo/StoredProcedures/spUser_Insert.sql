CREATE PROCEDURE [dbo].[spUser_Insert]
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50)
AS
BEGIN
	INSERT INTO DBO.[USER] (FirstName,LastName)
	VALUES (@FirstName,@LastName);
END