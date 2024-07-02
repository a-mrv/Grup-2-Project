using Eventify.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify.Domain.Entities
{
    internal class Person: EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
