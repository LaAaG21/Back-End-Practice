using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University_System_ERD___Models.Models
{
    public class Enrollment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int enrollmentId { get; set; }

        [Required]
        public int studentId { get; set; }

        [ForeignKey("studentId"), Required]
        public Student student { get; set; }

        [Required]
        public int courseId { get; set; }

        [ForeignKey("courseId"), Required]
        public Course course { get; set; }

        [Required]
        public DateTime enrollmentDate { get; set; }

        [MaxLength(2)]
        public string finalGrade { get; set; }

        [Required, MaxLength(20)]
        public string status { get; set; } = "In Progress";
    }
}
