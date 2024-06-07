

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

//List<int> temperatures = new List<int>() { -5, 0, 10, 15, 25, 35 };

//foreach (var temperature in temperatures)
//{
//    if (temperature <-10)
//        Console.WriteLine("İnanılmaz soğuk bir hava var.");
//    else if (temperature < 0)
//        Console.WriteLine("Çok soğuk bir hava var.");
//    else if (temperature < 10)
//        Console.WriteLine("Soğuk bir hava var.");
//    else if (temperature < 20)
//        Console.WriteLine("Ilık  bir hava var.");
//    else if (temperature < 30)
//        Console.WriteLine("Sıcak bir hava var.");
//    else
//        Console.WriteLine("Çok sıcak bir hava var.");

//}

using SwitchExamples.Entities;
using SwitchExamples.Enums;

//List<Product> products = new()

//{

//    new Product{Name="Laptop", Price=5000, State= ProductState.InStock},
//    new Product{Name="Mouse", Price=5000, State= ProductState.InStock},
//    new Product{Name="Keyboard", Price=5000, State= ProductState.InStock},
//};

//foreach (var product in products)
//{
//    if (product.State == ProductState.InStock)
//        Console.WriteLine($"{product.Name} ürünü stokta");
//    else if (product.State == ProductState.OutOfStock)
//        Console.WriteLine($"{product.Name} ürünü stokta yok");
//}

List<Customer> customers = new()
{
    new Customer { Name="Merve",Address= "Ankara",Recorded=CustomerStatus.Yes },
    new Customer {Name= " Ayşe", Address= "İzmir",Recorded=CustomerStatus.No },
    new Customer {Name= " Mehmet", Address= "Adana",Recorded=CustomerStatus.Yes },
    new Customer {Name= " Erol", Address= "Kayseri",Recorded=CustomerStatus.No },
    new Customer {Name= " Elif", Address= "Konya",Recorded=CustomerStatus.Yes },
};

string name = Console.ReadLine();

bool isUserExist = false;
foreach (var customer in customers)
{
    if (customer.Name == name)
    {
        isUserExist = true;
        break;
    }
}

if(isUserExist)
    Console.WriteLine("Musterı zaten mevcut");

//foreach (var customer in customers)
//{
//    if (customer.Recorded == CustomerStatus.Yes)
//        Console.WriteLine($"{customer.Name} kayıtlı müşteri");
//    else if (customer.Recorded == CustomerStatus.No)
//        Console.WriteLine($"{customer.Name} kayıtlı olmayan müşteri");

//}
