DROP PROCEDURE IF EXISTS [dbo].[MyTable_Add]
GO
CREATE PROCEDURE [dbo].[MyTable_Add]
	@userId int = 0,
	@text nvarchar(MAX)
AS
SET NOCOUNT ON
	DECLARE @id int = NEXT VALUE FOR SequenceMyTable
	INSERT INTO MyTable (myId, userId, [text]) VALUES (@id, @userId, @text)


