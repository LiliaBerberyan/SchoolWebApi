using SchoolWebAPi.Data.ViewModels;
using SchoolWebAPi.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchoolWebAPi.Data.Services
{
    public class SubjectsService
    {
        private AppDbContext _context;
        public SubjectsService(AppDbContext context)
        {
            _context = context;
        }
        public List<Subject> GetAllSubjects()
        {
            return _context.Subjects.ToList();
        }
        public Subject GetSubjectById(int subjectID)
        {
            return _context.Subjects.FirstOrDefault(n => n.Id == subjectID);
        }
        public void AddSubject(SubjectVM subject)
        {
            Subject _subject = new Subject()
            {
                Name = subject.Name
            };
            _context.Subjects.Add(_subject);
            _context.SaveChanges();
        }
        public void DeleteSubjectById(int id)
        {
            var subject = _context.Subjects.FirstOrDefault(n => n.Id == id);
            if (subject != null)
            {
                _context.Subjects.Remove(subject);
                _context.SaveChanges();
            }
        }
    }
}
