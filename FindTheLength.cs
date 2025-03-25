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
        // Find the length of the entered name and check if it is greater than 10 characters
        static void Main(string[] args)
        {
            string name;
            Console.Write("Enter your name:");
            name = Console.ReadLine();
            if (name.Length > 10)
            {
                Console.WriteLine("You have a long name");
            }
            else
            {
                Console.WriteLine("Your name is less than 10 characters");
            }
            // Console.ReadKey(); 
            Console.WriteLine($"Length value {name.Length}");
        }
    }
}
