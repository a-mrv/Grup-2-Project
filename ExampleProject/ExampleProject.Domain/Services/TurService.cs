using ExampleProject.Domain.Abstractions;
using ExampleProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.Domain.Services
{
    public class TurService : ITurService
    {
        public void Add(List<string> şehirler, List<string> katılımcılar, DateTime tarih, double ücret)
        {
            string şehirText = "";
            foreach (var şehir in şehirler)
            {
                şehirText += $"{şehir}-";
            }

            string katılımcıText = "";
            foreach (var katılımcı in katılımcılar)
            {
                katılımcıText += $"{katılımcı}-";
            }
            string text = $"{şehirText},{katılımcıText},{tarih},{ücret}\n";
            File.AppendAllText("C:\\Users\\MERVE\\Documents\\GitHub\\Grup-2-Project\\ExampleProject\\ExampleProject.Domain\\Data.txt", text);
        }

        public List<Tur> GetAll()
        {
            string text = File.ReadAllText("C:\\Users\\MERVE\\Documents\\GitHub\\Grup-2-Project\\ExampleProject\\ExampleProject.Domain\\Data.txt");
            var turs = new List<Tur>();
            string[] lines = text.Split('\n');

            foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }
                string[] columns = line.Split(",");

                string[] şehirler = columns[0].Split('-');
                string[] katılımcılar = columns[1].Split('-');

                //string şehirlerStr = string.Join(", ", şehirler);
                //string katılımcılarStr = string.Join(", ", katılımcılar);

                Tur tur = new Tur
                {

                    Şehirler = şehirler.ToList(),
                    Katılımcılar = katılımcılar.ToList(),
                    Tarih = DateTime.Parse(columns[2]),
                    Ücret = double.Parse(columns[3]),
                };

                turs.Add(tur);

            }
            return turs;

        }
    }
}
