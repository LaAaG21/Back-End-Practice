using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_System_ERD___Models.Models
{
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
}
