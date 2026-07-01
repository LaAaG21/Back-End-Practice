using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_System_ERD___Models.Models
{
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
}
