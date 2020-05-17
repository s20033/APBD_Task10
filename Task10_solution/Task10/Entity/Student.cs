using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task10.Entity
{
    public partial class Student
    {
        public string IndexNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int IdEnrollment { get; set; }
        public string Password { get; set; }
        public string Refreshtoken { get; set; }
        public string Salt { get; set; }
        public string Orijinalpass { get; set; }

        public virtual Enrollment IdEnrollmentNavigation { get; set; }
    }
}
