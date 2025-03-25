using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
		// Counter-controlled iteration with the for iteraion satatement
        static void Main(string[] args)
        {
            
           
            // for statement header includes initialization
			//loop-continuation condition and increment
            for (int counter = 1; counter <= 10; ++counter)
            {
                Console.Write($"{counter}");
            }
            Console.WriteLine();


        }
    }
}
