using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.ToDoList.Models
{
    public class GetUserViewModel
    {
        public GetUserViewModel(string cd_user, string id_user, string nm_user, DateTime createdOnDate, DateTime lasModifiedOnDate, int pageIndex, int pageTotal)
        {
            this.cd_user = cd_user;
            this.id_user = id_user;
            this.nm_user = nm_user;
            this.createdOnDate = createdOnDate;
            this.lasModifiedOnDate = lasModifiedOnDate;
            this.pageIndex = pageIndex;
            this.pageTotal = pageTotal;
        }

        public GetUserViewModel()
        {

        }



        public string cd_user { get; set; }
        public string id_user { get; set; }
        public string nm_user { get; set; }


        public DateTime createdOnDate { get; set; }
        public DateTime lasModifiedOnDate { get; set; }

        public int pageIndex { get; set; }
        public int pageTotal { get; set; }
    }
}