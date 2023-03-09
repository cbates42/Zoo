using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Dolphin : Mammal
    {
        public Dolphin(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string name { get; set; }
        public int age { get; set; }

        public void PerformTrick()
        {
            Console.WriteLine($"{name} jumps through a hoop!");
        }

        public void GetInfo()
        {
            Console.WriteLine($"{name} the dolphin is {age} years old! Here is his trick:");
        }
    }
}
