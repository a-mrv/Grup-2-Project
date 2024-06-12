using Productify.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productify.Domain.Abstractions
{
    public interface IProductifyService
    {
        void Add(string name, string description, decimal price, int stock);

        void Delete(string id);


        public ICollection<Product> GetAll();

    }
}
