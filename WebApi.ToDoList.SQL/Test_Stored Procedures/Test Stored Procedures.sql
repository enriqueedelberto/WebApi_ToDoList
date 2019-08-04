DECLARE	@return_value int
--Save a task
EXEC	@return_value = [dbo].[pr_task_save]
		@cdTask = N'12_3',
		@titletask = N'Ttile 2',
		@dstasks = N'This is one task',
		@statustask = N'IN_PROGRESS'


--Task List
DECLARE	@return_value int

EXEC	@return_value = [dbo].[pr_task_list]
		@cdTask = NULL,
		@cdUser = NULL,
		@titletask = NULL,
		@statustask = NULL,
		@createTaskOnDate = NULL,
		@PageNumber = 1,
		@PageSize = 5

SELECT	'Return Value' = @return_value


