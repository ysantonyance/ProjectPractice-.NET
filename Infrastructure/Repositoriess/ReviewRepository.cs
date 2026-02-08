using ProjectPractice.Infrastructure;
using ProjectPractice_.NET.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice_.NET.Infrastructure.Repositoriess
{
    public class ReviewRepository
    {
        private AppDbContext context;

        public ReviewRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void AddReview(Review review)
        {
            context.Reviews?.Add(review);
            context.SaveChanges();
        }

        public void AddReviews(List<Review> reviews)
        {
            context.Reviews?.AddRange(reviews);
            context.SaveChanges();
        }

        public void UpdateReview(int id, int newRating, string? newComment, int userId, User user, int productId, Product product)
        {
            var review = context.Reviews?.FirstOrDefault(r => r.Id == id);
            if (review != null)
            {
                review.Rating = newRating;
                review.Comment = newComment;
                review.UserId = userId;
                review.User = user;
                review.ProductId = productId;
                review.Product = product;
                context.SaveChanges();
            }
        }

        public void UpdateReview(int id, int newRating)
        {
            var review = context.Reviews?.FirstOrDefault(r => r.Id == id);
            if (review != null)
            {
                review.Rating = newRating;
                context.SaveChanges();
            }
        }

        public void UpdateReview(int id, string? newComment)
        {
            var review = context.Reviews?.FirstOrDefault(r => r.Id == id);
            if (review != null)
            {
                review.Comment = newComment;
                context.SaveChanges();
            }
        }

        public void UpdateReview(int id, int userId, User user)
        {
            var review = context.Reviews?.FirstOrDefault(r => r.Id == id);
            if (review != null)
            {
                review.UserId = userId;
                review.User = user;
                context.SaveChanges();
            }
        }

        public void UpdateReview(int id, int productId, Product product)
        {
            var review = context.Reviews?.FirstOrDefault(r => r.Id == id);
            if (review != null)
            {
                review.ProductId = productId;
                review.Product = product;
                context.SaveChanges();
            }
        }

        public void UpdateAllReviews(int newRating)
        {
            var reviews = context.Reviews?.Where(r => true).ToList();
            if (reviews != null)
            {
                foreach (var review in reviews)
                {
                    review.Rating = newRating;
                }
                context.SaveChanges();
            }
        }

        public void DeleteReview(int id)
        {
            var review = context.Reviews?.FirstOrDefault(r => r.Id == id);
            if (review != null)
            {
                context.Reviews?.Remove(review);
                context.SaveChanges();
            }
        }

        public void DeleteAllReviews()
        {
            var reviews = context.Reviews?.ToList();
            if (reviews != null && reviews.Any())
            {
                context.Reviews?.RemoveRange(reviews);
                context.SaveChanges();
            }
        }

        public void ShowReview(int id)
        {
            var review = context.Reviews?.FirstOrDefault(r => r.Id == id);
            if (review != null)
            {
                Console.WriteLine($"ID: {review.Id}, Рейтинг: {review.Rating}, Коментар: {review.Comment} " +
                    $"Ід користувача: {review.UserId}, Ід продукту: {review.ProductId}");
            }
        }

        public void ShowOrder(int rating)
        {
            var review = context.Reviews?.FirstOrDefault(r => r.Rating == rating);
            if (review != null)
            {
                Console.WriteLine($"ID: {review.Id}, Рейтинг: {review.Rating}, Коментар: {review.Comment} " +
                    $"Ід користувача: {review.UserId}, Ід продукту: {review.ProductId}");
            }
        }

        public void ShowOrder(string? comment)
        {
            var review = context.Reviews?.FirstOrDefault(r => r.Comment == comment);
            if (review != null)
            {
                Console.WriteLine($"ID: {review.Id}, Рейтинг: {review.Rating}, Коментар: {review.Comment} " +
                    $"Ід користувача: {review.UserId}, Ід продукту: {review.ProductId}");
            }
        }

        public void ShowOrder(User user)
        {
            var review = context.Reviews?.FirstOrDefault(r => r.User == user);
            if (review != null)
            {
                Console.WriteLine($"ID: {review.Id}, Рейтинг: {review.Rating}, Коментар: {review.Comment} " +
                    $"Ід користувача: {review.UserId}, Ід продукту: {review.ProductId}");
            }
        }

        public void ShowOrder(Product product)
        {
            var review = context.Reviews?.FirstOrDefault(r => r.Product == product);
            if (review != null)
            {
                Console.WriteLine($"ID: {review.Id}, Рейтинг: {review.Rating}, Коментар: {review.Comment} " +
                    $"Ід користувача: {review.UserId}, Ід продукту: {review.ProductId}");
            }
        }

        public void ShowAllReviews()
        {
            var reviews = context.Reviews?.ToList();
            if (reviews != null && reviews.Any())
            {
                foreach (var review in reviews)
                {
                    Console.WriteLine($"ID: {review.Id}, Рейтинг: {review.Rating}, Коментар: {review.Comment} " +
                    $"Ід користувача: {review.UserId}, Ід продукту: {review.ProductId}");
                }
            }
        }
    }
}
