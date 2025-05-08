using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using shopapp.entity;

namespace shopapp.data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategories);
                }
                context.SaveChanges();
            }
        }
        private static Category[] Categories ={
            new Category(){Name="Telefon", Url="telefon"},
            new Category(){Name="Bilgisayar",Url="bilgisayar"},
            new Category(){Name="Elektronik",Url="elektronik"},
            new Category(){Name="Beyaz Eşya",Url="beyaz-esya"}
        };

        private static Product[] Products = {
            new Product(){Name="Samsung S5", Url="samsung-s5", Price=2000, Description="iyi telefon", ImageUrl="1.jpg", IsApproved=true},
            new Product(){Name="Samsung S6", Url="samsung-s6", Price=3000, Description="iyi telefon", ImageUrl="2.jpg", IsApproved=false},
            new Product(){Name="Samsung S7", Url="samsung-s7", Price=4000, Description="iyi telefon", ImageUrl="3.jpg", IsApproved=true},
            new Product(){Name="Samsung S8", Url="samsung-s8", Price=5000, Description="iyi telefon", ImageUrl="4.jpg", IsApproved=false},
            new Product(){Name="Samsung S9", Url="samsung-s9", Price=6000, Description="iyi telefon", ImageUrl="5.jpg", IsApproved=true}
        };

        private static ProductCategory[] ProductCategories ={
            new ProductCategory(){Product = Products[0], Category = Categories[0]},
            new ProductCategory(){Product = Products[0], Category = Categories[2]},
            new ProductCategory(){Product = Products[1], Category = Categories[0]},
            new ProductCategory(){Product = Products[1], Category = Categories[2]},
            new ProductCategory(){Product = Products[2], Category = Categories[0]},
            new ProductCategory(){Product = Products[2], Category = Categories[2]},
            new ProductCategory(){Product = Products[3], Category = Categories[0]},
            new ProductCategory(){Product = Products[3], Category = Categories[2]},
            new ProductCategory(){Product = Products[4], Category = Categories[0]},
            new ProductCategory(){Product = Products[4], Category = Categories[2]},
        };
    }
}