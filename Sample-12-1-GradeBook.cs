using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    // Fig 8.21: GradeBook.cs
    // Grade book using a rectangular array to store grades.
    class GradeBook
    {
        private int[,] grades; //  rectangular array of student grades

        // auto-implemented property CourseName
        public string CourseName { get; }

        // two-parameter constructor initializes
        // auto-implemented propery CourseName and grades array

        public GradeBook(string name, int[,] gradesArray)
        {
            CourseName = name; //set CourseName to name
            grades = gradesArray; // initializes grades array
        }
        //display a welcome message to the GradeBook user
        public void DisplayMessage()
        {
            //auto-impelemented property CourseName gets the name of course
            Console.WriteLine($"Welcome to the grade book for \n {CourseName}!");

        }
        //perform various operations on the data
        public void ProcessGrades()
        {
            //output grades array
            OutputGrades();
            //call methods GetMinimum and GetMaximum
            Console.WriteLine($"\n Lowest grade in the grade book is {GetMinimum()}"+
                $"\n Highest grade in the gradebook is {GetMaximum()}\n");
            //Output grade distrubution chart of all grades on al tests
            OutputBarChart();
        }

        //find minimum grade 
        public int GetMinimum()
        {
            //assume first eement of grades array is sallest 
            var lowGrade = grades[0, 0];
            //loop through elements of rectanular grades array
            foreach (var grade in grades)
            {
                // if grade less than lowGrade , assign it to lowGrade
                if (grade < lowGrade)
                {
                    lowGrade = grade;
                }
            }
            return lowGrade; // return lowest grade

        }
        //find maximum grade
        public int GetMaximum()
        {
            //assume first element of grades array is largest
            var highGrade = grades[0, 0];

            // loop through elements of rectangular grades array
            foreach (var grade in grades)
            {
                // if grade greater than highGrade, assign it to highGrade
                if (grade > highGrade)
                {
                    highGrade = grade;
                }
            }
            return highGrade; // return highest grade
        }

        // determine average grade for particular student
        public double GetAverage(int student)
        {
            //get the number of grades per student
            var gradeCount = grades.GetLength(1);
            var total = 0.0; //initialize total

            // sum grades for one student
            for (var exam = 0; exam < gradeCount; ++exam)
            {
                total += grades[student, exam];
            }
            //return average of grades
            return total / gradeCount;
        }

        public void OutputBarChart()
        {
            Console.WriteLine("Overalll grade distrubution");

            //stores frequency of grades in each range of 10 grades
            var frequency = new int[11];
            //for each grade in GradeBook, inrement the appropriate frequency
            foreach (var grade in grades)
            {
                ++frequency[grade / 10];
            }

            //for each grade frequency, display bar in chart
            for (var count = 0; count < frequency.Length; ++count)
            {
                //output bar label ("00-09:  ", ...."90-99:  ", "100: ")
                if (count == 10)
                {
                    Console.Write("  100: ");
                }
                else 
                {
                    Console.Write($"{count * 10:D2}-{count * 10 + 9:D2}: ");
                }

                //display bar of asteriks
                for (var stars = 0; stars < frequency[count]; ++stars)
                {
                    Console.Write("*");
                }
                Console.WriteLine();//start a new line of output
            }
        }

        //output the contents of he grades array
        public void OutputGrades()
        {
            Console.WriteLine("The grades are: \n");
            Console.Write("             "); //align column heads

            //for average
            double averageStudent = 0.0;


            //create a column heading for each of the tests
            for (var test = 0; test < grades.GetLength(1); ++test)
            {
                Console.Write($"Test {test + 1}    ");

            }
            Console.WriteLine("Average");//student average column heading

            //create rows/columns of text representing aray grades
            for (var student = 0; student < grades.GetLength(0); ++student)
            {
                Console.Write($" Student {student + 1,2} ");
                //Output student's grades
                averageStudent = 0.0;
                for (var grade = 0; grade < grades.GetLength(1); ++grade)
                {
                    Console.Write($" {grades[student, grade],8}");
                    //averageStudent += grades[student, grade]; ;// added by Mdamar 
                }
                // Console.Write($"    {averageStudent/3,8}");// added by Mdamar 

                //call method GetAverage to calculate student's average grade;
                //pass row number as the argument to GetAverage
                Console.WriteLine($"{GetAverage(student),9:F}");
            }
        }
    }
}
