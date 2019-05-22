using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// Madison Mehalko
// 12/2/2018 Final Project

namespace SignalRChat.Models
{
    public class ProductModel
    {
        private List<Product> products;

        public ProductModel()
        {
            this.products = new List<Product>()
            {
                new Product
                {
                    Id = "1",
                    Name = "Free Subscription",
                    Price = 0,
                    Photo = "1medal.png"
                },
                 new Product
                {
                    Id = "2",
                    Name = "Plus Subscription",
                    Price = 20,
                    Photo = "2medal.png"
                },
                  new Product
                {
                    Id = "3",
                    Name = "Pro Subscription",
                    Price = 120,
                    Photo = "3medal.png"
                }
            };

        }

        public List<Product> findAll()
        {
            return this.products;
        }

        public Product find(string id)
        {
            return this.products.Single(p => p.Id.Equals(id));
        }
    }
}