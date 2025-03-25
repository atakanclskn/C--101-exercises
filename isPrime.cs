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
        // Program to determine if the entered number is prime
        static void Main(string[] args)
        {
            int control = 0;
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    control++;
            }

            if (control != 0)
                Console.WriteLine("The number you entered is not prime.");
            else
                Console.WriteLine("The number you entered is prime.");
            Console.ReadKey();
        }
    }
}
