using Insight.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.ToDoList.Database;
using WebApi.ToDoList.Models;

namespace WebApi.ToDoList.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        public UserController()
        {

        }

        [HttpGet]
        [Route("GetUsers")]
        public HttpResponseMessage GetAllUsers([FromBody] GetUserViewModel user)
        {
            try
            {
                var resp = ToDoApp_Db.getInstance().singleton.As<User_DB>().pr_user_list(cdUser: user.cd_user,
                                                                                          nmUser: user.cd_user,
                                                                                          pageIndex: user.pageIndex,
                                                                                          pageSize: user.pageTotal);

                var vTest = new
                {
                    data = resp
                };

                return Request.CreateResponse(HttpStatusCode.OK, vTest);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.ToString());
            }
        }

        [HttpPost]
        [Route("SaveUser")]
        public HttpResponseMessage SaveUser([FromBody] GetUserViewModel user)
        {
            try
            {
                ToDoApp_Db.getInstance().singleton.As<User_DB>().pr_user_save(cdUser: user.cd_user,
                                                                                          nmUser: user.nm_user,
                                                                                          dsUser: user.nm_user,
                                                                                          createUserOnDate: DateTime.Now);

                var vTest = new
                {
                    data = "Successfull"
                };

                return Request.CreateResponse(HttpStatusCode.OK, vTest);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.ToString());
            }
        }
    }
}
