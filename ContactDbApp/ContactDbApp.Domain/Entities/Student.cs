using ContactDbApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDbApp.Domain.Entities
{
   public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public GradeLevel Grade { get; set; }
    }
}
