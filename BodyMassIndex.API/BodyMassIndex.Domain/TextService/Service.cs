using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMass.Domain.TextService
{
    public class Service
    {
        public void WriteTextToFile(string fileName, string content)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(content);
            }
        }
    }
    
        

    
}
