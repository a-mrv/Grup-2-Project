using ExampleProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.Domain.Abstractions
{
   public interface ITurService
    {

        void Add(List<string> şehirler, List<string>katılımcılar, DateTime tarih, double ücret);

        List<Tur> GetAll();
    }
}
