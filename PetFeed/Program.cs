using PetFeed.interfaces;
using System;

namespace PetFeed
{
    class Program
    {
        static void Main(string[] args)
        {

            Fish fishfood = new Fish();
            Milk milkfood = new Milk();

            Cat cat = new Cat("Yumak", enums.Enums.AnimalColor.black);
            Dog dog = new Dog("Karabaş", enums.Enums.AnimalColor.grey);

            PetFeeder.Feed<Animal,IFood>(cat, fishfood);
            PetFeeder.Feed<Animal, IFood>(cat, milkfood);

            PetFeeder.Feed<Animal, IFood>(dog, fishfood);
            PetFeeder.Feed<Animal, IFood>(dog, milkfood);


            Console.WriteLine(cat.Miav());
            Console.WriteLine(dog.Havla());

            Console.WriteLine(cat.MyPet());
            Console.WriteLine(dog.MyPet());
        }
    }
}
