﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    //Fig 8.22: GradeBookTest.cs
    //Create a GradeBook object using a rectangular array of grades
    class GradeBookTest
    {
        //main method begins app execution
        static void Main()
        {
            //rectangular aray of student grades
            int[,] gradesArray = {{ 87,96,70},
                { 68,87,90},
                { 94,100,90},
                { 100, 81, 82},
                { 83, 65, 85},
                { 78, 87, 65},
                { 85,75,83},
                { 91,94,100},
                { 76,72,84},
                { 87,93,73},
                 };
            GradeBook myGradeBook = new GradeBook("CS101 Introduction to c# programming", gradesArray);
            myGradeBook.DisplayMessage();
            myGradeBook.ProcessGrades();
            
        }
    }
}
