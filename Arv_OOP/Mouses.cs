using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_OOP
{
    internal class Mouses : Animals
    {
        public bool IsAPet;
        public Mouses() : this(false, "No name added", 00, "No colour added", "No species added", false)
        {

        }
        public Mouses(bool isAPet,
            string name, int age,
            string colour,
            string species,
            bool hasTail) :
            base(name, age, colour, species, hasTail)
        {
            IsAPet = isAPet;
        }
        public override void BaseInfo()
        {
            base.BaseInfo();
            if (IsAPet)
            {
            Console.WriteLine($"\nIs it a pet: Yes");
            }
            else
            {
                Console.WriteLine("\nIs it a pet: No");
            }
        }
        public void Sneaking()
        {
            Console.WriteLine("the tiny mouse is sneaking around");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"The Mouse goes Meeeep Meeep Meeeeeep");
        }
    }
}
