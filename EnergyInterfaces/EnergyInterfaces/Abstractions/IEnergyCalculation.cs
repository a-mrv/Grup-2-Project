﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyInterfaces.Abstractions
{
    public interface IEnergyCalculation
    {
        double EnergySpent();
        double EnergyPrice();

         
    }
}
