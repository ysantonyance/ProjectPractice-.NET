using ProjectPractice.Infrastructure;
using ProjectPractice_.NET.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice_.NET.Infrastructure.Repositoriess
{
    public class OrderRepository
    {
        private AppDbContext context;

        public OrderRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void AddOrder(Order order)
        {
            context.Orders?.Add(order);
            context.SaveChanges();
        }

        public void AddOrders(List<Order> orders)
        {
            context.Orders?.AddRange(orders);
            context.SaveChanges();
        }

        public void UpdateOrder(int id, string newName, decimal newPrice, DateTime newDate, int userId, User user)
        {
            var order = context.Orders?.FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                order.ProductName = newName;
                order.Price = newPrice;
                order.OrderDate = newDate;
                order.UserId = userId;
                order.User = user;
                context.SaveChanges();
            }
        }

        public void UpdateOrder(int id, string newName)
        {
            var order = context.Orders?.FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                order.ProductName = newName;
                context.SaveChanges();
            }
        }

        public void UpdateOrder(int id, decimal newPrice)
        {
            var order = context.Orders?.FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                order.Price = newPrice;
                context.SaveChanges();
            }
        }

        public void UpdateOrder(int id, DateTime newDate)
        {
            var order = context.Orders?.FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                order.OrderDate = newDate;
                context.SaveChanges();
            }
        }

        public void UpdateOrder(int id, int userId, User user)
        {
            var order = context.Orders?.FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                order.UserId = userId;
                order.User = user;
                context.SaveChanges();
            }
        }

        public void UpdateAllOrders(string newName)
        {
            var orders = context.Orders?.Where(o => true).ToList();
            if (orders != null)
            {
                foreach (var order in orders)
                {
                    order.ProductName = newName;
                }
                context.SaveChanges();
            }
        }

        public void DeleteOrder(int id)
        {
            var order = context.Orders?.FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                context.Orders?.Remove(order);
                context.SaveChanges();
            }
        }

        public void DeleteAllOrders()
        {
            var orders = context.Orders?.ToList();
            if (orders != null && orders.Any())
            {
                context.Orders?.RemoveRange(orders);
                context.SaveChanges();
            }
        }

        public void ShowOrder(int id)
        {
            var order = context.Orders?.FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                Console.WriteLine($"ID: {order.Id}, Назва: {order.ProductName}, Ціна: {order.Price}, " +
                    $"Ід користувача: {order.UserId}");
            }
        }

        public void ShowOrder(string name)
        {
            var order = context.Orders?.FirstOrDefault(o => o.ProductName == name);
            if (order != null)
            {
                Console.WriteLine($"ID: {order.Id}, Назва: {order.ProductName}, Ціна: {order.Price}, " +
                    $"Ід користувача: {order.UserId}");
            }
        }

        public void ShowOrder(decimal price)
        {
            var order = context.Orders?.FirstOrDefault(o => o.Price == price);
            if (order != null)
            {
                Console.WriteLine($"ID: {order.Id}, Назва: {order.ProductName}, Ціна: {order.Price}, " +
                    $"Ід користувача: {order.UserId}");
            }
        }

        public void ShowOrder(User user)
        {
            var order = context.Orders?.FirstOrDefault(o => o.User == user);
            if (order != null)
            {
                Console.WriteLine($"ID: {order.Id}, Назва: {order.ProductName}, Ціна: {order.Price}, " +
                    $"Ід користувача: {order.UserId}");
            }
        }

        public void ShowAllOrders()
        {
            var orders = context.Orders?.ToList();
            if (orders != null && orders.Any())
            {
                foreach (var order in orders)
                {
                    Console.WriteLine($"ID: {order.Id}, Назва: {order.ProductName}, Ціна: {order.Price}, " +
                    $"Ід користувача: {order.UserId}");
                }
            }
        }
    }
}
