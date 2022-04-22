using Microsoft.AspNetCore.Mvc;
using SchoolWebAPi.Data.Services;
using SchoolWebAPi.Data.ViewModels;

namespace SchoolWebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private SubjectsService _subjectsService;
        public SubjectsController(SubjectsService subjectsService)
        {
            _subjectsService = subjectsService;
        }

        [HttpGet("Get-All-Subjects")]
        public IActionResult GetAllSubjects()
        {
            var allSubjects = _subjectsService.GetAllSubjects();
            return Ok(allSubjects);
        }

        [HttpGet("Get-Subject-By-Id/{id}")]
        public IActionResult GetSubjectById(int id)
        {
            var subjects = _subjectsService.GetSubjectById(id);
            return Ok(subjects);
        }

        [HttpPost("Add-Subject")]
        public IActionResult AddSubject([FromBody] SubjectVM subject)
        {
            _subjectsService.AddSubject(subject);
            return Ok();
        }

        [HttpDelete("Delete-Subject-by-id/{id}")]
        public IActionResult DeleteStudentById(int id)
        {
            _subjectsService.DeleteSubjectById(id);
            return Ok();
        }
    }
}
