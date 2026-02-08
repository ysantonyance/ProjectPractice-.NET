using Microsoft.EntityFrameworkCore;
using ProjectPractice.Infrastructure;
using ProjectPractice_.NET.Infrastructure.Repositoriess;
using ProjectPractice_.NET.Modules;

internal class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var context = new AppDbContext();

        var users = new UserRepository(context);
        var categories = new CategoryRepository(context);
        var products = new ProductRepository(context);
        var orders = new OrderRepository(context);
        var reviews = new ReviewRepository(context);

        /*users.AddUsers(new List<User>
            {
                new User { Name = "John Smith", Age = 28 },
                new User { Name = "Emily Emily Johnson", Age = 32 },
                new User { Name = "Michael Brown", Age = 25 },
                new User { Name = "Sarah Williams", Age = 30 },
                new User { Name = "David Miller", Age = 35 }
            });

        categories.AddCategories(new List<Category>
        {
            new Category { Name = "Electronics" },
            new Category { Name = "Books" },
            new Category { Name = "Clothing" },
            new Category { Name = "Sports" },
            new Category { Name = "Home & Garden" }
        });

        products.AddProducts(new List<Product>
        {
            new Product { Name = "Iphone 15 pro", Price = 999, CategoryId = 6 },
            new Product { Name = "Harry Potter Book Set", Price = 89, CategoryId = 7 },
            new Product { Name = "Nike T-shirt", Price = 29, CategoryId = 8  },
            new Product { Name = "Football", Price = 49, CategoryId = 9  },
            new Product { Name = "Coffee Maker", Price = 79, CategoryId = 10 }
        });

        orders.AddOrders(new List<Order>
        {
            new Order { ProductName = "Iphone 15 pro", Price = 999, OrderDate = DateTime.Now, UserId = 21 },
            new Order { ProductName = "Harry Potter Book Set", Price = 89, OrderDate = DateTime.Now.AddDays(-1), UserId = 22 },
            new Order { ProductName = "Nike T-shirt", Price = 29, OrderDate = DateTime.Now.AddDays(-3), UserId = 23 },
            new Order { ProductName = "Football", Price = 49, OrderDate= DateTime.Now.AddDays(-5), UserId = 24 },
            new Order { ProductName = "Coffee Maker", Price = 79, OrderDate = DateTime.Now.AddDays(-7), UserId = 25 }
        });

        reviews.AddReviews(new List<Review>
        {
            new Review { Rating = 5, Comment = "Best phone ever!", UserId = 21, ProductId = 14 },
            new Review { Rating = 4, Comment = "Great collection!", UserId = 22, ProductId = 15},
            new Review { Rating = 3, Comment = "Shrinks after wash", UserId = 23, ProductId = 16 },
            new Review { Rating = 5, Comment = "Perfect for training", UserId = 24, ProductId = 17 },
            new Review { Rating = 4, Comment = "Good value", UserId = 25, ProductId = 18 }
        });*/

        users.ShowAllUsers();
        Console.WriteLine();
        categories.ShowAllCategories();
        Console.WriteLine();
        products.ShowAllProducts();
        Console.WriteLine();
        orders.ShowAllOrders();
        Console.WriteLine();
        reviews.ShowAllReviews();
        Console.WriteLine();
    }
}
