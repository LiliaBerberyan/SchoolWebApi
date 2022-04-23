using SchoolWebAPi.Models;
using System.ComponentModel.DataAnnotations;

namespace SchoolWebAPi.Data.Models
{
    public class Student_Subject
    {
        [Key]
        public int Id { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
