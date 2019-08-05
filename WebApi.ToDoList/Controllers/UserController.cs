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
        public HttpResponseMessage GetAllUsers([FromUri] GetUserViewModel user, [FromUri]int pageIndex = 1, [FromUri] int pageSize = 10)
        {
            try
            {
                var resp = ToDoApp_Db.getInstance().singleton.As<User_DB>().pr_user_list(cdUser: user.cd_user,
                                                                                          nmUser: user.nm_user,
                                                                                          pageIndex: pageIndex,
                                                                                          pageSize: pageSize);

                var response = new
                {
                    data = resp.ToList(),
                    pageIndex = pageIndex,
                    pageSize = pageSize
                };

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.ToString());
            }
        }

        [HttpPost]
        [Route("SaveUser")]
        public HttpResponseMessage SaveUser([FromBody] UserViewModel user)
        {
            try
            {
                ToDoApp_Db.getInstance().singleton.As<User_DB>().pr_user_save(cdUser: user.cd_user,
                                                                                          nmUser: user.nm_user,
                                                                                          dsUser: user.ds_user,
                                                                                          createUserOnDate: DateTime.Now);

                var response = new
                {
                    data = "Successfull",
                    user = user
                };

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.ToString());
            }
        }
    }
}
