using Phone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone.Domain.Abstractions
{
    public interface IPhoneService
    {
        void Add(Batarya batarya, Ekran ekran, Kamera kamera, Özellikler özellikler);
         ICollection<Telefon> GetAll();

    }
}
