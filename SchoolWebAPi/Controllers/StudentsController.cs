using Microsoft.AspNetCore.Mvc;
using SchoolWebAPi.Data.Services;
using SchoolWebAPi.Data.ViewModels;

namespace SchoolWebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private StudentsService _studentsService;
        public StudentsController(StudentsService studentsService)
        {
            _studentsService = studentsService;
        }

        [HttpGet("Get-All-Student")]
        public IActionResult GetAllStudents()
        {
            var allStudents = _studentsService.GetAllStudents();
            return Ok(allStudents);
        }

        [HttpGet("Get-Student-By-Id/{id}")]
        public IActionResult GetStudentById(int id)
        {
            var students = _studentsService.GetStudentById(id);
            return Ok(students);
        }

        [HttpPost("Add-Student")]
        public IActionResult AddStudent([FromBody] StudentVM student)
        {
            _studentsService.AddStudent(student);
            return Ok();
        }

        [HttpPut("Update-Student-by-id/{id}")]
        public IActionResult UpdateStudentById(int id, [FromBody] StudentVM student)
        {
            var updatedBook = _studentsService.UpdateStudentById(id, student);
            return Ok(updatedBook);
        }

        [HttpDelete("Delete-Student-by-id/{id}")]
        public IActionResult DeleteStudentById(int id)
        {
            _studentsService.DeleteStudentById(id);
            return Ok();
        }
    }
}
