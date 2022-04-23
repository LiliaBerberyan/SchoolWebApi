﻿using Microsoft.AspNetCore.Mvc;
using SchoolWebAPi.Data.Services;
using SchoolWebAPi.Data.ViewModels;
using SchoolWebAPi.RepositryInterfaces;

namespace SchoolWebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private IUnitOfWork _unit;
        public SubjectsController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet("Get-All-Subjects")]
        public IActionResult GetAllSubjects()
        {
            var allSubjects = _unit.Subjects.GetAll();
            return Ok(allSubjects);
        }

        [HttpGet("Get-Subject-By-Id/{id}")]
        public IActionResult GetSubjectById(int id)
        {
            var subject = _unit.Subjects.Get(id);
            return Ok(subject);
        }

        [HttpPost("Add-Subject")]
        public IActionResult AddSubject([FromBody] SubjectVM subject)
        {

            return Ok();
        }

        [HttpDelete("Delete-Subject-by-id/{id}")]
        public IActionResult DeleteStudentById(int id)
        {
            var subjects = _unit.Subjects.Get(id);
            _unit.Subjects.Remove(subjects);
            return Ok();
        }
    }
}
