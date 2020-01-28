using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JeromeOnlineStore.Models
{
    public class Product
    {
        //ID
        //[ScaffoldColumn(false)]
        //[HiddenInput(DisplayValue = false)]
        //Primary Key
        [Key]
        public int ProductID { get; set; }

        //Category - Shoe, Pants, Shirt
        public ProductCategory PCategory { get; set; }
        
        //Name
        //Cost
        //Description
        //Brand
        //ImagePath
        //ProductID
    }
}