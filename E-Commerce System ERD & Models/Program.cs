using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace E_Commerce_System_ERD___Models
{

    [Index(nameof(userName), IsUnique = true), Index(nameof(email), IsUnique = true)]
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userId { get; set; }

        [Required, MaxLength(50)]
        public string userName{ get; set; }

        [Required, MaxLength(150)]
        public string email{ get; set; }

        [Required, MaxLength(256)]
        public string passwordHash{ get; set; }

        [Required, MaxLength(100)]
        public string fullName{ get; set; }

        [MaxLength(20)]
        public string? phoneNumber { get; set; }

        [MaxLength(300)]
        public string? address { get; set; }

        [Required]
        public DateTime registrationDate { get; set; }

        public bool isActive { get; set; } = true;
    }


    [Index(nameof(categoryName), IsUnique = true)]
    public class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int categoryId { get; set; }

        [Required, MaxLength(100)]
        public string categoryName { get; set; }

        [MaxLength(500)]
        public string? description { get; set; }

        [MaxLength(300)]
        public string? imageUrl { get; set; }
    }


    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productId { get; set; }

        [Required, MaxLength(150)]
        public string productName { get; set; }

        [MaxLength(1000)]
        public string? description { get; set; }

        [Required, Range(0.1, double.MaxValue)]
        public decimal? price { get; set; }

        [Required, Range(0, int.MaxValue)]
        public int? stockQuantity { get; set; }

        [MaxLength(300)]
        public string imageUrl { get; set; }

        [Required]
        public int categoryId { get; set; }
        [ForeignKey("categoryId"), Required]
        public Category category { get; set; }

        [Required]
        public DateTime creadeAt { get; set; }

        public bool isAvalible { get; set; } = true;
    }


    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderId { get; set; }

        [ForeignKey("userId"), Required]
        public int userId { get; set; }
        public User user { get; set; }

        [Required]
        public DateTime orderDate { get; set; }

        [Required, Range(0, double.MaxValue)]
        public decimal totalAmount { get; set; }

        [Required, MaxLength(30)]
        public string status { get; set; } = "Pending";

        [Required, MaxLength(300)]
        public string shippingAddress { get; set; }

        [Required, MaxLength(50)]
        public string paymentMethod { get; set; }
    }


    public class Review
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int reviewId { get; set; }

        [ForeignKey("userId"), Required]
        public int userId { get; set; }
        public User user { get; set; }

        [ForeignKey("productId"), Required]
        public int productId { get; set; }
        public Product product { get; set; }

        [Required, Range(1,5)]
        public int rating { get; set; }

        [MaxLength(1000)]
        public string? comment { get; set; }

        [Required]
        public DateTime reviewDate { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
