﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task10.Entity
{
    public partial class Studies
    {
        public Studies()
        {
            Enrollment = new HashSet<Enrollment>();
        }

        public int IdStudy { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}
