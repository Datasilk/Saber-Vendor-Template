DROP PROCEDURE IF EXISTS [dbo].[MyTable_GetList]
GO
CREATE PROCEDURE [dbo].[MyTable_GetList]
	@userId int = 0
AS
SET NOCOUNT ON
	SELECT * FROM MyTable WHERE userId=@userId ORDER BY datecreated DESC


