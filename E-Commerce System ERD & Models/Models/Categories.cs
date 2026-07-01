using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_System_ERD___Models.Models
{
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
}
