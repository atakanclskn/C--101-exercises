using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//@atakanclskn

namespace ConsoleApp5
{
    class Program
    {
        // ( Determine if the number is odd or even )
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
            Console.ReadKey();
        }
    }
}
