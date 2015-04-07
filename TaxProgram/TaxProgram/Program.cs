using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Taxpayer[] taxArray  = new Taxpayer[10];

           
            


            for (int i = 0; i < taxArray.Length; i++)
            {
                taxArray[i] = new Taxpayer(0,0);
                Console.WriteLine("Please enter person {0} Social", i + 1);
                taxArray[i].Social = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter your Gross Income");
                taxArray[i].GrossIncome = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < taxArray.Length; i++)
            {
                Console.WriteLine("Social Security = {0}, Gross Income = {1}", taxArray[i].Social, taxArray[i].GrossIncome);
                Console.WriteLine("The Tax owed is {0}",taxArray[i].TaxOwed);
                
            }

            
         
        }
    }
}
