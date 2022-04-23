using Microsoft.AspNetCore.Mvc;
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
