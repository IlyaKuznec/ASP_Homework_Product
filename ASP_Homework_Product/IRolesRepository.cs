using ASP_Homework_Product.Models;
using Library.Models;
using System.Collections.Generic;

namespace ASP_Homework_Product
{
    public interface IRolesRepository
    {
        void Add(Role role);
        List<Role> GetAll();
        Role TryGetByName(string Name);
        void Remove(string Name);
    }
}