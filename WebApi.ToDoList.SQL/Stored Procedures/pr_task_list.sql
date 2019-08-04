-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================


CREATE PROCEDURE pr_task_list 
	-- Add the parameters for the stored procedure here
	     @idTask INT = NULL,
		 @cdTask VARCHAR(255) = NULL,
		 @cdUser VARCHAR(255)=NULL,
		 @titletask VARCHAR(255)=NULL, 
		 @statustask VARCHAR(255)= NULL, 
		 @createTaskOnDate DATE=NULL,
	@PageNumber	INT = 1,
	@PageSize	INT = 10
		 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [id_task],
	       [cd_task] ,
           [title_task],[ds_task],[status_task],[cd_user],[createOnDate],
           [lastModifiedOnDate],
           TotalRecords = COUNT(1) OVER()


	FROM dbo.Tasks
	where (@idTask IS NULL Or id_task = @idTask)
	    and (@cdTask IS NULL Or cd_task = @cdTask)
	      and (@titletask IS NULL OR [title_task] = @titletask)
		  and (@cdUser IS NULL OR [cd_user] = @cdUser)
		  and (@statustask IS NULL OR [status_task] = @statustask)
		  order by [createOnDate] desc
		  OFFSET (@PageNumber-1)*ISNULL(@PageSize,1) ROWS FETCH NEXT ISNULL(@PageSize,@@ROWCOUNT) ROWS ONLY
END
GO
