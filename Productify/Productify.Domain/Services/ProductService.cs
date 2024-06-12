using Productify.Domain.Abstractions;
using Productify.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Productify.Domain.Services
{
    public class ProductService : IProductifyService
    {
        public void Add(string name, string description, decimal price, int stock)
        {
           Guid id= Guid.NewGuid();
            string text=$"{id},{name},{description},{price},{stock}\n";
            File.AppendAllText("C:\\Users\\MERVE\\Documents\\GitHub\\Grup-2-Project\\Productify\\Productify.Domain\\Data.txt", text);
      
        }

        public void Delete(string id)
        {
           string text=File.ReadAllText("C:\\Users\\MERVE\\Documents\\GitHub\\Grup-2-Project\\Productify\\Productify.Domain\\Data.txt");
           string[] lines = text.Split("\n");

           string newData = "";
            foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }

                string[] columns = line.Split(",");

                if (columns[0] == id)
                {
                    continue;
                }

                newData += line + "\n";
            }
            File.WriteAllText("C:\\Users\\MERVE\\Documents\\GitHub\\Grup-2-Project\\Productify\\Productify.Domain\\Data.txt",newData);

        }

        public ICollection<Product> GetAll()
        { 
           string text = File.ReadAllText("C:\\Users\\MERVE\\Documents\\GitHub\\Grup-2-Project\\Productify\\Productify.Domain\\Data.txt");
            string[] lines =text.Split('\n');
            List<Product> products = new();
           foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }
                string[] columns = line.Split(",");

                Product product = new()
                {
                    Id = Guid.Parse(columns[0]),
                    Name = columns[1],
                    Description= columns[2],
                    Price = decimal.Parse(columns[3]),
                    Stock = int.Parse(columns[4]),
                };
            products.Add(product);

            }
            return products;

        }

        
    }
}
