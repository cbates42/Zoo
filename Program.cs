// Referenced abstract_interface demo provided by Leo Haozu

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Mammal> animals = new List<Mammal>();
            animals.Add(new Dog("Rook", 1));
            animals.Add(new Dog("Bishop", 3));
            animals.Add(new Dog("Knight", 2));
            animals.Add(new Cat("Pawn", 2));
            animals.Add(new Cat("Joker", 2));
            animals.Add(new Cat("Vergil", 1));
            animals.Add(new Dolphin("Queen", 2));
            animals.Add(new Dolphin("King", 1));
            animals.Add(new Dolphin("Jack", 4));

            foreach(Mammal animal in animals)
            {
                animal.GetInfo();
                animal.PerformTrick();
            }   

            var mammals = animals.Where(a => a.GetType().BaseType != typeof(Animal));

            foreach(var mammal in mammals) 
            {
                Console.WriteLine($"{mammal.name} is a mammal!");
                Console.WriteLine(mammal.GetType());
            }

            Console.ReadLine();
        }
    }
}
