using EnergyInterfaces.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyInterfaces.Devices
{
    public class WashingMachine : IEnergyCalculation
    {
        public double DevicePower { get; set; }
        public double Time { get; set; }
        public double Price {  get; set; }
        public double EnergySpent()
        {
            return (DevicePower) / 1000 * (Time * 30);
        }
        public double EnergyPrice()
        {
            return EnergySpent() * Price;
        }
    }
}
