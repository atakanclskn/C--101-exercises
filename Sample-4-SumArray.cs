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
    // Fig. 8.5: InitArray.cs
    //Computing the sum of he elements of an array
    class SumArray
    {
        static void Main(string[] args)
        {

            int[] array = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            int total = 0;

            // add each element's vale total
            for (int counter = 0; counter < array.Length; ++counter)
            {
                total += array[counter]; // add element value to total
            }

            Console.WriteLine($"Total of array elements: {total}"); // headings

        }
    }
}
