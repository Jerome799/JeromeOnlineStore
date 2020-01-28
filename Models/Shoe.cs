using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JeromeOnlineStore.Models
{
    enum ProductCategory
    { 
        Shoe,
        Pants,
        Shirt
    }
    public class Shoe : Product
    {
        //ID
        [ScaffoldColumn(false)]
        [HiddenInput(DisplayValue = false)]
        public int ShoeID { get; set; }

        //Name
        [Required, StringLength(128), Display(Name = "Name")]
        public string Name { get; set; }

        //Brand/Manufacturer
        [StringLength(64), Display(Name = "Brand")]
        public string Brand { get; set; }

        //Size (US)
        [Required, Display(Name = "Size (US)")]
        public double Size { get; set; }

        //Cost
        [Required, Display(Name = "Cost")]
        public double Cost { get; set; }

        //Description
        [StringLength(4048), DataType(DataType.MultilineText), Display(Name = "Description")]
        public string Description { get; set; }

        //Image Path
        public string ImagePath { get; set; }
    }
}