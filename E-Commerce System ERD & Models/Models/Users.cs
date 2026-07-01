using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_System_ERD___Models.Models
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
}
