using System;
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
        //Using a switch statement to count letter grades
        static void Main(string[] args)
        {
            int total = 0;
            int gradeCounter = 0;
            int aCount =0 ; //Count of A grades 
            int bCount = 0; //Count of B grades 
            int cCount = 0; //Count of C grades 
            int dCount = 0; //Count of D grades 
            int fCount = 0; //Count of F grades  

            Console.WriteLine("Enter the integer grades in the rnge 0-100.");
            Console.WriteLine("Type <Ctrl> z and press Enter to terminate input:");
            string input = Console.ReadLine(); // read user input

            // loop until user enters th end of file idicator (<ctrl> z)

            while (input != null)
            {
                int grade = int.Parse(input); // read grade off user input
                total += grade; //add grade to total
                ++gradeCounter; //increment number of grades
                //determine which grade was entered
                switch (grade / 10)
                {
                   
                    case 10: // grade was 100
                        ++aCount; //Increment  aCount
                        break;//exit switch
                    case 9:// grade was in the 90s
                        ++aCount; //Increment  aCount
                        break;//exit switch
                    case 8://grade was between 80 and 89
                        ++bCount; //Increment  bCount
                        break;//exit switch
                    case 7://grade was between 70 and 79
                        ++cCount; //Increment cCount
                        break;//exit switch
                    case 6://grade was between 60 and 69
                        ++dCount; //Increment dCount
                        break;//exit switch
                    default:// grades ess than 60 
                        ++fCount; //Increment  fCount
                        break;//exit switch 
                }
                input = Console.ReadLine();//read user input 

            }
            Console.WriteLine("\n Grade Report");
            // if user entered at least one grade...
            if (gradeCounter != 0)
            {
                //calculate aerage of all grades entered
                double average = (double)total / gradeCounter;
                //output summary of results
                Console.WriteLine($"Total of the {gradeCounter} grade entered is {total}");
                Console.WriteLine($"Class averge is {average:F}");
                Console.WriteLine("Number of stundets who received each grade");
                Console.WriteLine($"A: {aCount}"); //display number of A grades
                Console.WriteLine($"B: {bCount}"); //display number of B grades
                Console.WriteLine($"C: {cCount}"); //display number of C grades
                Console.WriteLine($"D: {dCount}"); //display number of D grades
                Console.WriteLine($"F: {fCount}"); //display number of F grades
            }
            else // no grades were entered , so ouput appropriate message
            {
                Console.WriteLine("No grades were entered");
                
            }

        }
    }
}
