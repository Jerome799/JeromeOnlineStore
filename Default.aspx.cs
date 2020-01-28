using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JeromeOnlineStore.Models;

namespace JeromeOnlineStore
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public List<Category> getCategories()
        {
            List<Category> myList = new List<Category>
            {
                new Category
                {
                    Name = "Shoes",
                    ImagePath = "ShoePreview.jfif",
                    PageName = "ShoeList.aspx"
                },

                new Category
                {
                    Name = "Pants",
                    ImagePath = "PantsPreview.jpg",
                    PageName = "PantsList.aspx"
                },

                new Category
                {
                    Name = "Shirts",
                    ImagePath = "ShirtPreview.jfif",
                    PageName = "ShirtList.aspx"
                },
            };

            return myList;
        }
    }
}