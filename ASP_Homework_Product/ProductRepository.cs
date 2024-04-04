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
            new Product("Сандалестрел", 228, "Стреляет и что-то говорит", "/images/image1.png"),
            new Product("Андрей", 499, "Башмак", "/images/image2.jpg"),
            new Product("Продавец арбузов", 50, "Ну типа кот на арбузе", "/images/image3.gif"),
            new Product("Мудрый Кувшин", 3999, "Скажет любую мудрость(по настроению)", "/images/image4.gif"),
            new Product("Трюкачи и Лихачи", 100, "Любой трюк абсолютно везде и на чём угодно", "/images/image5.png"),            
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
