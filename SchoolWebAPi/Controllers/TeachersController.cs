using Microsoft.AspNetCore.Mvc;
using SchoolWebAPi.Data.Services;
using SchoolWebAPi.Data.ViewModels;
using SchoolWebAPi.RepositryInterfaces;

namespace SchoolWebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private IUnitOfWork _unit;
        public TeachersController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet("Get-All-Teachers")]
        public IActionResult GetAllTeachers()
        {
            var allTeachers = _unit.Teachers.GetAll();
            return Ok(allTeachers);
        }

        [HttpGet("Get-Teacher-By-Id/{id}")]
        public IActionResult GetTeacherById(int id)
        {
            var teacher = _unit.Teachers.Get(id);
            return Ok(teacher);
        }

        [HttpPost("Add-Teacher")]
        public IActionResult AddTeacher([FromBody] TeacherVM teacher)
        {
            var _teacher = _unit.Teachers.AddTeacher(teacher);
            _unit.Teachers.Add(_teacher);
            _unit.Complete();
            return Ok();
        }

        [HttpDelete("Delete-Teacher-by-id/{id}")]
        public IActionResult DeleteStudentById(int id)
        {
            var teacher = _unit.Teachers.Get(id);
            if (teacher != null)
            {
                _unit.Teachers.Remove(teacher);
                _unit.Complete();
            }
            return Ok();
        }
    }
}
