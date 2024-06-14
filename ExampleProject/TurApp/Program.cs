
using ExampleProject.Domain.Entities;
using ExampleProject.Domain.Services;

TurService turService = new();
List<string> şehirler = new List<string>();

şehirler.Add("Ordu");
şehirler.Add("Gümüşhane");
şehirler.Add("Trabzon");
şehirler.Add("Rize");
şehirler.Add("Artvin");


Console.WriteLine("Gezilecek Şehirler");
foreach (var item in şehirler)
{
    Console.WriteLine(item);
}
List<string> katılımcılar = new List<string>();
katılımcılar.Add("Merve Aydoğan");
katılımcılar.Add("Ayşe Ay");
katılımcılar.Add("Halil Kaya");
katılımcılar.Add("Ali Kaya");
katılımcılar.Add("Elif Dal");

Console.WriteLine("Katılımcılar");
foreach (var item in katılımcılar)
{
    Console.WriteLine(item);
}

var tur = new Tur
{
    Şehirler = şehirler,
    Katılımcılar = katılımcılar,
    Tarih= DateTime.Now,
    Ücret = 100,

};

turService.Add(tur.Şehirler, tur.Katılımcılar, tur.Tarih, tur.Ücret);

List<Tur> turlar = turService.GetAll();

string kayitDosyasi = "C:\\Users\\MERVE\\Documents\\GitHub\\Grup-2-Project\\ExampleProject\\ExampleProject.Domain\\Kayit.txt";

foreach (var item in turlar)
{
    Console.WriteLine($"Şehirler: {tur.Şehirler}, Katılımcılar: {tur.Katılımcılar}, Tarih: {tur.Tarih}, Ücret: {tur.Ücret}");
}

Console.ReadLine();
        

