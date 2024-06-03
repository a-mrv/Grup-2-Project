using EducationInterfaces.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationInterfaces.University
{
  public class Ankara : IGrandCalculator
    {
        
        public double Midterm1 { get; set; }
        public double Midterm2 { get; set; }
        public double Final { get; set; }

        public double ExamResult()
        {
          
            return 0.4 * ((Midterm1 + Midterm2))/2 + (Final * 0.6);
        }
    }
}
