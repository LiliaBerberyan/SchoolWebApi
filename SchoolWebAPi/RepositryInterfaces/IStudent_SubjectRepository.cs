using SchoolWebAPi.Data.Models;
using SchoolWebAPi.Data.ViewModels;
using SchoolWebAPi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolWebAPi.RepositryInterfaces
{
   public interface IStudent_SubjectRepository : IRepository<Student_Subject>
    {
        List<Student_Subject> AddStudent_Subject(StudentVM student, Student _student);
    }
}
