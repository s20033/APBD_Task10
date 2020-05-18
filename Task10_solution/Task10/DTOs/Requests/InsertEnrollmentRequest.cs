using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task10.DTOs.Requests
{
    public class InsertEnrollmentRequest
    {
        public int Semester { get; set; }
        public int IdStudy { get; set; }
        public string StartDate { get; set; }
    }
}
