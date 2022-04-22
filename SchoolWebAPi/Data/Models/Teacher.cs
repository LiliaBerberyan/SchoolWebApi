using System.ComponentModel.DataAnnotations;

namespace SchoolWebAPi.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [MaxLength(20)]
        public string Surname { get; set; }

        [Required]
        [MaxLength(9)]
        public string PhoneNumber { get; set; }
        public int SubjectID { get; set; }
        public Subject Subject { get; set; }
    }
}
