﻿CREATE PROCEDURE [dbo].[spUser_Delete]

 @ID int
AS
	DELETE FROM DBO.[USER] WHERE ID=@ID;
RETURN 0
