using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class PetDog : PetAnimal
    {
        public PetDog(string petName, PetColor petColor) : base(petName, petColor)
        {

        }

        public string Bark()
        {
            return "Woof!";
        }

    }
}
