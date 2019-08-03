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
CREATE PROCEDURE pr_user_save
	-- Add the parameters for the stored procedure here
	 @cdUser VARCHAR(255), 
	 @nmUser VARCHAR(255), 
	 @dsUser VARCHAR(255), 
	 @createUserOnDate DATE  
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.[Users]
           ([cd_user]
           ,[nm_user]
           ,[ds_user]
           ,[createOnDate]
           ,[lastModifiedOnDate])
     VALUES
           (@cdUser
           ,@nmUser
           ,@dsUser
           ,@createUserOnDate
           ,@createUserOnDate)
END
GO
