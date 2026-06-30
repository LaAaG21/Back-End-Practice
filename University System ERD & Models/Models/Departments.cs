using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace University_System_ERD___Models.Models
{
    [Index(nameof(departmentName), IsUnique = true)]
    public class Department
    {
        [Key]
        public int departmentId { get; set; }

        [Required, MaxLength(100)]
        public string departmentName { get; set; }

        [MaxLength(50)]
        public string? building { get; set; }

        [Required, Range(0, double.MaxValue)]
        public double budget { get; set; }

        public int? headInstructorId { get; set; }

        [ForeignKey("headInstructorId")]
        public Instructor? headInstructor { get; set; }
    }
}
