using EnergyInterfaces.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyInterfaces.Devices
{
    public class Refrigerator : IEnergyCalculation
    {
        public double DevicePower { get; set; }
        public double Timee { get; set; }
        public double EnergySpent()
        {
            return (DevicePower) / 1000 * (Timee * 30);
        }
    }
}
