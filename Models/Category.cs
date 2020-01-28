using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JeromeOnlineStore.Models
{
    public class Category
    {
        //Name
        public string Name { get; set; }
        //Image Path
        public string ImagePath { get; set; }

        public string PageName { get; set; }
    }
}