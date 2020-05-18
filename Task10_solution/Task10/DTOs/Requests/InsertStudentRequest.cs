using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task10.DTOs.Requests
{
    public class InsertStudentRequest
    {
        public string IndexNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public int IdEnrollment { get; set; }
    }
}
