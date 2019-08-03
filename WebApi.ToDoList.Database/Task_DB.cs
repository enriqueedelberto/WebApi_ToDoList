using Insight.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.ToDoList.Database
{
    public interface Task_DB : IDbConnection, IDbTransaction
    {
        [Sql("pr_task_list", CommandType.StoredProcedure)]
        List<Task> pr_task_list(string iVch_cd_task,
                                string iVch_title_task,
                                string iVch_status_task,
                                string iVch_cd_user,
                                DateTime? iVch_fecha,
                                int? pageIndex = null,
                                int? pageSize = null

                              );

        [Sql("pr_task_save", CommandType.StoredProcedure)]
        void pr_task_save(string cdTask,
                           string titletask,
                           string statustask,
                           string cdUser,
                           string dstasks

                             );

        [Sql("pr_task_update", CommandType.StoredProcedure)]
        void pr_task_update(string idTask,
                            string cdTask,
                                  string titletask,
                                  string dstasks,
                                  string statustask,
                                  string cdUser,
                                  DateTime createTaskOnDate

                              );

        [Sql("pr_task_changeStatus", CommandType.StoredProcedure)]
        void pr_task_changeStatus(string idTask,
                                   string statustask
                              );

        [Sql("pr_task_assignUser", CommandType.StoredProcedure)]
        void pr_task_assignUser(string idTask,
                                string cdUser,
                                DateTime createTaskOnDate
                              );

        [Sql("pr_task_removeUser", CommandType.StoredProcedure)]
        void pr_task_removeUser(string idTask,
                                string cdUser,
                                DateTime createTaskOnDate
                              );


    }
}
