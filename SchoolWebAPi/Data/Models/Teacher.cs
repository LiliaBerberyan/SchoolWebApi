using System.ComponentModel.DataAnnotations;

namespace SchoolWebAPi.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Length must be less then 30 characters")]
        public string Name { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Length must be less then 20 characters")]
        public string Surname { get; set; }

        [Required]
        [MaxLength(9, ErrorMessage = "Must Include 9 characters")]
        public string PhoneNumber { get; set; }

        //Navigation Properties
        public int SubjectID { get; set; }
        public Subject Subject { get; set; }
    }
}
