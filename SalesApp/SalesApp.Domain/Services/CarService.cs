using SalesApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.Domain.Services
{
    public class CarService
    {
        private static List<Car> cars = new();

        public void Add(Car car)
        {
            cars.Add(car);
        }
        public void PrintConsole() 
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"Markası : {car.Make}, Modeli : {car.Model}");
            }
            
        }

        public List<Car> GetAll()
        {
            return cars;
        }
        public void Remove(Guid Id)
        {
          foreach (var car in cars)
            {
                if (car.Id == Id)
                {
                    cars.Remove(car);
                    break;
                }

            }
            
        }
        public void UpDate(Guid Id,string Model)
        {  
            foreach (var car in cars)
            {
                if (car.Id == Id)
                {
                    car.Make= Model;
                    break;
                }
            }
        }

    }
    
}
