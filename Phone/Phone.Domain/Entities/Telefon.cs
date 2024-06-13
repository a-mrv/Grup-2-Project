using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone.Domain.Entities
{
    public class Telefon
    {
        public Batarya Batarya { get; set; }
        public Ekran Ekran { get; set; }
        public Kamera Kamera { get; set; }
        public Özellikler Özellikler { get; set; }

    }
}
