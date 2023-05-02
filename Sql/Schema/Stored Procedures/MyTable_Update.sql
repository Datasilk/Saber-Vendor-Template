DROP PROCEDURE IF EXISTS [dbo].[MyTable_Update]
GO
CREATE PROCEDURE [dbo].[MyTable_Update]
	@myId int,
	@text nvarchar(MAX)
AS
SET NOCOUNT ON
	UPDATE MyTable SET [text] = @text WHERE myId=@myId


