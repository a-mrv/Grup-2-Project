﻿using Eventify.Domain.Enums;
using Eventify.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify.Application.Dtos
{
    public class EventAddDto
    {
        public string Title {  get; set; }
        public string Description { get; set; }
        public DateTimeOffset Date { get; set; }
        public Address Location { get; set; }
        public EventType Type { get; set; }

    }
}
