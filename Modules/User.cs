using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice_.NET.Modules
{
    public class User
    {
        public int Id { get; set; }         // первинний ключ
        public string? Name { get; set; }   // інші поля
        public int Age { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string Address { get; set; } = "Ukraine";

        public User()
        {
            Name = "Alex";
            Age = 25;
        }

        public User(string? name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
