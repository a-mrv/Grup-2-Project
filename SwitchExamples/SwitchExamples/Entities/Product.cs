using SwitchExamples.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExamples.Entities
{
   public class Product
    {
        public string Name { get; set; }
        public decimal   Price { get; set; }
        public ProductState State { get; set; } 

          
    }
}
