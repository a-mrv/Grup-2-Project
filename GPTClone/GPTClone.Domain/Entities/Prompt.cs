using GPTClone.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPTClone.Domain.Entities
{
    public class Prompt: EntityBase
    {
       
        public string Text { get; set; } // sorduğumuz soru
        public string Response { get; set; } // aldığımız cevap
    }
}
