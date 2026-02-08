using ProjectPractice.Infrastructure;
using ProjectPractice_.NET.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice_.NET.Infrastructure.Repositoriess
{
    public class UserRepository
    {
        private AppDbContext context;

        public UserRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void AddUser(User user)
        {
            context.Users?.Add(user);
            context.SaveChanges();
        }

        public void AddUsers(List<User> users)
        {
            context.Users?.AddRange(users);
            context.SaveChanges();
        }

        public void UpdateUser(int id, int newAge)
        {
            var user = context.Users?.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                user.Age = newAge;
                context.SaveChanges();
            }
        }

        public void UpdateAllUsers(int newAge)
        {
            var users = context.Users?.Where(u => true).ToList();
            if (users != null)
            {
                foreach (var user in users)
                {
                    user.Age = newAge;
                }
                context.SaveChanges();
            }
        }

        public void DeleteUser(int id)
        {
            var user = context.Users?.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                context.Users?.Remove(user);
                context.SaveChanges();
            }
        }

        public void DeleteAllUsers()
        {
            var users = context.Users?.ToList();
            if (users != null && users.Any())
            {
                context.Users?.RemoveRange(users);
                context.SaveChanges();
            }
        }

        public void ShowUser(int id)
        {
            var user = context.Users?.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                Console.WriteLine($"ID: {user.Id}, Ім'я: {user.Name}, Вік: {user.Age}");
            }
        }

        public void ShowUser(User user)
        {
            var result = context.Users?.FirstOrDefault(u => u == user);
            if (result != null)
            {
                Console.WriteLine($"ID: {user.Id}, Ім'я: {user.Name}, Вік: {user.Age}");
            }
        }

        public void ShowAllUsers()
        {
            var users = context.Users?.ToList();
            if (users != null && users.Any())
            {
                foreach (var user in users)
                {
                    Console.WriteLine($"ID: {user.Id}, Ім'я: {user.Name}, Вік: {user.Age}");
                }
            }
        }
    }

}
