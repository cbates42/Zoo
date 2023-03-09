using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Cat : Animal
    { 
        public Cat(string name, int age) : base(name, age)
        {

        }

        public override void PerformTrick()
        {
            Console.WriteLine($"{name} walks on a tightrope... and makes it to the other side!");
        }

    }
}
