using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
	//counter-controlled iteration with the while iteration statement
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;  // declare and initialize control variala
            while (counter <= 10)
            {
                Console.Write($"{counter}"); // loop-continuation variable
                ++counter; // increment control variable
            }
            Console.WriteLine(); 

        }
    }
}
