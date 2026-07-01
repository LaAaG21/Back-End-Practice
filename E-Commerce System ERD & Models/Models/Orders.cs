using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_System_ERD___Models.Models
{
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
}
