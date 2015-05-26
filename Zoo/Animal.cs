using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class Animal
    {
        public string Color { get; set; }
        public double Age { get; set; }
        public double Weight { get; set; }

        public void Speak()
        {
            Console.Write("Hi");
        }

        public void Eat()
        {
            Weight++;
        }

        public void Sleep()
        {

        }
    }

}
