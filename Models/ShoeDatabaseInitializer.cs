using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace JeromeOnlineStore.Models
{
    public class ShoeDatabaseInitializer : DropCreateDatabaseAlways<ShoeContext>
    {
        protected override void Seed(ShoeContext context)
        {
            GetShoes().ForEach(s => context.Shoes.Add(s));
        }

        private static List<Shoe> GetShoes()
        {
            var ShoeList = new List<Shoe>
            {
                new Shoe
                {
                    ShoeID = 1,
                    Name = "Men's Casual Running Sport Shoes",
                    Size = 9.5,
                    Brand = "Damyuan",
                    Description = "NEW Mens Lightweight Casual Shoes Men's Casual Running Sport Shoes Man Breathable Flats Shoes New Mens Breathable Mesh Shoes",
                    Cost = 2.75,
                    ImagePath = "Shoe1.jpg"
                },

                new Shoe
                {
                    ShoeID = 2,
                    Name = "Blade Large Size Sports Casual Shoes",
                    Size = 9.5,
                    Brand = "Wiz Khalifa",
                    Description = "Men's New Fashion Trend Flame Blade Large Size Sports Casual Shoes Sports Shoes Outdoor Shoes Running Shoes",
                    Cost = 18,
                    ImagePath = "Shoe2.jpg"
                },

                new Shoe
                {
                    ShoeID = 3,
                    Name = "Men's Casual Running Shoes",
                    Size = 9.5,
                    Brand = "Fashion",
                    Description = "New Fashion Men's Casual Running Sport Shoes Man Breathable Flats Shoes",
                    Cost = 28,
                    ImagePath = "Shoe3.jpg"
                },

                new Shoe
                {
                    ShoeID = 4,
                    Name = "Men's Casual Shoes",
                    Size = 9.5,
                    Brand = "Mensports",
                    Description = "Men's Casual Shoes Lace-Up Simple Breathable Shoes Mesh Sneakers",
                    Cost = 4.65,
                    ImagePath = "Shoe4.jpg"
                },

                new Shoe
                {
                    ShoeID = 5,
                    Name = "2019 New Fashion Mens Running Sneakers",
                    Size = 9.5,
                    Brand = "junhua lucky",
                    Description = "2019 New Fashion Mens Running Sneakers Outdoor Breathable Sneakers Comfortable Mesh Shoes Lightweight Non-slip Wear-resistant Shock Absorbing Shoes",
                    Cost = 3,
                    ImagePath = "Shoe5.jpg"
                },
            };

            return ShoeList;
        }
    }
}