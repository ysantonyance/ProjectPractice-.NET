using ProjectPractice.Infrastructure;
using ProjectPractice_.NET.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice_.NET.Infrastructure.Repositoriess
{
    public class CategoryRepository
    {
        private AppDbContext context;

        public CategoryRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void AddCategory(Category category)
        {
            context.Categories?.Add(category);
            context.SaveChanges();
        }

        public void AddCategories(List<Category> categories)
        {
            context.Categories?.AddRange(categories);
            context.SaveChanges();
        }

        public void UpdateCategory(int id, string? newName)
        {
            var category = context.Categories?.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                category.Name = newName;
                context.SaveChanges();
            }
        }

        public void UpdateAllCategories(string? newName)
        {
            var categories = context.Categories?.Where(c => true).ToList();
            if (categories != null)
            {
                foreach (var category in categories)
                {
                    category.Name = newName;
                }
                context.SaveChanges();
            }
        }

        public void DeleteCategory(int id)
        {
            var category = context.Categories?.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                context.Categories?.Remove(category);
                context.SaveChanges();
            }
        }

        public void DeleteAllCategories()
        {
            var categories = context.Categories?.ToList();
            if (categories != null && categories.Any())
            {
                context.Categories?.RemoveRange(categories);
                context.SaveChanges();
            }
        }

        public void ShowCategory(int id)
        {
            var category = context.Categories?.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                Console.WriteLine($"ID: {category.Id}, Назва: {category.Name}");
            }
        }

        public void ShowCategory(string? name)
        {
            var result = context.Categories?.FirstOrDefault(c => c.Name == name);
            if (result != null)
            {
                Console.WriteLine($"ID: {result.Id}, Назва: {result.Name}");
            }
        }

        public void ShowAllCategories()
        {
            var categories = context.Categories?.ToList();
            if (categories != null && categories.Any())
            {
                foreach (var category in categories)
                {
                    Console.WriteLine($"ID: {category.Id}, Назва: {category.Name}");
                }
            }
        }
    }

}
