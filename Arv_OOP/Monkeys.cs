using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_OOP
{
    internal class Monkeys : Animals
    {
        public string FavouriteFood;

        public Monkeys() : this("No favourite food added", "No name added", 00, "No colour added", "No species added", false)
        {

        }
        public Monkeys(string favouriteFood,
            string name, int age,
            string colour,
            string species,
            bool hasTail) :
            base(name, age, colour, species, hasTail)
        {
            FavouriteFood = favouriteFood;
        }
        public override void BaseInfo()
        {
            base.BaseInfo();
            Console.WriteLine($"\nFavouritefood = {FavouriteFood}");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"The Monkey goes OOOHOhohAaahAHAHAHAHa");
        }
        public virtual void Climbing()
        {
            Console.WriteLine("The monkeys are climbing in the trees");
        }
    }
}
