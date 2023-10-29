using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    class Cat : Animal
    {
        public string catBreed { get; set; }
        

        public Cat(string name, int age, string color, double weight, bool isFriendly, string breed)
            : base("Nisse", 5, "White", 4.0, true)
        {
            catBreed = breed;
           
        }

        public void ChasingMouse()
        {
            Console.WriteLine($"{Name} chasing a mouse");
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
            Console.WriteLine($"{Name} says Mjau");
        }
    }
}
