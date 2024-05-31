using System;
using System.Collections.Generic;
using System.Linq;
using ASP_Homework_Product.Models;

namespace ASP_Homework_Product
{
	public class OrdersInMemoryRepository : IOrdersRepository
	{
		private List<Order> orders = new List<Order>();



		public void Add(Order order)
		{
			orders.Add(order);
		}

        public List<Order> GetAll()
        {
            return orders;
        }

        public object TryGetById(Guid id)
        {
            return orders.FirstOrDefault(x => x.Id == id);
        }

		public void UpdateStatus(Guid orderid, OrderStatus newStatus)
		{
			var order = TryGetById(orderid);
			if (order != null)
			{
				//order.Status = newStatus;
			}
		}
	}
}
