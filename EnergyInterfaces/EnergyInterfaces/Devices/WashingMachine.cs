using EnergyInterfaces.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyInterfaces.Devices
{
    public class WashingMachine : IEnergyCalculation
    {
        public double DevicePower { get; set; }
        public double Times { get; set; }
        public double EnergySpent()
        {
            return (DevicePower) / 1000 * (Times * 30);
        }
    }
}
