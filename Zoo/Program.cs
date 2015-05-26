using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dragon Toothless = new Dragon(2, "black", "Toothless");
            IActivity DoStuff = (IActivity)Toothless;
            DoStuff.Eat();

            Toothless.Age = 2;
            Toothless.Color = "Black";

            Dragon Bob = new Dragon();
         
        }
    }
}
