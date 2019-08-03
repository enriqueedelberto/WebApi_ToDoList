using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.ToDoList.Models
{
    public class GetTaskViewModel
    {
        public string cd_task { get; set; }
        public string id_task { get; set; }
        public string title_task { get; set; }
        public string desc_task { get; set; }
        public string status_task { get; set; }
        public string cd_user { get; set; }
        public DateTime createdOnDate { get; set; }
        public DateTime lasModifiedOnDate { get; set; }

        public int pageIndex { get; set; }
        public int pageTotal { get; set; }
    }
}