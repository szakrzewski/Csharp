using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades

    // A Grade Calculator which allows the user to see the class average, student with the highest score, and list all students 
{
    class GradeCalculator
    {
        private double highestGrade;
        private string highestGradeName;
        private double average;
        private int numOfStudents;
        private string[] names = new string[100];
        private double[] grades = new double[100];

        public void CalculateGrades()  //function which calls all methods needed in order to run the application 
        {
            StudentCount();
            UserInput();
            ClassAverage();
            HighestGrade();
            Results();
        }

        public int StudentCount()  //Asks User to enter in the number of students
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome to Grade Calculator by Simon");

            while (numOfStudents == 0 || numOfStudents > 100)
            {
                Console.WriteLine("How many students are in your class");
                numOfStudents = int.Parse(Console.ReadLine());
                
                if (numOfStudents < 1 || numOfStudents > 100)
                {
                    Console.WriteLine("Invalid Entry");
                    continue;
           
                }

            }
            return numOfStudents; 

        }
      
        public void UserInput()  //Asks User to enter in names and grades
        {
            for (int i = 0; i < numOfStudents; i++)   
            {
                Console.WriteLine("Please enter Student {0}'s name", i + 1);
                names[i] = Console.ReadLine();
                Console.WriteLine("Please enter {0}'s grade", names[i]);
                grades[i] = double.Parse(Console.ReadLine());
            }
        }

        public void WriteNames()  //Displays Names and Grades to console
        {
            Console.WriteLine("");
            Console.WriteLine("*** Class Roster ***");
            for (int i = 0; i < numOfStudents; i++)   
            {
                Console.Write("Name: {0} ", names[i]);
                Console.Write(" Grade: {0} ", grades[i]);
                Console.WriteLine();
            }
        }

        public void ClassAverage()  //Calculates the class average 
        {
            for (int i = 0; i < numOfStudents; i++)  
            {
                average += grades[i];
            }

            average /= numOfStudents;  
        }

        public void HighestGrade()  //Calculates what is the highest grade in the class and which student it belongs to 
        {
            for (int i = 0; i < numOfStudents; i++) 
            {
                if (grades[i] > highestGrade)
                {
                    highestGrade = grades[i];
                    highestGradeName = names[i];
                }
            }
        }

        public void Results() //Displays who has the highest grade, what the highest grade is, and the class average 
        {
            WriteNames();
            Console.WriteLine();
            Console.WriteLine("{0} has the highest grade which is a {1}", highestGradeName, highestGrade);
            Console.WriteLine("The class average is {0}", average);

            Console.WriteLine("Type quit to exit application \nor any key to calculate a new roster");
            string responce = Console.ReadLine();

            if (responce == "quit")
            {
                Environment.Exit(0);
            }

            else
            {
                CalculateGrades();
            }
        }

    }

}
