﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithNums
{
    class Calculator
    {
        //Calculator object that takes in two numbers and then adds, subtracts, multiplies, or divides

        private double num1 { get; set; }
        private double num2 { get; set; }
        private double sum { get; set; }
        private string choice { get; set; }
        private string answer { get; set; }

        public Calculator()
        {
            
        }

        public void UserInput()
        {
            Console.WriteLine("Command Prompt Calculator");

            do
            {
                //reads first number from user
                Console.Write("\nPlease enter first number: ");
                num1 = double.Parse(Console.ReadLine());   

                //reads second number from user 
                Console.Write("Please enter second number: ");
                num2 = double.Parse(Console.ReadLine());    

                //displays back numbers to users
                Console.WriteLine("\nNumbers are: {0} and {1}", num1, num2);  

                Console.WriteLine("\nEnter:\n + to Add\n - to Subtract\n * to Mulitply\n / to Divide\n");
                choice = Console.ReadLine();

                
                //switch statement which excutes based upon user's choice 
                switch (choice)
                {

                 case "+":
                 {
                    //Add
                    double sum = Add(num1, num2);
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
                    break;
                 } 
                
                case "-":
                {
                    //Substract
                    double sum = Subtract(num1, num2);
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, sum);
                    break;
                }

                case "*":
                {
                    //Multiply
                    double sum = Multiply(num1, num2);
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, sum);
                    break;
                }

                case "/":
                {
                    //Divide
                    sum = Divide(num1, num2);
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, sum);
                    break;
                }

                }

                //Ask user if they would like to solve again 
                Console.Write("Solve another experssion? [y/n]\n");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "y");

        }

        private double Add(double num1, double num2)
        {
            //add user's numbers 
            double sum = num1 + num2;
            return sum;
        }

        private double Subtract(double num1, double num2)
        {
            //subtract user's numbers
            double sum = num1 - num2;
            return sum;
        }

        private double Multiply(double num1, double num2)
        {
            //multiply user's numbers
            double sum = num1 * num2;
            return sum;
        }

        private double Divide(double num1, double num2)
        {
            //divide user's numbers 
            double sum = num1 / num2;
            return sum;
        }
    }
}
