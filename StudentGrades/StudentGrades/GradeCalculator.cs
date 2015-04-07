using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace StudentGrades

    // A Grade Calculator which allows the user to see the class average, student with the highest score, and list all students 
{
    class GradeCalculator
    {
        private double highestGrade;
        private string highestGradeName;
        private double average;
        private int numOfStudents;
        private string[] names = new string[1000];
        private double[] grades = new double[1000];
      

        #region User Input
        public void CalculateGrades()  //function which calls all methods needed in order to run the application 
        {
            StudentCount();
            UserInput();
            ClassAverage();
            HighestGrade();
            Results();
        }

        private void StudentCount()  //Asks User to enter in the number of students
        {

            while (numOfStudents < 1 || numOfStudents > 1000)
            {

                Console.WriteLine("How many students are in your class (1-1000)");
                string responce = Console.ReadLine();

                bool res = int.TryParse(responce, out numOfStudents);
                if (res == false)
                {
                    Console.WriteLine("\n*This is an invalid input*\nPlease enter a number between 1-1000\n");
                }
            }

        }
           
        private void UserInput()  //Asks User to enter in names and grades
        {

            for (int i = 0; i < numOfStudents; i++)   
            {
                Console.WriteLine("Please enter Student {0}'s name", i + 1);
                names[i] = Console.ReadLine();
                Console.WriteLine("Please enter {0}'s grade", names[i]);
                grades[i] = double.Parse(Console.ReadLine());
            }
        }

        #endregion 

        private void WriteNames()  //Displays Names and Grades to console
        {
            Console.WriteLine("\n*** Class Roster ***");
            for (int i = 0; i < numOfStudents; i++)   
            {
                Console.Write("Name: {0} ", names[i]);
                Console.Write(" Grade: {0}% ", grades[i]);
                Console.WriteLine();
            }
        }

        private void ClassAverage()  //Calculates the class average 
        {
            for (int i = 0; i < numOfStudents; i++)  
            {
                average += grades[i];
            }

            average /= numOfStudents;  
        }

        private void HighestGrade()  //Calculates what is the highest grade in the class and which student it belongs to 
        {
            for (int i = 0; i < numOfStudents; i++) 
            {
                if (grades[i] > highestGrade)
                {
                    highestGrade = grades[i];
                    highestGradeName = names[i];
                }
            }

            Console.WriteLine("\nCalculating Results");
            Thread.Sleep(3000);
        }

        public void Sort()
        {
            for (int i = 0; i < numOfStudents; i++)
            {
                double x = grades[i];
                int j = i;


                while (j > 0 && grades[j - 1].CompareTo(x) > 0)
                {
                    grades[j] = grades[j - 1];
                    j = j - 1;
                }
                grades[j] = x;
              
            }
        }

        private void Results() //Displays who has the highest grade, what the highest grade is, and the class average 
        {
            WriteNames();
            Console.WriteLine("\n{0} has the highest grade which is a {1}%", highestGradeName, highestGrade);
            Console.WriteLine("The class average is {0}%", average);
            Console.WriteLine("\nType quit to exit application \nor press enter to calculate a new roster");
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
