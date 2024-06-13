using Phone.Domain.Abstractions;
using Phone.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Phone.Domain.Services
{
    public class PhoneService: IPhoneService
    {
        public void Add(Batarya batarya, Ekran ekran, Kamera kamera, Özellikler özellikler)
        {
            Guid id = Guid.NewGuid();
            string text = $"{id},{batarya},{ekran},{kamera},{özellikler}\n";
            File.AppendAllText("C:\\Users\\MERVE\\Documents\\GitHub\\Grup-2-Project\\Phone\\Phone.Domain\\Data.txt", text);
        }

        public ICollection<Telefon> GetAll()
        {
            throw new NotImplementedException();
        }

        
    }
}
