using EnergyInterfaces.Devices;



Dishwasher dishwasher = new();
dishwasher.DevicePower = 840;
Console.WriteLine($"Çamaşır makinesi gücü:{dishwasher.DevicePower} W");
Console.WriteLine("Günlük kullanım saatinizi giriniz:");
double Time = Convert.ToDouble(Console.ReadLine());
dishwasher.Time = Time;

double dishwasherResult = dishwasher.EnergySpent();
Console.WriteLine($"Aylık harcanan enerji: {dishwasherResult} kW");

Console.WriteLine("*********************");

Refrigerator refrigerator = new();
refrigerator.DevicePower = 800;
Console.WriteLine($"Buzdolabı gücü:{refrigerator.DevicePower} W");
Console.WriteLine("Günlük kullanım saatinizi giriniz:");
double Timee = Convert.ToDouble(Console.ReadLine());
refrigerator.Timee = Timee;

double refrigeratorResult= refrigerator.EnergySpent();
Console.WriteLine($"Aylık harcanan enerji: {refrigeratorResult} kW");

Console.WriteLine("*********************");

WashingMachine washingMachine = new();
washingMachine.DevicePower = 650;
Console.WriteLine($"Çamaşır makinesi gücü: {washingMachine.DevicePower} W");
Console.WriteLine("Günlük kullanım saatini giriniz:");
double Times = Convert.ToDouble(Console.ReadLine());
washingMachine.Times = Times;

double washingMachineResult= washingMachine.EnergySpent();
Console.WriteLine($"Aylık harcanan enerji: {washingMachineResult} kW");


