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
    public class UnitTestUser
    {
        [TestMethod]
        public void TestMethodConnection()
        {
            var conex = ToDoApp_Db.getInstance().singleton;
        }


        [TestMethod]
        public void TestMethodApiUser_ListUsers()
        {
            var contrlUser = new UserController();
            

            contrlUser.Request = new HttpRequestMessage();
            contrlUser.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            var user = new GetUserViewModel()
            {
                cd_user = "",
                createdOnDate = DateTime.Now,
                nm_user = "Me",
               
                pageIndex = 1,
                pageTotal = 3


            };

            
            var response = contrlUser.GetAllUsers(user);
           

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public void TestMethodApiUser_SaveUsers()
        {
            var contrlUser = new UserController();


            contrlUser.Request = new HttpRequestMessage();
            contrlUser.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            var user = new UserViewModel()
            {
                cd_user = "343434",
                createdOnDate = DateTime.Now,
                nm_user = "ENrique test",
                


            };


            var response = contrlUser.SaveUser(user);
            

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public void TestMethodApiUser_UpdateUsers()
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


            };


            var response = contrlTask.UpdateTask(task);
            // var lstUsers = contrlUser.GetAllUsers(user);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

       
    }
}
