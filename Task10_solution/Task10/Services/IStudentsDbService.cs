using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task10.DTOs;
using Task10.DTOs.Requests;
using Task10.DTOs.Responses;

namespace Task10.Services
{
    public interface IStudentsDbService
    {
        public IEnumerable<GetStudentsResponse> GetAllStudents();

        public Task<int> AddStudentAsync(InsertStudentRequest isq);
        public Task<int> AddStudiesAsync(InsertStudiesRequest isq);
        public Task<int> AddEnrollmentAsync(InsertEnrollmentRequest ieq);
        public Task<int> ModifyStudentAsync(UpdateStudentRequest usr);
        public Task<int> RemoveStudentAsync(string index);
        public Task<EnrollStudentResponse> EnrollStudentAsync(EnrollStudentRequest request);

        public Task<PromoteStudentResponse> PromoteStudentsAsync(PromoteStudentRequest promoteStudentRequest);

    }
}
