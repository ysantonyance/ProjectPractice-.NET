using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice_.NET.Modules
{
    public class Review
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; } 
        public int UserId { get; set; }
        public User? User { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public Review()
        {
            Rating = 10;
            Comment = "Very nice!";
        }

        public Review(int rating, string? comment, int userId, User user, int productId, Product product)
        {
            Rating = rating;
            Comment = comment;
            UserId = userId;
            ProductId = productId;
        }
    }
}
