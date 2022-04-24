using Microsoft.AspNetCore.Mvc;
using SchoolWebAPi.Data.Models;
using SchoolWebAPi.Data.Services;
using SchoolWebAPi.Data.ViewModels;
using SchoolWebAPi.RepositryInterfaces;
using Serilog;
using System;

namespace SchoolWebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private IUnitOfWork _unit;
        public StudentsController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet("Get-All-Students")]
        public IActionResult GetAllStudents()
        {
            // throw new Exception("Exeption");
            var allStudents = _unit.Students.GetAll();
            return Ok(allStudents);
        }

        [HttpGet("Get-Student-By-Id/{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = _unit.Students.Get(id);
            return Ok(student);
        }

        [HttpPost("Add-Student")]
        public IActionResult AddStudent([FromBody] StudentVM student)
        {
            var _student = _unit.Students.AddStudent(student);
            _unit.Students.Add(_student);
            _unit.Complete();
            foreach (var id in student.SubjectsIds)
            {
                var student_subject = new Student_Subject()
                {
                    StudentId = _student.Id,
                    SubjectId = id
                };
                _unit.Student_Subject.Add(student_subject);
                _unit.Complete();
            }
            //var student_subjects = _unit.Student_Subjects.AddStudent_Subject(student, _student);
            //_unit.Student_Subjects.AddRange(student_subjects);
            //_unit.Complete();
            return Ok();
        }

        //[HttpPut("Update-Student-by-id/{id}")]
        //public IActionResult UpdateStudentById(int id, [FromBody] StudentVM student)
        //{
        //    var updatedBook = _studentsService.UpdateStudentById(id, student);
        //    return Ok(updatedBook);
        //}

        [HttpDelete("Delete-Student-by-id/{id}")]
        public IActionResult DeleteStudentById(int id)
        {
            var student = _unit.Students.Get(id);
            _unit.Students.Remove(student);
            return Ok();
        }
    }
}
