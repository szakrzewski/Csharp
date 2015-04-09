using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

namespace ProjectEuler6
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double sumTotal = 0;
            double sumSquared = 0;

            for (int i = 1; i < 101; i++)
            {
                double x = i * i;
                sum += x;
                sumTotal += i;
                sumSquared = sumTotal * sumTotal;

            }

            Console.WriteLine("The sum of the squares of the first 100 numbers is {0}", sum);
            Console.WriteLine("The square of the sum of the first 100 numbers is {0}", sumSquared);
            Console.WriteLine("The difference between the two is {0}", sumSquared - sum);
        }
    }
}
