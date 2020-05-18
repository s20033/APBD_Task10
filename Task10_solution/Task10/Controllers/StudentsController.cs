using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task10.DTOs.Requests;
using Task10.Services;

namespace Task10.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentsDbService _dbService;
        public StudentsController(IStudentsDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = _dbService.GetAllStudents();

            return Ok(students);
        }

        [HttpPost]
        public async Task<IActionResult> InsertStudentAsync(InsertStudentRequest isq)
        {
            int i = 0;

            i = await _dbService.AddStudentAsync(isq);

            if(i == -1)
            {
                return BadRequest();
            }

            return Ok("Student inserted");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStudentAsync(UpdateStudentRequest usr)
        {
            int i = 0;

            i = await _dbService.ModifyStudentAsync(usr);

            if (i == -1)
            {
                return NotFound("Student with that index number does not exist");
            }

            return Ok("Student updated");
        }

        [HttpDelete("{index}")]
        public async Task<IActionResult> DeleteStudentAsync(string index)
        {
            int i = 0;

            i = await _dbService.RemoveStudentAsync(index);

            if (i == -1)
            {
                return NotFound("Student with that index number does not exist");
            }

            return Ok("Student deleted");
        }

        [HttpPost("addstudies")]
        public async Task<IActionResult> InsertStudiesAsync(InsertStudiesRequest isq)
        {
            int i = 0;

            i = await _dbService.AddStudiesAsync(isq);

            if (i == -1)
            {
                return BadRequest();
            }
            
            return Ok();
        }

        [HttpPost("addenrollment")]
        public async Task<IActionResult> InsertEnrollmentAsync(InsertEnrollmentRequest ieq)
        {
            int i = 0;

            i = await _dbService.AddEnrollmentAsync(ieq);

            if (i == -1)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}