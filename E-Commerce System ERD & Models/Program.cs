using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace E_Commerce_System_ERD___Models
{
    [Index(nameof(userName), IsUnique = true), Index(nameof(email), IsUnique = true)]
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userId { get; set; }                     // system generated

        [Required, MaxLength(50)]
        public string userName { get; set; }                // user input

        [Required, MaxLength(150)]
        public string email { get; set; }                   // user input

        [Required, MaxLength(256)]
        public string passwordHash { get; set; }            // system generated

        [Required, MaxLength(100)]
        public string fullName { get; set; }                // user input

        [MaxLength(20)]
        public string? phoneNumber { get; set; }            // user input

        [MaxLength(300)]
        public string? address { get; set; }                // user input

        [Required]
        public DateTime registrationDate { get; set; }      // system generated

        public bool isActive { get; set; } = true;          // default value

        public ICollection<Order> orders { get; set; }      // navigation property
        public ICollection<Review> reviews { get; set; }    // navigation property
    }


    [Index(nameof(categoryName), IsUnique = true)]
    public class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int categoryId { get; set; }                 // system generated

        [Required, MaxLength(100)]
        public string categoryName { get; set; }            // user input

        [MaxLength(500)]
        public string? description { get; set; }            // user input

        [MaxLength(300)]
        public string? imageUrl { get; set; }               // user input

        public ICollection<Product> products { get; set; }  // navigation property
    }


    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productId { get; set; }                      // system generated

        [Required, MaxLength(150)]
        public string productName { get; set; }                 // user input

        [MaxLength(1000)]
        public string? description { get; set; }                // user input

        [Required, Range(0.1, double.MaxValue)]
        public decimal price { get; set; }                      // user input

        [Required, Range(0, int.MaxValue)]
        public int stockQuantity { get; set; } = 0;             // default value

        [MaxLength(300)]
        public string? imageUrl { get; set; }                   // user input

        public int categoryId { get; set; }                     // foreign key

        [ForeignKey("categoryId")]
        public Category category { get; set; }                  // navigation property

        [Required]
        public DateTime createdAt { get; set; }                 // system generated

        public bool isAvailable { get; set; } = true;           // default value

        public ICollection<OrderItem> orderItems { get; set; }  // navigation property
        public ICollection<Review> reviews { get; set; }        // navigation property
    }


    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderId { get; set; }                        // system generated

        public int userId { get; set; }                         // foreign key

        [ForeignKey("userId")]
        public User user { get; set; }                          // navigation property

        [Required]
        public DateTime orderDate { get; set; }                 // system generated

        [Required, Range(0, double.MaxValue)]
        public decimal totalAmount { get; set; }                // calculated

        [Required, MaxLength(30)]
        public string status { get; set; } = "Pending";         // default value

        [Required, MaxLength(300)]
        public string shippingAddress { get; set; }             // user input

        [Required, MaxLength(50)]
        public string paymentMethod { get; set; }               // from list

        public ICollection<OrderItem> orderItems { get; set; }  // navigation property
    }


    public class Review
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int reviewId { get; set; }            // system generated

        public int userId { get; set; }              // foreign key

        [ForeignKey("userId")]
        public User user { get; set; }               // navigation property

        public int productId { get; set; }           // foreign key

        [ForeignKey("productId")]
        public Product product { get; set; }         // navigation property

        [Required, Range(1, 5)]
        public int rating { get; set; }              // user input

        [MaxLength(1000)]
        public string? comment { get; set; }         // user input

        [Required]
        public DateTime reviewDate { get; set; }     // system generated
    }


    public class OrderItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderItemId { get; set; }         // system generated

        public int productId { get; set; }           // foreign key

        [ForeignKey("productId")]
        public Product product { get; set; }         // navigation property

        public int orderId { get; set; }             // foreign key

        [ForeignKey("orderId")]
        public Order order { get; set; }             // navigation property

        [Required, Range(1, 999)]
        public int quantity { get; set; }            // user input
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}