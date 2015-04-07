using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_Mowing_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            LawnJobPricer jobCalc = new LawnJobPricer();
            jobCalc.LawnCalculator();

        }
    }
}
