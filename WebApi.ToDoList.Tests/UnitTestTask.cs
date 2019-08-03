using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi.ToDoList.Controllers;
using WebApi.ToDoList.Database;
using WebApi.ToDoList.Entities;
using WebApi.ToDoList.Models;

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
            //var conex = ToDoList_DB.getInstance().singleton;

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
            // var lstUsers = contrlUser.GetAllUsers(user);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }






        private List<User> GetTestUsers()
        {
            var testProducts = new List<User>();
            testProducts.Add(new User { cd_user = "23", nm_user = "Demo1" });
            testProducts.Add(new User { cd_user = "23", nm_user = "Demo2" });
            testProducts.Add(new User { cd_user = "23", nm_user = "Demo3" });
            testProducts.Add(new User { cd_user = "23", nm_user = "Demo4" });

            return testProducts;
        }
    }
}
