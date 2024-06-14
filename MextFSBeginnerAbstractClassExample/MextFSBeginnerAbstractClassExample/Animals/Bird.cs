using MextFSBeginnerAbstractClassExample.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MextFSBeginnerAbstractClassExample.Animals
{
    public class Bird : AnimalBase
    {
        public override string Name { get; set; } = "Tweety";
        public override int LegCount { get; set; } = 2;
        public override string Sound { get; set; } = "Tweety";

        public override void MakeSound()
        {
            string[] birdArt = new string[]
            {
            "  \\",
            "   \\",
            "    \\",
            "     \\",
            "      \\    /\\",
            "       )  ( ')",
            "      (  /  )",
            "       \\(__)|"
            };

            var birdArtText = string.Join("\n", birdArt);

            Console.WriteLine($"{birdArtText}\n\n{Sound}");
        }
    }
}
