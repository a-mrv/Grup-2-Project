﻿using MextFSBeginnerAbstractClassExample.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MextFSBeginnerAbstractClassExample.Animals
{
    public class Dog : AnimalBase
    {
        public override string Name { get; set; } = "Boss";

        public override string Sound { get; set; } = "Hav Hav";

        public override void MakeSound()
        {
            string[] dogArt = new string[]
            {
             "  / \\__",
             " (    @\\___",
             " /         O",
             "/   (_____/",
             "/_____/   U",
             "       | |"
            };

            var dogArtText = string.Join("\n", dogArt);

            Console.WriteLine($"{dogArtText}\n\n{Sound}");
        }
    }
}
