using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //creates one instance of a Grade Calculator 

            GradeCalculator gradecalc = new GradeCalculator();

            gradecalc.CalculateGrades();
            

    
        }
    }
}
