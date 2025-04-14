using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    // Fig. 8.7: BarChart.cs
    // Bar chart displying app.
    class ForEachTest
    {
        static void Main(string[] args)
        {

            int[] array = { 0, 0,0, 0, 0 , 0, 1, 2, 4, 2, 1 };// distrubution
            Console.WriteLine("Grade distrubution"); //  

            // for each array element, output a bar of the chart
            for (var counter = 0; counter < array.Length; ++counter)
            {
                //output bar lebels ("00-09: ", ..."90-99: ", "100: ")
                if (counter == 10)
                {
                    Console.Write(" 100: ");
                }
                else
                {
                    Console.Write($"{counter * 10:D2} - {counter * 10 + 9:D2}: ");
                }
                //display bar of asteriks 
                for (var stars = 0; stars < array[counter]; ++stars)
                {
                    Console.Write("*");
                }
                Console.WriteLine();//start a new line of output
            }

             

        }
    }
}
