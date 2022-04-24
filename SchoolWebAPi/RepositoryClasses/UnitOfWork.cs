using SchoolWebAPi.Data.Models;
using SchoolWebAPi.RepositryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolWebAPi.RepositoryClasses
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Students = new StudentRepository(_context);
            Subjects = new SubjectRepository(_context);
            Teachers = new TeacherRepository(_context);
            Student_Subject = new Student_SubjectRepository(_context);
        }
        public IStudentRepository Students { get; private set; }
        public ITeacherRepository Teachers { get; private set; }
        public ISubjectRepository Subjects { get; private set; }
        public IStudent_SubjectRepository Student_Subject { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
