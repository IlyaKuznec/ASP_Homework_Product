using ASP_Homework_Product.Models;
using System;
using System.Collections.Generic;

namespace ASP_Homework_Product
{
	public interface IOrdersRepository
	{
		void Add(Order order);
        List<Order> GetAll();
        object TryGetById(Guid id);
		void UpdateStatus(Guid orderid, OrderStatus newStatus);
	}
}