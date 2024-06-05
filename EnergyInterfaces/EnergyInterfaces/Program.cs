using EnergyInterfaces.Devices;



Dishwasher dishwasher = new();
dishwasher.DevicePower = 840;
Console.WriteLine($"Bulaşık makinesi gücü:{dishwasher.DevicePower} W");
Console.WriteLine("Günlük kullanım saatinizi giriniz:");
double Time = Convert.ToDouble(Console.ReadLine());
dishwasher.Time = Time;
dishwasher.Price = 1.47;

double dishwasherResult = dishwasher.EnergySpent();
Console.WriteLine($"Aylık harcanan enerji: {dishwasherResult} kW");
double dishwasherPResult = dishwasher.EnergyPrice();
Console.WriteLine($"Aylık tutar:{dishwasherPResult} TL");

Console.WriteLine("*********************");

Refrigerator refrigerator = new();
refrigerator.DevicePower = 800;
Console.WriteLine($"Buzdolabı gücü:{refrigerator.DevicePower} W");
Console.WriteLine("Günlük kullanım saatinizi giriniz:");
Time = Convert.ToDouble(Console.ReadLine());
refrigerator.Time = Time;
refrigerator.Price = 1.47;

double refrigeratorResult= refrigerator.EnergySpent();
Console.WriteLine($"Aylık harcanan enerji: {refrigeratorResult} kW");
double refrigeratorPResult = refrigerator.EnergyPrice();
Console.WriteLine($"Aylık tutar:{refrigeratorPResult} TL");

Console.WriteLine("*********************");

WashingMachine washingMachine = new();
washingMachine.DevicePower = 650;
Console.WriteLine($"Çamaşır makinesi gücü: {washingMachine.DevicePower} W");
Console.WriteLine("Günlük kullanım saatini giriniz:");
Time = Convert.ToDouble(Console.ReadLine());
washingMachine.Time = Time;
washingMachine.Price = 1.47;

double washingMachineResult= washingMachine.EnergySpent();
Console.WriteLine($"Aylık harcanan enerji: {washingMachineResult} kW");
double washingMachinePResult= washingMachine.EnergyPrice();
Console.WriteLine($"Aylık tutar:{washingMachinePResult} TL");



