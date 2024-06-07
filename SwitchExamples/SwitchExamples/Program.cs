

//int temprature = 20;

//if (temprature < -10)
//    Console.WriteLine("İnanılmaz soğuk bir hava var.");
//else if (temprature < 0)
//    Console.WriteLine("Çok soğuk bir hava var.");
//else if (temprature < 10)
//    Console.WriteLine("Soğuk bir hava var.");
//else if (temprature < 20)
//    Console.WriteLine("Ilık  bir hava var.");
//else if (temprature < 30)
//    Console.WriteLine("Sıcak bir hava var.");
//else  
//    Console.WriteLine("Çok sıcak bir hava var.");


//Console.WriteLine("Please enter you name:");
//string name1 = Console.ReadLine();
//switch(name1)
//{
//    case "Hakan":
//        Console.WriteLine("Geçiş izni verildi.");
//        break;
//    case "Ahmet":
//        Console.WriteLine("Kısmi izni verildi");
//        break;
//    default:
//        Console.WriteLine("Geçiş izni verilmedi.");
//        break ;
//}

//using SwitchExamples;
//using SwitchExamples.Entities;
//using SwitchExamples.Enums;
//using System.Data;

//Product product = new()
//{
//    Name = "Laptop",
//    Price = 5000,
//    State= ProductState.Discontinued,

//};

//switch (product.State)
//{
//    case ProductState.InStock:
//        Console.WriteLine("Ürün stokta.");
//        break;
//    case ProductState.OutOfStock:
//        Console.WriteLine("Ürün stokta değil.");
//        break;
//    case ProductState.Discontinued:
//        Console.WriteLine("Ürün satıştan kaldırıldı.");
//        break;
//}

List<int> temperatures = new List<int>() { -5, 0, 10, 15, 25, 35 };

foreach (var temperature in temperatures)
{
    if (temperature <-10)
        Console.WriteLine("İnanılmaz soğuk bir hava var.");
    else if (temperature < 0)
        Console.WriteLine("Çok soğuk bir hava var.");
    else if (temperature < 10)
        Console.WriteLine("Soğuk bir hava var.");
    else if (temperature < 20)
        Console.WriteLine("Ilık  bir hava var.");
    else if (temperature < 30)
        Console.WriteLine("Sıcak bir hava var.");
    else
        Console.WriteLine("Çok sıcak bir hava var.");

}
