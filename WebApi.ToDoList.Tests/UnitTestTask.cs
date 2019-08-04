using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi.ToDoList.Controllers;
using WebApi.ToDoList.Database;
using WebApi.ToDoList.Entities;
using WebApi.ToDoList.Models;

using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Hosting;

namespace WebApi.ToDoList.Tests
{
    [TestClass]
    public class UnitTestTask
    {
        [TestMethod]
        public void TestMethodConnection()
        {
            var conex = ToDoApp_Db.getInstance().singleton;
        }


        [TestMethod]
        public void TestMethodApiUser_ListTasks()
        {
            var contrlTask = new TaskController();
            

            contrlTask.Request = new HttpRequestMessage();
            contrlTask.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            var task = new GetTaskViewModel()
            {
                cd_user = "",
                createdOnDate = DateTime.Now,
                title_task = "Me",
                cd_task = "123",
                pageIndex = 1,
                pageTotal = 3


            };

            
            var response = contrlTask.GetAllTasks(task);
            

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public void TestMethodApiUser_SaveTasks()
        {
            var contrlTask = new TaskController();


            contrlTask.Request = new HttpRequestMessage();
            contrlTask.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            var task = new TaskViewModel()
            {
                cd_user = "",
                createdOnDate = DateTime.Now,
                title_task = "Me",
                cd_task = "123"
              


            };


            var response = contrlTask.SaveTask(task);
            

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public void TestMethodApiUser_UpdateTasks()
        {
            var contrlTask = new TaskController();


            contrlTask.Request = new HttpRequestMessage();
            contrlTask.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            var task = new TaskViewModel()
            {
                id_task="1",
                cd_user = "",
                createdOnDate = DateTime.Now,
                title_task = "Me",
                cd_task = "CODE2",
                status_task = "ARCHIVED"

            };


            var response = contrlTask.UpdateTask(task);
          

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public void TestMethodApiUser_ChangeStatusTasks()
        {
            var contrlTask = new TaskController();


            contrlTask.Request = new HttpRequestMessage();
            contrlTask.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            var task = new TaskViewModel()
            {
                cd_user = "",
                createdOnDate = DateTime.Now,
                title_task = "Me",
                cd_task = "123",
                id_task= "1",
                


            };


            var response = contrlTask.ChangeStatusTask(task);
            

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public void TestMethodApiUser_AssignUserToTasks()
        {
            var contrlTask = new TaskController();


            contrlTask.Request = new HttpRequestMessage();
            contrlTask.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            var task = new TaskViewModel()
            {
                cd_user = "",
                createdOnDate = DateTime.Now,
                title_task = "Me",
                cd_task = "123",
                id_task = "1",
               


            };


            var response = contrlTask.AssignUserToTask(task);


            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public void TestMethodApiUser_RemoveUserToTask()
        {
            var contrlTask = new TaskController();


            contrlTask.Request = new HttpRequestMessage();
            contrlTask.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            var task = new TaskViewModel()
            {
                cd_user = "",
                createdOnDate = DateTime.Now,
                title_task = "Me",
                cd_task = "123",
                id_task = "1",


            };


            var response = contrlTask.RemoveUserToTask(task);


            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }


 
    }
}
