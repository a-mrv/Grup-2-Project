
using ExampleProject.Domain.Entities;
using ExampleProject.Domain.Services;

TurService turService = new();
List<string> şehirler = new List<string>();

şehirler.Add("Ordu");
şehirler.Add("Gümüşhane");
şehirler.Add("Trabzon");
şehirler.Add("Rize");
şehirler.Add("Artvin");

var tur = new Tur
{
    Şehirler = şehirler

};
Console.WriteLine("Gezilecek Şehirler");
foreach (var item in şehirler)
{
    Console.WriteLine(item);
}