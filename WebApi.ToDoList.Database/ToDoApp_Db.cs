﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Common;

namespace WebApi.ToDoList.Database
{
    public class ToDoApp_Db 
    {
        private static ToDoApp_Db instance = new ToDoApp_Db();
        public DbConnection singleton = null;
        public static readonly string DB_CONFIG = "Task_DB";
        private IDbConnection _connection;


        private ToDoApp_Db()
        {
            singleton = new SqlConnection(ConnectionStringWebAPI());
            _connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString.ToString());
            _connection.Open();
        }

        public static string ConnectionStringWebAPI()
        {

            var stringConnection = ConfigurationManager.ConnectionStrings[ConfigurationManager.AppSettings[DB_CONFIG]];

            if (stringConnection == null)
            {
                throw new Exception($"ConnectionString doesnt found: {DB_CONFIG}");
            }

            return stringConnection.ConnectionString;
        }

        public static ToDoApp_Db getInstance()
        {
            if (instance != null)
                instance = new ToDoApp_Db();

            return instance;

        }
    }
}
