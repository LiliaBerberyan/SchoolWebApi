using SchoolWebAPi.Data.ViewModels;
using SchoolWebAPi.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchoolWebAPi.Data.Services
{
    public class TeachersService
    {
        private AppDbContext _context;
        public TeachersService(AppDbContext context)
        {
            _context = context;
        }
        public List<Teacher> GetAllTeachers()
        {
            return _context.Teachers.ToList();
        }
        public object GetTeacherById(int id)
        {
            return _context.Teachers.FirstOrDefault(n => n.Id == id);
        }
        public void AddTeacher(TeacherVM teacher)
        {
            Teacher _teacher = new Teacher()
            {
                Name = teacher.Name,
                Surname = teacher.Surname,
                PhoneNumber = teacher.PhoneNumber,
                SubjectID = teacher.SubjectID
            };
            _context.Teachers.Add(_teacher);
            _context.SaveChanges();
        }
        public void DeleteTeacherById(int id)
        {
            var teacher = _context.Teachers.FirstOrDefault(n => n.Id == id);
            if (teacher != null)
            {
                _context.Teachers.Remove(teacher);
                _context.SaveChanges();
            }
        }
    }
}
