using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Services
    {
        public  string filePath;

        public Services(string filePath)
        {
            this.filePath = filePath;
        }

        public void Add(string note)
        {
            File.AppendAllText(filePath, note + "\n");
        }

        public IEnumerable<string> GetAll()
        {
            return File.ReadAllLines(filePath);
        }
    }
}
       
   
    

