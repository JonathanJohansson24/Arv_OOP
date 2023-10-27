using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_OOP
{
    internal class Horses : Animals
    {
        public string Origin;

        public Horses() : this ("No origin added", "No name added", 00, "No colour added", "No species added", false)
        {

        }
        public Horses(string origin, 
            string name, int age,
            string colour, 
            string species, 
            bool hasTail) : 
            base(name, age, colour, species, hasTail)
        {
            Origin = origin;
        }
        public override void BaseInfo()
        {
            base.BaseInfo();
            Console.WriteLine($"\nOrigin = {Origin}");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"The Horse goes gneeeggeggeneneg");
        }

        public void Jumping()
        {
            Console.WriteLine("The horse is jumping over the fence");
        }
        
    }
}
