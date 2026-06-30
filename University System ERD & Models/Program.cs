using System.ComponentModel.DataAnnotations;
namespace University_System_ERD___Models
{

    
    public class Student
    {
        [Key]
        public int studentId {  get; set; }

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
    }

    public class Instructor
    {
        [Key]
        public int instructorId { get; set; }

        [Required, MaxLength(100)]
        public string fullName { get; set; }

        [Required, MaxLength(150)]
        public string email { get; set; }

        [MaxLength(20)]
        public string? officeNumber { get; set; }

        [Required]
        public DateTime hireDate { get; set; }

        [Required, Range(0.1,double.MaxValue)]
        public decimal salary { get; set; }

        [Required, MaxLength(50)]
        public string academicTitle { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
