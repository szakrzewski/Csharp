using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Dragon : Animal, IActivity
    {
        public string Name { get; set; }

        public Dragon(int age, string color, string name)
        {
            this.Age = age;
            this.Color = color;
            this.Name = name;
        }

        public Dragon()
        {

        }


        public void Fly()
        {

        }
    }
}
