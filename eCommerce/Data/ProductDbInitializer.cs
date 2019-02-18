using eCommerce.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace eCommerce.Data
{
    public class ProductDbInitializer : CreateDatabaseIfNotExists<ProductDbContext>
    {
        protected override void Seed(ProductDbContext context)
        {
            var products = new List<Product>
            {
                new Product { ItemId = 1, Name = "Ski Hat", Description = "A nice warm hat", Price = 17.00 },
                new Product { ItemId = 2, Name = "Biathlon Rifle", Description = "A rifle to hit those targets", Price = 925.00 },
                new Product { ItemId = 3, Name = "Ski Gloves", Description = "Keep those fingers warm", Price = 15.00 },
                new Product { ItemId = 4, Name = "Ski Suit", Description = "Look good out there on the course", Price = 75.00 },
                new Product { ItemId = 5, Name = "Ski Poles", Description = "We have one for your left hand and one for your right", Price = 125.00 },
                new Product { ItemId = 6, Name = "Cross-country Skis", Description = "Zooooom!", Price = 345.00 },
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}