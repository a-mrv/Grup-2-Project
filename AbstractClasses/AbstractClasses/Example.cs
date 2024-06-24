
Taşıt araba = new Araba();
Taşıt motosiklet = new Motosiklet();
Taşıt otobüs =new Otobüs();
araba.HareketEt();
motosiklet.HareketEt();
otobüs.HareketEt();


abstract class Taşıt
{
    public virtual void HareketEt()
    {
        Console.WriteLine("Araç Hareket Etti");
    }
}

class Araba:Taşıt
{

}

class Motosiklet:Taşıt
{
    public override void HareketEt()
    {
        Console.WriteLine("Motosiklet Hareket Etti");
    }
}
class Otobüs : Taşıt
{
    public override void HareketEt()
    {
        Console.WriteLine("Otobüs Hareket Etti");
    }

}
