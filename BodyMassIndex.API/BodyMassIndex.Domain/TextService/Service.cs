using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndex.Domain.TextService
{
    public class Service
    {
        public void SaveText (string line)
        {
            string filePath ="body_logs.txt";
            using (StreamWriter writer = new StreamWriter(filePath,true))
            {
                writer.WriteLine(line);
            }
        }
    }
    
        

    
}
