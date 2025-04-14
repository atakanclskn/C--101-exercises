using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    // Fig. 8.2: InitArray.cs
    class InitArray
    {
        static void Main(string[] args)
        {
            // create the space for array and initialize to defaoult zeros
            int[] array = new int[5]; // array contains 5 int elements
            Console.WriteLine($"{"Index"} {"Value",8}"); // headings
            //output each array eement's value
            for (int counter = 0; counter < array.Length; ++counter)
            {
                Console.WriteLine($"{counter,5} {array[counter],8}");
            }

        }
    }
}
