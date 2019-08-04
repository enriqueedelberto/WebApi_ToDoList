using Insight.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.ToDoList.Database;
using WebApi.ToDoList.Entities.Enums;
using WebApi.ToDoList.Models;

namespace WebApi.ToDoList.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Task")]
    public class TaskController : ApiController
    {
        public TaskController() {

        }

        [HttpGet]
        [Route("GetTasks")]
        public HttpResponseMessage GetAllTasks([FromUri] GetTaskViewModel task, [FromUri]int pageIndex =1,[FromUri] int pageSize=10)
        {
            try
            {
                var resp = ToDoApp_Db.getInstance().singleton.As<Task_DB>().pr_task_list(
                                                                                idTask: task.id_task,
                                                                                cdTask: task.cd_task,
                                                                                createTaskOnDate: task.createdOnDate,
                                                                                statustask: task.status_task,
                                                                                titletask: task.title_task,
                                                                                cdUser: task.cd_user,
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
        [Route("saveTask")]
        public HttpResponseMessage SaveTask([FromBody] TaskViewModel task)
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

                var response = new
                {
                    data = "Success"
                };

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.ToString());
            }
        }

        [HttpPost]
        [Route("updateTask")]
        public HttpResponseMessage UpdateTask([FromBody] TaskViewModel task)
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
        public HttpResponseMessage ChangeStatusTask([FromBody] TaskViewModel task)
        {
            try
            {
                ToDoApp_Db.getInstance().singleton.As<Task_DB>().pr_task_changeStatus(
                              idTask: task.id_task, 
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
        public HttpResponseMessage AssignUserToTask([FromBody] TaskViewModel task)
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
        public HttpResponseMessage RemoveUserToTask([FromBody] TaskViewModel task)
        {
            try
            {
                ToDoApp_Db.getInstance().singleton.As<Task_DB>().pr_task_removeUser(
                              idTask: task.id_task,

                              cdUser: task.cd_user,
                              createTaskOnDate: DateTime.Now

                     );

                var response = new
                {
                    data = "Success"
                };

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.ToString());
            }
        }

        [HttpGet]
        [Route("GetStatuses")]
        public HttpResponseMessage GetStatuses() {
            var lstStatuses = Enum.GetValues(typeof(Status))
                                         .Cast<Status>()
                                         .Select(v => v.ToString())
                                         .ToList();
            var response = new {
                   data = lstStatuses
            };
            return Request.CreateResponse(HttpStatusCode.OK, response);

        }
    }
}
