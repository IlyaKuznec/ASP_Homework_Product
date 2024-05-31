using ASP_Homework_Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASP_Homework_Product
{
    public class ProductsInMemoryRepository : IProductsRepository
    {
        private List<Product> products = new List<Product>()
        {
            new Product("Основные понятия алгебры", "Шафаревич Игорь Ростиславович", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget ultricies est. Praesent sodales id tellus eu tristique. Mauris tincidunt.", "/images/book1.webp"),
            new Product("Математический анализ. Часть I. Издание исправленное", "Зорич Владимир Антонович", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut porttitor placerat augue. Pellentesque eros nunc, iaculis vitae convallis et, placerat.", "/images/book2.webp"),
            new Product("Теоремы и задачи функционального анализа", "Кириллов Александр Александрович, Гвишиани Алексей Джерменович", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer in purus elementum mauris iaculis egestas id lobortis ligula. Nulla libero.", "/images/book3.webp"),
            new Product("Обыкновенные дифференциальные уравнения", "Арнольд Владимир Игоревич", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer luctus magna libero, sit amet sollicitudin enim viverra vitae. Suspendisse lorem.", "/images/book4.webp"),
            new Product("Элементы теории функций и функционального анализа. Изд.7", "Колмогоров Андрей Николаевич, Фомин Сергей Васильевич", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent sed maximus ipsum. Donec eget iaculis lectus, quis aliquet elit. Pellentesque.", "/images/book5.webp"),            
        };

        public void Add(Product product)
        {
            product.ImagePath = "/images/image1.png";
            products.Add(product);
        }

        public List<Product> GetAll()
        {           
            return products;
        }

        public void Remove(int productId)
        {
            products.RemoveAll(x => x.Id == productId);
        }

        public Product TryGetById(int id)
        {
            return products.FirstOrDefault(product => product.Id == id);
        }

        public void Update(Product product)
        {
            var existingProduct = products.FirstOrDefault(x => x.Id == product.Id);
            if (existingProduct == null) 
            {
                return;
            }
            
            existingProduct.Title = product.Title;
            existingProduct.Description = product.Description;
            existingProduct.Author = product.Author;            
        }
    }
}
