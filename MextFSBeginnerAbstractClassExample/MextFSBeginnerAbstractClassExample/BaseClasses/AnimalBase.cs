using MextFSBeginnerAbstractClassExample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MextFSBeginnerAbstractClassExample.BaseClasses
{
    public abstract class AnimalBase
    {
        public virtual string Name { get; set; }
        public virtual string Sound { get; set; }
        public virtual int LegCount { get; set; } = 4;
        public virtual bool IsPet { get; set; }
        public virtual AnimalGender Gender { get; set; }
        public string GetFancyName()
        {
            // Ternary Operator
            return Gender == AnimalGender.Male ? $"Mr.{Name}" : $"Mrs.{Name}";

        }
        public abstract void MakeSound();


    }
}
