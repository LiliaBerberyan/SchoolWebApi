using SchoolWebAPi.Data.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolWebAPi.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Length must be less then 20 characters")]
        public string Name { get; set; }

        //Navigation Properties
        public List<Teacher> Teachers { get; set; }
        public List<Student_Subject> Student_Subjects { get; set; }
    }
}
