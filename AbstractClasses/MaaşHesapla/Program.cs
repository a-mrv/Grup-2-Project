

Personel müdür = new Müdür();
müdür.Ad = "Ayşe";
müdür.Soyad = "Kaya";
müdür.Gün = 20;
müdür.MaasHesapla();  

Personel işçi = new İşçi();
işçi.Ad = "Elif";
işçi.Soyad = "Ay";
işçi.Gün = 24;
işçi.MaasHesapla();   


abstract class Personel
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int Gün { get; set; }
    public decimal Ücret { get; set; }

    public abstract void MaasHesapla();
    
        
}

class Müdür : Personel
{
    public override void MaasHesapla()
    {
        Console.WriteLine("Müdür maaşı hesaplandı.");
        decimal maaş = Gün * 1000;
        Console.WriteLine($"Müdür:{Ad} {Soyad} - Maaşı: {maaş} TL");

    }
}


class İşçi : Personel
{
    public override void MaasHesapla()
    {
        Console.WriteLine("İşçi maaşı hesaplandı.");
        decimal maaş = Gün * 500;
        Console.WriteLine($"İşçi: {Ad} {Soyad} - Maaşı: {maaş} TL");

    }
}

