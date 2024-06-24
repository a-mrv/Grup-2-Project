// Abstract Class (Soyut Sınıf)

Personel müdür = new Müdür();
müdür.MaasHesapla();  // Çıktı: "Müdür maaşı hesaplandı."

Personel işçi = new İşçi();
işçi.MaasHesapla();   // Çıktı: "İşçi maaşı hesaplandı."


abstract class Personel
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int Gün { get; set; }
    public decimal Ücret { get; set; }

    public abstract void MaasHesapla()
    {
        return Gün * Ücret;
    }
}

// Concrete Class (Somut Sınıf) - Müdür
class Müdür : Personel
{
    public override void MaasHesapla()
    {
        Console.WriteLine("Müdür maaşı hesaplandı.");
       
        // Maaş hesaplama işlemleri burada yapılabilir
    }
}

// Concrete Class (Somut Sınıf) - İşçi
class İşçi : Personel
{
    public override void MaasHesapla()
    {
        Console.WriteLine("İşçi maaşı hesaplandı.");
        // Maaş hesaplama işlemleri burada yapılabilir
    }
}

