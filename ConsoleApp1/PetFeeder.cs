using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class PetFeeder
    {
        public static void PetFeed<TP, TF>(PetAnimal petAnimal, IPetFood petFood) where TP: PetAnimal
                                                                                    where TF: IPetFood
        {
            petAnimal.Feed(petFood);
        }
    }
}
