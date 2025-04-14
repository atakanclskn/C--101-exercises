using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    // Fig 8.19: InitArray.cs
    // Initializing regular and jagged arays
    class InitArray
    {
        // create and output rectangular and jagged arrays
        static void Main(string[] args)
        {
            //with rectagular arrays,
            //every row must be the same length
            int[,] rectangular = { { 1, 2, 3 }, { 4, 5, 6 } };
            //with jagged arrays,
            //we need to use "new int[]" for every row
            //But every row does not neet to be the same length
            int[][] jagged = { new int  []{1,2}, new int[] { 3},
                               new int [] { 4,5,6}};
            OutputArray(rectangular); //displays array rectangular by row
            Console.WriteLine(); //output a blank line
            OutputArray(jagged);//displays array jagged by row 
            
        }

        // output rows and columns of a rectangular array
        static void OutputArray(int[,] array)
        {
            Console.WriteLine("Values in the rectangular aray by row are");
            //loop through aray's row
            for (var row = 0; row < array.GetLength(0); ++row)
            {
                // loop through columns of current row
                for (var column = 0; column < array.GetLength(1); ++column)
                {
                    Console.Write($"{array[row, column]}");
                }
                Console.WriteLine(); // start new line of output
            }
        }

        //output rows and columns of a jagged array
        static void OutputArray(int[][] array)
        {
            Console.WriteLine("Values in the rectangular aray by row are");
            //loop through each row
            foreach (var row in array)
            {
                // loop through each element in current row
                foreach (var element in row)
                {
                    Console.Write($"{element}");
                }
                Console.WriteLine(); // start new line of output
            }
        }
    }
}
