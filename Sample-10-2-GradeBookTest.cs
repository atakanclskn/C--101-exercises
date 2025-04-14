using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    //Fig 8.16. GRadeBookTest.cs
    //Create a GradeBook object using an array of grades.
    class GradeBookTest
    {

        // main method begins app execution
        static void Main()
        {
            // one-dimensiona array of studen grades 
            int[] gradesArray = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            var myGradeBook = new GradeBook("CS101 Intoduction to C# Programming", gradesArray);
            myGradeBook.DisplayMessage();
            myGradeBook.ProcessGrades();
        }
    }
}
