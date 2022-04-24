using SchoolWebAPi.Data.ViewModels;
using SchoolWebAPi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolWebAPi.RepositryInterfaces
{
    public interface ISubjectRepository : IRepository<Subject>
    {
        Subject AddSubject(SubjectVM subject);
    }
}
