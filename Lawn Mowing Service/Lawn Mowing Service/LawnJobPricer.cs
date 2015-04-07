using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mowing_Service
{
    class LawnJobPricer
    {
        private int length;
        private int width;
        private int sqFootage;
        private int weeklyPrice;
 

            public void LawnCalculator()
        {

            Console.WriteLine("Please enter the length of your yard");
            length = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the width of your yard");
            width = int.Parse(Console.ReadLine());

            sqFootage = length*width;

            if (sqFootage < 400)
            {
                weeklyPrice = 25;
            }

            else if (sqFootage >= 400 && sqFootage < 600)
            {
                weeklyPrice = 35;
            }

            else
            {
                weeklyPrice = 50;
            }

            Console.WriteLine("Your weekly fee is ${0}", weeklyPrice);
            Console.WriteLine("Your total fee for the 20 week season is ${0}", 20*weeklyPrice);
        }
    }
}
