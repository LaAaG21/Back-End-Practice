using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University_System_ERD___Models.Models
{
    [Index(nameof(email), IsUnique = true)]
    public class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studentId { get; set; }

        [Required, StringLength(100)]
        public string fullName { get; set; }

        [Required, StringLength(150)]
        public string email { get; set; }

        [StringLength(20)]
        public string? phoneNumber { get; set; }

        [Required]
        public DateTime dateOfBirth { get; set; }

        [Required, Range(2000, 2030)]
        public int enrollmentYear { get; set; }

        [Range(0.0, 4.0)]
        public decimal gpa { get; set; } = 0.0m;

        public ICollection<Enrollment> enrollments { get; set; }
    }
}
