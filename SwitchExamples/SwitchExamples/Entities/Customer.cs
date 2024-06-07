using SwitchExamples.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExamples.Entities
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public CustomerStatus Recorded { get; set; }
    }
}
