using EducationInterfaces.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationInterfaces.University
{
    internal class Hacettepe : IGrandCalculator
    {

        public double Quiz1 { get; set; }
        public double Quiz2 { get; set; }
        public double Midterm1 { get; set; }
        public double Midterm2 { get; set; }
 
        public double Final { get; set; }

        public double ExamResult()
        {

            return (0.1 * (Quiz1 + Quiz2)/2) + ((Midterm1+ Midterm2)/2 * 0.3) + (Final * 0.6);
        }
    }
}
