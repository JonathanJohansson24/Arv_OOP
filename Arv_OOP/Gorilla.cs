using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_OOP
{
    internal class Gorilla : Monkeys
    {
        public string Type;

        public Gorilla() : this("No type added", "No favourite food added", "No name added", 00, "No colour added", "No species added", false)
        {

        }
        public Gorilla(string type,
            string favouriteFood,
            string name, int age,
            string colour,
            string species,
            bool hasTail) :
            base(favouriteFood, name, age, colour, species, hasTail)
        {
            Type = type;
        }
        public override void MakeSound()
        {
            Console.WriteLine("The gorilla goes out with a great roar OOOOOOOOAHHAHHAAAAAAAAAHA");
        }
        public override void Climbing()
        {
            Console.WriteLine("The gorilla likes to climb very fast chasing his oranges");
        }
        public override void BaseInfo()
        {
            base.BaseInfo();
            Console.WriteLine($"\nType = {Type}");
        }

    }
}
