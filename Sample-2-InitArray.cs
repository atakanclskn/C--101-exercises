using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    // Fig. 8.3: InitArray.cs
    //Iniializing the elements of an aray with array ith an array initializer.
    class InitArray
    {
        static void Main(string[] args)
        {
            // initializer list specifies the value of each elment
            int[] array = { 32, 27, 64, 18, 95 };
            Console.WriteLine($"{"Index"} {"Value",8}"); // headings

            //output each array eement's value
            for (int counter = 0; counter < array.Length; ++counter)
            {
                Console.WriteLine($"{counter,5} {array[counter],8}");
            }

        }
    }
}
