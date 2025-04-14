using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    // Fig. 8.8: RollDie.cs
    // Roll a six sided die 60.000.000 times
    class RollDie
    {
        static void Main(string[] args)
        {
            var randomNumbers = new Random(); //random-number genertor
            var frequency = new int[7]; //array of frequency counters

            // roll die 60.000.000 times; use die value as frequency index
            for (var roll = 1; roll <= 60000000; ++roll)
            {
                ++frequency[randomNumbers.Next(1, 7)];
            }
            Console.WriteLine($"{"Face"} {"Frequency",10}");

            // output each array element's value
            for (var face = 1; face < frequency.Length; ++face)
            {
                Console.WriteLine($"{face,4} {frequency[face],10}");
            }

              
        }
    }
}
