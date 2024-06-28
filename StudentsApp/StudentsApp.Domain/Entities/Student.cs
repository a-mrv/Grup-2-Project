using StudentsApp.Domain.Common;
using StudentsApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp.Domain.Entities
{
    public class Student: EntityBase
    {
     
        public string Name { get; set; }
        public GradeLevel Grade { get; set; }

    }
}
