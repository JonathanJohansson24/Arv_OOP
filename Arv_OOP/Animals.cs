using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_OOP
{
    internal class Animals
    {
        public string Name;
        public int Age;
        public string Colour;
        public string Species;          //Dog cat monkey or whatever
        public bool HasTail;

        public Animals () : this ("No name added", 00, "No colour added", "No species added", false)
        {

        }
        public Animals(string name,
            int age,
            string colour,
            string species,
            bool hasTail)
        {
            Name = name;
            Age = age;  
            Colour = colour;
            Species = species;
            HasTail = hasTail;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal has no sound");
        }
        public void Walking()
        {
            Console.WriteLine($"The {Species} with the name {Name} is walking!!");
        }
        public void Sleeping()
        {
            Console.WriteLine($"The {Species} with the name {Name} is sleeping!!");
        }
        public void Eating()
        {
            Console.WriteLine($"The {Species} with the name {Name} is eating!!");
        }
        public virtual void BaseInfo()
        {
            Console.WriteLine($@"
Name: {Name}

Age: {Age}

Colour: {Colour}

Species: {Species}");
            if (HasTail)
            {
                Console.WriteLine("\nHas a tail: True");
            }
            else
            {
                Console.WriteLine("\nHas a tail: False");
            }
        }
    }
}
