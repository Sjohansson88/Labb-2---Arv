using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    class Pig : Animal
    {
        public bool Dirty { get; set; }
        
        public Pig(string name, int age, string color, double weight, bool isFriendly, bool dirty)
            : base("Ralf", 7, "Pink", 38.0, false)
        {
            Dirty = dirty;
            
        }

        public void Mudd()
        {
            Console.WriteLine($"{Name} is rooling in the mudd.");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{Name} is {Age} years old and is sleeping");
        }

        public override void Sound()
        {
            Console.WriteLine($"{Name} says nöff nöff");
        }
    }
}
