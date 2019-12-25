using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class PetCat : PetAnimal
    {
        private string deneme;


        public PetCat(string petName, PetColor petColor) : base (petName, petColor)
        {

        }

        public string Meow()
        {
            return "Meow!";
        }

        public override void Feed(IPetFood food)
        {
            if(food is Fish)
            {
                Eat(food);
            }
            else
            {
                Meow();
            }
        }
    }
}
