﻿using ASP_Homework_Product.Models;
using System.Collections.Generic;

namespace ASP_Homework_Product
{
    public interface IProductsRepository
    {
        void Add(Product product);
        List<Product> GetAll();
        Product TryGetById(int id);
        void Update(Product product);
        void Remove(int productId);
    }
}