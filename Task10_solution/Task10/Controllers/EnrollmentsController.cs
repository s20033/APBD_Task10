using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task10.DTOs.Requests;
using Task10.DTOs.Responses;
using Task10.Services;

namespace Task10.Controllers
{
    [Route("api/enrollment")]
    [ApiController]
    public class EnrollmentsController : ControllerBase
    {
        private readonly IStudentsDbService _dbService;
        public EnrollmentsController(IStudentsDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpPost]
        public async Task<IActionResult> EnrollStudentAsync(EnrollStudentRequest request)
        {
            EnrollStudentResponse enrollStudentResponse = await _dbService.EnrollStudentAsync(request);

            if (enrollStudentResponse == null)
            {
                return BadRequest();
            }

            return this.StatusCode(201, enrollStudentResponse);
        }

        [HttpPost("promotions")]
        public async Task<IActionResult> PromoteStudents(PromoteStudentRequest promoteStudentRequest)
        {
            PromoteStudentResponse promoteStudentResponse = await _dbService.PromoteStudentsAsync(promoteStudentRequest);

            if (promoteStudentResponse == null)
            {
                return NotFound();
            }

            return this.StatusCode(201, promoteStudentResponse);
        }
    }
}