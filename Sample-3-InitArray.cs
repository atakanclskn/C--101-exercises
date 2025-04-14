using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    // Fig. 8.4: InitArray.cs
    //Calculating values to be placed into the elements of an array
    class InitArray
    {
        static void Main(string[] args)
        {
             
            const int ArrayLength = 5; // create a named constant
            int[] array = new int[ArrayLength]; // create array

            //calculate value for each array element
            for (int counter = 0; counter < array.Length; ++counter)
            {
                array[counter] = 2 + 2 * counter;
            }

            Console.WriteLine($"{"Index"} {"Value",8}"); // headings

            //output each array eement's value
            for (int counter = 0; counter < array.Length; ++counter)
            {
                Console.WriteLine($"{counter,5} {array[counter],8}");
            }

        }
    }
}
