using BankInterface.Concrate;

VakıfBank vakıfBank = new();
vakıfBank.Miktar = 100;
vakıfBank.FaizOranı = 25m / 100;
vakıfBank.Vade = 20;

decimal vakıfBankResult = vakıfBank.ÖdenecekTutar();
Console.WriteLine($"Ana Para:{vakıfBank.Miktar}");
Console.WriteLine($"Faiz Oranı:{vakıfBank.FaizOranı}");
Console.WriteLine($"Vade:{vakıfBank.Vade}");

Console.WriteLine($"Ödemeniz Gereken Tutar:{vakıfBankResult}");
Console.WriteLine(vakıfBank.CSV());
