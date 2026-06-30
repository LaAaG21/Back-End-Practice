using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace University_System_ERD___Models.Models
{
    [Index(nameof(email), IsUnique = true)]
    public class Instructor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int instructorId { get; set; }

        [Required, MaxLength(100)]
        public string fullName { get; set; }

        [Required, MaxLength(150)]
        public string email { get; set; }

        [MaxLength(20)]
        public string? officeNumber { get; set; }

        [Required]
        public DateTime hireDate { get; set; }

        [Required, Range(0.1, double.MaxValue)]
        public decimal salary { get; set; }

        [Required, MaxLength(50)]
        public string academicTitle { get; set; }

        public ICollection<Course>? courses { get; set; }
    }
}
