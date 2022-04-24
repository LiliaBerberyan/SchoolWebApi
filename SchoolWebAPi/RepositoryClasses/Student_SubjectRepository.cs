using SchoolWebAPi.Data.Models;
using SchoolWebAPi.Data.ViewModels;
using SchoolWebAPi.Models;
using SchoolWebAPi.RepositryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolWebAPi.RepositoryClasses
{
    public class Student_SubjectRepository : Repository<Student_Subject>, IStudent_SubjectRepository
    {
        public Student_SubjectRepository(AppDbContext context) : base(context)
        {

        }

        public List<Student_Subject> AddStudent_Subject(StudentVM student, Student _student)
        {
            List<Student_Subject> list = new List<Student_Subject>();
            foreach (var id in student.SubjectsIds)
            {
                var student_subject = new Student_Subject()
                {
                    StudentId = _student.Id,
                    SubjectId = id
                };
                list.Add(student_subject);
            }
            return list;
        }
    }
}
