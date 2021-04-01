using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OOP example");

            PetCat cat = new PetCat("Clementine", new PetColor("Beyaz"));
            Fish fish = new Fish();
            Kibble kibble = new Kibble();
            cat.Feed(fish);
            cat.Feed(kibble);

            Console.WriteLine(cat.MyPet());

            PetFeeder.PetFeed<PetAnimal, IPetFood>(cat, fish);
            Console.WriteLine(cat.MyPet());
            Console.WriteLine(cat.Meow());
            Console.ReadLine();
            PetDog dog = new PetDog("Ace", new PetColor("Kahverengi"));
            Console.WriteLine(dog.MyPet());
            Console.WriteLine(dog.Bark());

            Console.ReadLine();

        }
    }
}
