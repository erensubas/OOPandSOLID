using PetFeed.enums;
using PetFeed.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFeed
{
    public class Dog : Animal
    {
        public Dog(string petName, Enums.AnimalColor petColor) : base(petName, petColor)
        {

        }

        public string Havla()
        {
            return "Hav!";
        }

        public override void Feed(IFood food)
        {
            if(food is Fish)
            {
                Havla();
            }
            else
            {
                base.Feed(food);
            }
        }
    }
}
