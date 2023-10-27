using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_OOP
{
    internal class Orangutang : Monkeys
    {
        public string Type;
        public Orangutang() : this("No type added", "No favourite food added", "No name added", 00, "No colour added", "No species added", false)
        {

        }

        public Orangutang(string type,
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
            Console.WriteLine("The Orangutang goes out with a slow OOOOH AAAAH HIIIII ");
        }
        public override void Climbing()
        {
            Console.WriteLine("the orangutang likes to climb slowly");
        }
        public override void BaseInfo()
        {
            base.BaseInfo();
            Console.WriteLine($"\nType = {Type}");
        }
    }
}
