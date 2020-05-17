using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task10.Model
{
    public class GetStudentsResponse
    {
        public string IndexNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public int Semester { get; set; }
        public string Studies { get; set; }
    }
}
