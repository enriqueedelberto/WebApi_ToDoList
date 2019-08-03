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
        List<User> pr_user_list(string iVch_cd_user,
                                string iVch_nm_user,

                                int? pageIndex = null,
                                int? pageTotal = null);

        [Sql("pr_user_save", CommandType.StoredProcedure)]
        void pr_user_save(string iVch_cd_user,
                          string iVch_nm_user


                            );
    }
}
