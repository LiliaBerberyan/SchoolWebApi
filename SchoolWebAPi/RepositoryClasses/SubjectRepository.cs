using SchoolWebAPi.Data.ViewModels;
using SchoolWebAPi.Models;
using SchoolWebAPi.RepositryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolWebAPi.RepositoryClasses
{
    public class SubjectRepository : Repository<Subject>, ISubjectRepository
    {
        public SubjectRepository(AppDbContext context) : base(context)
        {

        }

        public Subject AddSubject(SubjectVM subject)
        {
            Subject _subject = new Subject()
            {
                Name = subject.Name
            };
            return _subject;
        }
    }
}
