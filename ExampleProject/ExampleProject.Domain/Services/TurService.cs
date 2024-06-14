using ExampleProject.Domain.Abstractions;
using ExampleProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.Domain.Services
{
    public class TurService : ITurService
    {
        public void Add(List<string> şehirler, List<string> katılımcılar, DateTime tarih, double ücret)
        {
            string text = $"{şehirler},{katılımcılar},{tarih},{ücret}\n";
            File.AppendAllText("C:\\Users\\MERVE\\Documents\\GitHub\\Grup-2-Project\\ExampleProject\\ExampleProject.Domain\\Data.txt",text);
        }

        public List<Tur> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
