using PetFeed.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFeed
{
    public class Cat: Animal
    {
        public Cat(string petName, Enums.AnimalColor petColor) : base(petName, petColor)
        {

        }

        public string Miav()
        {
            return "Miav";
        }
    }
}
