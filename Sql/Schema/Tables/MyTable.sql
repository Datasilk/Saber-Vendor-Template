BEGIN TRY
    CREATE TABLE [dbo].[MyTable]
    (
	    [myId] INT IDENTITY(1,1) PRIMARY KEY, 
        [userId] INT NULL, 
        [text] NVARCHAR(MAX) NOT NULL, 
        [datecreated] DATETIME2 NOT NULL DEFAULT GETUTCDATE()
    )
END TRY
BEGIN CATCH END CATCH

GO

BEGIN TRY
    CREATE INDEX [IX_MyTable_DateCreated] ON [dbo].[MyTable] ([datecreated])
END TRY
BEGIN CATCH END CATCH
