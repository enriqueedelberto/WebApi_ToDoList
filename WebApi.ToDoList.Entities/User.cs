using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.ToDoList.Entities
{
    public class User
    {
        public string cd_user { get; set; }
        public string id_user { get; set; }
        public string nm_user { get; set; }
        
        public DateTime createdOnDate { get; set; }
        public DateTime lasModifiedOnDate { get; set; }
    }
}
