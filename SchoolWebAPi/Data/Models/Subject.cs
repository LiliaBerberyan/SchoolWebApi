using SchoolWebAPi.Data.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolWebAPi.Models
{
    public class Subject
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Student_Subject> Student_Subjects { get; set; }

    }
}
