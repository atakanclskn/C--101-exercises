using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
		//Summing integers with for statement
        static void Main(string[] args)
        {
             
            int total = 0; // initialize total
            // total even integers from 2 to through 20
            for (int number = 2; number <= 20; number+=2)
            {
                total += number;
            }
            Console.WriteLine($"Sum is {total}"); //dispay results
            

        }
    }
}
