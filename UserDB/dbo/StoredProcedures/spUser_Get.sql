﻿CREATE PROCEDURE [dbo].[spUser_Get]

@ID INT
AS
BEGIN
	SELECT ID,FIRSTNAME,LASTNAME FROM DBO.[User] WHERE ID=@ID;
END