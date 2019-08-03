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
                var resp = ToDoApp_Db.getInstance().singleton.As<User_DB>().pr_user_list(iVch_cd_user: user.cd_user,
                                                                                          iVch_nm_user: user.cd_user,
                                                                                          pageIndex: user.pageIndex,
                                                                                          pageTotal: user.pageTotal);

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
                ToDoApp_Db.getInstance().singleton.As<User_DB>().pr_user_save(iVch_cd_user: user.cd_user,
                                                                                          iVch_nm_user: user.cd_user);

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
