using ProjectPractice.Infrastructure;
using ProjectPractice_.NET.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice_.NET.Infrastructure.Repositoriess
{
    public class ProductRepository
    {
        private AppDbContext context;

        public ProductRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void AddProduct(Product product)
        {
            context.Products?.Add(product);
            context.SaveChanges();
        }

        public void AddProducts(List<Product> products)
        {
            context.Products?.AddRange(products);
            context.SaveChanges();
        }

        public void UpdateProduct(int id, string? newName, decimal newPrice)
        {
            var product = context.Products?.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                product.Name = newName;
                product.Price = newPrice;
                context.SaveChanges();
            }
        }

        public void UpdateProduct(int id, string? newName)
        {
            var product = context.Products?.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                product.Name = newName;
                context.SaveChanges();
            }
        }

        public void UpdateProduct(int id, decimal newPrice)
        {
            var product = context.Products?.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                product.Price = newPrice;
                context.SaveChanges();
            }
        }

        public void UpdateAllProducts(string? newName)
        {
            var products = context.Products?.Where(p => true).ToList();
            if (products != null)
            {
                foreach (var product in products)
                {
                    product.Name = newName;
                }
                context.SaveChanges();
            }
        }

        public void DeleteProduct(int id)
        {
            var product = context.Products?.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                context.Products?.Remove(product);
                context.SaveChanges();
            }
        }

        public void DeleteAllProducts()
        {
            var products = context.Products?.ToList();
            if (products != null && products.Any())
            {
                context.Products?.RemoveRange(products);
                context.SaveChanges();
            }
        }

        public void ShowProduct(int id)
        {
            var product = context.Products?.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Ціна: {product.Price}, Ід категорії: {product.CategoryId}");
            }
        }

        public void ShowProduct(string? name)
        {
            var result = context.Products?.FirstOrDefault(p => p.Name == name);
            if (result != null)
            {
                Console.WriteLine($"ID: {result.Id}, Назва: {result.Name}, Ціна: {result.Price}, Ід категорії: {result.CategoryId}");
            }
        }

        public void ShowProduct(decimal price)
        {
            var result = context.Products?.FirstOrDefault(p => p.Price == price);
            if (result != null)
            {
                Console.WriteLine($"ID: {result.Id}, Назва: {result.Name}, Ціна: {result.Price}, Ід категорії: {result.CategoryId}");
            }
        }

        public void ShowAllProducts()
        {
            var products = context.Products?.ToList();
            if (products != null && products.Any())
            {
                foreach (var product in products)
                {
                    Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Ціна: {product.Price}, Ід категорії: {product.CategoryId}");
                }
            }
        }
    }
}
