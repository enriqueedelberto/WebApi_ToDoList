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
	 @idUser INT = NULL, 
	 @nmuser VARCHAR(255), 
	 @createTaskOnDate DATE = NULL
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
          ,[lastModifiedOnDate]
   FROM dbo.[Users]
   WHERE @idUser IS NULL OR [id_user] = @idUser
        AND @nmuser IS NULL OR [nm_user] = @nmuser
		AND @createTaskOnDate IS NULL OR [createOnDate] = @createTaskOnDate
END
GO
