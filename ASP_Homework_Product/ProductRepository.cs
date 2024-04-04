using ASP_Homework_Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASP_Homework_Product
{
    public class ProductRepository
    {
        private static List<Product> products = new List<Product>()
        {
            new Product("Name1", 10, "Desc1"),
            new Product("Name2", 20, "Desc2"),
            new Product("Name3", 30, "Desc3"),
            new Product("Name4", 40, "Desc4"),
        };

        public List<Product> GetAll()
        {
            return products;
        }

        public Product TryGetById(int id)
        {
            return products.FirstOrDefault(product =>  product.Id == id);            
        }
    }
}
