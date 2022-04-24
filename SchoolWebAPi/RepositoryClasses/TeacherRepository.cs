using SchoolWebAPi.Data.ViewModels;
using SchoolWebAPi.Models;
using SchoolWebAPi.RepositryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolWebAPi.RepositoryClasses
{
    public class TeacherRepository : Repository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(AppDbContext context) : base(context)
        {

        }

        public Teacher AddTeacher(TeacherVM teacher)
        {
            Teacher _teacher = new Teacher()
            {
                Name = teacher.Name,
                Surname = teacher.Surname,
                PhoneNumber = teacher.PhoneNumber,
                SubjectID = teacher.SubjectID
            };
            return _teacher;
        }
    }
}
