﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify.Domain.ValueObjects
{
    public class Address
    {
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string No { get; set; }
        public string PostalCode { get; set; }
        public string Note { get; set; }
    }
}