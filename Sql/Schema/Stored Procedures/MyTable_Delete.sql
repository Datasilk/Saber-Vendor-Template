DROP PROCEDURE IF EXISTS [dbo].[MyTable_Delete]
GO
CREATE PROCEDURE [dbo].[MyTable_Delete]
	@myId int
AS
SET NOCOUNT ON
	DELETE FROM MyTable WHERE myId=@myId


