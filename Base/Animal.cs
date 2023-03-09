using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Animal : Mammal
    {
        public string name { get; set; }
        public int age { get; set; }



        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void GetInfo()
        {
        Console.WriteLine($"{name} is {age} years old! Here is his trick:");
        }
        public virtual void PerformTrick()
    {
        Console.WriteLine("does a flip!");
    }

    }
}
