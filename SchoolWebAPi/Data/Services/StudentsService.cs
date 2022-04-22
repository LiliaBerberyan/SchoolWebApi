using SchoolWebAPi.Data.Models;
using SchoolWebAPi.Data.ViewModels;
using SchoolWebAPi.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchoolWebAPi.Data.Services
{
    public class StudentsService
    {
        private AppDbContext _context;
        public StudentsService(AppDbContext context)
        {
            _context = context;
        }
        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }
        public Student GetStudentById(int studentID)
        {
            return _context.Students.FirstOrDefault(n => n.Id == studentID);
        }

        public void AddStudent(StudentVM student)
        {
            Student _student = new Student()
            {
                Name = student.Name,
                Surname = student.Surname,
                PhoneNumber = student.PhoneNumber,
            };
            _context.Students.Add(_student);
            _context.SaveChanges();

            foreach (var id in student.SubjectsIds)
            {
                var student_subject = new Student_Subject()
                {
                    StudentId = _student.Id,
                    SubjectId = id
                };
                _context.Student_Subjects.Add(student_subject);
                _context.SaveChanges();
            }
        }

        public Student UpdateStudentById(int id, StudentVM student)
        {
            var _student = _context.Students.FirstOrDefault(n => n.Id == id);
            if (student != null)
            {
                _student.Name = student.Name;
                _student.Surname = student.Surname;
                _student.PhoneNumber = student.PhoneNumber;

                _context.SaveChanges();
            }
            return _student;
        }

        public void DeleteStudentById(int id)
        {
            var student = _context.Students.FirstOrDefault(n => n.Id == id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }
    }
}
