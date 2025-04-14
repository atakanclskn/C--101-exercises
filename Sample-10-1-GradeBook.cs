using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    // Fig 8.15 gradeBook.cs
    //Grade book using an array to store test grades
    class GradeBook
    {
        private int[] grades; // array of student grades
        
        //getter only auto-implement property CouseName
        public string CourseName { get; }
        //two-parameter constrctor initializes
        
        //auto-implemented property CourseName ad grades array
        public GradeBook(string name, int[] gradesArray)
        {
            CourseName = name; // set courseName to name
            grades = gradesArray; //initialize grades array            
        }

        //display a welcome message to the GradeBook user
        public void DisplayMessage()
        {
            //auto-impelemented property CourseName gets the name of course
            Console.WriteLine($"Welcome to the grade book for \n {CourseName}!\n");
        }

        //perform various operations on the data
        public void ProcessGrades()
        {
            //output grades array
            OutputGrades();

            // call method GetAverage to calculate the average grade
            Console.WriteLine($"\n Class average is {GetAverage():F}");

            //call methods GetMinimum and GetMaximim
            Console.WriteLine($"Lowest grade is {GetMinimum()}");
            Console.WriteLine($"Highest grade is {GetMaximum()}");

            // call OutputBaChart to display grade distrubution
            OutputBarChart();
        }

        //find minimum grade
        public int GetMinimum()
        {
            var lowGrade = grades[0]; // assume grades[0] is smallest
            // loo through grades array
            foreach (var grade in grades)
            {
                //if grade lower than lowGrade, assign it to lowGRade
                if (grade < lowGrade)
                {
                    lowGrade = grade; //new lowest grade
                }
            }
            return lowGrade; // return lowest grade 
        }

        //find maksimum grade
        public int GetMaximum()
        {
            var  highGrade = grades[0]; // assume grades[0] is largest
            // loop through grades array
            foreach (var grade in grades)
            {
                //if grade greaer than highGrade, assign it to highGrade
                if (grade > highGrade)
                {
                    highGrade = grade; //new highest grade
                }
            }
            return highGrade; // return highGrade grade

        }

        //determine average grade for test 
        public double GetAverage()
        {
            var total = 0.0; //initialize total as a double
            // sum student's grades
            foreach (var grade in grades)
            {
                total += grade;
            }
            //return average of grades 
            return total / grades.Length;
        }

        //output bar chart displaying grade distrubution
        public void OutputBarChart()
        {
            Console.WriteLine("Grade distrubtion:");
            //stores frequency of grades in each range of 10 grades
            var frequency = new int[11];

            //for each grade , increment, increment the appropriate frequency
            foreach (var grade in grades)
            {
                ++frequency[grade / 10];
            }

            // for eachgrade frequency, display bar in chart 
            for (var count = 0; count < frequency.Length; ++count)
            {
                //OutputBarChart bar label (00-09: ", ..., "90-9:  ", "100:  ")
                if (count == 10)
                {
                    Console.Write("  100: ");
                }
                else 
                {
                    Console.Write($"{count * 10:D2}-{count * 10 + 9:D2}:  ");
                }
                //display bar of asteriks 
                for (var stars = 0; stars < frequency[count]; ++stars)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); //start a new line of output
            }
        }


        //output the contents of the grades array
        public void OutputGrades()
        {
            Console.WriteLine("The grades are: \n");

            //output ech student's grade
            for (var student = 0; student < grades.Length; ++student)
            {
                Console.WriteLine($"Student {student + 1,2}: {grades[student],3} ");
            }
        }
    }
}
