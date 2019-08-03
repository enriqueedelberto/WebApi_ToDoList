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
CREATE PROCEDURE pr_user_list
	-- Add the parameters for the stored procedure here
	 @cdUser INT = NULL, 
	 @nmuser VARCHAR(255), 
	 @createTaskOnDate DATE = NULL,
	@PageNumber	INT = 1,
	@PageSize	INT = 10
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [id_user]
          ,[cd_user]
          ,[nm_user]
          ,[ds_user]
          ,[createOnDate]
          ,[lastModifiedOnDate],
           TotalRecords = COUNT(1) OVER()
   FROM dbo.[Users]
   WHERE @cdUser IS NULL OR [cd_user] = @cdUser
        AND @nmuser IS NULL OR [nm_user] = @nmuser
		AND @createTaskOnDate IS NULL OR [createOnDate] = @createTaskOnDate
		 order by [createOnDate] desc
		  OFFSET (@PageNumber-1)*ISNULL(@PageSize,1) ROWS FETCH NEXT ISNULL(@PageSize,@@ROWCOUNT) ROWS ONLY
END
GO
