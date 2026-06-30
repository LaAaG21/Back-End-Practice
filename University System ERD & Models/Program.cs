using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace University_System_ERD___Models
{

    [Index(nameof(email), IsUnique = true)]
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

        [Range(0.0, 4.0), DefaultValue(0.0)]
        public decimal gpa { get; set; }
    }

    [Index(nameof(email), IsUnique = true)]
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

    [Index(nameof(departmentName), IsUnique = true)]
    public class Department
    {
        [Key]
        public int departmentId { get; set; }

        [Required, MaxLength(100)]
        public string departmentName { get; set; }

        [MaxLength(50)]
        public string? building { get; set; }

        [Required, Range(0,double.MaxValue)]
        public double budget { get; set; }

        public int? headInstructorId { get; set; }

        [ForeignKey("headInstructorId")]
        public Instructor? headInstructor { get; set; }
    }

    [Index(nameof(courseCode), IsUnique = true)]
    public class Course
    {
        [Key]
        public int courseId { get; set; }

        [Required, MaxLength(10)]
        public string courseCode { get; set; }

        [Required, MaxLength(150)]
        public string courseTitle { get; set; }

        [Required, Range(1,6)]
        public int creditHours { get; set; }

        public int? departmentId { get; set; }

        [ForeignKey("departmentId")]
        public Department? department { get; set; }

        public int? headInstructorId { get; set; }

        [ForeignKey("headInstructorId")]
        public Instructor? headInstructor { get; set; }

        [Required, MaxLength(20)]
        public string semesterOffered { get; set; }
    }

    public class Enrollment
    {
        [Key]
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

        [Required, MaxLength(20), DefaultValue("In Progress")]
        public string status { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
