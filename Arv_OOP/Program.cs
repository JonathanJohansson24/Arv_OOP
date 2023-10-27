namespace Arv_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Horses horses = new Horses("Iceland", "Lassie", 13, "Brown/Yellow", "Horse", true);
            
            Monkeys monkeys = new Monkeys("Leaves", "King-Kong", 17, "Black", "Monkey", false);
      
            Mouses mouses = new Mouses(false, "Ohyran", 3, "Grey", "Mouse", true);

            Gorilla gorilla = new Gorilla("Gorilla", "Leaves", "Evert", 12, "Grey/black", "Monkey", false);

            Orangutang orangutang = new Orangutang("Orangutang", "Bananas", "King Louie", 20, "Orange", "Monkey", true);

            Horses horsesDefault = new Horses();

            Animals[] animals = { horses, monkeys, mouses, gorilla, orangutang, horsesDefault };

            Monkeys[] differentmonkeys = { monkeys, gorilla, orangutang };
            foreach (Animals animal in animals)
            {
                animal.BaseInfo();
                animal.MakeSound();
                Console.WriteLine();
                animal.Walking();
                Console.WriteLine();
                animal.Sleeping();
                
                Console.WriteLine("\n--- \t --- \t --- \t ---");
            }

            mouses.Sneaking();
            horses.Jumping();
            foreach (Monkeys monkey in differentmonkeys)
            {
                monkey.Climbing();
            }

        }
    }
}