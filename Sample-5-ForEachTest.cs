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
    // Fig. 8.6: ForEachTest.cs
    // Using the foreach statement to total integersin an array
    class ForEachTest
    {
        static void Main(string[] args)
        {

            int[] array = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            int total = 0;

            // add each element's value to total
            foreach (int number in array)
            {
                total += number; // add element value to total
            }

            Console.WriteLine($"Total of array elements: {total}"); // headings

        }
    }
}
