using SchoolWebAPi.Data.ViewModels;
using SchoolWebAPi.Models;
using SchoolWebAPi.RepositryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolWebAPi.RepositoryClasses
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext context) : base(context)
        {

        }

        public Student AddStudent(StudentVM student)
        {
            Student _student = new Student()
            {
                Name = student.Name,
                Surname = student.Surname,
                PhoneNumber = student.PhoneNumber,
            };
            return _student;
        }
    }
}
