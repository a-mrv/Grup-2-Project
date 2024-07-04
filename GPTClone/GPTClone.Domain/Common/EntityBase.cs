using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPTClone.Domain.Common
{
   public class EntityBase
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; } // oluşturulma zamanı
        public string CreatedBy { get; set; } // oluşturan
    }
}
