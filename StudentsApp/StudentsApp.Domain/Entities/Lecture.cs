using StudentsApp.Domain.Common;
using StudentsApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp.Domain.Entities
{
    public class Lecture: EntityBase
    {

         
        public string Title {  get; set; }
        public LectureType Type {  get; set; }
    }
}
