using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPTClone.Application.Dtos
{
   public class PromptGetAllDto
    {
        public Guid Id { get; set; }
        public string CreatedBy { get; set; }
        public string Text { get; set; }
        public string Response { get; set; }
    }
}
