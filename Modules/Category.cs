using Azure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice_.NET.Modules
{
    public class Category
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public ICollection<Product>? Products { get; set; }


        public Category()
        {
            Name = "Unknown";
        }

        public Category(string? name)
        {
            Name = name;
        }
    }
}
