using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

//@atakanclskn

namespace ConsoleApp5
{
    class Program
    {
        //do-while iteration statement
        static void Main(string[] args)
        {

            int counter = 1; // initialize counter
            do
            {
                Console.Write($"{counter}    ");
                ++counter;
            } while (counter <=10); // required semicolor

        }
    }
}
