using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_System_ERD___Models.Models
{
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
}
