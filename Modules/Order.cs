using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice_.NET.Modules
{
    public class Order
    {
        public int Id { get; set; } 
        public string ProductName { get; set; } = null!;
        public decimal Price { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        public int UserId { get; set; }       
        public User User { get; set; } = null!;    

        public Order()
        {
            ProductName = "Order";
            Price = 10;
        }

        public Order(string productName, decimal price)
        {
            ProductName= productName;
            Price = price;
        }

        public Order(string productName, decimal price, DateTime orderDate)
        {
            ProductName = productName;
            Price = price;
            OrderDate = orderDate;
        }

        public Order(string productName, decimal price, DateTime orderDate, int userId, User user)
        {
            ProductName = productName;
            Price = price;
            OrderDate = orderDate;
            UserId = userId;
            User = user;
        }
    }
}
