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
    [RoutePrefix("api/Task")]
    public class TaskController : ApiController
    {
        [HttpGet]
        [Route("GetTasks")]
        public HttpResponseMessage GetAllTasks([FromBody] GetTaskViewModel task, [FromUri]int pageIndex =1,[FromUri] int pageSize=10)
        {
            try
            {
                var resp = ToDoApp_Db.getInstance().singleton.As<Task_DB>().pr_task_list(
                                                                                iVch_cd_task: task.cd_task,
                                                                                iVch_fecha: task.createdOnDate,
                                                                                iVch_status_task: task.status_task,
                                                                                iVch_title_task: task.title_task,
                                                                                iVch_cd_user: task.cd_user,
                                                                                pageIndex: pageIndex,
                                                                                         pageSize: pageSize);

                var vTest = new
                {
                    data = resp.FirstOrDefault()
                };

                return Request.CreateResponse(HttpStatusCode.OK, vTest);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.ToString());
            }
        }

        [HttpPost]
        [Route("saveTask")]
        public HttpResponseMessage SaveTask([FromBody] GetTaskViewModel task)
        {
            try
            {
                ToDoApp_Db.getInstance().singleton.As<Task_DB>().pr_task_save(
                              cdTask: task.cd_task,
                              titletask: task.title_task,
                              statustask: task.status_task,
                              cdUser: task.cd_user,
                              dstasks: task.desc_task
                     );

                var vTest = new
                {
                    data = "Success"
                };

                return Request.CreateResponse(HttpStatusCode.OK, vTest);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.ToString());
            }
        }

        [HttpPost]
        [Route("updateTask")]
        public HttpResponseMessage UpdateTask([FromBody] GetTaskViewModel task)
        {
            try
            {
                ToDoApp_Db.getInstance().singleton.As<Task_DB>().pr_task_update(
                              idTask: task.id_task,
                              cdTask: task.cd_task,
                              titletask: task.title_task,
                              statustask: task.status_task,
                              cdUser: task.cd_user,
                              dstasks: task.desc_task,
                              createTaskOnDate: DateTime.Now
                     );

                var vTest = new
                {
                    data = "Success"
                };

                return Request.CreateResponse(HttpStatusCode.OK, vTest);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.ToString());
            }
        }

        [HttpPost]
        [Route("changeStatusTask")]
        public HttpResponseMessage ChangeStatusTask([FromBody] GetTaskViewModel task)
        {
            try
            {
                ToDoApp_Db.getInstance().singleton.As<Task_DB>().pr_task_changeStatus(
                              idTask: task.cd_task,

                              statustask: task.status_task

                     );

                var vTest = new
                {
                    data = "Success"
                };

                return Request.CreateResponse(HttpStatusCode.OK, vTest);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.ToString());
            }
        }

        [HttpPost]
        [Route("assignUserToTask")]
        public HttpResponseMessage AssignUserToTask([FromBody] GetTaskViewModel task)
        {
            try
            {
                ToDoApp_Db.getInstance().singleton.As<Task_DB>().pr_task_assignUser(
                              idTask: task.id_task, 
                              cdUser: task.cd_user,
                              createTaskOnDate: DateTime.Now

                     );

                var vTest = new
                {
                    data = "Success"
                };

                return Request.CreateResponse(HttpStatusCode.OK, vTest);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.ToString());
            }
        }
        
        [HttpPost]
        [Route("removeUserToTask")]
        public HttpResponseMessage RemoveUserToTask([FromBody] GetTaskViewModel task)
        {
            try
            {
                ToDoApp_Db.getInstance().singleton.As<Task_DB>().pr_task_removeUser(
                              idTask: task.id_task,

                              cdUser: task.cd_user,
                              createTaskOnDate: DateTime.Now

                     );

                var vTest = new
                {
                    data = "Success"
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
