﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        //break statement exiting a for statement
        static void Main(string[] args)
        {
            int count; // control variable also used after loop terminates
            for (count = 1; count <= 10; ++count) // loop 10 times
            {
                if (count == 5) // if count is 5 skip
                {
                    continue; // skip remaning code in the loop
                }
                Console.Write($"{count} ");
            }
            Console.WriteLine($"\nBroke out of loop at count ={count}");

        }
    }
}
