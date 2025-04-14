using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    // Fig 8.25: ArrayReferenceTest.cs
    // Testing the effects of passing arrat of references
    // by value and by reference.
    class ArrayReferenceTest
    {
        static void Main(string[] args)
        {
            //create and initalize firstArray
            int[] firstArray = { 1, 2, 3 };
            //copy the reference in variable firstArray
            int[] firstArrayCopy=firstArray;
            Console.WriteLine("Test passing firstArray reference by value");
            Console.WriteLine("Contents of firstArray before calling FirstDouble:\n\t");

            //display contents of first array
            foreach (var element in firstArray)
            {
                Console.Write($"{element} ");
            }

            //pass variable firstArray by value to firstDouble
            FirstDouble(firstArray);  
            Console.Write($"\nContents of firstArray after calling FirstDouble \n\t");
            //display contents of firstArray
            foreach (var element in firstArray)
            {
                Console.Write($"{element} ");
            }
            // test whether reference was changed by FirstDouble
            if (firstArray == firstArrayCopy)
            {
                Console.WriteLine("\n\nThe referneces refer tı the same array");
            }
            else 
            {
                Console.WriteLine("\n\n The references refer to different arrays");
            }
            // create and initalize secondArray
            int[] secondArray = { 1,2,3};

            //copy the references in variable secondArray
            int[] secondArrayCopy = secondArray;
            Console.WriteLine("\n Test passing secondArray reference by reference");
            Console.WriteLine("Contents of secondArray before callig SecondDouble:\n\t");

            // display contents of secondArray before method call
            foreach (var element in secondArray)
            {
                Console.Write($"{element} ");
            }

            // pass variable secondArray by reference to SecondDouble
            SecondDouble(ref secondArray);
            Console.Write("\nContents of secondArray afrer calling SecondDouble:\n\t");

            //display contents o secondArray after method call
            foreach (var element in secondArray)
            {
                Console.Write($"{element} ");
            }
            // test whether references was changed by SeondDouble
            if (secondArray == secondArrayCopy)
            {
                Console.WriteLine("\n\n The references refer to the same array");
            } else 
            {
                Console.WriteLine("\n\nThereferences refer to different arrays");
            }

            
        }

        //modify elements of array and attempt to modify reference
        static void FirstDouble(int[] array)
        {
            // double each element's value
            for (var i = 0; i < array.Length; ++i)
            {
                array[i] *= 2;                
            }
            //create new object and assign it referece to array
            array = new int[] { 11,12,13}; 
        }

        //modify elements of array ad change refeence array
        //to refer to a new array
        static void SecondDouble(ref int[] array)
        {
            //double each element's value
            for (var i = 0; i < array.Length; ++i)
            {
                array[i] *= 2;
            }
            //create new object and assign its reference to array
            array = new int[] { 11, 12, 13 };
        }
    
    }
}
