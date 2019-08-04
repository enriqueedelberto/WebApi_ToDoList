using Insight.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WebApi.ToDoList.Entities;

namespace WebApi.ToDoList.Database
{
    public interface Task_DB : IDbConnection, IDbTransaction
    {
        [Sql("dbo.pr_task_list", CommandType.StoredProcedure)]
        List<Task> pr_task_list( int? idTask,
                                string cdTask,
                                string titletask,
                                string statustask,
                                string cdUser,
                                DateTime? createTaskOnDate,
                                int? pageIndex = null,
                                int? pageSize = null

                              );

        [Sql("dbo.pr_task_save", CommandType.StoredProcedure)]
        void pr_task_save(string cdTask,
                           string titletask,
                           string statustask,
                           string cdUser,
                           string dstasks

                             );

        [Sql("dbo.pr_task_update", CommandType.StoredProcedure)]
        void pr_task_update(string idTask,
                            string cdTask,
                                  string titletask,
                                  string dstasks,
                                  string statustask,
                                  string cdUser,
                                  DateTime createTaskOnDate

                              );

        [Sql("dbo.pr_task_changeStatus", CommandType.StoredProcedure)]
        void pr_task_changeStatus(string idTask,
                                   string statustask
                              );

        [Sql("dbo.pr_task_assignUser", CommandType.StoredProcedure)]
        void pr_task_assignUser(string idTask,
                                string cdUser,
                                DateTime createTaskOnDate
                              );

        [Sql("dbo.pr_task_removeUser", CommandType.StoredProcedure)]
        void pr_task_removeUser(string idTask,
                                string cdUser,
                                DateTime createTaskOnDate
                              );


    }
}
