using BankInterface.Abstraction;
using BankInterface.CommaSeperedValue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankInterface.Concrate
{
    public class VakıfBank : IGetCredit , ICSVConvertible
    {
        public decimal Miktar { get; set; }
        public decimal FaizOranı { get; set; }
        public decimal Vade {  get; set; }

        public string CSV()
        {
            return $"{Miktar},{FaizOranı},{Vade}";
        }
        

        public decimal ÖdenecekTutar()
        {
            if (Vade < 6)
                FaizOranı = FaizOranı + 4;

            else if (Vade < 12)
                FaizOranı = FaizOranı + 6;

            else if (Vade < 24)
                FaizOranı = FaizOranı + 10;

            if (Miktar < 10000)
                Vade = Vade + 1;

            else if (Miktar < 50000)
                Vade = Vade + 3;

            else if (Miktar < 100000)
                Vade = Vade + 5;

            return Miktar * FaizOranı * Vade;
        }
    }
}
