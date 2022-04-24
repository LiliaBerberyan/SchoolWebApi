using SchoolWebAPi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolWebAPi.RepositryInterfaces
{
   public interface IUnitOfWork : IDisposable
    {
        IStudentRepository Students { get; }
        ITeacherRepository Teachers { get; }
        ISubjectRepository Subjects { get; }
        IStudent_SubjectRepository Student_Subject { get; }
        int Complete();
    }
}
