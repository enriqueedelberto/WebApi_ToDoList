
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE pr_task_save
	-- Add the parameters for the stored procedure here
	     @cdTask VARCHAR(255) = NULL,
	     @titletask VARCHAR(255),
	     @dstasks VARCHAR(255),
	     @statustask VARCHAR(255),  
		 @cdUser VARCHAR(255) = NULL, 
		 @createTaskOnDate DATE = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.[Tasks]
           ([cd_task]
           ,[title_task]
           ,[ds_task]
           ,[status_task]
           ,[cd_user]
           ,[createOnDate]
           ,[lastModifiedOnDate])
     VALUES
           (@cdTask
           ,@titletask
           ,@dstasks
           ,@statustask
           ,@cdUser
           ,@createTaskOnDate
           ,@createTaskOnDate)

END
GO
