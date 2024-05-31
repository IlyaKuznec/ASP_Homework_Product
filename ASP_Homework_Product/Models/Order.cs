﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ASP_Homework_Product.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public UserDeliveryInfo User {  get; set; }
        public List<CartItem> Items { get; set; }

        public OrderStatus Status { get; set; }
        public DateTime CreateDateTime { get; set; }

        public Order() 
        {
            Id = Guid.NewGuid();
            Status = OrderStatus.Created;
            CreateDateTime = DateTime.Now;
        }        
    }
}
