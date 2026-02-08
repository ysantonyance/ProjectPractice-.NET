using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice_.NET.Modules
{
    public class Product
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; } 

        public Product() 
        {
            Name = "Product";
            Price = 10;
        }

        public Product(string? name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
