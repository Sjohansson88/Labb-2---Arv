using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        double Weight { get; set; }
        public bool IsFriendly { get; set; }

        public Animal(string name, int age, string color, double weight, bool isfriendly)
        {
            Name = name;
            Age = age;
            Color = color;
            Weight = weight;
            IsFriendly = isfriendly;
        }

        public virtual void Eat()
        {

        }

        public virtual void Sleep()
        {

        }

        public virtual void Sound()
        {

        }
    }
}

