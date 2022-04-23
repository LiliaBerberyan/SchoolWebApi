using SchoolWebAPi.Data.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolWebAPi.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Length must be less then 20 characters")]
        public string Name { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Length must be less then 20 characters")]
        public string Surname { get; set; }

        [Required]
        [MaxLength(9, ErrorMessage = "Must Include 9 characters")]
        public string PhoneNumber { get; set; }

        //Navigation Properties
        public List<Student_Subject> Student_Subjects { get; set; }
    }
}
