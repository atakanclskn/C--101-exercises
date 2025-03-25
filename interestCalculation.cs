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
        //Compound-interest calculation with for
        static void Main(string[] args)
        {


            decimal principal = 1000; // initial amount before interest
            double rate = 0.05; // interest rate 
            // display headers 
            Console.WriteLine("Year        Amount on deposit");
            //calculate aount on deposit for each of ten years
            for (int year = 1; year <= 10; ++year)
            {
                //calculate new amount for speciied year
                decimal amount = principal * ((decimal)Math.Pow(1.0 + rate, year));
                //display the year and the amount
                Console.WriteLine($"{year,4}{amount,20:C}");
            }
            

        }
    }
}
