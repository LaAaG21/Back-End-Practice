using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University_System_ERD___Models.Models
{
    [Index(nameof(courseCode), IsUnique = true)]
    public class Course
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int courseId { get; set; }

        [Required, MaxLength(10)]
        public string courseCode { get; set; }

        [Required, MaxLength(150)]
        public string courseTitle { get; set; }

        [Required, Range(1, 6)]
        public int creditHours { get; set; }

        public int departmentId { get; set; }

        [ForeignKey("departmentId")]
        public Department department { get; set; }

        public int? instructorId { get; set; }

        [ForeignKey("instructorId")]
        public Instructor? instructor { get; set; }

        [Required, MaxLength(20)]
        public string semesterOffered { get; set; }

        public ICollection<Enrollment>? enrollments { get; set; }
    }
}
