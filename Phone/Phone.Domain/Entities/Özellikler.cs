using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone.Domain.Entities
{
 public class Özellikler
    {
        public Guid Id { get; set; }
        public string Model { get; set; }
        public string Açıklama { get; set; }
        //public string Renk { get; set; }
        public string HatSayısı {  get; set; }

    }
}
