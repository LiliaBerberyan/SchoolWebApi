using Microsoft.AspNetCore.Mvc;
using SchoolWebAPi.Data.Services;
using SchoolWebAPi.Data.ViewModels;

namespace SchoolWebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private TeachersService _teachersService;
        public TeachersController(TeachersService teachersService)
        {
            _teachersService = teachersService;
        }

        [HttpGet("Get-All-Teachers")]
        public IActionResult GetAllTeachers()
        {
            var allTeachers = _teachersService.GetAllTeachers();
            return Ok(allTeachers);
        }

        [HttpGet("Get-Teacher-By-Id/{id}")]
        public IActionResult GetTeacherById(int id)
        {
            var teachers = _teachersService.GetTeacherById(id);
            return Ok(teachers);
        }

        [HttpPost("Add-Teacher")]
        public IActionResult AddTeacher([FromBody] TeacherVM teacher)
        {
            _teachersService.AddTeacher(teacher);
            return Ok();
        }

        [HttpDelete("Delete-Teacher-by-id/{id}")]
        public IActionResult DeleteStudentById(int id)
        {
            _teachersService.DeleteTeacherById(id);
            return Ok();
        }
    }
}
