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
                                int? pageTotal = null

                              );

        [Sql("pr_task_save", CommandType.StoredProcedure)]
        void pr_task_save(string iVch_cd_task,
                           string iVch_title_task,
                           string iVch_status_task,
                           string iVch_cd_user,
                           string iVch_desc_task

                             );

        [Sql("pr_task_update", CommandType.StoredProcedure)]
        void pr_task_update(string iVch_cd_task,
                                  string iVch_title_task,
                                  string iVch_status_task,
                                  string iVch_desc_task,
                                  string iVch_cd_user

                              );

        [Sql("pr_task_changeStatus", CommandType.StoredProcedure)]
        void pr_task_changeStatus(string iVch_cd_task,
                                   string iVch_status_task
                              );

        [Sql("pr_task_assignUser", CommandType.StoredProcedure)]
        void pr_task_assignUser(string iVch_cd_task,
                                string iVch_cd_user
                              );

        [Sql("pr_task_removeUser", CommandType.StoredProcedure)]
        void pr_task_removeUser(string iVch_cd_task,
                                string iVch_cd_user
                              );


    }
}
