﻿CREATE PROCEDURE [dbo].[spUser_GetAll]

AS
BEGIN
	SELECT ID,FIRSTNAME,LASTNAME FROM DBO.[User];
END
