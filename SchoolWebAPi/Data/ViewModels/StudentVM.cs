using System.Collections.Generic;

namespace SchoolWebAPi.Data.ViewModels
{
    public class StudentVM
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public List<int> SubjectsIds { get; set; }
    }
}
