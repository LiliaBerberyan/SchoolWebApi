using SchoolWebAPi.Data.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolWebAPi.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [MaxLength(20)]
        public string Surname { get; set; }

        [Required]
        [MaxLength(9)]
        public string PhoneNumber { get; set; }

        public List<Student_Subject> Student_Subjects { get; set; }
    }
}
