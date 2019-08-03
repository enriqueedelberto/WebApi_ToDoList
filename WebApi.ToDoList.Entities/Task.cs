using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.ToDoList.Entities
{
    public class Task
    {
        public string cd_task { get; set; }
        public string id_task { get; set; }
        public string title_task { get; set; }
        public string desc_task { get; set; }
        public string status_task { get; set; }
        public string cd_user { get; set; }
        public DateTime createdOnDate { get; set; }
        public DateTime lasModifiedOnDate { get; set; }
    }
}
