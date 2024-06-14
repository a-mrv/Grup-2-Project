using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.Domain.Entities
{
   public class Tur
    {

        public List<string> Şehirler { get; set; }
        public List<string> Katılımcılar { get; set; }
        public DateTime Tarih { get; set; }

        public double Ücret {  get; set; }
       
      
    }
}
