using Eventify.Domain.Common;
using Eventify.Domain.Enums;
using Eventify.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify.Domain.Entities
{
    public class Event:EntityBase
    {

        
        public string Title {  get; set; }
        public string Description { get; set; }
        public DateTimeOffset Date { get; set; }
        public Address Location {  get; set; }
        public EventType Type {  get; set; }
    }
}
