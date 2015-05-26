using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithNums
{
    class Calculator
    {
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
            Console.WriteLine("Command Prompt Calculator\n");

            do
            {

                Console.Write("Please enter first number: ");
                num1 = double.Parse(Console.ReadLine());

                Console.Write("Please enter second number: ");
                num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("\nNumbers are: {0} and {1}", num1, num2);

                Console.WriteLine("\nEnter:\n + to Add\n - to Subtract\n * to Mulitply\n / to Divide\n");
                choice = Console.ReadLine();



                if (choice == "+")
                {
                    double sum = Add(num1, num2);
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
                }

                if (choice == "-")
                {
                    double sum = Subtract(num1, num2);
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, sum);
                }

                if (choice == "*")
                {
                    double sum = Multiply(num1, num2);
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, sum);
                }

                if (choice == "/")
                {
                    sum = Divide(num1, num2);
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, sum);
                }
                Console.Write("Solve another experssion? [y/n]\n");
                answer = Console.ReadLine();

            } while (answer.ToUpper() == "Y");

        }

        private double Add(double num1, double num2)
        {
            double sum = num1 + num2;
            return sum;
        }

        private double Subtract(double num1, double num2)
        {
            double sum = num1 - num2;
            return sum;
        }

        private double Multiply(double num1, double num2)
        {
            double sum = num1 * num2;
            return sum;
        }

        private double Divide(double num1, double num2)
        {
            double sum = num1 / num2;
            return sum;
        }
    }
}
