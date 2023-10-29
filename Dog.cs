using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    class Dog : Animal
    {
        public string Breed { get; set; }
        
        public Dog(string name, int age, string color, double weight, bool isFriendly, string breed) : base(name, age, color, weight, isFriendly)

        {
            Breed = breed;
            
        }



   

        public void Play()
        {
            Console.WriteLine($"{Name} is playing with a ball.");
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
            Console.WriteLine($"{Name} barks");
        }
    }




    class Rottweiler : Dog
    {
        public bool IsStrong { get; set; }

        public Rottweiler(string name, int age, string color, double weight, bool isFriendly, string breed, bool isStrong)
            : base("Rocky", 4, "Brown", 25.0, true, "Bulldog")
        {
            IsStrong = isStrong;
        }

        public void GuardHouse()
        {
            Console.WriteLine($"{Name} the Rottweiler is guarding the house.");
        }
    }

    class Chihuahua : Dog
    {
        public bool IsTiny { get; set; }

        public Chihuahua(string name, int age, string color, double weight, bool isFriendly, string breed, bool isTiny)
            : base(name, age, color, weight, isFriendly, breed)
        {
            IsTiny = isTiny;
        }

        public void ShakeHands()
        {
            Console.WriteLine($"{Name} the Chihuahua is shaking hands with you.");
        }
    }
}
