﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    //Fig 8.13: PassArray.cs
    // Passing arrays and individual array elements to methods.
    class PassArray
    {
        // Main creates array and calls ModifyArray and ModifyElement
        static void Main()
        {
            int [] array= { 1, 2, 3, 4, 5 };
            Console.WriteLine("Effect of passing reference to entire array:");
            Console.WriteLine("The values of the original array array:");

            //output original array elements
            foreach (var value in array)
            {
                Console.Write($"    {value}");
            }
            ModifyArray(array); // pass array reference
            Console.WriteLine("\n\n The values of the modified array are");

            //output modified array elements
            foreach (var value in array)
            {
                Console.Write($"    {value}");
            }
            Console.WriteLine("\n\n Effects of passing aray element value:\n" + $"array[3] before ModifyElement: {array[3]}");
            ModifyElement(array[3]); //attempt to modify array[3]
            Console.WriteLine($"array[3] after ModifyElement: {array[3]}");
             
        }

        /////////////// functions
        //multiply each element of an array by 2
        static void ModifyArray(int[] array2)
        {
            for (var counter = 0; counter < array2.Length; ++counter)
            {
                array2[counter] *= 2;
            }
        }
        //multiply argument by 2
        static void ModifyElement(int element)
        {
            element *= 2;
            Console.WriteLine($"Value of element in ModifyElement: {element}");
        }
    }
}
