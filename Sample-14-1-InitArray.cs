using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    //Fig 8.24: InitArray.cs
    //Using command line arguments to initialize an array
    class InitArray
    {
        static void Main(string[] args)
        {
            //firstly open cmd 
            // than cd C:\Users\muhammetdamar\source\repos\ConsoleApp7\ConsoleApp7\bin\Debug>
            // than >ConsoleApp7.exe 5 0 4
            // than ConsoleApp7.exe 10 1 2 
            //check number of command line arguments
            if (args.Length != 3)
            {
                Console.WriteLine(
                    "Error: Please re-enter the entire command, incluing \n" +
                    "an array size, initial value and increment.");
            }
            else 
            {
                //get array size from first command-line argument
                var arrayLength = int.Parse(args[0]);
                var array = new int[arrayLength];//create array

                // get initial value and increment from command-line argument
                var initialValue = int.Parse(args[1]);
                var increment = int.Parse(args[2]);

                //calculate value for each array element
                for (var counter = 0; counter < array.Length; ++counter)
                {
                    array[counter] = initialValue + increment * counter; 
                }
                Console.WriteLine($"{"Index"}  {"Value",8}");
                //display array index and value
                for (int counter = 0; counter < array.Length; ++counter)
                {
                    Console.WriteLine($"{counter,5} {array[counter],8}");
                }

            }
        }
    }
}
