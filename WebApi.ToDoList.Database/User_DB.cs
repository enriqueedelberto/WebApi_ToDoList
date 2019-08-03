using Insight.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.ToDoList.Entities;

namespace WebApi.ToDoList.Database
{
    public interface User_DB : IDbConnection, IDbTransaction
    {
        [Sql("pr_user_list", CommandType.StoredProcedure)]
        List<User> pr_user_list(string cdUser,
                                string nmUser,

                                int? pageIndex = null,
                                int? pageSize = null);

        [Sql("pr_user_save", CommandType.StoredProcedure)]
        void pr_user_save(string cdUser,
                          string nmUser,
                          string dsUser,
                          DateTime createUserOnDate

                            );
    }
}
