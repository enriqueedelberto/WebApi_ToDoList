
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE pr_task_assignUser
	-- Add the parameters for the stored procedure here
	     @idTask INT = NULL,  
		 @cdUser VARCHAR(255) = NULL, 
		 @createTaskOnDate DATE = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    UPDATE dbo.[Tasks]
   SET [cd_user] = @cdUser 
      ,[lastModifiedOnDate] = @createTaskOnDate
 WHERE [id_task] = @idTask

END
GO
